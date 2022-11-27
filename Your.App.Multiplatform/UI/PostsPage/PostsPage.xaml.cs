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

	private async void OnAddClicked(object sender, EventArgs e) {
		await Shell.Current.GoToAsync($"postcreate");
	}
}
