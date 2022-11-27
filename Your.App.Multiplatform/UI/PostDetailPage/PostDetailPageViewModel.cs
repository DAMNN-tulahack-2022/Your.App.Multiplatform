using Your.Network.Models;
using Your.Network.Handlers;
using Database = Your.Network.Methods.Database;
using Post = Your.Network.Methods.Post;
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
    private string photo;
    public string Photo {
        get => this.photo;
        set => SetProperty(ref this.photo, value, nameof(Photo));
    }
    private string name;
    public string Name {
        get => this.name;
        set => SetProperty(ref this.name, value, nameof(Name));
    }
    public string Date => DateTime.Now.ToString("dd MMMM yyyy");
    public int UserId => int.Parse(CredentialStorage.ReadToken());


    private void MarkAsRead(int id) {
         Api.Get(new Post.Read(id, UserId));
    }

    public void FetchArticles(int id) {
        Api.Get(new Database.Get(), new ApiCallback<Data>()
            .OnSuccess(result => {
                var posts = result.Articles.ConvertAll(it => new PostItem(it, result.Users, result.Skills));
                var currentPost = posts.SingleOrDefault(p => p.Id.Equals(id));

                Title = currentPost.Title ?? "";
                Body = currentPost.Body ?? "";
                Photo = currentPost.CreatorPhoto ?? "";
                Name = currentPost.CreatorName ?? "";
            })
            .OnError(reason => {})
        );
        MarkAsRead(id);
    }
}