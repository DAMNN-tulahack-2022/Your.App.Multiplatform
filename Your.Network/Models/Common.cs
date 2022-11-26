using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Your.Network.Models {
    public class Data {
        [JsonPropertyName("users")] public List<User>? Users { get; set; }
        [JsonPropertyName("projects")] public List<Project>? Projects { get; set; }
        [JsonPropertyName("skills")] public List<Skill>? Skills { get; set; }
        [JsonPropertyName("articles")] public List<Article>? Articles { get; set; }
    }
}