using Your.Network.Models;
using Your.Network.Handlers;
using Database = Your.Network.Methods.Database;
using Your.Network;

namespace Your.App;

public class PostDetailPageViewModel: ObservableModel {
    private string title;
    public string Title {
        get => this.title;
        set => SetProperty(ref this.title, value, nameof(Title));
    }

    private string body;
    public string Body {
        get => this.body;
        set => SetProperty(ref this.body, value, nameof(Body));
    }

    public PostDetailPageViewModel(string id) {
        FetchArticles(id);
        MarkAsRead();
    }


    private void MarkAsRead() {
    }
    
    private void FetchArticles(string id) {
        Api.Get(new Database.Get(), new ApiCallback<Data>()
            .OnSuccess(result => {
                var posts = result.Articles.ConvertAll(it => new PostItem(it, result.Users, result.Skills));
                var currentPost = posts.SingleOrDefault(p => p.Id.Equals(id));

                Title = currentPost.Title;
                Body = currentPost.Body;
            })
            .OnError(reason => {})
        );
    }
}