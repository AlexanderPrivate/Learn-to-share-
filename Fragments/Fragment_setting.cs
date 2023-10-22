using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.CardView.Widget;
using Google.Android.Material.Button;
using LearnToShare.Activities;
using System;
using System.Collections.Generic;

namespace LearnToShare.Fragments
{
    [Obsolete]
    public class Fragment_setting : Fragment
    {
        View This_View;
        Switch Notif_Version3;
        AndroidX.AppCompat.Widget.Toolbar toolbar;
        LinearLayout linear;
        MaterialButton btnAbout, btnShare, btnComment;
        CardView cardDarkTheme, cardNotif, cardAbout,
            cardShare, cardComment;
        Spinner spinner;

        [Obsolete]
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
        [Obsolete]
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            This_View = inflater.Inflate(Resource.Layout.fragment_setting, container, false);

            toolbar = (AndroidX.AppCompat.Widget.Toolbar)This_View.FindViewById(Resource.Id.toolbar1);
            linear = (LinearLayout)This_View.FindViewById(Resource.Id.mylinear);

            linear.Animate().Alpha(1f).SetDuration(600).Start();

            string[] items =
            {
                "تم برنامه",
                "حالت شب با رنگ آبی" ,
                "حالت روز با رنگ آبی",
                "حالت شب با رنگ خاکستری" ,
                "حالت روز با رنگ خاکستری",
                "حالت شب با رنگ قرمز",
                "حالت روز با رنگ قرمز"
            };

            spinner = (Spinner)This_View.FindViewById(Resource.Id.spinner1);



            ArrayAdapter<string> adapter = new ArrayAdapter<string>(This_View.Context, Android.Resource.Layout.SimpleSpinnerItem, items);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner.Adapter = adapter;

            spinner.ItemSelected += Spinner_ItemSelected;

            Notif_Version3 = (Switch)This_View.FindViewById(Resource.Id.switch2);
            cardDarkTheme = (CardView)This_View.FindViewById(Resource.Id.cardView1);
            cardNotif = (CardView)This_View.FindViewById(Resource.Id.cardView4);
            cardAbout = (CardView)This_View.FindViewById(Resource.Id.cardView5);
            cardShare = (CardView)This_View.FindViewById(Resource.Id.cardView6);
            cardComment = (CardView)This_View.FindViewById(Resource.Id.cardView7);
            btnAbout = (MaterialButton)This_View.FindViewById(Resource.Id.mybutton3);
            btnShare = (MaterialButton)This_View.FindViewById(Resource.Id.mybutton4);
            btnComment = (MaterialButton)This_View.FindViewById(Resource.Id.mybutton5);



            int Day = Activity_main.preferences.GetInt("Theme", default);
            bool Version3 = Activity_main.preferences.GetBoolean("Version3_Notification", default);

            if (Version3)
            {
                Notif_Version3.Checked = true;
            }
            else
            {
                Notif_Version3.Checked = false;
            }

            List<TextView> texts = new List<TextView>
            {
                (TextView)This_View.FindViewById(Resource.Id.textView1),
                (TextView)This_View.FindViewById(Resource.Id.textView4),
                (TextView)This_View.FindViewById(Resource.Id.textView5),
                (TextView)This_View.FindViewById(Resource.Id.textView6),
                (TextView)This_View.FindViewById(Resource.Id.textView7)
            };

            List<CardView> Cards = new List<CardView>
            {
                (CardView)This_View.FindViewById(Resource.Id.cardView1),
                (CardView)This_View.FindViewById(Resource.Id.cardView4),
                (CardView)This_View.FindViewById(Resource.Id.cardView5),
                (CardView)This_View.FindViewById(Resource.Id.cardView6),
                (CardView)This_View.FindViewById(Resource.Id.cardView7)
            };


            foreach (var txt in texts)
            {
                txt.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Normal);
            }


            List<MaterialButton> materialButtons = new List<MaterialButton>
            {
                (MaterialButton)This_View.FindViewById(Resource.Id.mybutton3),
                (MaterialButton)This_View.FindViewById(Resource.Id.mybutton4),
                (MaterialButton)This_View.FindViewById(Resource.Id.mybutton5)
            };

            foreach (var material in materialButtons)
            {
                material.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Bold);
            }

            if (Activity_main.theme_number == 0 || Activity_main.theme_number == 1 || Activity_main.theme_number == 4) // حالت شب
            {
                foreach (var txt in texts)
                {
                    txt.SetTextColor(Color.White);
                }
                foreach (var card in Cards)
                {
                    card.SetCardBackgroundColor(Color.Rgb(30, 30, 30));
                }

                toolbar.SetBackgroundResource(Resource.Drawable.toolbar_back_dark);
                toolbar.SetTitleTextColor(Color.White);
            }
            else if (Activity_main.theme_number == 2 || Activity_main.theme_number == 3 || Activity_main.theme_number == 5) // حالت روز
            {
                foreach (var card in Cards)
                {
                    card.SetCardBackgroundColor(Color.White);
                }
                foreach (var txt in texts)
                {
                    txt.SetTextColor(Color.Black);
                }
                toolbar.SetBackgroundResource(Resource.Drawable.toolbar_back);
                toolbar.SetTitleTextColor(Color.Black);
            }



            btnAbout.Click += BtnAbout_Click;
            btnShare.Click += BtnShare_Click;
            btnComment.Click += BtnComment_Click;

            Notif_Version3.CheckedChange += Vs3_CheckedChange;
            cardDarkTheme.Click += CardDarkTheme_Click;
            cardNotif.Click += CardNotif_Click;
            cardAbout.Click += CardAbout_Click;
            cardShare.Click += CardShare_Click;
            cardComment.Click += CardComment_Click;


            return This_View;
        }

        private void CardComment_Click(object sender, EventArgs e)
        {
            btnComment.PerformClick();
        }

        private void BtnComment_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "myket://comment?id=learn.windowsform.ir";
                Intent intent = new Intent();
                intent.SetAction(Intent.ActionView);
                intent.SetData(Android.Net.Uri.Parse(url));
                StartActivity(intent);
            }
            catch (Exception)
            {
                Toast.MakeText(Context, "این قابلیت در گوشی شما پشتیبانی نمی شود", ToastLength.Long).Show();
            }

        }

        private void Spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            string selectedOption = spinner.GetItemAtPosition(e.Position).ToString();

            if (selectedOption.Equals("حالت شب با رنگ آبی"))
            {
                Activity_main.MyEditor.PutInt("Theme", 0);
                Activity_main.MyEditor.Apply();
                var intent = new Intent(This_View.Context, typeof(Activity_main));
                intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.NewTask);
                StartActivity(intent);
            }
            else if (selectedOption.Equals("حالت شب با رنگ خاکستری"))
            {
                Activity_main.MyEditor.PutInt("Theme", 1);
                Activity_main.MyEditor.Apply();
                var intent = new Intent(This_View.Context, typeof(Activity_main));
                intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.NewTask);
                StartActivity(intent);
            }
            else if (selectedOption.Equals("حالت روز با رنگ آبی"))
            {
                Activity_main.MyEditor.PutInt("Theme", 2);
                Activity_main.MyEditor.Apply();
                var intent = new Intent(This_View.Context, typeof(Activity_main));
                intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.NewTask);
                StartActivity(intent);
            }
            else if (selectedOption.Equals("حالت روز با رنگ خاکستری"))
            {
                Activity_main.MyEditor.PutInt("Theme", 3);
                Activity_main.MyEditor.Apply();
                var intent = new Intent(This_View.Context, typeof(Activity_main));
                intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.NewTask);
                StartActivity(intent);
            }
            else if (selectedOption.Equals("حالت شب با رنگ قرمز"))
            {
                Activity_main.MyEditor.PutInt("Theme", 4);
                Activity_main.MyEditor.Apply();
                var intent = new Intent(This_View.Context, typeof(Activity_main));
                intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.NewTask);
                StartActivity(intent);
            }
            else if (selectedOption.Equals("حالت روز با رنگ قرمز"))
            {
                Activity_main.MyEditor.PutInt("Theme", 5);
                Activity_main.MyEditor.Apply();
                var intent = new Intent(This_View.Context, typeof(Activity_main));
                intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.NewTask);
                StartActivity(intent);
            }

        }

        private void CardShare_Click(object sender, EventArgs e)
        {
            btnShare.PerformClick();
        }

        private void CardAbout_Click(object sender, EventArgs e)
        {
            btnAbout.PerformClick();
        }

        private void CardNotif_Click(object sender, EventArgs e)
        {
            Notif_Version3.PerformClick();
        }

        private void CardDarkTheme_Click(object sender, EventArgs e)
        {
            spinner.PerformClick();
        }


        private void BtnShare_Click(object sender, EventArgs e)
        {
            Intent sharingInt = new Intent(Intent.ActionSend);
            sharingInt.SetType("text/plain");
            string shareBody = "https://myket.ir/app/learn.windowsform.ir";
            sharingInt.PutExtra(Intent.ExtraSubject, "برنامه لرن تو شر");
            sharingInt.PutExtra(Intent.ExtraText, shareBody);
            var intent = Intent.CreateChooser(sharingInt, "اشتراک گذاری با :");
            StartActivity(intent);
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(This_View.Context, typeof(Activity_about));
            StartActivity(intent);
        }

        private void Vs3_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            switch (e.IsChecked)
            {
                case true:
                    Activity_main.MyEditor.PutBoolean("Version3_Notification", true);
                    Activity_main.MyEditor.Apply();
                    break;
                case false:
                    Activity_main.MyEditor.PutBoolean("Version3_Notification", false);
                    Activity_main.MyEditor.Apply();
                    break;
            }
        }
    }
}