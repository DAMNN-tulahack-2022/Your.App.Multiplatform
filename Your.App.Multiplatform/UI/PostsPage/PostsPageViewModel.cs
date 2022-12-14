using Your.Network.Models;
using Your.Network.Handlers;
using Database = Your.Network.Methods.Database;
using Your.Network;

namespace Your.App;

public class PostsPageViewModel: ObservableModel {
    private List<PostItem> posts;
    public List<PostItem> Posts {
        get => this.posts;
        set => SetProperty(ref this.posts, value, nameof(Posts));
    }

    public void FetchArticles() {
        Api.Get(new Database.Get(), new ApiCallback<Data>()
            .OnSuccess(result => {
                var nonOrderedPosts = result.Articles.ConvertAll(it => new PostItem(it, result.Users, result.Skills));
                nonOrderedPosts.Reverse();
                Posts = nonOrderedPosts;
            })
            .OnError(reason => {})
        );
    }
}