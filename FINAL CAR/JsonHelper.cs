using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public static class JsonHelper
{
    // LOAD data from JSON file
    public static List<T> Load<T>(string file)
    {
        // If file does not exist, return empty list
        if (!File.Exists(file))
            return new List<T>();

        string json = File.ReadAllText(file);
        return JsonSerializer.Deserialize<List<T>>(json);
    }

    // SAVE data to JSON file
    public static void Save<T>(string file, List<T> data)
    {
        string json = JsonSerializer.Serialize(
            data,
            new JsonSerializerOptions
            {
                WriteIndented = true
            });

        File.WriteAllText(file, json);
    }
}
