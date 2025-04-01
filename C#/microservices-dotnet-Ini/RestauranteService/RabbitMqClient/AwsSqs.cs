using Amazon;
using Amazon.Runtime;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace RestauranteService.RabbitMqClient;

public class AwsSqs
{
    private IConfiguration _configuration;
    private readonly string? queueUrl;
    private readonly string accessKey;
    private readonly string secretKey;

    public AwsSqs(IConfiguration configuration)
    {
        _configuration = configuration;
        queueUrl = _configuration["AwsSqsUrl"] ?? string.Empty;
        accessKey = _configuration["AwsAccessKey"] ?? string.Empty;
        secretKey = _configuration["AwsSecretKey"] ?? string.Empty;
    }

    public async Task SendMessageAsync(string message)
    {
        var credentials = new BasicAWSCredentials(accessKey, secretKey);
        var client = new AmazonSQSClient(credentials, RegionEndpoint.SAEast1);

        var request = new SendMessageRequest
        {
            QueueUrl = queueUrl,
            MessageBody = message
        };

        var response = await client.SendMessageAsync(request);
    }
}
