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
        //a list of the diferent options of the Screen
        String[] optionList;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            
            //button for going back to the previous screen
            Button backButton = new Button(this);
            
            //button text
            backButton.Text = "Back";
            
            //initializing list with options
            optionList = new String[] {"Descripción","Miembros Activos","Miembros Antiguos","Proyectos Pasados", "Proyectos Actuales"};
            
            //Component of the actual activity, UI to show the previous list
            this.ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, optionList);
            
            //Button method for going back
            backButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };
        }
    }
}