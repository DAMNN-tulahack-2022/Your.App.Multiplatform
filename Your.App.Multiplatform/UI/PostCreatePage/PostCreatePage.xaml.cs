using Your.Network.Models;
using Your.Network.Handlers;
using Post = Your.Network.Methods.Post;
using Your.Network;

namespace Your.App;

public partial class PostCreatePage : ContentPage {
	private readonly PostCreatePageViewModel ViewModel;

	private int userId => int.Parse(CredentialStorage.ReadToken());

	public PostCreatePage() {
		ViewModel = new PostCreatePageViewModel();
		Title = Localization.Instance.GetString("title_common_create_post");

		InitializeComponent();
		BindingContext = ViewModel;
	}

	private void OnPublishClicked(object sender, EventArgs e) {
		Api.Get(new Post.Create(titleField.Text, bodyField.Text, userId), new ApiCallback<object>()
			.OnSuccess(result => GoBack())
			.OnError(reason => {})
		);
	}

	private async void GoBack() {
		await Shell.Current.GoToAsync("..");
	}
}
