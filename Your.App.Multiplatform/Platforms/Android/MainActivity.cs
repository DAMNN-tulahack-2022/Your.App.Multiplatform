using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace Your.App;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    override protected void OnCreate(Bundle savedInstanceState) {
        base.OnCreate(savedInstanceState);

        if (Build.VERSION.SdkInt >= BuildVersionCodes.R) {
            Window.InsetsController?.SetSystemBarsAppearance((int)WindowInsetsControllerAppearance.LightStatusBars, (int)WindowInsetsControllerAppearance.LightStatusBars);
        }
        if(Build.VERSION.SdkInt >= BuildVersionCodes.M && Build.VERSION.SdkInt < BuildVersionCodes.R) {
            Window.DecorView.SystemUiVisibility = (StatusBarVisibility)SystemUiFlags.LightStatusBar;
        }
    }
}
