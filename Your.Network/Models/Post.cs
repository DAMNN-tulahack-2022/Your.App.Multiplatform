using System.Collections.Generic;
using System.Text.Json.Serialization;
using System;

namespace Your.Network.Models {
    public class Post {
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("photo")] public string? Photo { get; set; }
        [JsonPropertyName("creator")] public string? Creator { get; set; }
        [JsonPropertyName("title")] public string? Title { get; set; }
        [JsonPropertyName("body")] public string? Body { get; set; }
        [JsonPropertyName("date")] public DateTime Date { get; set; }
        [JsonPropertyName("languages")] public List<string>? Languages { get; set; }

        [JsonIgnore] public string DateString => Date.ToString("dd MMMM yyyy");
    }
}