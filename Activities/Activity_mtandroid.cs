using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.Button;
using LearnToShare.Classes;
using System;
using System.Collections.Generic;

namespace LearnToShare.Activities
{
    [Activity(Label = "materialdesign_list_Activity")]
    public class Activity_mtandroid : AppCompatActivity
    {

        AndroidX.AppCompat.Widget.Toolbar toolbar;
        MaterialButton btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8;

        MaterialButton download1, download2, download3, download4, download5, download6,
            download7, download8;

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


            SetContentView(Resource.Layout.activity_mt);


            toolbar = (AndroidX.AppCompat.Widget.Toolbar)FindViewById(Resource.Id.toolbar1);


            btn1 = (MaterialButton)FindViewById(Resource.Id.materialButton1);
            btn2 = (MaterialButton)FindViewById(Resource.Id.materialButton2);
            btn3 = (MaterialButton)FindViewById(Resource.Id.materialButton3);
            btn4 = (MaterialButton)FindViewById(Resource.Id.materialButton4);
            btn5 = (MaterialButton)FindViewById(Resource.Id.materialButton5);
            btn6 = (MaterialButton)FindViewById(Resource.Id.materialButton6);
            btn7 = (MaterialButton)FindViewById(Resource.Id.materialButton7);
            btn8 = (MaterialButton)FindViewById(Resource.Id.materialButton8);

            download1 = (MaterialButton)FindViewById(Resource.Id.downloadbutton1);
            download2 = (MaterialButton)FindViewById(Resource.Id.downloadbutton2);
            download3 = (MaterialButton)FindViewById(Resource.Id.downloadbutton3);
            download4 = (MaterialButton)FindViewById(Resource.Id.downloadbutton4);
            download5 = (MaterialButton)FindViewById(Resource.Id.downloadbutton5);
            download6 = (MaterialButton)FindViewById(Resource.Id.downloadbutton6);
            download7 = (MaterialButton)FindViewById(Resource.Id.downloadbutton7);
            download8 = (MaterialButton)FindViewById(Resource.Id.downloadbutton8);

            SetSupportActionBar(toolbar);

            List<AndroidX.CardView.Widget.CardView> cardViews = new List<AndroidX.CardView.Widget.CardView>
            {
                (AndroidX.CardView.Widget.CardView)FindViewById(Resource.Id.cardView1),
                (AndroidX.CardView.Widget.CardView)FindViewById(Resource.Id.cardView2),
                (AndroidX.CardView.Widget.CardView)FindViewById(Resource.Id.cardView3),
                (AndroidX.CardView.Widget.CardView)FindViewById(Resource.Id.cardView4),
                (AndroidX.CardView.Widget.CardView)FindViewById(Resource.Id.cardView5),
                (AndroidX.CardView.Widget.CardView)FindViewById(Resource.Id.cardView6),
                (AndroidX.CardView.Widget.CardView)FindViewById(Resource.Id.cardView7),
                (AndroidX.CardView.Widget.CardView)FindViewById(Resource.Id.cardView8)
            };

            List<TextView> textViews = new List<TextView>()
            {
                (TextView)FindViewById(Resource.Id.textView1),
                (TextView)FindViewById(Resource.Id.textView2),
                (TextView)FindViewById(Resource.Id.textView3),
                (TextView)FindViewById(Resource.Id.textView4),
                (TextView)FindViewById(Resource.Id.textView5),
                (TextView)FindViewById(Resource.Id.textView6),
                (TextView)FindViewById(Resource.Id.textView7),
                (TextView)FindViewById(Resource.Id.textView8)
            };

            foreach (var i in textViews)
            {
                i.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Bold);
            }

            List<TextView> textsNormal = new List<TextView>()
            {
                (TextView)FindViewById(Resource.Id.textTitle1),
                (TextView)FindViewById(Resource.Id.textTitle2),
                (TextView)FindViewById(Resource.Id.textTitle3),
                (TextView)FindViewById(Resource.Id.textTitle4),
                (TextView)FindViewById(Resource.Id.textTitle5),
                (TextView)FindViewById(Resource.Id.textTitle6),
                (TextView)FindViewById(Resource.Id.textTitle7),
                (TextView)FindViewById(Resource.Id.textTitle8)
            };

            foreach (var b in textsNormal)
            {
                b.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Normal);
            }

            List<MaterialButton> materialButtons = new List<MaterialButton>
            {
                (MaterialButton)FindViewById(Resource.Id.materialButton1),
                (MaterialButton)FindViewById(Resource.Id.materialButton2),
                (MaterialButton)FindViewById(Resource.Id.materialButton3),
                (MaterialButton)FindViewById(Resource.Id.materialButton4),
                (MaterialButton)FindViewById(Resource.Id.materialButton5),
                (MaterialButton)FindViewById(Resource.Id.materialButton6),
                (MaterialButton)FindViewById(Resource.Id.materialButton7),
                (MaterialButton)FindViewById(Resource.Id.materialButton8),

                ////////////////////////////////////////////////////////////////////////////////////////
                
                (MaterialButton)FindViewById(Resource.Id.downloadbutton1),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton2),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton3),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton4),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton5),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton6),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton7),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton8)
            };

            foreach (var material in materialButtons)
            {
                material.SetTypeface(Activity_main.IranSansFont, Android.Graphics.TypefaceStyle.Bold);
            }

            if (themes.ColorNumber == 0 || themes.ColorNumber == 1 || themes.ColorNumber == 4) // 0 ==  "حالت شب "
            {
                foreach (var card in cardViews)
                {
                    card.SetCardBackgroundColor(Color.Rgb(30, 30, 30));
                }
                toolbar.SetBackgroundResource(Resource.Drawable.toolbar_back_dark);
                toolbar.SetTitleTextColor(Color.White);
                foreach (var txt in textViews)
                {
                    txt.SetTextColor(Color.White);
                }
                foreach (var txt in textsNormal)
                {
                    txt.SetTextColor(Color.Rgb(240, 240, 240));
                }
            }
            else if (themes.ColorNumber == 2 || themes.ColorNumber == 3 || themes.ColorNumber == 5)  // 2 ==    "حالت روز با رنگ بنفش"
            {
                toolbar.SetBackgroundResource(Resource.Drawable.toolbar_back);
                toolbar.SetTitleTextColor(Color.Black);
                foreach (var card in cardViews)
                {
                    card.SetCardBackgroundColor(Color.White);
                }
                foreach (var txt in textViews)
                {
                    txt.SetTextColor(Color.Black);
                }
                foreach (var txt in textsNormal)
                {
                    txt.SetTextColor(Color.Rgb(40, 40, 40));
                }
            }


            btn1.Click += Btn1_Click;
            btn2.Click += Btn2_Click;
            btn3.Click += Btn3_Click;
            btn4.Click += Btn4_Click;
            btn5.Click += Btn5_Click;
            btn6.Click += Btn6_Click;
            btn7.Click += Btn7_Click;
            btn8.Click += Btn8_Click;

            download1.Click += Download1_Click;
            download2.Click += Download2_Click;
            download3.Click += Download3_Click;
            download4.Click += Download4_Click;
            download5.Click += Download5_Click;
            download6.Click += Download6_Click;
            download7.Click += Download7_Click;
            download8.Click += Download8_Click;
        }

        private void Download8_Click(object sender, EventArgs e)
        {
            Download("https://ia902602.us.archive.org/26/items/8_20230603/8.mp4",
              "قسمت هشتم", "آموزش متریال دیزاین");
        }

        private void Download7_Click(object sender, EventArgs e)
        {
            Download("https://ia902603.us.archive.org/12/items/7_20230603_20230603_1311/7.mp4",
              "قسمت هفتم", "آموزش متریال دیزاین");
        }

        private void Download6_Click(object sender, EventArgs e)
        {
            Download("https://ia802702.us.archive.org/10/items/6_20230603_202306/6.mp4",
              "قسمت ششم", "آموزش متریال دیزاین");
        }

        private void Download5_Click(object sender, EventArgs e)
        {
            Download("https://ia902609.us.archive.org/19/items/5_20230602_202306/5.mp4",
              "قسمت پنجم", "آموزش متریال دیزاین");
        }

        private void Download4_Click(object sender, EventArgs e)
        {
            Download("https://ia902606.us.archive.org/10/items/4_20230602_20230602_1212/4.mp4",
              "قسمت چهارم", "آموزش متریال دیزاین");
        }

        private void Download3_Click(object sender, EventArgs e)
        {
            Download("https://ia802601.us.archive.org/18/items/3_20230530_20230530_1914/3.mp4",
              "قسمت سوم", "آموزش متریال دیزاین");
        }

        private void Download2_Click(object sender, EventArgs e)
        {
            Download("https://ia802606.us.archive.org/13/items/2_20230530_20230530_1036/2.mp4",
              "قسمت دوم", "آموزش متریال دیزاین");
        }

        private void Download1_Click(object sender, EventArgs e)
        {
            Download("https://ia802602.us.archive.org/3/items/1_20230530_20230530/1.mp4",
              "قسمت اول", "آموزش متریال دیزاین");
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/KQDLw/vt/frame";
            info_manager.TEACHER_NAME = "رضا عمرانیان";
            info_manager.TIME_OF_VIDEO = "27:13 دقیقه";
            info_manager.DESCREPTION = "آموزش طراحی اپلیکیشن های اندرویدی، متریال دیزاین در اندروید قسمت هشتم.\r\n\r\nبرنامه نویسی یک هنر است، زیرا دانش انباشته شده را در جهان به کار می‌گیرد، زیرا به مهارت و نبوغ نیاز دارد و به ویژه به این دلیل که چیزهای زیبایی تولید می‌کند. برنامه نویسی که ناخودآگاه خود را یک هنرمند می‌بیند از کاری که انجام می‌دهد لذت می‌برد و آن را بهتر انجام خواهد داد.\r\n\r\nکنوث دانشمند علوم کامپیوتر است. شهرت او بخاطر مجموعه کتاب‌های هنر رایانه است که یکی از گران‌بهاترین مراجع در زمینه علوم کامپیوتر است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/KQDLw?playlist=6145217";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/vex4G/vt/frame";
            info_manager.TEACHER_NAME = "ابولفضل رادمنش";
            info_manager.TIME_OF_VIDEO = "32:49 دقیقه";
            info_manager.DESCREPTION = "آموزش طراحی اپلیکیشن های اندرویدی، متریال دیزاین در اندروید قسمت هفتم.\r\n\r\nمهمترین چیز در زبان برنامه نویسی نام آن زبان است. زبان بدون نام خوب موفق نخواهد شد.\r\n\r\nکنوث دانشمند علوم کامپیوتر است. شهرت او بخاطر مجموعه کتاب‌های هنر رایانه است که یکی از گران‌بهاترین مراجع در زمینه علوم کامپیوتر است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/vex4G?playlist=6145217";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/m8SrE/vt/frame";
            info_manager.TEACHER_NAME = "رضا عمرانیان";
            info_manager.TIME_OF_VIDEO = "33:07 دقیقه";
            info_manager.DESCREPTION = "آموزش طراحی اپلیکیشن های اندرویدی، متریال دیزاین در اندروید قسمت ششم.\r\n\r\nچه بخواهید اسرار کیهان را کشف کنید، چه بخواهید شغلی را در قرن بیست و یکم دنبال کنید، اصول پایه‌ای برنامه نویسی کامپیوتر یک مهارت ضروری برای یادگیری است.\r\n\r\nویلیام هاوکینگ، برنامه نویس نیست. او فیزیک‌دان نظری، کیهان‌شناس و نویسنده است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/m8SrE?playlist=6145217";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/LIOKh/vt/frame";
            info_manager.TEACHER_NAME = "ابولفضل رادمنش";
            info_manager.TIME_OF_VIDEO = "56:13 دقیقه";
            info_manager.DESCREPTION = "آموزش طراحی اپلیکیشن های اندرویدی، متریال دیزاین در اندروید قسمت پنجم.\r\n\r\nنرم‌افزار مانند رابطه جنسی است: وقتی رایگان باشد بهتر است.\r\n\r\nلینوس توروالدز یک مهندس نرم‌افزار است. او خالق هسته لینوکس و همچنین نرم‌افزار ورژن کنترل گیت است. ";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/LIOKh?playlist=6145217";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/oifEM/vt/frame";
            info_manager.TEACHER_NAME = "رضا عمرانیان";
            info_manager.TIME_OF_VIDEO = "37:27 دقیقه";
            info_manager.DESCREPTION = "آموزش طراحی اپلیکیشن های اندرویدی، متریال دیزاین در اندروید قسمت چهارم.\r\n\r\nصحبت کردن بی‌ارزش است؛ کدت را به من نشان بده.\r\n\r\nلینوس توروالدز یک مهندس نرم‌افزار است. او خالق هسته لینوکس و همچنین نرم‌افزار ورژن کنترل گیت است. ";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/oifEM?playlist=6145217";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/eic9A/vt/frame";
            info_manager.TEACHER_NAME = "رضا عمرانیان";
            info_manager.TIME_OF_VIDEO = "26:07 دقیقه";
            info_manager.DESCREPTION = "آموزش طراحی اپلیکیشن های اندرویدی، متریال دیزاین در اندروید قسمت سوم.\r\n\r\nاکثر برنامه نویسان خوب، برنامه نویسی می‌کنند؛ نه این دلیل که انتظار دارند دستمزد دریافت کنند یا توسط دیگران تحسین شوند، بلکه به این دلیل که برنامه نویسی سرگرم کننده است.\r\n\r\nلینوس توروالدز یک مهندس نرم‌افزار است. او خالق هسته لینوکس و همچنین نرم‌افزار ورژن کنترل گیت است. ";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/eic9A?playlist=6145217";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/gjtSr/vt/frame";
            info_manager.TEACHER_NAME = "رضا عمرانیان";
            info_manager.TIME_OF_VIDEO = "30:27 دقیقه";
            info_manager.DESCREPTION = "آموزش طراحی اپلیکیشن های اندرویدی، متریال دیزاین در اندروید قسمت دوم. \r\n\r\nهمه باید برنامه نویسی کامپیوتر را یاد بگیرند، زیرا که برنامه نویسی به شما یاد می‌دهد که چگونه فکر کنید.\r\n\r\nاستیو جابز، سازنده سیستم عامل مک او اس (اپل) ، در گزشت در 2012\r\n";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/gjtSr?playlist=6145217";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/qENH7/vt/frame";
            info_manager.TEACHER_NAME = "ابولفضل راد منش";
            info_manager.TIME_OF_VIDEO = "36:49 دقیقه";
            info_manager.DESCREPTION = "آموزش طراحی اپلیکیشن های اندرویدی، متریال دیزاین در اندروید قسمت اول . \r\n\r\nپانزده سال دیگر برنامه نویسی را درست مانند خواندن و نوشتن آموزش خواهیم داد و افسوس می‌خوریم که چرا زودتر این کار را انجام ندادیم.\r\n\r\nمارک زاکربرگ موسس کمپانی متا است که قبلا با نام فیس‌بوک شناخته می‌شد.\r\n";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/qENH7?playlist=6145217";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
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
    }
}