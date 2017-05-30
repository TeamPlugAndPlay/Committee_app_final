using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Committee_app_final
{
    [Activity(Label = "@string/Committee1")]
    public class Committee1Window : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            //var phoneNumbers = Intent.Extras.GetStringArrayList("phone_numbers") ?? new string[0];
            //this.ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, phoneNumbers);
            Button backButton = new Button(this);
            backButton.Text = "Back";
            var intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }
    }
}