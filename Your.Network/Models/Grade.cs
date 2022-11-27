using System.Collections.Generic;
using System.Text.Json.Serialization;
using System;

namespace Your.Network.Models {
    public class Grade {
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("label")] public string? Label { get; set; }
        [JsonPropertyName("description")] public string? Description { get; set; }
        [JsonPropertyName("experience")] public int Experience { get; set; }
        [JsonPropertyName("needsApproval")] public bool NeedsApproval { get; set; }
    }
}