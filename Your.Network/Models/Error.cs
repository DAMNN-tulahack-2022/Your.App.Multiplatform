using System.Text.Json.Serialization;

namespace Your.Network.Models {
    public class Error {
        [JsonPropertyName("code")] public int Code { get; set; }
        [JsonPropertyName("message")] public string? Message { get; set; }
    }
}