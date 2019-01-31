using Android.App;
using Android.Widget;
using Android.OS;
using Internationalization.Core;

namespace Internationalization.Droid
{
    [Activity(Label = "Internationalization", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var textViewLanguage = (TextView)FindViewById(Resource.Id.textView_language);
            textViewLanguage.Text = CommonStrings.Hello;
        }
    }
}

