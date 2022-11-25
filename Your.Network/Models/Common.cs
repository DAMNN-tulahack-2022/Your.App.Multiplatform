using System.Text.Json.Serialization;

namespace Your.Network.Models {

    public class Photo {
        [JsonPropertyName("photo_200")] public string? Photo200 { get; set; }
        [JsonPropertyName("photo_100")] public string? Photo100 { get; set; }
        [JsonPropertyName("photo_50")] public string? Photo50 { get; set; }
    }

    public class Post {
        [JsonPropertyName("userId")] public int UserId { get; set; }
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("title")] public string? Title { get; set; }
        [JsonPropertyName("body")] public string? Body { get; set; }
    }
}