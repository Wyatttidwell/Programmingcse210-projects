using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

public class JsonDeserializer
{
    private string filePath;

    public JsonDeserializer(string path)
    {
        filePath = path;
    }

    public T Deserialize<T>() where T : class
    {
        if (File.Exists(filePath))
        {
            try
            {
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    Converters = new List<JsonConverter> { new ProfileConverter() }
                };

                string json = File.ReadAllText(filePath);
                T obj = JsonConvert.DeserializeObject<T>(json, settings);
                return obj;
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"JSON deserialization error: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"File I/O error: {ex.Message}");
            }
        }
        return null;
    }
}
