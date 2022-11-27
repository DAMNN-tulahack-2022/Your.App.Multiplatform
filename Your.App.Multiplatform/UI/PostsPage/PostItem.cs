using Your.Network.Models;

namespace Your.App;

public class PostItem {
    public int Id { get; set; }
    public string CreatorName { get; set; }
    public string CreatorPhoto { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public List<string> Languages { get; set; }
    public string Date => DateTime.Now.ToString("dd MMMM yyyy");

    public PostItem(Article inner, List<User> users, List<Skill> skills) {
        var creator = users.SingleOrDefault(u => u.Id.Equals(inner.AuthorId));
        Languages = skills.Where(s => inner.SkillsIds.Contains(s.Id)).ToList().ConvertAll(s => s.Label);
        CreatorName = creator?.FullName ?? "Unknown";
        CreatorPhoto = creator?.AvatarUrl ?? "https://i.imgur.com/0X0X0X0.png";
        Title = inner.Title;
        Id = inner.Id;
        Body = inner.Description;
    }
}
