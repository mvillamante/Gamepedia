using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gamepedia
{
    [Activity(Label = "Next Activity")]
    public class CategoryActivity:AppCompatActivity
    {
        ImageButton returnBtn, ctg1, ctg2, ctg3;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_category);

            returnBtn = FindViewById<ImageButton>(Resource.Id.returnBtn);
            ctg1 = FindViewById<ImageButton>(Resource.Id.ctg1);
            ctg2 = FindViewById<ImageButton>(Resource.Id.ctg2);
            ctg3 = FindViewById<ImageButton>(Resource.Id.ctg3);

            returnBtn.Click += ReturnBtn_Click;
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            Finish();
        }
    }
}