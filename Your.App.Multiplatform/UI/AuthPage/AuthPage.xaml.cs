using Your.Network.Models;
using Your.Network.Handlers;
using Your.Network;

namespace Your.App;

public partial class AuthPage : ContentPage {
	private readonly AuthPageViewModel ViewModel;

	public AuthPage() {
		ViewModel = new AuthPageViewModel();
		InitializeComponent();

		BindingContext = ViewModel;
	}


	private void OnSignInClicked(object sender, EventArgs e) {
		Api.Get(new AuthRequest(loginField.Text), new ApiCallback<Auth>()
			.OnSuccess(result => {
				CredentialStorage.WriteToken(result.Id.ToString());
				App.Current.MainPage = new RootPage();
			})
			.OnError(reason => {
				loginField.ErrorText = reason;
				loginField.HasError = true;
			})
		);
	}
}
