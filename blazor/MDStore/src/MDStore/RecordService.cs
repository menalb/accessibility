using System.Text.Json.Serialization;
using System.Net.Http.Json;

public class RecordService
{
    private readonly HttpClient _httpClient;
    public RecordService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public Task<AvailableRecord[]?> GetRecords()
        => _httpClient.GetFromJsonAsync<AvailableRecord[]>("sample-data/records.json");


    public async Task<AvailableRecord?> GetRecord(string id)
    {
        var records = await GetRecords();
        if (records != null && records.Any())
        {
            return records.FirstOrDefault(record => record.Id == id);
        }
        return null;
    }
}

public class AvailableRecord
{
    public string Id { get; set; }
    public string? Artist { get; set; }
    public string? Album { get; set; }
    public string AlbumImagePath { get => "sample-data/images/" + AlbumImage; }

    [JsonPropertyName("image")]
    public string? AlbumImage { get; set; }
    [JsonPropertyName("release_date")]
    public DateTime ReleaseDate { get; set; }

    public string? Category { get; set; }

}