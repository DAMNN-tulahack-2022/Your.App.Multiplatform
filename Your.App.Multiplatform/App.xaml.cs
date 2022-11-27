namespace Your.App;

public partial class App : Application {
	public App() {
		InitializeComponent();

		MainPage = (CredentialStorage.ReadToken() == null) ? new AuthPage() : new RootPage();
	}
}
