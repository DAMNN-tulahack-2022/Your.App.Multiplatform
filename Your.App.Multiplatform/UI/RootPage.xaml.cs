namespace Your.App;

public partial class RootPage : Shell {
	public RootPage() {
		InitializeComponent();
		BindingContext = new RootPageViewModel();

		Routing.RegisterRoute("postdetail", typeof(PostDetailPage));
	}
}
