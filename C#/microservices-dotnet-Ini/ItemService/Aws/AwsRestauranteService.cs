using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;
using AutoMapper;
using ItemService.Data;
using ItemService.Dtos;
using ItemService.Models;
using System.Text.Json;

public class SqsBackgroundService : BackgroundService
{
    private readonly ILogger<SqsBackgroundService> _logger;
    private readonly string QueueUrl;
    private readonly string _sqsAccessKey;
    private readonly string _sqsSecretKey;
    private IConfiguration _configuration;
    private readonly IServiceScopeFactory _serviceScopeFactory;
    private IMapper _mapper;

    public SqsBackgroundService(ILogger<SqsBackgroundService> logger, IConfiguration configuration, IMapper mapper, IServiceScopeFactory serviceScopeFactory)
    {
        _logger = logger;
        _configuration = configuration;
        QueueUrl = _configuration["AwsSqsUrl"] ?? string.Empty;
        _sqsAccessKey = _configuration["AwsAccessKey"] ?? string.Empty;
        _sqsSecretKey = _configuration["AwsSecretKey"] ?? string.Empty;
        _mapper = mapper;
        _serviceScopeFactory = serviceScopeFactory;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var sqsClient = new AmazonSQSClient(_sqsAccessKey, _sqsSecretKey, RegionEndpoint.SAEast1);

        _logger.LogInformation("SQS Background Service iniciado.");

        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                _logger.LogInformation("Verificando mensagens na fila SQS...");

                var receiveMessageRequest = new ReceiveMessageRequest
                {
                    QueueUrl = QueueUrl,
                    MaxNumberOfMessages = 10,
                    WaitTimeSeconds = 5 
                };

                var response = await sqsClient.ReceiveMessageAsync(receiveMessageRequest, stoppingToken);

                if (response.Messages.Count > 0)
                {
                    using (var scope = _serviceScopeFactory.CreateScope())
                    {
                        var itemRepository = scope.ServiceProvider.GetRequiredService<IItemRepository>();

                        List<Restaurante> lista = new();

                        foreach (var message in response.Messages)
                        {
                            _logger.LogInformation($"Mensagem recebida: {message.Body}");

                            RestauranteReadDto? dto = JsonSerializer.Deserialize<RestauranteReadDto>(message.Body);

                            if (dto != null)
                            {
                                lista.Add(_mapper.Map<Restaurante>(dto));
                            }

                            await sqsClient.DeleteMessageAsync(QueueUrl, message.ReceiptHandle);
                            _logger.LogInformation("Mensagem removida da fila.");
                        }

                        itemRepository.SaveRangeAsync(lista);
                    }
                }
                else
                {
                    _logger.LogInformation("Nenhuma mensagem na fila.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Erro ao processar mensagens do SQS: {ex.Message}");
            }

            await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);
        }
    }
}
