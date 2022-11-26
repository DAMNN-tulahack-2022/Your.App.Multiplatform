using System.Text.Json.Serialization;

namespace Your.Network.Models {
    public class Skill {
        [JsonPropertyName("id")] public string? Id { get; set; }
        [JsonPropertyName("label")] public string? Label { get; set; }
    }
}