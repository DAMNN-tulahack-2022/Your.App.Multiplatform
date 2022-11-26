namespace Your.App;

public partial class ProjectPage : ContentPage {
	private readonly ProjectPageViewModel ViewModel;

	public ProjectPage() {
		Title = Localization.Instance.GetString("title_page_project");
		ViewModel = new ProjectPageViewModel();

		InitializeComponent();
		BindingContext = ViewModel;
	}
}
