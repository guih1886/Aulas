using RabbitMq.Models;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;
using System.Threading.Channels;

namespace RabbitMq.Services;

public class RabbitMqPublishService
{
    private ConnectionFactory _factory;
    private IConnection? _connection;
    private IChannel? _channel;

    public RabbitMqPublishService()
    {
        _factory = new ConnectionFactory
        {
            HostName = "localhost",
            Port = 5672,
        };
    }

    public static async Task<RabbitMqPublishService> CreateAsync()
    {
        var service = new RabbitMqPublishService();
        await service.InitializeAsync();
        return service;
    }

    private async Task InitializeAsync()
    {
        _connection = await Task.Run(() => _factory.CreateConnectionAsync());
        _channel = await Task.Run(() => _connection.CreateChannelAsync());
    }

    public async Task PublishMessageAsync(string exchange, string queue, string message)
    {
        await _channel.ExchangeDeclareAsync(exchange, ExchangeType.Direct);

        await _channel.QueueDeclareAsync(queue: queue, durable: true, exclusive: false,
            autoDelete: false,
            arguments: null
            );

        await _channel.QueueBindAsync(queue, exchange, queue);


        byte[] body = Encoding.UTF8.GetBytes(message);
        await _channel.BasicPublishAsync(exchange: exchange, routingKey: queue, body: body);
        Console.WriteLine($" [x] Sent {message}");
    }

    public async Task<Product> ConsumeAsync(string queue)
    {
        string json = string.Empty;
        Product? produto = new();

        var consumer = new AsyncEventingBasicConsumer(_channel);

        consumer.ReceivedAsync += async (model, ea) =>
        {
            var body = ea.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);
            Console.WriteLine($" [x] Mensagem recebida, salvando em banco");
            json = message;
        };

        produto = JsonSerializer.Deserialize<Product>(json);
        await _channel.BasicConsumeAsync(queue, autoAck: true, consumer: consumer);
        return produto;
    }
}
