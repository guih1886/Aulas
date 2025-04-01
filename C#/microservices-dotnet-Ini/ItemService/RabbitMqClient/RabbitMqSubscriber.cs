using ItemService.EventProcessor;
using Microsoft.AspNetCore.Connections;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace ItemService.RabbitMqClient
{
    public class RabbitMqSubscriber : BackgroundService
    {
        private readonly IConfiguration _configuration;
        private readonly ConnectionFactory _factory;
        private IChannel? _channel;
        private IProcessaEvento _processaEvento;

        public RabbitMqSubscriber(IConfiguration configuration, IProcessaEvento processaEvento)
        {
            _configuration = configuration;
            _factory = new ConnectionFactory
            {
                HostName = _configuration["RabbitMqHost"],
                Port = int.Parse(_configuration["RabbitMqPort"]),
            };
            _processaEvento = processaEvento;
        }

        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            using var connection = await _factory.CreateConnectionAsync();
            using var channel = await connection.CreateChannelAsync();

            await channel.ExchangeDeclareAsync(exchange: "trigger", type: ExchangeType.Fanout);
            var nome = await channel.QueueDeclareAsync();
            await channel.QueueBindAsync(queue: nome.QueueName, exchange: "trigger", routingKey: "");

            var consumidor = new AsyncEventingBasicConsumer(channel);

            consumidor.ReceivedAsync += (model, ea) =>
            {
                ReadOnlyMemory<byte> body = ea.Body;
                string? mensagem = Encoding.UTF8.GetString(body.ToArray());
                _processaEvento.Processa(mensagem);
                return Task.CompletedTask;
            };

            await channel.BasicConsumeAsync(queue: nome.QueueName, autoAck: true, consumer: consumidor);
        }
    }
}
