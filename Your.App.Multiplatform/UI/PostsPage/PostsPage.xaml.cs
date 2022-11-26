namespace Your.App;

public partial class PostsPage : ContentPage {
	private PostsPageViewModel ViewModel;

	public PostsPage() {
		ViewModel = new PostsPageViewModel();
		Title = Localization.Instance.GetString("title_page_posts");

		InitializeComponent();
		BindingContext = ViewModel;
	}
}
