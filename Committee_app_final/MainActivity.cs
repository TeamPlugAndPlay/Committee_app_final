using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Content;

namespace Committee_app_final
{
    [Activity(Label = "Universidad El Bosque", MainLauncher = true, Icon = "@drawable/logo_bosque")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            TextView firstText = FindViewById<TextView>(Resource.Id.mainText);
            Button button1 = FindViewById<Button>(Resource.Id.buttonCommittee1);
            Button button2 = FindViewById<Button>(Resource.Id.buttonCommittee2);
            Button button3 = FindViewById<Button>(Resource.Id.buttonCommittee3);
            Button button4 = FindViewById<Button>(Resource.Id.buttonCommittee4);
            Button button5 = FindViewById<Button>(Resource.Id.buttonCommittee5);
            Button button6 = FindViewById<Button>(Resource.Id.buttonCommittee6);
            Button button7 = FindViewById<Button>(Resource.Id.buttonCommittee7);
            Button button8 = FindViewById<Button>(Resource.Id.buttonCommittee8);
            Button button9 = FindViewById<Button>(Resource.Id.buttonCommittee9);
            Button button10 = FindViewById<Button>(Resource.Id.buttonCommittee10);
            button1.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Committee1Window));
                intent.PutExtra("committee", "committee1"); //for sending some extra data to the new activity
                StartActivity(intent);
            };
            button2.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Committee1Window));
                intent.PutExtra("committee", "committee2"); //for sending some extra data to the new activity
                StartActivity(intent);
            };
            button3.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Committee1Window));
                intent.PutExtra("committee", "committee3"); //for sending some extra data to the new activity
                StartActivity(intent);
            };
            button4.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Committee1Window));
                intent.PutExtra("committee", "committee4"); //for sending some extra data to the new activity
                StartActivity(intent);
            };
            button5.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Committee1Window));
                intent.PutExtra("committee", "committee5"); //for sending some extra data to the new activity
                StartActivity(intent);
            };
            button6.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Committee1Window));
                intent.PutExtra("committee", "committee6"); //for sending some extra data to the new activity
                StartActivity(intent);
            };
            button7.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Committee1Window));
                intent.PutExtra("committee", "committee7"); //for sending some extra data to the new activity
                StartActivity(intent);
            };
            button8.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Committee1Window));
                intent.PutExtra("committee", "committee8"); //for sending some extra data to the new activity
                StartActivity(intent);
            };
            button9.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Committee1Window));
                intent.PutExtra("committee", "committee9"); //for sending some extra data to the new activity
                StartActivity(intent);
            };
            button10.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Committee1Window));
                intent.PutExtra("committee", "committee10"); //for sending some extra data to the new activity
                StartActivity(intent);
            };
        }
    }
}

