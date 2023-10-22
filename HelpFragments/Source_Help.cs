using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using LearnToShare.Classes;
using LearnToShare.Fragments;
using System;

namespace LearnToShare.HelpFragments
{
    [Obsolete]
    public class Source_Help : Fragment
    {
        CheckBox check;
        [Obsolete]
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }
        [Obsolete]
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            View This_View = inflater.Inflate(Resource.Layout.fragment_sourceshelp, container, false);



            check = (CheckBox)This_View.FindViewById(Resource.Id.checkBox1);
            TextView textView = (TextView)This_View.FindViewById(Resource.Id.textView1);
            Google.Android.Material.Button.MaterialButton button =
                (Google.Android.Material.Button.MaterialButton)This_View.FindViewById(Resource.Id.materialButton1);

            if (themes.ColorNumber == 0 || themes.ColorNumber == 1 || themes.ColorNumber == 4) // 0 ==  "حالت شب"
            {
                check.ButtonTintList = ColorStateList.ValueOf(Color.White);
                check.SetTextColor(Color.White);
                check.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Bold);
                textView.SetTextColor(Color.White);
                textView.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Bold);
                button.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Bold);
            }
            else if (themes.ColorNumber == 2 || themes.ColorNumber == 3 || themes.ColorNumber == 5)  // 2 ==    "حالت روز "
            {
                check.ButtonTintList = ColorStateList.ValueOf(Color.Rgb(60, 60, 60));
                check.SetTextColor(Color.Rgb(60, 60, 60));
                check.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Bold);
                textView.SetTextColor(Color.Rgb(60, 60, 60));
                textView.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Bold);
                button.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Bold);
            }

            button.Click += Button_Click;

            return This_View;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (check.Checked)
            {
                Fragment fragment = new Fragment_sources();
                var Transaction = FragmentManager.BeginTransaction();
                Transaction.Replace(Resource.Id.frameLayout1, fragment);
                Transaction.Commit();
                Activity_main.Source_Open = false;
                Activity_main.MyEditor.PutBoolean("Source_Open", false) ;
                Activity_main.MyEditor.Apply();
            }
            else
            {
                Fragment fragment = new Fragment_sources();
                var Transaction = FragmentManager.BeginTransaction();
                Transaction.Replace(Resource.Id.frameLayout1, fragment);
                Transaction.Commit();
            }
        }
    }
}