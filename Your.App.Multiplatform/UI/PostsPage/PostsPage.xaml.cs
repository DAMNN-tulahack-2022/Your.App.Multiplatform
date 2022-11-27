namespace Your.App;

public partial class PostsPage : ContentPage {
	private readonly PostsPageViewModel viewModel;

	public PostsPage() {
		viewModel = new PostsPageViewModel();
		Title = Localization.Instance.GetString("title_page_posts");

		InitializeComponent();
		BindingContext = viewModel;
	}

    protected override void OnAppearing() {
        base.OnAppearing();
		viewModel.FetchArticles();
    }
}
