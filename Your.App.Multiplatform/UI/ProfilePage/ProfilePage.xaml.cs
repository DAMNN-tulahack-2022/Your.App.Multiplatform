namespace Your.App;

[QueryProperty(nameof(UserId), "user_id")]
public partial class ProfilePage : ContentPage {
	private readonly ProfilePageViewModel viewModel;
	public int UserId { get; set; }

	public ProfilePage() {
		Title = Localization.Instance.GetString("title_page_profile");
		viewModel = new ProfilePageViewModel();

		InitializeComponent();
		BindingContext = viewModel;
	}

    protected override void OnAppearing() {
        base.OnAppearing();
		if (UserId == 0) {
			UserId = int.Parse(CredentialStorage.ReadToken());
		}
		viewModel.FetchUsers(UserId);
    }

	private async void OnIconTap(object sender, EventArgs e) {
		var exp = viewModel.Grade.Experience - viewModel.ExperienceCount;
		
		await DisplayAlert($"Level Up to {viewModel.Grade.Label}", $"You need at least {exp} more exp", "OK");
	}
}
