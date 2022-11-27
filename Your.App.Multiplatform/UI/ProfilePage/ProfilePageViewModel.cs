using Your.Network.Models;
using Your.Network.Handlers;
using Database = Your.Network.Methods.Database;
using Your.Network;

namespace Your.App;

public class ProfilePageViewModel: ObservableModel {
    private string photoUrl;
    public string PhotoUrl {
        get => this.photoUrl;
        set => SetProperty(ref this.photoUrl, value, nameof(PhotoUrl));
    }

    private string fullName;
    public string FullName {
        get => this.fullName;
        set => SetProperty(ref this.fullName, value, nameof(FullName));
    }

    private string role;
    public string Role {
        get => this.role;
        set => SetProperty(ref this.role, value, nameof(Role));
    }

    private string experience;
    public string Experience {
        get => this.experience;
        set => SetProperty(ref this.experience, value, nameof(Experience));
    }

    private string projectCount;
    public string ProjectCount {
        get => this.projectCount;
        set => SetProperty(ref this.projectCount, value, nameof(ProjectCount));
    }

    private string readCount;
    public string ReadCount {
        get => this.readCount;
        set => SetProperty(ref this.readCount, value, nameof(ReadCount));
    }

    public ProfilePageViewModel() {
    }

    public void FetchUsers(int id) {
        Api.Get(new Database.Get(), new ApiCallback<Data>()
            .OnSuccess(result => {
                var user = result.Users.SingleOrDefault(u => u.Id.Equals(id));
                PhotoUrl = user.AvatarUrl;
                FullName = user.FullName;
                Role = user.Role;
                Experience = user.TotalExperience.ToString() + " exp";
                ProjectCount = user.CompletedProjectsId?.Count.ToString() ?? "0";
                ReadCount = user.ViewedPostsIds.Count.ToString();
            })
            .OnError(reason => {})
        );
    }
}