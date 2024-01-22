using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace MediaPlayerSample.Droid
{
    [Activity(
        MainLauncher = true,
        ConfigurationChanges = global::Uno.UI.ActivityHelper.AllConfigChanges,
        WindowSoftInputMode = SoftInput.AdjustNothing | SoftInput.StateHidden
    )]
    public class MainActivity : Microsoft.UI.Xaml.ApplicationActivity
    {
    }
}
