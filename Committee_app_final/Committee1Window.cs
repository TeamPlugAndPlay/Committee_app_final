﻿using System;
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
            string text = Intent.GetStringExtra("committee") ?? "Data not available";
            committeeName = FindViewById<TextView>(Resource.Id.textView1);

            //call method populateList to fill the data needed on the dictionary
            optionsMapping = new Dictionary<string, List<string>>();
            PopulateList();

            listAdapter = new ExpandableListAdapter(this, optionList, optionsMapping);
            listView.SetAdapter(listAdapter);

            //if and el if for asigning the committee title, main image and banner
            if (text.Equals("committee1"))
            {
                image = FindViewById<ImageView>(Resource.Id.imageView1);
                image.SetImageResource(Resource.Drawable.icon_calidad_circle);
                committeeName.Text=("Calidad");

            }
            else if (text.Equals("committee2"))
            {
                image = FindViewById<ImageView>(Resource.Id.imageView1);
                image.SetImageResource(Resource.Drawable.icon_comunicaciones_circle);
                committeeName.Text = ("Comunicaciones");
            }
            else if (text.Equals("committee3"))
            {
                image = FindViewById<ImageView>(Resource.Id.imageView1);
                image.SetImageResource(Resource.Drawable.icon_internacionalizacion_circle);
                committeeName.Text = ("Internacionalización");
            }
            else if (text.Equals("committee4"))
            {
                image = FindViewById<ImageView>(Resource.Id.imageView1);
                image.SetImageResource(Resource.Drawable.icon_curricular_circle);
                committeeName.Text = ("Curricular");
            }
            else if (text.Equals("committee5"))
            {
                image = FindViewById<ImageView>(Resource.Id.imageView1);
                image.SetImageResource(Resource.Drawable.icon_rsu_circle);//falta
                committeeName.Text = ("Responsabilidad Social");
            }
            else if (text.Equals("committee6"))
            {
                image = FindViewById<ImageView>(Resource.Id.imageView1);
                image.SetImageResource(Resource.Drawable.icon_egresados_circle);
                committeeName.Text = ("Egresados");
            }
            else if (text.Equals("committee7"))
            {
                image = FindViewById<ImageView>(Resource.Id.imageView1);
                image.SetImageResource(Resource.Drawable.icon_continuada_circle);
                committeeName.Text = ("Educación Continuada");
            }
            else if (text.Equals("committee8"))
            {
                image = FindViewById<ImageView>(Resource.Id.imageView1);
                image.SetImageResource(Resource.Drawable.icon_investigacion_circle);
                committeeName.Text = ("Investigaciones");
            }
            else if (text.Equals("committee9"))
            {
                image = FindViewById<ImageView>(Resource.Id.imageView1);
                image.SetImageResource(Resource.Drawable.icon_externo_circle);
                committeeName.Text = ("Prácticas Empresariales");
            }
            else if (text.Equals("committee10"))
            {
                image = FindViewById<ImageView>(Resource.Id.imageView1);
                image.SetImageResource(Resource.Drawable.icon_exito_circle);
                committeeName.Text = ("Éxito Estudiantil");
            }

            
        }

        public void PopulateList()
        {
            //data that will be contained on each option of the expendable list
            //initializing list with options
            optionList = new List<string>();
            optionList.Add("Descripción");
            optionList.Add("Miembros Activos");
            optionList.Add("Miembros Antiguos");
            optionList.Add("Proyectos Pasados");
            optionList.Add("Proyectos Actuales");

            List<string> descriptionText = new List<string>();
            descriptionText.Add( "apply RESTful Service" );
            List<string> membersList = new List<string>();
            membersList.Add("member1");
            membersList.Add("member2");
            membersList.Add("member3");
            List<string> oldMembersList = new List<string>();
            oldMembersList.Add("oldMember1");
            oldMembersList.Add("oldMember2");
            oldMembersList.Add("oldMember3");
            List<string> proyectsDone = new List<string> ();
            proyectsDone.Add("apply another service here");
            List<string> proyectsDoing = new List<string> ();
            proyectsDoing.Add("apply yet another service");

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