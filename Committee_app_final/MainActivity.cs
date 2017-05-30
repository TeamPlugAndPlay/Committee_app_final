using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Content;

namespace Committee_app_final
{
    [Activity(Label = "Committee_app_final", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            TextView firstText = FindViewById<TextView>(Resource.Id.mainText);
            Button button1 = FindViewById<Button>(Resource.Id.buttonCommittee1);
            button1.Click += (sender, e) =>
             {
                 var intent = new Intent(this, typeof(Committee1Window));
                 //intent.PutStringArrayListExtra("phone_numbers", phoneNumbers);
                 StartActivity(intent);
             };
        }
    }
}

