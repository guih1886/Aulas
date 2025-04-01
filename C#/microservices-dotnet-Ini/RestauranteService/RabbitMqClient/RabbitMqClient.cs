using RabbitMQ.Client;
using RestauranteService.Dtos;
using System.Text;
using System.Text.Json;

namespace RestauranteService.RabbitMqClient
{
    public class RabbitMqClient : IRabbitMqClient
    {
        private readonly IConfiguration _configuration;
        private readonly ConnectionFactory _factory;
        private readonly IChannel _channel;

        public RabbitMqClient(IConfiguration configuration)
        {
            _configuration = configuration;
            _factory = new ConnectionFactory()
            {
                HostName = _configuration["RabbitMqHost"],
                Port = int.Parse(_configuration["RabbitMqPort"]!)
            };
        }

        public async void PublicaRestaurante(RestauranteReadDto restauranteReadDto)
        {
            using var connection = await _factory.CreateConnectionAsync();
            using var channel = await connection.CreateChannelAsync();

            string mensagem = JsonSerializer.Serialize(restauranteReadDto);
            byte[] body = Encoding.UTF8.GetBytes(mensagem);

            BasicProperties properties = new BasicProperties
            {

            };

            await channel.BasicPublishAsync(exchange: "trigger", routingKey: "", mandatory: true, basicProperties: properties, body: body);

        }
    }
}
