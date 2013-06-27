using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.OS;
using Android.Support.V4.App;
using System.Collections.Generic;
using Android.Support.V4.Widget;
using Android.Widget;

namespace NavigationDrawer
{
	[Activity (Label = "NavigationDrawer", MainLauncher = true)]
	public class MainActivity : FragmentActivity
	{
		List<string> listContent = new List<string> {"Fragment One", "Fragment Two"};
		List<Android.Support.V4.App.Fragment>fragments = new List<Android.Support.V4.App.Fragment>{
			new FirstFragment(),
			new SecondFragment()
		};
		Android.Support.V4.App.FragmentTransaction transaction;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			ArrayAdapter<string> ad = new ArrayAdapter<string> (ActionBar.ThemedContext, Android.Resource.Layout.SimpleListItem1, listContent);
			DrawerLayout drawer = FindViewById<DrawerLayout> (Resource.Id.drawer_layout);
			ListView list = FindViewById<ListView> (Resource.Id.drawer);
			list.SetAdapter (ad);

			transaction = SupportFragmentManager.BeginTransaction ();
			transaction.Add (Resource.Id.main,fragments [0]);
			transaction.Commit ();

			list.ItemClick += (sender, e) => {
				var item = sender as ListView;
				var position = item.CheckedItemPosition;
				transaction = SupportFragmentManager.BeginTransaction();
				transaction.Replace(Resource.Id.main,fragments[position]);
				transaction.Commit();
				drawer.CloseDrawer(item);
			};
		}
	}
}


