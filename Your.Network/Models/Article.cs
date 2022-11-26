using System.Collections.Generic;
using System.Text.Json.Serialization;
using System;

namespace Your.Network.Models {
    public class Article {
        [JsonPropertyName("id")] public string? Id { get; set; }
        [JsonPropertyName("authorId")] public string? AuthorId { get; set; }
        [JsonPropertyName("title")] public string? Title { get; set; }
        [JsonPropertyName("description")] public string? Description { get; set; }
        [JsonPropertyName("skillsIds")] public List<string>? SkillsIds { get; set; }
        [JsonPropertyName("totalViewed")] public int TotalViewed { get; set; }
        [JsonPropertyName("experience")] public int Experience { get; set; }
    }
}