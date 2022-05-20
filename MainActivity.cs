using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace AppRemesas
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ListView listAnios;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Inicializar();
            listAnios.Adapter = new Adaptadores.AdapterAnio(this, Global.anios);//contiene la plantilla y el contenido dentro de la vista.
            Eventos();
        }


        private void Eventos()
        {
            listAnios.ItemClick += ListAnios_ItemClick;
        }

        private void ListAnios_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(Actividades.mesesActivity));//  Referencia a la Actividad que se quiere llamar
            Global.indiceAnio = Global.anios[e.Position].Id;//Guardando la Llave Foránea del Año de la Tabla Remesas
            StartActivity(i);
        }

        private void Inicializar()//Referencia los elementos dentro del Layout a través del Id.
        {
            listAnios = FindViewById<ListView>(Resource.Id.listanios);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}