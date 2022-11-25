namespace Your.App;

public class RootPageViewModel: ObservableModel {

    private string profileLocalizedTitle;
    public string ProfileLocalizedTitle {
        get => this.profileLocalizedTitle; 
        set => SetProperty(ref this.profileLocalizedTitle, value, nameof(ProfileLocalizedTitle));
    }

    private string searchLocalizedTitle;
    public string SearchLocalizedTitle {
        get => this.searchLocalizedTitle;
        set => SetProperty(ref this.searchLocalizedTitle, value, nameof(SearchLocalizedTitle));
    }

    private string projectLocalizedTitle;
    public string ProjectLocalizedTitle {
        get => this.projectLocalizedTitle;
        set => SetProperty(ref this.projectLocalizedTitle, value, nameof(ProjectLocalizedTitle));
    }

    private string postsLocalizedTitle;
    public string PostsLocalizedTitle {
        get => this.postsLocalizedTitle;
        set => SetProperty(ref this.postsLocalizedTitle, value, nameof(PostsLocalizedTitle));
    }

    public RootPageViewModel() {
        this.profileLocalizedTitle = Localization.Instance.GetString("title_page_profile");
        this.searchLocalizedTitle = Localization.Instance.GetString("title_page_search");
        this.projectLocalizedTitle = Localization.Instance.GetString("title_page_project");
        this.postsLocalizedTitle = Localization.Instance.GetString("title_page_posts");
    }
}