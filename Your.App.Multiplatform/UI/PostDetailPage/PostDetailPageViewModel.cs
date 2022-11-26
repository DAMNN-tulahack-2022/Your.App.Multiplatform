using Your.Network.Models;
using Your.Network.Handlers;
using Database = Your.Network.Methods.Database;
using Your.Network;

namespace Your.App;

[QueryProperty(nameof(PostId), "post_id")]
public class PostDetailPageViewModel: ObservableModel {
    public string PostId {get; set; }

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

    public PostDetailPageViewModel() {
        FetchArticles();
        MarkAsRead();
    }


    private void MarkAsRead() {
        var t = 10;
    }
    private void FetchArticles() {
        Api.Get(new Database.Get(), new ApiCallback<Data>()
            .OnSuccess(result => {
                var posts = result.Articles.ConvertAll(it => new PostItem(it, result.Users, result.Skills));
                var currentPost = posts.SingleOrDefault(p => p.Id.Equals(PostId));

                Title = currentPost.Title;
                Body = currentPost.Body;
            })
            .OnError(reason => {})
        );
    }
}