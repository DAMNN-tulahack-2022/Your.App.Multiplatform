namespace Your.App;

public static class Localization {
    private static System.Resources.ResourceManager instance;
    public static System.Resources.ResourceManager Instance {
        get {
            if (instance == null) {
                const string localizationFile = "Your.App.Resources.Lang.lang";
                var assembly = System.Reflection.Assembly.GetExecutingAssembly();
                instance = new System.Resources.ResourceManager(localizationFile, assembly);
            }
            return instance;
        }
    }
}