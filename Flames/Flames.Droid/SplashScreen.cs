﻿using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;
using Xamarin.Forms;

namespace Flames.Droid
{

    [Activity(
        Label = "Flames"
        , MainLauncher = true
        , Icon = "@mipmap/flames"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }

        protected override void TriggerFirstNavigate()
        {
            StartActivity(typeof(MainActivity));
            base.TriggerFirstNavigate();
        }

        protected override void OnCreate(Android.OS.Bundle bundle)
        {
            Forms.Init(this, bundle);
            // Leverage controls' StyleId attrib. to Xamarin.UITest
            Forms.ViewInitialized += (object sender, ViewInitializedEventArgs e) =>
            {
                if (!string.IsNullOrWhiteSpace(e.View.StyleId))
                {
                    e.NativeView.ContentDescription = e.View.StyleId;
                }
            };

            base.OnCreate(bundle);
        }
    }
}
