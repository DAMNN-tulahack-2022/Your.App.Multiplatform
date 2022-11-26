using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Your.Network.Models {
    public class Project {
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("title")] public string? Title { get; set; }
        [JsonPropertyName("body")] public string? Body { get; set; }
        [JsonPropertyName("languages")] public List<string>? Languages { get; set; }
        [JsonPropertyName("users")] public List<int>? Users { get; set; }
    }
}