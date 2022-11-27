namespace Your.App;

public partial class ProjectPage : ContentPage {
	private readonly ProjectPageViewModel viewModel;

	public int UserId => int.Parse(CredentialStorage.ReadToken());

	public ProjectPage() {
		Title = Localization.Instance.GetString("title_page_project");
		viewModel = new ProjectPageViewModel();

		InitializeComponent();
		BindingContext = viewModel;
	}

    protected override void OnAppearing() {
        base.OnAppearing();
		viewModel.FetchProjects(UserId);
    }
}
