using System.Text.Json.Serialization;

namespace Your.Network.Methods.Post {
    public class Create : PostRequest<object> {
        public Create(string title, string desc, int userId) : base(new Body { Title = title, Description = desc, UserId = userId}, "users/public-post") {}

        public class Body {
            [JsonPropertyName("title")] public string? Title { get; set; }
            [JsonPropertyName("description")] public string ?Description { get; set; }
            [JsonPropertyName("userId")] public int UserId { get; set; }
        }
    }
}