using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.CardView.Widget;
using LearnToShare.Classes;
using System.Collections.Generic;

namespace LearnToShare.Activities
{
    [Activity(Label = "About_app_Activity")]
    public class Activity_about : AppCompatActivity
    {
        AndroidX.AppCompat.Widget.Toolbar toolbar;
        CardView Mode1, Mode2, Mode3;
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

            // وصل شدن به لیاوت 
            SetContentView(Resource.Layout.activity_about);
            //
            // ست کردن آیدی ها
            TextView txt1 = (TextView)FindViewById(Resource.Id.textView1);
            TextView txt2 = (TextView)FindViewById(Resource.Id.textView2);
            TextView txt3 = (TextView)FindViewById(Resource.Id.textView3);

            toolbar = (AndroidX.AppCompat.Widget.Toolbar)FindViewById(Resource.Id.toolbar1);
            Mode1 = (CardView)FindViewById(Resource.Id.ModeCard1);
            Mode2 = (CardView)FindViewById(Resource.Id.ModeCard2);
            Mode3 = (CardView)FindViewById(Resource.Id.ModeCard3);
            /////////////////////////////////////////////

            // اضافه کردن تولبار به اکتیویتی
            SetSupportActionBar(toolbar);
            ///////////////////////////////////////
            ///

            Typeface typeface = Typeface.CreateFromAsset(Assets, "PACIFICO.TTF");

            txt1.SetTypeface(typeface, TypefaceStyle.Normal);
            txt2.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Normal);
            txt3.SetTypeface(typeface, TypefaceStyle.Normal);

            txt3.Text = "Version : " + Xamarin.Essentials.AppInfo.VersionString;

            List<CardView> cardViews = new List<CardView>
            {
                (CardView)FindViewById(Resource.Id.cardView1),
                (CardView)FindViewById(Resource.Id.cardView2),
                (CardView)FindViewById(Resource.Id.cardView3),
            };

            if (themes.ColorNumber == 0) // حالت شب با رنگ آبی
            {
                DarkMode(txt1, txt2, txt3, cardViews);
                Mode1.SetCardBackgroundColor(Color.ParseColor("#009dff"));
                Mode2.SetCardBackgroundColor(Color.ParseColor("#009dff"));
                Mode3.SetCardBackgroundColor(Color.ParseColor("#009dff"));
            }
            else if (themes.ColorNumber == 1) // خاکستری شب
            {
                DarkMode(txt1, txt2, txt3, cardViews);
                Mode1.SetCardBackgroundColor(Color.White);
                Mode2.SetCardBackgroundColor(Color.White);
                Mode3.SetCardBackgroundColor(Color.White);
            }
            else if (themes.ColorNumber == 2) // روز آبی
            {
                Mode1.SetCardBackgroundColor(Color.ParseColor("#009dff"));
                Mode2.SetCardBackgroundColor(Color.ParseColor("#009dff"));
                Mode3.SetCardBackgroundColor(Color.ParseColor("#009dff"));
            }
            else if (themes.ColorNumber == 3) // روز با خاکستری
            {
                Mode1.SetCardBackgroundColor(Color.ParseColor("#141414"));
                Mode2.SetCardBackgroundColor(Color.ParseColor("#141414"));
                Mode3.SetCardBackgroundColor(Color.ParseColor("#141414"));
            }
            else if (themes.ColorNumber == 4) // شب آپارات
            {
                DarkMode(txt1, txt2, txt3, cardViews);
                Mode1.SetCardBackgroundColor(Color.ParseColor("#ED145B"));
                Mode2.SetCardBackgroundColor(Color.ParseColor("#ED145B"));
                Mode3.SetCardBackgroundColor(Color.ParseColor("#ED145B"));
            }
            else if (themes.ColorNumber == 5) // روز آپارات
            {
                Mode1.SetCardBackgroundColor(Color.ParseColor("#ED145B"));
                Mode2.SetCardBackgroundColor(Color.ParseColor("#ED145B"));
                Mode3.SetCardBackgroundColor(Color.ParseColor("#ED145B"));
            }

        }

        private void DarkMode(TextView txt1, TextView txt2, TextView txt3, List<CardView> cardViews)
        {
            toolbar.SetBackgroundResource(Resource.Drawable.toolbar_back_dark);
            toolbar.SetTitleTextColor(Color.White);
            foreach (var card in cardViews)
            {
                card.SetCardBackgroundColor(Color.Rgb(20, 20, 20));
            }
            txt1.SetTextColor(Color.White);
            txt2.SetTextColor(Color.White);
            txt3.SetTextColor(Color.White);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            if (themes.ColorNumber == 0 || themes.ColorNumber == 1 || themes.ColorNumber == 4) //  ==  "حالت شب"
            {
                MenuInflater.Inflate(Resource.Menu.back_dark, menu);
                return base.OnCreateOptionsMenu(menu);
            }
            else if (themes.ColorNumber == 2 || themes.ColorNumber == 3 || themes.ColorNumber == 5)  //  ==    "حالت روز"
            {
                MenuInflater.Inflate(Resource.Menu.back, menu);
                return base.OnCreateOptionsMenu(menu);
            }
            else
            {
                MenuInflater.Inflate(Resource.Menu.back_dark, menu);
                return base.OnCreateOptionsMenu(menu);
            }
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.back:
                    Finish();
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}