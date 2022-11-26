using Your.Network.Models;
using Your.Network.Handlers;
using Database = Your.Network.Methods.Database;
using Your.Network;

namespace Your.App;

public class SearchPageViewModel: ObservableModel {
    private List<User> users;
    public List<User> Users {
        get => this.users;
        set {
            this.users = value;
            ActualUsers = value;
        }
    }

    private List<User> actualUsers;
    public List<User> ActualUsers {
        get => this.actualUsers;
        set => SetProperty(ref this.actualUsers, value, nameof(ActualUsers));
    }

    public SearchPageViewModel() {
        FetchUsers();
    }

    public void FilterUsers(string value) {
        ActualUsers = this.users.Where(user => user.FullName.Contains(value)).ToList();
    }

    private void FetchUsers() {
        Api.Get(new Database.Get(), new ApiCallback<Data>()
            .OnSuccess(result => Users = result.Users)
            .OnError(reason => {})
        );
    }
}