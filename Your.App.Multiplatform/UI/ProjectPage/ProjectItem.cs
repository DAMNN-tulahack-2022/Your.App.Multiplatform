using Your.Network.Models;

namespace Your.App;

public class ProjectItem {
    public string Title { get; set; }
    public string Description { get; set; }
    public List<string> Languages { get; set; }
    public List<User> Contributors { get; set; }

    public ProjectItem(Project inner, List<User> users, List<Skill> skills) {
        Contributors = users.Where(u => inner.UserIds.Contains(u.Id)).ToList();
        Languages = skills.Where(s => inner.SkillsIds.Contains(s.Id)).ToList().ConvertAll(s => s.Label);
        Title = inner.Title;
        Description = inner.Description;
    }
}
