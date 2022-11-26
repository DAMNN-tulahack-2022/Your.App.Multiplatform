namespace Your.App;

[QueryProperty(nameof(UserId), "user_id")]
public partial class ProfilePage : ContentPage {
	private readonly ProfilePageViewModel viewModel;
	public string UserId { get; set; }

	public ProfilePage() {
		Title = Localization.Instance.GetString("title_page_profile");
		viewModel = new ProfilePageViewModel();

		InitializeComponent();
		BindingContext = viewModel;
	}

    protected override void OnAppearing() {
        base.OnAppearing();

		UserId ??= "user1";//stored;
		viewModel.FetchUsers(UserId);
    }
}
