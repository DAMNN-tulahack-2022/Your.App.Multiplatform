namespace Your.App;

public partial class SearchPage : ContentPage {
	private SearchPageViewModel ViewModel;

	public SearchPage() {
		ViewModel = new SearchPageViewModel();
		InitializeComponent();

		BindingContext = ViewModel;
	}
}
