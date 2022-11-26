namespace Your.App;

public partial class ProfilePage : ContentPage {
	public ProfilePage() {
		Title = Localization.Instance.GetString("title_page_profile");

		InitializeComponent();
		BindingContext = new ProfilePageViewModel();
	}
}
