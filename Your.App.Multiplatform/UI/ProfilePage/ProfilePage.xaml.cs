namespace Your.App;

public partial class ProfilePage : ContentPage {
	int count = 0;

	public ProfilePage() {
		InitializeComponent();
		BindingContext = new ProfilePageViewModel();
	}

	private void OnCounterClicked(object sender, EventArgs e) {
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}
