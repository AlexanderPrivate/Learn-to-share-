using Android.App;
using Android.Content.Res;
using Android.Graphics;
using Android.OS;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.Fragment.App;
using LearnToShare.Classes;
using LearnToShare.Search_Fragments;
using System;

namespace LearnToShare.Activities
{
    [Activity(Label = "Search_page_Activity")]
    public class Activity_search : AppCompatActivity
    {
        ImageButton Back;
        EditText SearchBox;

        [Obsolete]
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            if (themes.ColorNumber == 0) // 0 ==  "حالت شب با رنگ بنفش"
            {
                SetTheme(Resource.Style.DarkBlue);
            }
            else if (themes.ColorNumber == 1)  // 1 ==   "حالت شب با رنگ آبی" 
            {
                SetTheme(Resource.Style.DarkGray);
            }
            else if (themes.ColorNumber == 2)  // 2 ==    "حالت روز با رنگ بنفش"
            {
                SetTheme(Resource.Style.LightBlue);
            }
            else if (themes.ColorNumber == 3) // 3 ==     "حالت روز با آبی"
            {
                SetTheme(Resource.Style.LightGray);
            }
            else if (themes.ColorNumber == 4) // 4 ==     "حالت شب با آپارات"
            {
                SetTheme(Resource.Style.DarkAparat);
            }
            else if (themes.ColorNumber == 5) // 5 ==     "حالت روز با آپارات"
            {
                SetTheme(Resource.Style.LightAparat);
            }

            SetContentView(Resource.Layout.activity_search);

            SearchBox = (EditText)FindViewById(Resource.Id.editText1);
            Back = (ImageButton)FindViewById(Resource.Id.imageButton1);

            SearchBox.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Normal);

            SearchBox.TextChanged += SearchBox_TextChanged;


            if (themes.ColorNumber == 0 || themes.ColorNumber == 1 || themes.ColorNumber == 4) // "حالت شب "
            {
                SearchBox.SetBackgroundResource(Resource.Drawable.search_dark_back);
                SearchBox.SetHintTextColor(ColorStateList.ValueOf(Color.Rgb(230, 230, 230)));
                SearchBox.SetTextColor(Color.White);
                Back.SetImageResource(Resource.Drawable.backicon_layerlist2);
            }
            else if (themes.ColorNumber == 2 || themes.ColorNumber == 3 || themes.ColorNumber == 5)  //  "حالت روز "
            {
                SearchBox.SetBackgroundResource(Resource.Drawable.search_light_back);
                SearchBox.SetHintTextColor(ColorStateList.ValueOf(Color.Rgb(70, 70, 70)));
                SearchBox.SetTextColor(Color.Black);
                Back.SetImageResource(Resource.Drawable.backicon_layerlist);
            }

            Android.App.Fragment fragment = null;
            fragment = new NotFound_frag();
            var Transaction = FragmentManager.BeginTransaction();
            Transaction.Replace(Resource.Id.frameLayout1, fragment);
            Transaction.Commit();

            Back.Click += Back_Click;
        }
        [Obsolete]
        private void SearchBox_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            Android.App.Fragment fragment = null;

            string MyText = SearchBox.Text;

            if (MyText.Contains("سی شارپ") || MyText.Contains("سیشارپ") ||
                MyText.Contains("C#") || MyText.Contains("c#") || MyText.Contains("ویندوز")
                || MyText.Contains("فرم"))
            {
                fragment = new csharp();
                var Transaction = FragmentManager.BeginTransaction();
                Transaction.Replace(Resource.Id.frameLayout1, fragment);
                Transaction.Commit();
            }
            else if (MyText.Contains("جاوا") || MyText.Contains("Java")
                || MyText.Contains("java") || MyText.Contains("JAVA") ||
                MyText.Contains("اندروید") || MyText.Contains("android"))
            {
                fragment = new thejava();
                var Transaction = FragmentManager.BeginTransaction();
                Transaction.Replace(Resource.Id.frameLayout1, fragment);
                Transaction.Commit();

            }
            else if (MyText.Contains("پایتون") || MyText.Contains("python") ||
                MyText.Contains("PYTHON") || MyText.Contains("Python"))
            {
                fragment = new python();
                var Transaction = FragmentManager.BeginTransaction();
                Transaction.Replace(Resource.Id.frameLayout1, fragment);
                Transaction.Commit();
            }
            else if (MyText.Contains("Ai") || MyText.Contains("ai")
                || MyText.Contains("هوش") || MyText.Contains("مصنوعی"))
            {
                fragment = new Ai();
                var Transaction = FragmentManager.BeginTransaction();
                Transaction.Replace(Resource.Id.frameLayout1, fragment);
                Transaction.Commit();
            }
            else if (MyText.Contains("ویژوال") || MyText.Contains("visual") ||
                MyText.Contains("Visual") || MyText.Contains("استودیو")
                || MyText.Contains("کد"))
            {
                fragment = new thevs();
                var Transaction = FragmentManager.BeginTransaction();
                Transaction.Replace(Resource.Id.frameLayout1, fragment);
                Transaction.Commit();
            }
            else if (MyText.Contains("الگوریتم") || MyText.Contains("مسئله") ||
                MyText.Contains("حل"))
            {
                fragment = new algoritm();
                var Transaction = FragmentManager.BeginTransaction();
                Transaction.Replace(Resource.Id.frameLayout1, fragment);
                Transaction.Commit();
            }
            else if (MyText.Contains("html") || MyText.Contains("css") ||
              MyText.Contains("وب") || MyText.Contains("web") || MyText.Contains("سی اس اس") ||
              MyText.Contains("اچ"))
            {
                fragment = new web();
                var Transaction = FragmentManager.BeginTransaction();
                Transaction.Replace(Resource.Id.frameLayout1, fragment);
                Transaction.Commit();
            }
            else if (MyText.Contains("گیتهاب") || MyText.Contains("گیت") ||
             MyText.Contains("git") || MyText.Contains("گیتلب"))
            {
                fragment = new thegit();
                var Transaction = FragmentManager.BeginTransaction();
                Transaction.Replace(Resource.Id.frameLayout1, fragment);
                Transaction.Commit();
            }
            else
            {
                fragment = new NotFound_frag();
                var Transaction = FragmentManager.BeginTransaction();
                Transaction.Replace(Resource.Id.frameLayout1, fragment);
                Transaction.Commit();
            }
        }

        private void Back_Click(object sender, System.EventArgs e)
        {
            Finish();
        }
    }
}