using Android.App;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;
using System.Threading;

namespace task
{
    [Activity(Label = "task", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button button;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
             button = FindViewById<Button>(Resource.Id.button1);
            button.Click += delegate {
                var t = Task.Factory.StartNew(() => mytask());
            };

        }
        void mytask()
        {
            int i = 0;
                while (i < 10)
            {
                RunOnUiThread(() => button.Text = i.ToString());
                Thread.Sleep(300);
                i++;
            }
        }
    }
}

