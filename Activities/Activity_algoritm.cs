using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.CardView.Widget;
using Google.Android.Material.Button;
using LearnToShare.Classes;
using System.Collections.Generic;

namespace LearnToShare.Activities
{
    [Activity(Label = "algoritm_list_Activity")]
    public class Activity_algoritm : AppCompatActivity
    {
        AndroidX.AppCompat.Widget.Toolbar toolbar;

        MaterialButton btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11;

        MaterialButton download1, download2, download3, download4, download5, download6,
            download7, download8, download9, download10, download11;
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


            SetContentView(Resource.Layout.activity_algoritm);

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
            btn10 = (MaterialButton)FindViewById(Resource.Id.materialButton10);
            btn11 = (MaterialButton)FindViewById(Resource.Id.materialButton11);

            download1 = (MaterialButton)FindViewById(Resource.Id.downloadbutton1);
            download2 = (MaterialButton)FindViewById(Resource.Id.downloadbutton2);
            download3 = (MaterialButton)FindViewById(Resource.Id.downloadbutton3);
            download4 = (MaterialButton)FindViewById(Resource.Id.downloadbutton4);
            download5 = (MaterialButton)FindViewById(Resource.Id.downloadbutton5);
            download6 = (MaterialButton)FindViewById(Resource.Id.downloadbutton6);
            download7 = (MaterialButton)FindViewById(Resource.Id.downloadbutton7);
            download8 = (MaterialButton)FindViewById(Resource.Id.downloadbutton8);
            download9 = (MaterialButton)FindViewById(Resource.Id.downloadbutton9);
            download10 = (MaterialButton)FindViewById(Resource.Id.downloadbutton10);
            download11 = (MaterialButton)FindViewById(Resource.Id.downloadbutton11);

            SetSupportActionBar(toolbar);

            List<CardView> cardViews = new List<CardView>
            {
                (CardView)FindViewById(Resource.Id.cardView1),
                (CardView)FindViewById(Resource.Id.cardView2),
                (CardView)FindViewById(Resource.Id.cardView3),
                (CardView)FindViewById(Resource.Id.cardView4),
                (CardView)FindViewById(Resource.Id.cardView5),
                (CardView)FindViewById(Resource.Id.cardView6),
                (CardView)FindViewById(Resource.Id.cardView7),
                (CardView)FindViewById(Resource.Id.cardView8),
                (CardView)FindViewById(Resource.Id.cardView9),
                (CardView)FindViewById(Resource.Id.cardView10),
                (CardView)FindViewById(Resource.Id.cardView11)
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
                (TextView)FindViewById(Resource.Id.textView10),
                (TextView)FindViewById(Resource.Id.textView11),
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
                (TextView)FindViewById(Resource.Id.textTitle10),
                (TextView)FindViewById(Resource.Id.textTitle11),
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
                (MaterialButton)FindViewById(Resource.Id.materialButton10),
                (MaterialButton)FindViewById(Resource.Id.materialButton11),

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
                (MaterialButton)FindViewById(Resource.Id.downloadbutton10),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton11),

            };

            foreach (var material in materialButtons)
            {
                material.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Bold);
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
            btn9.Click += Btn9_Click;
            btn10.Click += Btn10_Click;
            btn11.Click += Btn11_Click;

            download1.Click += Download1_Click;
            download2.Click += Download2_Click;
            download3.Click += Download3_Click;
            download4.Click += Download4_Click;
            download5.Click += Download5_Click;
            download6.Click += Download6_Click;
            download7.Click += Download7_Click;
            download8.Click += Download8_Click;
            download9.Click += Download9_Click;
            download10.Click += Download10_Click;
            download11.Click += Download11_Click;
        }

        private void Download11_Click(object sender, System.EventArgs e)
        {
            Download("https://ia800509.us.archive.org/21/items/11_20230815_20230815_1848/11.mp4",
             "قسمت یازدهم", "آموزش الگوریتم و حل مسئله در برنامه نویسی");
        }

        private void Download10_Click(object sender, System.EventArgs e)
        {
            Download("https://ia800506.us.archive.org/2/items/10_20230815_20230815/10.mp4",
             "قسمت دهم", "آموزش الگوریتم و حل مسئله در برنامه نویسی");
        }

        private void Download9_Click(object sender, System.EventArgs e)
        {
            Download("https://ia800508.us.archive.org/0/items/9_20230815_20230815_1816/9.mp4",
             "قسمت نهم", "آموزش الگوریتم و حل مسئله در برنامه نویسی");
        }

        private void Download8_Click(object sender, System.EventArgs e)
        {
            Download("https://ia600509.us.archive.org/11/items/8_20230815_20230815_1804/8.mp4",
             "قسمت هشتم", "آموزش الگوریتم و حل مسئله در برنامه نویسی");
        }

        private void Download7_Click(object sender, System.EventArgs e)
        {
            Download("https://ia800508.us.archive.org/6/items/7_20230815_20230815/7.mp4",
             "قسمت هفتم", "آموزش الگوریتم و حل مسئله در برنامه نویسی");
        }

        private void Download6_Click(object sender, System.EventArgs e)
        {
            Download("https://ia801703.us.archive.org/14/items/6_20230815_20230815_1750/6.mp4",
             "قسمت ششم", "آموزش الگوریتم و حل مسئله در برنامه نویسی");
        }

        private void Download5_Click(object sender, System.EventArgs e)
        {
            Download("https://ia800505.us.archive.org/35/items/5_20230815_20230815_1730/5.mp4",
             "قسمت پنجم", "آموزش الگوریتم و حل مسئله در برنامه نویسی");
        }

        private void Download4_Click(object sender, System.EventArgs e)
        {
            Download("https://ia800508.us.archive.org/6/items/4_20230815_20230815_1725/4.mp4",
             "قسمت چهارم", "آموزش الگوریتم و حل مسئله در برنامه نویسی");
        }

        private void Download3_Click(object sender, System.EventArgs e)
        {
            Download("https://ia902701.us.archive.org/26/items/3_20230815_20230815_1716/3.mp4",
             "قسمت سوم", "آموزش الگوریتم و حل مسئله در برنامه نویسی");
        }

        private void Download2_Click(object sender, System.EventArgs e)
        {
            Download("https://ia600509.us.archive.org/24/items/2_20230815_20230815_1708/2.mp4",
             "قسمت دوم", "آموزش الگوریتم و حل مسئله در برنامه نویسی");
        }

        private void Download1_Click(object sender, System.EventArgs e)
        {
            Download("https://ia600507.us.archive.org/2/items/1_20230815_20230815_1705/1.mp4",
             "قسمت اول", "آموزش الگوریتم و حل مسئله در برنامه نویسی");
        }

        private void Btn11_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/52Fmg/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "27:26 دقیقه";
            info_manager.DESCREPTION = "یاد گیری الگوریتم و حل مسئله مهم ترین چیز در برنامه نویسی است!\r\n\r\nاین هنر عالی معلم برای بیدار کردن شادی در بیان خلاقانه و دانش است.\r\n\r\nآلبرت انیشتین";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/52Fmg?playlist=7080284";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn10_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/szHaE/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "38:53 دقیقه";
            info_manager.DESCREPTION = "یاد گیری الگوریتم و حل مسئله مهم ترین چیز در برنامه نویسی است!\r\n\r\nانسان ها باید اقدام کنند؛ و اگر نتوانند آن را پیدا کنند ، آن را بسازند .\r\n\r\nآلبرت انیشتین";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/szHaE?playlist=7080284";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn9_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/KWvMX/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "23:44 دقیقه";
            info_manager.DESCREPTION = "یاد گیری الگوریتم و حل مسئله مهم ترین چیز در برنامه نویسی است!\r\n\r\nهنگامی که محدودیت های خود را می پذیریم، فراتر از آن ها می رویم.\r\n\r\nآلبرت انیشتین";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/KWvMX?playlist=7080284";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn8_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/7CKvJ/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "17:59 دقیقه";
            info_manager.DESCREPTION = "یاد گیری الگوریتم و حل مسئله مهم ترین چیز در برنامه نویسی است!\r\n\r\nاز دیروز یاد بگیرید، برای امروز زندگی کنید، به فردا امیدوار باشید . نکته مهم این است که سوال پرسیدن را کنار نگذارید.\r\n\r\nآلبرت انیشتین";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/7CKvJ?playlist=7080284";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn7_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/lwFKG/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "31:10 دقیقه";
            info_manager.DESCREPTION = "یاد گیری الگوریتم و حل مسئله مهم ترین چیز در برنامه نویسی است!\r\n\r\nما نمی توانیم مشکلات را با همان تفکری که مشکل را ایجاد کردیم حل کنیم.\r\n\r\nآلبرت انیشتین";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/lwFKG?playlist=7080284";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn6_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/N3jK4/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "26:59 دقیقه";
            info_manager.DESCREPTION = "یاد گیری الگوریتم و حل مسئله مهم ترین چیز در برنامه نویسی است!\r\n\r\nارزش یک فرد باید در آنچه که به او می دهید باشد نه در آنچه که او می تواند دریافت کند.\r\n\r\nآلبرت انیشتین";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/N3jK4?playlist=7080284";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn5_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/ubt28/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "20:18 دقیقه";
            info_manager.DESCREPTION = "یاد گیری الگوریتم و حل مسئله مهم ترین چیز در برنامه نویسی است!\r\n\r\nسعی نکن که مرد موفقی شوی، بلکه تلاش کنید فرد با ارزشی شوید.\r\n\r\nآلبرت انیشتین";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/ubt28?playlist=7080284";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn4_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/vxlPt/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "22:19 دقیقه";
            info_manager.DESCREPTION = "یاد گیری الگوریتم و حل مسئله مهم ترین چیز در برنامه نویسی است!\r\n\r\nزمانی فرا می رسد که ذهن سطح بالاتری از دانش را به خود اختصاص می دهد اما هرگز نمی تواند ثابت کند که چگونه آن را دریافت می کند.\r\n\r\nآلبرت انیشتین";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/vxlPt?playlist=7080284";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn3_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/Y1DJF/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "26:22 دقیقه";
            info_manager.DESCREPTION = "یاد گیری الگوریتم و حل مسئله مهم ترین چیز در برنامه نویسی است!\r\n\r\nدو راه برای زندگی وجود دارد:می توانید زندگی کنید گویی هیچ چیز معجزه نیست؛ می توانید طوری زندگی کنید که همه چیز یک معجزه است .\r\n\r\nآلبرت انیشتین";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/Y1DJF?playlist=7080284";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn2_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/Ndc9b/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "23:22 دقیقه";
            info_manager.DESCREPTION = "یاد گیری الگوریتم و حل مسئله مهم ترین چیز در برنامه نویسی است!\r\n\r\nتحصیلات چیزی است که پس از فراموش کردن آنچه در مدرسه آموخته اید، باقی می ماند.\r\n\r\nآلبرت انیشتین";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/Ndc9b?playlist=7080284";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn1_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/dqIcW/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "25:00 دقیقه";
            info_manager.DESCREPTION = "یاد گیری الگوریتم و حل مسئله مهم ترین چیز در برنامه نویسی است!\r\n\r\nهر فردی که بسیار کتاب می خواند و از مغز خود استفاده می کند خیلی کم به عادات تنبلی فکر می کند.\r\n\r\nآلبرت انیشتین";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/dqIcW?playlist=7080284";

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