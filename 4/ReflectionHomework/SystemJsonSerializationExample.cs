using System.Text.Json;
using ReflectionHomework.Serialize;

public static class SystemJsonSerializationExample
{
    public static void SerializeJson(int repeatCount = 1000)
    {
        Console.WriteLine("Trying to serialize {0} object of type {1} to JSON using SystemTextJson", repeatCount, typeof(F));
        var timeStart = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

        var options = new JsonSerializerOptions
        {
            IncludeFields = true
        };

        for (int i = 0; i < repeatCount; i++)
        {
            var f = F.Get();
            Console.WriteLine(JsonSerializer.Serialize(f, options));
        }

        var timeEnd = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

        Console.WriteLine("To processing {0} items {1}ms was used.", repeatCount, timeEnd - timeStart);
        Console.WriteLine("{0}ms per item.", (float)(timeEnd - timeStart) / repeatCount);
    }

    public static void DeserializeJson(string filePath, int repeatCount = 1000)
    {
        Console.WriteLine("Trying to deserialize object from {0}", filePath);

        var options = new JsonSerializerOptions
        {
            IncludeFields = true
        };

        string json;

        using (StreamReader reader = new StreamReader(filePath))
        {
            json = reader.ReadToEnd();
        }

        var timeStart = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

        for (int i = 0; i < repeatCount; i++)
        {
            F jsonF = JsonSerializer.Deserialize<F>(json);
        }

        var timeEnd = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

        Console.WriteLine("To processing {0} items {1}ms was used.", repeatCount, timeEnd - timeStart);
        Console.WriteLine("{0}ms per item.", (float)(timeEnd - timeStart) / repeatCount);
    }
}
