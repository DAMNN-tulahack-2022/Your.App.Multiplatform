namespace Your.App;

public partial class PostDetailPage : ContentPage {
	public PostDetailPage() {
		InitializeComponent();
		BindingContext = new PostDetailPageViewModel();
	}
}
