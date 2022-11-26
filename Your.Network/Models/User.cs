using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Your.Network.Models {
    public class User {
        [JsonPropertyName("id")] public string? Id { get; set; }
        [JsonPropertyName("login")] public string? Login { get; set; }
        [JsonPropertyName("viewedPostsIds")] public List<string>? ViewedPostsIds { get; set; }
        [JsonPropertyName("firstName")] public string? FirstName { get; set; }
        [JsonPropertyName("lastName")] public string? LastName { get; set; }
        [JsonPropertyName("avatarUrl")] public string? AvatarUrl { get; set; }
        [JsonPropertyName("currentProjectId")] public string? CurrentProjectId { get; set; }
        [JsonPropertyName("completedProjectsId")] public List<string>? CompletedProjectsId { get; set; }
        [JsonPropertyName("skillsIds")] public List<string>? SkillsIds { get; set; }
        [JsonPropertyName("role")] public string? Role { get; set; }
        [JsonPropertyName("totalExperience")] public int TotalExperience { get; set; }

        [JsonIgnore] public string FullName => $"{FirstName} {LastName}";
    }
}