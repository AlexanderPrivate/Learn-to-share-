using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.CardView.Widget;
using LearnToShare.Classes;
using System;
using System.Collections.Generic;

namespace LearnToShare.Activities
{
    [Activity(Label = "vscode_list_Activity")]
    public class Activity_vscode : AppCompatActivity
    {
        AndroidX.AppCompat.Widget.Toolbar toolbar;
        Google.Android.Material.Button.MaterialButton btn1, btn2, btn3, btn4, btn5;
        Google.Android.Material.Button.MaterialButton download1, download2, download3, download4, download5;
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

            SetContentView(Resource.Layout.activity_vscode);


            toolbar = (AndroidX.AppCompat.Widget.Toolbar)FindViewById(Resource.Id.toolbar1);

            SetSupportActionBar(toolbar);

            btn1 = (Google.Android.Material.Button.MaterialButton)FindViewById(Resource.Id.materialButton1);
            btn2 = (Google.Android.Material.Button.MaterialButton)FindViewById(Resource.Id.materialButton2);
            btn3 = (Google.Android.Material.Button.MaterialButton)FindViewById(Resource.Id.materialButton3);
            btn4 = (Google.Android.Material.Button.MaterialButton)FindViewById(Resource.Id.materialButton4);
            btn5 = (Google.Android.Material.Button.MaterialButton)FindViewById(Resource.Id.materialButton5);

            download1 = (Google.Android.Material.Button.MaterialButton)FindViewById(Resource.Id.downloadbutton1);
            download2 = (Google.Android.Material.Button.MaterialButton)FindViewById(Resource.Id.downloadbutton2);
            download3 = (Google.Android.Material.Button.MaterialButton)FindViewById(Resource.Id.downloadbutton3);
            download4 = (Google.Android.Material.Button.MaterialButton)FindViewById(Resource.Id.downloadbutton4);
            download5 = (Google.Android.Material.Button.MaterialButton)FindViewById(Resource.Id.downloadbutton5);

            List<CardView> cardViews = new List<CardView>
            {
                (CardView)FindViewById(Resource.Id.cardView1),
                (CardView)FindViewById(Resource.Id.cardView2),
                (CardView)FindViewById(Resource.Id.cardView3),
                (CardView)FindViewById(Resource.Id.cardView4),
                (CardView)FindViewById(Resource.Id.cardView5)
            };

            List<TextView> text_of_bold = new List<TextView>
            {
                (TextView)FindViewById(Resource.Id.textView1),
                (TextView)FindViewById(Resource.Id.textView2),
                (TextView)FindViewById(Resource.Id.textView3),
                (TextView)FindViewById(Resource.Id.textView4),
                (TextView)FindViewById(Resource.Id.textView5)
            };

            foreach (var bold in text_of_bold)
            {
                bold.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Bold);
            }

            List<TextView> text_of_normal = new List<TextView>
            {
                (TextView)FindViewById(Resource.Id.textTitle1),
                (TextView)FindViewById(Resource.Id.textTitle2),
                (TextView)FindViewById(Resource.Id.textTitle3),
                (TextView)FindViewById(Resource.Id.textTitle4),
                (TextView)FindViewById(Resource.Id.textTitle5)
            };

            foreach (var Normal in text_of_normal)
            {
                Normal.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Normal);
            }

            List<Google.Android.Material.Button.MaterialButton> materialButtons = new List<Google.Android.Material.Button.MaterialButton>
            {
                (Google.Android.Material.Button.MaterialButton)FindViewById(Resource.Id.materialButton1),
                (Google.Android.Material.Button.MaterialButton)FindViewById(Resource.Id.materialButton2),
                (Google.Android.Material.Button.MaterialButton)FindViewById(Resource.Id.materialButton3),
                (Google.Android.Material.Button.MaterialButton)FindViewById(Resource.Id.materialButton4),
                (Google.Android.Material.Button.MaterialButton)FindViewById(Resource.Id.materialButton5)
            };

            foreach (var materialbutton in materialButtons)
            {
                materialbutton.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Bold);
            }

            List<Google.Android.Material.Button.MaterialButton> DownloadButtons = new List<Google.Android.Material.Button.MaterialButton>
            {
                (Google.Android.Material.Button.MaterialButton)FindViewById(Resource.Id.downloadbutton1),
                (Google.Android.Material.Button.MaterialButton)FindViewById(Resource.Id.downloadbutton2),
                (Google.Android.Material.Button.MaterialButton)FindViewById(Resource.Id.downloadbutton3),
                (Google.Android.Material.Button.MaterialButton)FindViewById(Resource.Id.downloadbutton4),
                (Google.Android.Material.Button.MaterialButton)FindViewById(Resource.Id.downloadbutton5)
            };

            foreach (var downloadbutton in DownloadButtons)
            {
                downloadbutton.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Bold);
            }


            if (themes.ColorNumber == 0 || themes.ColorNumber == 1 || themes.ColorNumber == 4) // 0 ==  "حالت شب "
            {
                foreach (var card in cardViews)
                {
                    card.SetCardBackgroundColor(Color.Rgb(30, 30, 30));
                }
                toolbar.SetBackgroundResource(Resource.Drawable.toolbar_back_dark);
                toolbar.SetTitleTextColor(Color.White);
                foreach (var txt in text_of_bold)
                {
                    txt.SetTextColor(Color.White);
                }
                foreach (var txt in text_of_normal)
                {
                    txt.SetTextColor(Color.Rgb(240, 240, 240));
                }
            }
            else if (themes.ColorNumber == 2 || themes.ColorNumber == 3 || themes.ColorNumber == 5)  // 2 ==    "حالت روز "
            {
                toolbar.SetBackgroundResource(Resource.Drawable.toolbar_back);
                toolbar.SetTitleTextColor(Color.Black);
                foreach (var card in cardViews)
                {
                    card.SetCardBackgroundColor(Color.White);
                }
                foreach (var txt in text_of_bold)
                {
                    txt.SetTextColor(Color.Black);
                }
                foreach (var txt in text_of_normal)
                {
                    txt.SetTextColor(Color.Rgb(40, 40, 40));
                }
            }


            btn1.Click += Btn1_Click;
            btn2.Click += Btn2_Click;
            btn3.Click += Btn3_Click;
            btn4.Click += Btn4_Click;
            btn5.Click += Btn5_Click;

            download1.Click += Download1_Click;
            download2.Click += Download2_Click;
            download3.Click += Download3_Click;
            download4.Click += Download4_Click;
            download5.Click += Download5_Click;
        }

        private void Download5_Click(object sender, EventArgs e)
        {
            Download("https://ia804602.us.archive.org/17/items/video5_202308/video5.mp4",
            "قسمت پنجم", "آموزش کار با ویژوال استودیو کد");
        }

        private void Download4_Click(object sender, EventArgs e)
        {
            Download("https://ia600508.us.archive.org/6/items/video4_202308/video4.mp4",
            "قسمت چهارم", "آموزش کار با ویژوال استودیو کد");
        }

        private void Download3_Click(object sender, EventArgs e)
        {
            Download("https://ia600508.us.archive.org/16/items/video3_202308/video3.mp4",
            "قسمت سوم", "آموزش کار با ویژوال استودیو کد");
        }

        private void Download2_Click(object sender, EventArgs e)
        {
            Download("https://ia804607.us.archive.org/15/items/video2_202308/video2.mp4",
            "قسمت دوم", "آموزش کار با ویژوال استودیو کد");
        }

        private void Download1_Click(object sender, EventArgs e)
        {
            Download("https://ia802709.us.archive.org/29/items/video1_202308/video1.mp4",
            "قسمت اول", "آموزش کار با ویژوال استودیو کد");
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/dAGnf/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "14:19 دقیقه";
            info_manager.DESCREPTION = "این قسمت پنجم از آموزش کار با ویژوال استودیو کد است!\r\nمن یک برنامه نویس عالی نیستم. من فقط یک برنامه نویس خوب با عادات عالی هستم.\r\n\r\nسخنی از کنت بک، کنت بک خالق برنامه‌سازی مفرط و یکی از 17 بنیان‌گذار توسعه نرم‌افزاری چابک است";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/dAGnf?playlist=7075698";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/nz8wa/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "37:39 دقیقه";
            info_manager.DESCREPTION = "این قسمت چهارم از آموزش کار با ویژوال استودیو کد است!\r\nکدی بنویسید که کار کند، درست و اصولی باشد و سریع اجرا شود.\r\n\r\nسخنی از کنت بک، کنت بک خالق برنامه‌سازی مفرط و یکی از 17 بنیان‌گذار توسعه نرم‌افزاری چابک است";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/nz8wa?playlist=7075698";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/xEZQt/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "25:52 دقیقه";
            info_manager.DESCREPTION = "این قسمت سوم از آموزش کار با برنامه ویژوال استودیو کد است!\r\nبه یاد داشته باشید که هرچقدر بر روی نرم افزاری که کار میکنید مسلط تر باشید برنامه نویسی هم برای شما راحت تر میشود.\r\n";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/xEZQt?playlist=7075698";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/u2MN4/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "25:25 دقیقه";
            info_manager.DESCREPTION = "این ویدیو قسمت دوم از آموزش کار با ویژوال استودیو کد است.\r\nبرای حمایت از ما برنامه Learn to share رو به دوستان خود معرفی نمایید.\r\n";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/u2MN4?playlist=7075698";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/8qChM/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "33:54 دقیقه";
            info_manager.DESCREPTION = "یکی از محبوب‌ترین ویرایشگرهای کد در دنیای برنامه‌نویسان است. تجربه برنامه‌نویسی با ویژوال استودیو کد به قدری آسان، سریع و لذت‌بخش است که دیگر حاضر نیستید با هیچ ویرایشگر دیگری کار کنید؛ فقط کافیست آن را نصب کنید و با آن کدنویسی کنید.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/8qChM?playlist=7075698";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }
        public void Download(string URL, string TITLE, string DESCREPTION)
        {
            DownloadManager.Request request = new DownloadManager.Request(Android.Net.Uri.Parse(URL));
            request.SetTitle(TITLE);
            request.SetDescription(DESCREPTION);
            request.SetNotificationVisibility(DownloadVisibility.VisibleNotifyCompleted);
            request.SetDestinationInExternalPublicDir(Android.OS.Environment.DirectoryDownloads, TITLE);
            DownloadManager manager = (DownloadManager)GetSystemService(DownloadService);
            manager.Enqueue(request);
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