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

namespace AppRemesas.Adaptadores
{
    class AdapterMes : BaseAdapter
    {
        Activity Intent;
        List<Remesas> remes;

        public AdapterMes(Activity intent, List<Remesas> remes)
        {
            Intent = intent;
            this.remes = remes;
        }

        public override int Count => remes.Count;

        public override Java.Lang.Object GetItem(int position)
        {
            throw new NotImplementedException();
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = remes[position];
            View vistam = convertView;

            if(vistam == null)
            {
                vistam = Intent.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem2, null);

            }
            llavemeses(item.Idmes, vistam);
            vistam.FindViewById<TextView>(Android.Resource.Id.Text2).Text = " "+ item.Datomes;
            return vistam;
        }

        private void llavemeses (int op, View r)
        {
           switch(op)
            {
                case 1: r.FindViewById<TextView>(Android.Resource.Id.Text1).Text = "Enero";  break;
                case 2: r.FindViewById<TextView>(Android.Resource.Id.Text1).Text = "Febrero";  break;
                case 3: r.FindViewById<TextView>(Android.Resource.Id.Text1).Text = "Marzo";  break;
                case 4: r.FindViewById<TextView>(Android.Resource.Id.Text1).Text = "Abril";  break;
                case 5: r.FindViewById<TextView>(Android.Resource.Id.Text1).Text = "Mayo";  break;
                case 6: r.FindViewById<TextView>(Android.Resource.Id.Text1).Text = "Junio";  break;
                case 7: r.FindViewById<TextView>(Android.Resource.Id.Text1).Text = "Julio";  break;
                case 8: r.FindViewById<TextView>(Android.Resource.Id.Text1).Text = "Agosto";  break;
                case 9: r.FindViewById<TextView>(Android.Resource.Id.Text1).Text = "Septiembre";  break;
                case 10:r.FindViewById<TextView>(Android.Resource.Id.Text1).Text = "Octubre";  break;
                case 11: r.FindViewById<TextView>(Android.Resource.Id.Text1).Text = "Noviembre"; break;
                case 12: r.FindViewById<TextView>(Android.Resource.Id.Text1).Text = "Diciembre";  break;
                default: r.FindViewById<TextView>(Android.Resource.Id.Text1).Text = " ..."; break;
            }
        }
    }
}