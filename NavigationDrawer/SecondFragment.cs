using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Widget;
using Android.Support.V4.App;
using Android.Views;

namespace NavigationDrawer
{
	public class SecondFragment : Fragment
	{
		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your fragment here
		}

		public override View OnCreateView (LayoutInflater p0, ViewGroup p1, Bundle p2)
		{
			ViewGroup root = (ViewGroup) p0.Inflate(Resource.Layout.Second,null);
			return root;
		}
	}
}

