namespace Your.App;

public partial class ProjectPage : ContentPage {
	private ProjectPageViewModel ViewModel;

	public ProjectPage() {
		ViewModel = new ProjectPageViewModel();

		InitializeComponent();
		BindingContext = ViewModel;
	}
}
