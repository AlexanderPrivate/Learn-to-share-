using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using Google.Android.Material.Button;
using LearnToShare.Activities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using Xamarin.Essentials;

namespace LearnToShare.Fragments
{
    [Obsolete]
    public class Fragment_manage : Fragment
    {
        View This_View;
        TextView txtVersion3, txtVersion4;
        MaterialButton Update, Read;
        string GetVersion4, GetVersion3;
        string url_4, url_3;
        Thread thread;
        LinearLayout linear;
        AndroidX.CardView.Widget.CardView card1, card2, card3, card4;

        [Obsolete]
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
        [Obsolete]
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            This_View = inflater.Inflate(Resource.Layout.fragment_manage, container, false);
            linear = (LinearLayout)This_View.FindViewById(Resource.Id.linearLayout1);

            card1 = (AndroidX.CardView.Widget.CardView)This_View.FindViewById(Resource.Id.cardView1);
            card2 = (AndroidX.CardView.Widget.CardView)This_View.FindViewById(Resource.Id.cardView2);
            card3 = (AndroidX.CardView.Widget.CardView)This_View.FindViewById(Resource.Id.cardView3);
            card4 = (AndroidX.CardView.Widget.CardView)This_View.FindViewById(Resource.Id.cardView4);

            url_4 = "https://ia902703.us.archive.org/13/items/message-4/message%20%284%29.txt";
            url_3 = "https://ia902606.us.archive.org/5/items/message_202305/message.txt";

            txtVersion3 = (TextView)This_View.FindViewById(Resource.Id.textView1);
            txtVersion4 = (TextView)This_View.FindViewById(Resource.Id.textView4);
            Read = (MaterialButton)This_View.FindViewById(Resource.Id.btnRead);

            thread = new Thread(new ThreadStart(GetFromServer));

            thread.Start();


            Update = (MaterialButton)This_View.FindViewById(Resource.Id.btnUpdate);

            List<TextView> textViews = new List<TextView>()
            {
                (TextView)This_View.FindViewById(Resource.Id.textView1),
                (TextView)This_View.FindViewById(Resource.Id.textView2),
                (TextView)This_View.FindViewById(Resource.Id.textView4)
            };

            foreach (TextView textView in textViews)
            {
                textView.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Normal);
            }

            List<MaterialButton> buttons = new List<MaterialButton>()
            {
                (MaterialButton)This_View.FindViewById(Resource.Id.btnUpdate),
                (MaterialButton)This_View.FindViewById(Resource.Id.btnRead),
            };

            foreach (var i in buttons)
            {
                i.SetTypeface(Activity_main.IranSansFont, Android.Graphics.TypefaceStyle.Bold);
            }

            if (Activity_main.theme_number == 0 || Activity_main.theme_number == 1 || Activity_main.theme_number == 4) // 0 ==  "حالت شب"
            {
                foreach (var txt in textViews)
                {
                    txt.SetTextColor(Color.White);
                }
                card1.SetCardBackgroundColor(Color.Rgb(30, 30, 30));
                card2.SetCardBackgroundColor(Color.Rgb(30, 30, 30));
                card4.SetCardBackgroundColor(Color.Rgb(30, 30, 30));

            }
            else if (Activity_main.theme_number == 2 || Activity_main.theme_number == 3 || Activity_main.theme_number == 5)  // 2 ==    "حالت روز"
            {
                card1.SetCardBackgroundColor(Color.White);
                card2.SetCardBackgroundColor(Color.White);
                card4.SetCardBackgroundColor(Color.White);
                foreach (TextView txt in textViews)
                {
                    if (txt == txtVersion4 || txt == txtVersion3)
                    {
                        txt.SetTextColor(Color.Rgb(70, 70, 70));
                    }
                    else
                    {
                        txt.SetTextColor(Color.Black);
                    }
                }
            }


            Update.Click += Update_Click;
            Read.Click += Read_Click;


            return This_View;
        }

        private void Read_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(This_View.Context, typeof(Activity_about));
            StartActivity(intent);
        }
        public void GetFromServer()
        {
            bool Version3 = Activity_main.preferences.GetBoolean("Version3_Notification", default);
            try
            {
                if (Connectivity.NetworkAccess == NetworkAccess.None
                    && Connectivity.NetworkAccess == NetworkAccess.Unknown)
                {
                    //Null Not internet!!!
                }
                else
                {
                    HttpClient Request = new HttpClient();

                    GetVersion4 = Request.GetStringAsync(url_4).Result;

                    if (Version3)
                    {
                        GetVersion3 = Request.GetStringAsync(url_3).Result;
                        MainThread.BeginInvokeOnMainThread(() =>
                        {
                            txtVersion3.Text = GetVersion3;
                        });
                    }
                    else
                    {
                        MainThread.BeginInvokeOnMainThread(() =>
                        {
                            txtVersion3.Text = "اعلان های نسخه 3 خاموش است میتوانید از تنظیمات دریافت را فعال نمایید.!";
                        });
                    }
                    MainThread.BeginInvokeOnMainThread(() =>
                    {
                        txtVersion4.Text = GetVersion4;
                    });
                }
            }
            catch (Exception)
            {
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    txtVersion4.SetTextColor(Color.Red);
                    txtVersion4.Text = "مشکلی در دریافت اطلاعات از سرور پیش آمد دوباره امتحان کنید.";
                });
                if (Version3)
                {
                    MainThread.BeginInvokeOnMainThread(() =>
                    {
                        txtVersion3.SetTextColor(Color.Red);
                        txtVersion3.Text = "مشکلی در دریافت اطلاعات از سرور پیش آمد دوباره امتحان کنید.";
                    });
                }
                else
                {
                    MainThread.BeginInvokeOnMainThread(() => { txtVersion3.Text = "اعلان های نسخه 3 خاموش است میتوانید از تنظیمات دریافت را فعال نمایید.!"; });
                }
            }
        }
        private void Update_Click(object sender, EventArgs e)
        {
            if (Activity_main.theme_number == 0 || Activity_main.theme_number == 1) // 0 ==  "حالت شب با رنگ بنفش"
            {
                txtVersion3.SetTextColor(Color.White);
                txtVersion4.SetTextColor(Color.White);
            }
            else if (Activity_main.theme_number == 2 || Activity_main.theme_number == 3)  // 2 ==    "حالت روز با رنگ بنفش"
            {
                txtVersion3.SetTextColor(Color.Rgb(70, 70, 70));
                txtVersion4.SetTextColor(Color.Rgb(70, 70, 70));
            }

            txtVersion4.Text = "درحال بروزرسانی";
            txtVersion3.Text = "درحال بروز رسانی";
            thread = null;
            thread = new Thread(new ThreadStart(GetFromServer));
            thread.Start();
        }
    }
}