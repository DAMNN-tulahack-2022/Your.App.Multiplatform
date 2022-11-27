using Your.Network.Models;
using Your.Network.Handlers;
using Database = Your.Network.Methods.Database;
using Your.Network;

namespace Your.App;

public class ProjectPageViewModel: ObservableModel {
    private List<ProjectItem> projects;
    public List<ProjectItem> Projects {
        get => this.projects;
        set => SetProperty(ref this.projects, value, nameof(Projects));
    }

    public ProjectPageViewModel() {
    }

    public void FetchProjects(int userId) {
        Api.Get(new Database.Get(), new ApiCallback<Data>()
            .OnSuccess(result => {
                var project = result.Projects.FirstOrDefault(it => it.UsersIds?.Contains(userId) == true);
                if (project == null)
                    return;

                Projects = new List<ProjectItem> { new ProjectItem(project, result.Users, result.Skills) };
            })
            .OnError(reason => {})
        );
    }
}