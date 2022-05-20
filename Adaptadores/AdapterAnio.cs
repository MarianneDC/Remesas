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
    class AdapterAnio : BaseAdapter
    {
        Activity context;
        List<Anio> Lanios;

        public AdapterAnio(Activity context, List<Anio> lanios)
        {
            this.context = context;
            Lanios = lanios;
        }

        public override int Count => Lanios.Count;

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
            var item = Lanios[position];
            View vistaA = convertView;
            if (vistaA == null)
            {
                vistaA = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, null);

            }
            vistaA.FindViewById<TextView>(Android.Resource.Id.Text1).Text = "" + item.Numanio;

            return vistaA;
        }
    }
}