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
        Dictionary<string, String[]> optionsMapping;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            //SetContentView(Resource.Layout.Committee1Layout);

            ImageView image = FindViewById<ImageView>(Resource.Id.imageView1);

            optionsMapping = new Dictionary<string, string[]>();

            //initializing list with options
            optionList = new String[] {"Descripción","Miembros Activos","Miembros Antiguos","Proyectos Pasados", "Proyectos Actuales"};

            //call method populateList to fill the data needed on the dictionary
            PopulateList();

            //Component of the actual activity, UI to show the previous list
            this.ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleExpandableListItem1, optionList);


        }
        //method for clicking the list adapter options and showing the option selected at the bottom of the Screen
        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            var t = optionList[position];
            /*String[] aux = new String[] { t.ToString() };
            this.ListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, aux);*/
            Android.Widget.Toast.MakeText(this, t, Android.Widget.ToastLength.Short).Show();
        }

        public void PopulateList()
        {
            //data that will be contained on each option of the expendable list
            String[] descriptionText = new String[] { "apply RESTful Service" };
            String[] membersList = new String[] { "member1", "member2", "member3" };
            String[] oldMembersList = new String[] { "oldMember1", "oldMember2", "oldMember3" };
            String[] proyectsDone = new String[] { "apply another service here" };
            String[] proyectsDoing = new String[] { "apply yet another service" };

            //fill the dictionary with the options and its data
            optionsMapping.Add(optionList[0], descriptionText);
            optionsMapping.Add(optionList[1], membersList);
            optionsMapping.Add(optionList[2], oldMembersList);
            optionsMapping.Add(optionList[3], proyectsDone);
            optionsMapping.Add(optionList[4], proyectsDoing);
        }
    }
}