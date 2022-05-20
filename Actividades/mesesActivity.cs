using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppRemesas.Actividades
{
    [Activity(Label = "mesesActivity")]
    public class mesesActivity : Activity  
    {
        ListView listMeses;
        TextView result;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.mesesVista); //Mande a llamar la Vista de los Meses del Layout;

            Inicializar();
            var listatemporal = Global.remesas.Where(x => x.Idanio == Global.indiceAnio).ToList();//Crear Lista Temporal con los registros que coinciden con la llave foranea del año
           // if(listatemporal.Count()>0)
            listMeses.Adapter = new Adaptadores.AdapterMes(this, listatemporal.ToList());//ojo: Mandar a llamar la clase que contiene la lista seleccionada.

            result.Text = "" + listatemporal.Sum(x => x.Datomes).ToString();
        }

        private void Inicializar()
        {
            listMeses = FindViewById<ListView>(Resource.Id.meses);
            result = FindViewById<TextView>(Resource.Id.textResult);

        }
    }
}