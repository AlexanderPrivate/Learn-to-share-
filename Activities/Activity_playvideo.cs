using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.CardView.Widget;
using LearnToShare.Classes;
using System;
using System.Collections.Generic;
using Xamarin.Essentials;

namespace LearnToShare.Activities
{
    [Activity(Label = "Player_Activity")]
    public class Activity_playvideo : AppCompatActivity
    {
        Google.Android.Material.Button.MaterialButton button;
        AndroidX.AppCompat.Widget.Toolbar toolbar;
        View v1, v2;

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
            SetContentView(Resource.Layout.activity_playvideo);
            //////////////////////////////////////////////////////////////

            toolbar = (AndroidX.AppCompat.Widget.Toolbar)FindViewById(Resource.Id.toolbar1);

            // ست کردن آیدی های سی شارپ با ایکس ام ال
            TextView NameOfTeacher = (TextView)FindViewById(Resource.Id.textView2);
            TextView TimeOfVideo = (TextView)FindViewById(Resource.Id.textView4);
            TextView InternetChecked = (TextView)FindViewById(Resource.Id.textView6);
            TextView TextOfDes = (TextView)FindViewById(Resource.Id.textView7);
            TextView Tozih = (TextView)FindViewById(Resource.Id.tozihat);
            TextView text1 = (TextView)FindViewById(Resource.Id.textView1);
            TextView text3 = (TextView)FindViewById(Resource.Id.textView3);
            TextView text5 = (TextView)FindViewById(Resource.Id.textView5);
            TextView Tozih2 = (TextView)FindViewById(Resource.Id.tozihat2);
            TextView text7 = (TextView)FindViewById(Resource.Id.textView7);
            CardView Mode1 = (CardView)FindViewById(Resource.Id.ModelCard1);
            CardView Mode2 = (CardView)FindViewById(Resource.Id.ModelCard2);
            button = (Google.Android.Material.Button.MaterialButton)FindViewById(Resource.Id.materialButton1);
            v1 = FindViewById(Resource.Id.view1);
            v2 = FindViewById(Resource.Id.view2);
            ///////////////////////////

            // اضافه کردن تولبار به اکتیویتی
            SetSupportActionBar(toolbar);
            //////////////////////////////////////////



            //// Get Info From infomanager Class ////
            NameOfTeacher.Text = info_manager.TEACHER_NAME;
            TimeOfVideo.Text = info_manager.TIME_OF_VIDEO;
            TextOfDes.Text = info_manager.DESCREPTION;
            ///////////////////////////////////////////////////////

            //--Set Font--//
            NameOfTeacher.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Normal);
            TimeOfVideo.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Normal);
            TextOfDes.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Normal);
            InternetChecked.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Normal);
            button.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Bold);
            Tozih.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Bold);
            text1.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Normal);
            text3.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Normal);
            text5.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Normal);
            Tozih2.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Bold);
            text7.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Normal);
            ///////////////////////////////

            // Show Video //
            WebView VideoPlayer_Web = (WebView)FindViewById(Resource.Id.MyWeb);
            WebSettings settings = VideoPlayer_Web.Settings;
            settings.JavaScriptEnabled = true;
            VideoPlayer_Web.SetWebChromeClient(new WebChromeClient());
            VideoPlayer_Web.LoadUrl(info_manager.IFRAME_URL);
            ////////////////////////////////

            List<CardView> cards = new List<CardView>()
            {
                (CardView)FindViewById(Resource.Id.mycard1),
                (CardView)FindViewById(Resource.Id.mycard2),
                (CardView)FindViewById(Resource.Id.mycard3)
            };

            if (Connectivity.NetworkAccess == NetworkAccess.None
                 && Connectivity.NetworkAccess == NetworkAccess.Unknown)
            {
                InternetChecked.Text = "اینترنت متصل نیست";
            }
            else
            {
                InternetChecked.Text = "متصل";
            }


            if (themes.ColorNumber == 0) // حالت شب با رنگ آبی
            {
                DarkMode(NameOfTeacher, TimeOfVideo, InternetChecked, Tozih, text1, text3, text5, Tozih2, text7, cards);
                Mode1.SetCardBackgroundColor(Color.ParseColor("#009dff"));
                Mode2.SetCardBackgroundColor(Color.ParseColor("#009dff"));
            }
            else if(themes.ColorNumber == 1) // خاکستری شب
            {
                DarkMode(NameOfTeacher, TimeOfVideo, InternetChecked, Tozih, text1, text3, text5, Tozih2, text7, cards);
                Mode1.SetCardBackgroundColor(Color.White);
                Mode2.SetCardBackgroundColor(Color.White);
            }
            else if (themes.ColorNumber == 2) // روز آبی
            {
                LightMode(NameOfTeacher, TimeOfVideo, InternetChecked, Tozih, text1, text3, text5, Tozih2, text7, cards);
                Mode1.SetCardBackgroundColor(Color.ParseColor("#009dff"));
                Mode2.SetCardBackgroundColor(Color.ParseColor("#009dff"));
            }
            else if (themes.ColorNumber == 3) // روز با خاکستری
            {
                LightMode(NameOfTeacher, TimeOfVideo, InternetChecked, Tozih, text1, text3, text5, Tozih2, text7, cards);
                Mode1.SetCardBackgroundColor(Color.ParseColor("#141414"));
                Mode2.SetCardBackgroundColor(Color.ParseColor("#141414"));
            }
            else if(themes.ColorNumber == 4) // شب آپارات
            {
                DarkMode(NameOfTeacher, TimeOfVideo, InternetChecked, Tozih, text1, text3, text5, Tozih2, text7, cards);
                Mode1.SetCardBackgroundColor(Color.ParseColor("#ED145B"));
                Mode2.SetCardBackgroundColor(Color.ParseColor("#ED145B"));
            }
            else if (themes.ColorNumber == 5) // روز آپارات
            {
                LightMode(NameOfTeacher, TimeOfVideo, InternetChecked, Tozih, text1, text3, text5, Tozih2, text7, cards);
                Mode1.SetCardBackgroundColor(Color.ParseColor("#ED145B"));
                Mode2.SetCardBackgroundColor(Color.ParseColor("#ED145B"));
            }

            button.Click += Button_Click;
        }

        private void DarkMode(TextView NameOfTeacher, TextView TimeOfVideo, TextView InternetChecked, TextView Tozih, TextView text1, TextView text3, TextView text5, TextView Tozih2, TextView text7, List<CardView> cards)
        {
            toolbar.SetBackgroundResource(Resource.Drawable.toolbar_back_dark);
            toolbar.SetTitleTextColor(Color.White);
            NameOfTeacher.SetTextColor(Color.Rgb(240, 240, 240));
            TimeOfVideo.SetTextColor(Color.Rgb(240, 240, 240));
            InternetChecked.SetTextColor(Color.Rgb(240, 240, 240));
            Tozih.SetTextColor(Color.White);
            Tozih2.SetTextColor(Color.White);
            text1.SetTextColor(Color.Rgb(240, 240, 240));
            text3.SetTextColor(Color.Rgb(240, 240, 240));
            text5.SetTextColor(Color.Rgb(240, 240, 240));
            text7.SetTextColor(Color.Rgb(240, 240, 240));
            foreach (var card in cards)
            {
                card.SetCardBackgroundColor(Color.Rgb(30, 30, 30));
            }
            v1.SetBackgroundColor(Color.White);
            v2.SetBackgroundColor(Color.White);
        }

        private void LightMode(TextView NameOfTeacher, TextView TimeOfVideo, TextView InternetChecked, TextView Tozih, TextView text1, TextView text3, TextView text5, TextView Tozih2, TextView text7, List<CardView> cards)
        {
            toolbar.SetBackgroundResource(Resource.Drawable.toolbar_back);
            toolbar.SetTitleTextColor(Color.Black);
            NameOfTeacher.SetTextColor(Color.Black);
            TimeOfVideo.SetTextColor(Color.Black);
            InternetChecked.SetTextColor(Color.Black);
            Tozih.SetTextColor(Color.Rgb(70, 70, 70));
            Tozih2.SetTextColor(Color.Rgb(70, 70, 70));
            text1.SetTextColor(Color.Black);
            text3.SetTextColor(Color.Black);
            text5.SetTextColor(Color.Black);
            text7.SetTextColor(Color.Black);
            foreach (var card in cards)
            {
                card.SetCardBackgroundColor(Color.White);
            }
            v1.SetBackgroundColor(Color.Rgb(70, 70, 70));
            v2.SetBackgroundColor(Color.Rgb(70, 70, 70));
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(Intent.ActionView, Android.Net.Uri.Parse(info_manager.APARAT_LINK));
            StartActivity(intent);
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