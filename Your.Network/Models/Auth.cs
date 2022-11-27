using System.Text.Json.Serialization;

namespace Your.Network.Models {
    public class Auth {
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("login")] public string? Login { get; set; }
    }
}