using Confluent.Kafka;
using Shared.Database.ClickHouse;
using System.Text;
using System.Text.Json;

namespace Study_2024_11;

public class Program
{
    public static async Task Main(string[] args)
    {
        var connector = new ClickHouseConnector();

        var res = await connector.ReadData(1);

        foreach (var item in res)
        {
            Console.WriteLine($"{item.UserId} - {item.KeyName} - {item.KeyCode}");
        }

        //await connector.WriteData(new UserClicksClickHouseData[]
        //{
        //    new UserClicksClickHouseData() { UserId = 1, KeyName = "first_login_key", KeyCode = null },
        //    new UserClicksClickHouseData() { UserId = 2, KeyName = "first_login_key", KeyCode = 5 },
        //    new UserClicksClickHouseData() { UserId = 1, KeyName = "second_login_key", KeyCode = 2 },
        //    new UserClicksClickHouseData() { UserId = 2, KeyName = "first_login_key", KeyCode = null },
        //    new UserClicksClickHouseData() { UserId = 1, KeyName = "logout", KeyCode = 5 },
        //    new UserClicksClickHouseData() { UserId = 1, KeyName = "first_login_key", KeyCode = null },
        //    new UserClicksClickHouseData() { UserId = 1, KeyName = "decond_login_key", KeyCode = 5 },
        //    new UserClicksClickHouseData() { UserId = 1, KeyName = "first_login_key", KeyCode = null },
        //    new UserClicksClickHouseData() { UserId = 2, KeyName = "first_login_key", KeyCode = null },
        //    new UserClicksClickHouseData() { UserId = 1, KeyName = "get_version", KeyCode = null },
        //});


        //var producerConfig = new ProducerConfig()
        //{
        //    BootstrapServers = "localhost:9092",
        //    ClientId = "Main-Client",
        //};

        //var producer = new ProducerBuilder<string, MyMessage>(producerConfig)
        //    .SetValueSerializer(new MyJsonSerializer())
        //    .Build();

        //var kafkaMessage = new Message<string, MyMessage>()
        //{
        //    Key = Guid.NewGuid().ToString(),
        //    Value = new MyMessage()
        //    {
        //        Id = 1,
        //        Name = "aacx",
        //        Value = "cbsj"
        //    }
        //};

        //producer.Produce("first_topic", kafkaMessage);

        //Console.WriteLine("Publish");
        //Console.ReadLine();

        //var consumerConfig = new ConsumerConfig()
        //{
        //    BootstrapServers = "localhost:9092",
        //    GroupId = "main-consumer",
        //    AutoOffsetReset = AutoOffsetReset.Earliest,
        //};

        //var consumer = new ConsumerBuilder<string, MyMessage>(consumerConfig)
        //    .SetValueDeserializer(new MyJsonSerializer())
        //    .Build();

        //consumer.Subscribe("first_topic");

        //while (true)
        //{
        //    try
        //    {
        //        var mes = consumer.Consume();

        //        Console.WriteLine($"{mes.Message.Key} {mes.Message.Value.Id} {mes.Message.Value.Name}");
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //    }
        //}
    }

    public class MyMessage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class MyJsonSerializer : ISerializer<MyMessage>, IDeserializer<MyMessage>
    {
        public MyMessage Deserialize(ReadOnlySpan<byte> data, bool isNull, SerializationContext context)
        {
            return (MyMessage)JsonSerializer.Deserialize(data, typeof(MyMessage));
        }

        public byte[] Serialize(MyMessage data, SerializationContext context)
        {
            return JsonSerializer.SerializeToUtf8Bytes(data);
        }
    }
}