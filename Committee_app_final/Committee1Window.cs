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
using Android.Graphics;

namespace Committee_app_final
{
    [Activity(Label = "Comite")]
    public class Committee1Window : Activity
    {
        //a list of the diferent options of the Screen
        List<string> optionList;
        ExpandableListAdapter listAdapter;
        ExpandableListView listView;
        Dictionary<string, List<string>> optionsMapping;
        ImageView image;
        TextView committeeName;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.Committee1Layout);
            listView = FindViewById<ExpandableListView>(Resource.Id.lvExp);

            //get extra String from the main class
            string text = Intent.GetStringExtra("committee") ?? "Data not available";

            //other view components
            committeeName = FindViewById<TextView>(Resource.Id.textView1);
            LinearLayout mcl = FindViewById<LinearLayout>(Resource.Id.maincommitteelayout);

            //call method populateList to fill the data needed on the dictionary
            optionsMapping = new Dictionary<string, List<string>>();

            //if and el if for asigning the committee title, main image and banner
            if (text.Equals("committee1"))
            {
                image = FindViewById<ImageView>(Resource.Id.imageView1);
                image.SetImageResource(Resource.Drawable.icon_calidad_circle);
                committeeName.Text=("Comité de Calidad");
                PopulateList(text);

            }
            else if (text.Equals("committee2"))
            {
                image = FindViewById<ImageView>(Resource.Id.imageView1);
                image.SetImageResource(Resource.Drawable.icon_comunicaciones_circle);
                committeeName.Text = ("Comité de Comunicaciones");
                PopulateList(text);
            }
            else if (text.Equals("committee3"))
            {
                image = FindViewById<ImageView>(Resource.Id.imageView1);
                image.SetImageResource(Resource.Drawable.icon_internacionalizacion_circle);
                committeeName.Text = ("Comité de Internacionalización");
                PopulateList(text);
            }
            else if (text.Equals("committee4"))
            {
                image = FindViewById<ImageView>(Resource.Id.imageView1);
                image.SetImageResource(Resource.Drawable.icon_curricular_circle);
                committeeName.Text = ("Comité Curricular");
                PopulateList(text);
            }
            else if (text.Equals("committee5"))
            {
                image = FindViewById<ImageView>(Resource.Id.imageView1);
                image.SetImageResource(Resource.Drawable.icon_rsu_circle);//falta
                committeeName.Text = ("Comité de Responsabilidad Social");
                PopulateList(text);
            }
            else if (text.Equals("committee6"))
            {
                image = FindViewById<ImageView>(Resource.Id.imageView1);
                image.SetImageResource(Resource.Drawable.icon_egresados_circle);
                committeeName.Text = ("Comité de Egresados");
                PopulateList(text);
            }
            else if (text.Equals("committee7"))
            {
                image = FindViewById<ImageView>(Resource.Id.imageView1);
                image.SetImageResource(Resource.Drawable.icon_continuada_circle);
                committeeName.Text = ("Comité de Educación Continuada");
                PopulateList(text);
            }
            else if (text.Equals("committee8"))
            {
                image = FindViewById<ImageView>(Resource.Id.imageView1);
                image.SetImageResource(Resource.Drawable.icon_investigacion_circle);
                committeeName.Text = ("Comité de Investigaciones");
                PopulateList(text);
            }
            else if (text.Equals("committee9"))
            {
                image = FindViewById<ImageView>(Resource.Id.imageView1);
                image.SetImageResource(Resource.Drawable.icon_externo_circle);
                committeeName.Text = ("Comité de Prácticas Empresariales");
                PopulateList(text);
            }
            else if (text.Equals("committee10"))
            {
                image = FindViewById<ImageView>(Resource.Id.imageView1);
                image.SetImageResource(Resource.Drawable.icon_exito_circle);
                committeeName.Text = ("Comité de Éxito Estudiantil");
                PopulateList(text);
            }
            else
            {
                PopulateList("default");
            }

            //create expandable list adapter and expandable list view and set them in the layout
            listAdapter = new ExpandableListAdapter(this, optionList, optionsMapping);
            listView.SetAdapter(listAdapter);
            mcl.SetBackgroundColor(Color.ParseColor("#b7df4c"));

        }

        public void PopulateList(String s)
        {
            //data that will be contained on each option of the expendable list
            //initializing list with options
            optionList = new List<string>();
            List<string> membersList = new List<string>();
            List<string> descriptionText = new List<string>();
            List<string> oldMembersList = new List<string>();
            List<string> proyectsDone = new List<string>();
            List<string> proyectsDoing = new List<string>();
            
            //fixed headers for the expandable view
            optionList.Add("Descripción");
            optionList.Add("Miembros Activos");
            optionList.Add("Miembros Antiguos");
            optionList.Add("Proyectos Pasados");
            optionList.Add("Proyectos Actuales");

            //fill childs depends on the committee selected
            if (s.Equals("committee1"))
            {
                descriptionText.Add("apply RESTful Service");
                membersList.Add("member1");
                membersList.Add("member2");
                membersList.Add("member3");
                oldMembersList.Add("oldMember1");
                oldMembersList.Add("oldMember2");
                oldMembersList.Add("oldMember3");
                proyectsDone.Add("apply another service here");
                proyectsDoing.Add("apply yet another service");
            }

            else if (s.Equals("committee2"))
            {
                descriptionText.Add("apply RESTful Service");
                membersList.Add("member1");
                membersList.Add("member2");
                membersList.Add("member3");
                oldMembersList.Add("oldMember1");
                oldMembersList.Add("oldMember2");
                oldMembersList.Add("oldMember3");
                proyectsDone.Add("apply another service here");
                proyectsDoing.Add("apply yet another service");
            }

            else if (s.Equals("committee8"))
            {
                descriptionText.Add("Promover la investigación y la estadarización de los " +
                    "poyectos de la facultad, por medio de la calidad y su roboste con el fin " +
                    "de lograr reconocimiento en la universidad como en colciencias");
                membersList.Add("Carlos Delgado");
                oldMembersList.Add("oldMember1");
                proyectsDone.Add("apply another service here");
                proyectsDoing.Add("apply yet another service");
            }

            else
            {
                descriptionText.Add("apply RESTful Service");
                membersList.Add("member1");
                membersList.Add("member2");
                membersList.Add("member3");
                oldMembersList.Add("oldMember1");
                oldMembersList.Add("oldMember2");
                oldMembersList.Add("oldMember3");
                proyectsDone.Add("apply another service here");
                proyectsDoing.Add("apply yet another service");
            }

            //fill the dictionary with the options and its data
            optionsMapping.Add(optionList[0], descriptionText);
            optionsMapping.Add(optionList[1], membersList);
            optionsMapping.Add(optionList[2], oldMembersList);
            optionsMapping.Add(optionList[3], proyectsDone);
            optionsMapping.Add(optionList[4], proyectsDoing);
            //listAdapter = new SimpleExpandableListAdapter(this, optionList, optionsMapping);
        }
    }
}