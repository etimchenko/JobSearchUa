﻿using Android.App;
using Android.OS;

namespace JobSearchUa.Droid
{
	[Activity(Label = "JobSearchUa.Droid", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
		}
	}
}

