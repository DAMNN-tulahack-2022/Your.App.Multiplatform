namespace Your.App;

[QueryProperty(nameof(PostId), "post_id")]
public partial class PostDetailPage : ContentPage {
	public string PostId {get; set; }

	public PostDetailPage() {
		InitializeComponent();
		BindingContext = new PostDetailPageViewModel(PostId);
	}
}
