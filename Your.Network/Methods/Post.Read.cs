using System.Text.Json.Serialization;

namespace Your.Network.Methods.Post {
    public class Read : PostRequest<object> {
        public Read(int postId, int userId) : base(new Body { PostId = postId, UserId = userId}, "users/read-post") {}

        public class Body {
            [JsonPropertyName("postId")] public int PostId { get; set; }
            [JsonPropertyName("userId")] public int UserId { get; set; }
        }

    }
}