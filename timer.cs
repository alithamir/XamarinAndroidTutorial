 using Android.App;
using Android.Widget;
using Android.OS;
using System.Timers;
using System;

namespace timerandview
{
    [Activity(Label = "timerandview", MainLauncher = true)]
    public class MainActivity : Activity
    {
        int Count =1;
        TextView txtview;
        Timer t;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            t = new Timer();
            t.Interval = 3000;
            t.Elapsed += new ElapsedEventHandler(T_elp);

            var bustart = FindViewById<Button>(Resource.Id.bustart);
            var bustop = FindViewById<Button>(Resource.Id.bustop);
            txtview = FindViewById<TextView>(Resource.Id.txtview);

            bustart.Click += delegate {
                t.Start();

            };
            bustop.Click += delegate {
                t.Stop();

            };
        }
        protected void T_elp(object sender,ElapsedEventArgs e)
        {
            RunOnUiThread(() =>
            txtview.Text = Count.ToString()

                );
            Count++;
        }

       
       
    }
}

