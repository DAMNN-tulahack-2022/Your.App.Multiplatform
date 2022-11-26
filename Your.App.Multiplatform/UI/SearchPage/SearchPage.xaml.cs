namespace Your.App;

public partial class SearchPage : ContentPage {
	private readonly SearchPageViewModel ViewModel;

	public SearchPage() {
		Title = Localization.Instance.GetString("title_page_search");
		ViewModel = new SearchPageViewModel();
		InitializeComponent();

		BindingContext = ViewModel;
	}
}
