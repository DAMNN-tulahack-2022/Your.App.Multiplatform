using Your.Network.Models;
using Your.Network.Handlers;
using Posts = Your.Network.Methods.Posts;
using Your.Network;

namespace Your.App;

public class SearchPageViewModel: ObservableModel {
    private List<Post> posts;
    public List<Post> Posts {
        get => this.posts; 
        set => SetProperty(ref this.posts, value, nameof(Posts));
    }

    public SearchPageViewModel() {
        Posts = new List<Post>();
        //RequestPosts();
    }


    private void RequestPosts() {
        Api.Get(new Posts.Get(), new ApiCallback<List<Post>>()
            .OnSuccess(result => Posts = result )
            .OnError(reason => {
                //Handle error
            })
        );
    }
}