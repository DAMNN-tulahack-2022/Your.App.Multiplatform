namespace Your.App;

public partial class PostsPage : ContentPage {
	private PostsPageViewModel ViewModel;

	public PostsPage() {
		ViewModel = new PostsPageViewModel();

		InitializeComponent();
		BindingContext = ViewModel;
	}
}
