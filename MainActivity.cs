using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using Android.Content;
using System;

namespace Gamepedia
{
    [Activity(Label = "Gamepedia", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ImageButton playBtn, helpBtn;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            playBtn = FindViewById<ImageButton>(Resource.Id.playBtn);
            helpBtn = FindViewById<ImageButton>(Resource.Id.helpBtn);

            playBtn.Click += PlayBtn_Click;
            helpBtn.Click += HelpBtn_Click;
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(CategoryActivity));
            StartActivity(intent);
        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(CategoryActivity));
            StartActivity(intent);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}