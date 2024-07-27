using ReflectionHomework.Serialize;

public static class CustomCsvSerializationExample
{
    public static void SerializeCSV(int repeatCount = 1000)
    {
        Console.WriteLine("Trying to serialize {0} object of type {1}", repeatCount, typeof(F));
        Console.WriteLine(CsvSerializer.GetHeaders<F>());

        var timeStart = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

        for (int i = 0; i < repeatCount; i++)
        {
            var f = F.Get();
            Console.WriteLine(CsvSerializer.Serialize(f));
        }

        var timeEnd = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

        Console.WriteLine("To processing {0} items {1}ms was used.", repeatCount, timeEnd - timeStart);
        Console.WriteLine("{0}ms per item.", (float)(timeEnd - timeStart) / repeatCount);
    }

    public static void DeserializeCSV(string filePath)
    {
        Console.WriteLine("Trying to deserialize objects in file {0}", filePath);

        string entity;
        List<F> listF = new List<F>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            var timeStart = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

            string header = reader.ReadLine() ?? throw new Exception("File is empty");

            while ((entity = reader.ReadLine()) != null)
            {
                listF.Add(CsvSerializer.Deserialize<F>(entity, header: header));
            }

            var timeEnd = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            var processedCount = listF.Count();

            Console.WriteLine("To processing {0} items {1}ms was used.", processedCount, timeEnd - timeStart);
            Console.WriteLine("{0}ms per item.", (float)(timeEnd - timeStart) / processedCount);
        }
    }
}
