namespace Your.App;

[QueryProperty(nameof(PostId), "post_id")]
public partial class PostDetailPage : ContentPage {
	private readonly PostDetailPageViewModel viewModel;
	public int PostId { get; set; }

	public PostDetailPage() {
		viewModel = new PostDetailPageViewModel();
		InitializeComponent();
		BindingContext = viewModel;
	}

    protected override void OnAppearing() {
        base.OnAppearing();
		viewModel.FetchArticles(PostId);
    }
}
