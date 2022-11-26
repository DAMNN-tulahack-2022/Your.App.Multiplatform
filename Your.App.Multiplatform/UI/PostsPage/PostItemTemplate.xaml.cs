namespace Your.App;

public partial class PostItemTemplate : Frame {
	public PostItemTemplate() {
		InitializeComponent();
	}

	private async void OnTapped(object sender, EventArgs e) {
		var item = (PostItem)BindingContext;
		await Shell.Current.GoToAsync($"postdetail?post_id={item.Id}");
	}
}
