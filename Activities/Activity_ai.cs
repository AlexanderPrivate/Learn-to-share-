using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.Button;
using LearnToShare.Classes;
using System.Collections.Generic;

namespace LearnToShare.Activities
{
    [Activity(Label = "Ai_1_Activity")]
    public class Activity_ai : AppCompatActivity
    {
        AndroidX.AppCompat.Widget.Toolbar toolbar;

        MaterialButton btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9;

        MaterialButton download1, download2, download3, download4, download5, download6,
            download7, download8, download9;

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


            SetContentView(Resource.Layout.activity_ai);

            toolbar = (AndroidX.AppCompat.Widget.Toolbar)FindViewById(Resource.Id.toolbar1);

            btn1 = (MaterialButton)FindViewById(Resource.Id.materialButton1);
            btn2 = (MaterialButton)FindViewById(Resource.Id.materialButton2);
            btn3 = (MaterialButton)FindViewById(Resource.Id.materialButton3);
            btn4 = (MaterialButton)FindViewById(Resource.Id.materialButton4);
            btn5 = (MaterialButton)FindViewById(Resource.Id.materialButton5);
            btn6 = (MaterialButton)FindViewById(Resource.Id.materialButton6);
            btn7 = (MaterialButton)FindViewById(Resource.Id.materialButton7);
            btn8 = (MaterialButton)FindViewById(Resource.Id.materialButton8);
            btn9 = (MaterialButton)FindViewById(Resource.Id.materialButton9);


            download1 = (MaterialButton)FindViewById(Resource.Id.downloadbutton1);
            download2 = (MaterialButton)FindViewById(Resource.Id.downloadbutton2);
            download3 = (MaterialButton)FindViewById(Resource.Id.downloadbutton3);
            download4 = (MaterialButton)FindViewById(Resource.Id.downloadbutton4);
            download5 = (MaterialButton)FindViewById(Resource.Id.downloadbutton5);
            download6 = (MaterialButton)FindViewById(Resource.Id.downloadbutton6);
            download7 = (MaterialButton)FindViewById(Resource.Id.downloadbutton7);
            download8 = (MaterialButton)FindViewById(Resource.Id.downloadbutton8);
            download9 = (MaterialButton)FindViewById(Resource.Id.downloadbutton9);


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
                (AndroidX.CardView.Widget.CardView)FindViewById(Resource.Id.cardView8),
                (AndroidX.CardView.Widget.CardView)FindViewById(Resource.Id.cardView9),
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
                (TextView)FindViewById(Resource.Id.textView8),
                (TextView)FindViewById(Resource.Id.textView9),
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
                (TextView)FindViewById(Resource.Id.textTitle8),
                (TextView)FindViewById(Resource.Id.textTitle9),
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
                (MaterialButton)FindViewById(Resource.Id.materialButton9),

                //////////////////////////////////////////////////////////////////////////////////////////////
                
                (MaterialButton)FindViewById(Resource.Id.downloadbutton1),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton2),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton3),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton4),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton5),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton6),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton7),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton8),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton9),

            };

            foreach (var material in materialButtons)
            {
                material.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Bold);
            }


            if (themes.ColorNumber == 0 || themes.ColorNumber == 1 || themes.ColorNumber == 4) // 0 ==  "حالت شب"
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
            else if (themes.ColorNumber == 2 || themes.ColorNumber == 3 || themes.ColorNumber == 5)  // 2 ==    "حالت روز "
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
                    txt.SetTextColor(Color.Rgb(70, 70, 70));
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
            btn9.Click += Btn9_Click;

            download1.Click += Download1_Click;
            download2.Click += Download2_Click;
            download3.Click += Download3_Click;
            download4.Click += Download4_Click;
            download5.Click += Download5_Click;
            download6.Click += Download6_Click;
            download7.Click += Download7_Click;
            download8.Click += Download8_Click;
            download9.Click += Download9_Click;
        }

        private void Download9_Click(object sender, System.EventArgs e)
        {
            Download("https://ia800504.us.archive.org/21/items/9_20230909/9.mp4",
             "قسمت نهم", "آموزش هوش مصنوعی دانش پیشرو");
        }

        private void Download8_Click(object sender, System.EventArgs e)
        {
            Download("https://ia800505.us.archive.org/18/items/8_20230909/8.mp4",
             "قسمت هشتم", "آموزش هوش مصنوعی دانش پیشرو");
        }

        private void Download7_Click(object sender, System.EventArgs e)
        {
            Download("https://ia600501.us.archive.org/18/items/7_20230909/7.mp4",
             "قسمت هفتم", "آموزش هوش مصنوعی دانش پیشرو");
        }

        private void Download6_Click(object sender, System.EventArgs e)
        {
            Download("https://ia800508.us.archive.org/21/items/6_20230909/6.mp4",
             "قسمت ششم", "آموزش هوش مصنوعی دانش پیشرو");
        }

        private void Download5_Click(object sender, System.EventArgs e)
        {
            Download("https://ia800508.us.archive.org/14/items/5_20230908_202309/5.mp4",
             "قسمت پنجم", "آموزش هوش مصنوعی دانش پیشرو");
        }

        private void Download4_Click(object sender, System.EventArgs e)
        {
            Download("https://ia800501.us.archive.org/14/items/4_20230908_20230908_2327/4.mp4",
             "قسمت چهارم", "آموزش هوش مصنوعی دانش پیشرو");
        }

        private void Download3_Click(object sender, System.EventArgs e)
        {
            Download("https://ia600501.us.archive.org/20/items/3_20230908_20230908_2321/3.mp4",
             "قسمت سوم", "آموزش هوش مصنوعی دانش پیشرو");
        }

        private void Download2_Click(object sender, System.EventArgs e)
        {
            Download("https://ia600505.us.archive.org/30/items/2_20230908_20230908_2215/2.mp4",
             "قسمت دوم", "آموزش هوش مصنوعی دانش پیشرو");
        }

        private void Download1_Click(object sender, System.EventArgs e)
        {
            Download("https://ia800504.us.archive.org/3/items/1_20230908_20230908_2209/1.mp4",
            "قسمت اول", "آموزش هوش مصنوعی دانش پیشرو");
        }

        private void Btn9_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/Kz6w8/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "27:24 دقیقه";
            info_manager.DESCREPTION = "این نهمین قسمت از آموزش هوش مصنوعی است.\r\n\r\nآن کس که جرات انجام کارهای شایسته را دارد، انسان است.\r\n\r\nویلیام شکسپیر";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/Kz6w8";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn8_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/8Xe4I/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "25:13 دقیقه";
            info_manager.DESCREPTION = "این هشتمین قسمت از آموزش هوش مصنوعی است.\r\n\r\nباید در هر کاری به امکان و عملی بودن آن کار ایمان داشت.\r\n\r\nآندره موروا";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/8Xe4I";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn7_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/YlJQb/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "42:34 دقیقه";
            info_manager.DESCREPTION = "این هفتمین قسمت از آموزش هوش مصنوعی است.\r\n\r\nازدواج مثل شهر محاصره شده است. کسانی که داخل شهرند سعی می کنند از آن خارج و آنها که خارج [ آن ] هستند، تلاش می کنند تا به آن داخل شوند.\r\n\r\nبنجامین فرانکلین";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/YlJQb";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn6_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/terfP/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "36:49 دقیقه";
            info_manager.DESCREPTION = "این ششمین قسمت از آموزش هوش مصنوعی است.\r\n\r\nخردمند به کار خویش تکیه کند و نادان به آرزوهای خویش.\r\n\r\nامام علی (ع)";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/terfP";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn5_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/dgky1/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "32:20 دقیقه";
            info_manager.DESCREPTION = "این پنجمین قسمت از آموزش هوش مصنوعی است.\r\n\r\nهر عمل دسته جمعی وقتی درست رهبری نگردد دچار آشفتگی و بی نظمی می شود.\r\n\r\nآندره موروا";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/dgky1";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn4_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/wsXu5/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "39:08 دقیقه";
            info_manager.DESCREPTION = "این چهارمین قسمت از آموزش هوش مصنوعی است.\r\n\r\nمن به هیچ وجه اجازه نمی دهم که شرایط مرا ناامید کند. سه چیز لازم برای رسیدن به یک هدف با ارزش عبارت است از : کار ، استقامت و عقل سلیم.\r\n\r\nتوماس ادیسون";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/wsXu5";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn3_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/Fy1Rl/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "32:09 دقیقه";
            info_manager.DESCREPTION = "این سومین قسمت از آموزش هوش مصنوعی است.\r\n\r\nکسی که دیگری را دوست دارد و به راستی به او عشق می ورزد، هر روز تلاش می کند یک کشیش دهکده ای باشد که دوست دارد همه شب خیابان های تنگ و پرپیچ و خم خود را طی کند و در محیط اندیشه و هوش و استعداد محبوب خود گردش نماید.\r\n\r\nآندره موروا";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/Fy1Rl";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn2_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/0ZNU3/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "19:43 دقیقه";
            info_manager.DESCREPTION = "این دومین قسمت از آموزش هوش مصنوعی است.\r\n\r\nبرای مرد عمل، اندیشه با عمل درهم است، همان گونه که برای یک شاعر، اندیشه با تصویر و نشانه های درهم و مربوط می باشد.\r\n\r\nآندره موروا";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/0ZNU3?playlist=7321785";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn1_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/FS3o1/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "33:17 دقیقه";
            info_manager.DESCREPTION = "این اولین قسمت از آموزش هوش مصنوعی است.\r\n\r\nمن بر این باورم که کارهای ساده و پیش پا افتاده هم بسیار نیرومند و کارآمد هستند.\r\n\r\nآنتونی رابینز";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/FS3o1?playlist=7321785";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        public void Download(string URL, string TITLE, string DESCREPTION)
        {
            DownloadManager.Request request = new DownloadManager.Request(Android.Net.Uri.Parse(URL));
            request.SetTitle(TITLE);
            request.SetDescription(DESCREPTION);
            request.SetNotificationVisibility(DownloadVisibility.VisibleNotifyCompleted);
            request.SetDestinationInExternalPublicDir(Environment.DirectoryDownloads, TITLE);
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