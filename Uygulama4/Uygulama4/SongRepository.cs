using System.Runtime.CompilerServices;
using System.Text.Json;

class SongRepository(string FilePath, JsonSerializerOptions options)
{
    private string filePath = FilePath;
    private JsonSerializerOptions jsonSerializerOptions = options;
    public List<Song> ReadFromFile()
    {
        if (!File.Exists(filePath))
        {
            var file = File.Create(filePath);
            file.Close();
        }
        var json = File.ReadAllText(filePath);
        if (json != "")
        {
            var songList = JsonSerializer.Deserialize<List<Song>>(json, jsonSerializerOptions);
            return songList;
        }
        return new List<Song>();
    }
    public void WriteToFile(List<Song> list)
    {
        var json = JsonSerializer.Serialize(list, jsonSerializerOptions);
        File.WriteAllText(filePath, json);
    }
}