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
        FetchProjects();
    }

    private void FetchProjects() {
        Api.Get(new Database.Get(), new ApiCallback<Data>()
            .OnSuccess(result => {
                Projects = new List<ProjectItem> { result.Projects.ConvertAll(it => new ProjectItem(it, result.Users, result.Skills)).FirstOrDefault() };
            })
            .OnError(reason => {})
        );
    }
}