// Trying serialize object using custom serializer to CSV
CustomCsvSerializationExample.SerializeCSV();

// Trying to serialize same object to string using System.Text.Json
SystemJsonSerializationExample.SerializeJson();

// Trying deserialize object using custom serializer to CSV
CustomCsvSerializationExample.DeserializeCSV("to-deserialize.csv");

// Trying deserialize using System.Text.Json
SystemJsonSerializationExample.DeserializeJson("to-deserialize.json");
