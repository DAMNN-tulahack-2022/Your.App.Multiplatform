using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Your.Network.Models {
    public class Project {
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("title")] public string? Title { get; set; }
        [JsonPropertyName("description")] public string? Description { get; set; }
        [JsonPropertyName("teamLeadId")] public string? TeamLeadId { get; set; }
        [JsonPropertyName("skillsIds")] public List<int>? SkillsIds { get; set; }
        [JsonPropertyName("userIds")] public List<int>? UserIds { get; set; }
        [JsonPropertyName("experience")] public int Experience { get; set; }
    }
}