namespace Your.App;

public class ProfilePageViewModel: ObservableModel {
    private string localizedString;
    public string LocalizedString {
        get => this.localizedString; 
        set => SetProperty(ref this.localizedString, value, nameof(LocalizedString));
    }

    public ProfilePageViewModel() {
        LocalizedString = Localization.Instance.GetString("title_page_contacts");
    }
}