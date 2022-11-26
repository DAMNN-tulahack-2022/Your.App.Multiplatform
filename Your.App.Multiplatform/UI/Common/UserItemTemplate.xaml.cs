using Your.Network.Models;

namespace Your.App;

public partial class UserItemTemplate : VerticalStackLayout {
	public UserItemTemplate() {
		InitializeComponent();
	}

	private async void OnTapped(object sender, EventArgs e) {
		var item = (User)BindingContext;
		await Shell.Current.GoToAsync($"userdetail?user_id={item.Id}");
	}
}
