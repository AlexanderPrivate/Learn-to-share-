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
using System;
using System.Collections.Generic;

namespace LearnToShare.Activities
{
    [Activity(Label = "windowsform_list_Activity")]
    public class Activity_winform : AppCompatActivity
    {
        AndroidX.AppCompat.Widget.Toolbar toolbar;

        MaterialButton btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11,
            btn12, btn13, btn14, btn15, btn16, btn17, btn18, btn19, btn20, btn21, btn22, btn23, btn24, btn25;

        MaterialButton download1, download2, download3, download4, download5, download6,
            download7, download8, download9, download10, download11, download12, download13,
            download14, download15, download16, download17, download18, download19, download20,
            download21, download22, download23, download24, download25;
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

            SetContentView(Resource.Layout.activity_winform);

            toolbar = (AndroidX.AppCompat.Widget.Toolbar)FindViewById(Resource.Id.toolbar1);

            SetSupportActionBar(toolbar);


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
            btn12 = (MaterialButton)FindViewById(Resource.Id.materialButton12);
            btn13 = (MaterialButton)FindViewById(Resource.Id.materialButton13);
            btn14 = (MaterialButton)FindViewById(Resource.Id.materialButton14);
            btn15 = (MaterialButton)FindViewById(Resource.Id.materialButton15);
            btn16 = (MaterialButton)FindViewById(Resource.Id.materialButton16);
            btn17 = (MaterialButton)FindViewById(Resource.Id.materialButton17);
            btn18 = (MaterialButton)FindViewById(Resource.Id.materialButton18);
            btn19 = (MaterialButton)FindViewById(Resource.Id.materialButton19);
            btn20 = (MaterialButton)FindViewById(Resource.Id.materialButton20);
            btn21 = (MaterialButton)FindViewById(Resource.Id.materialButton21);
            btn22 = (MaterialButton)FindViewById(Resource.Id.materialButton22);
            btn23 = (MaterialButton)FindViewById(Resource.Id.materialButton23);
            btn24 = (MaterialButton)FindViewById(Resource.Id.materialButton24);
            btn25 = (MaterialButton)FindViewById(Resource.Id.materialButton25);

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
            download12 = (MaterialButton)FindViewById(Resource.Id.downloadbutton12);
            download13 = (MaterialButton)FindViewById(Resource.Id.downloadbutton13);
            download14 = (MaterialButton)FindViewById(Resource.Id.downloadbutton14);
            download15 = (MaterialButton)FindViewById(Resource.Id.downloadbutton15);
            download16 = (MaterialButton)FindViewById(Resource.Id.downloadbutton16);
            download17 = (MaterialButton)FindViewById(Resource.Id.downloadbutton17);
            download18 = (MaterialButton)FindViewById(Resource.Id.downloadbutton18);
            download19 = (MaterialButton)FindViewById(Resource.Id.downloadbutton19);
            download20 = (MaterialButton)FindViewById(Resource.Id.downloadbutton20);
            download21 = (MaterialButton)FindViewById(Resource.Id.downloadbutton21);
            download22 = (MaterialButton)FindViewById(Resource.Id.downloadbutton22);
            download23 = (MaterialButton)FindViewById(Resource.Id.downloadbutton23);
            download24 = (MaterialButton)FindViewById(Resource.Id.downloadbutton24);
            download25 = (MaterialButton)FindViewById(Resource.Id.downloadbutton25);


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
                (CardView)FindViewById(Resource.Id.cardView11),
                (CardView)FindViewById(Resource.Id.cardView12),
                (CardView)FindViewById(Resource.Id.cardView13),
                (CardView)FindViewById(Resource.Id.cardView14),
                (CardView)FindViewById(Resource.Id.cardView15),
                (CardView)FindViewById(Resource.Id.cardView16),
                (CardView)FindViewById(Resource.Id.cardView17),
                (CardView)FindViewById(Resource.Id.cardView18),
                (CardView)FindViewById(Resource.Id.cardView19),
                (CardView)FindViewById(Resource.Id.cardView20),
                (CardView)FindViewById(Resource.Id.cardView21),
                (CardView)FindViewById(Resource.Id.cardView22),
                (CardView)FindViewById(Resource.Id.cardView23),
                (CardView)FindViewById(Resource.Id.cardView24),
                (CardView)FindViewById(Resource.Id.cardView25),
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
                (TextView)FindViewById(Resource.Id.textView12),
                (TextView)FindViewById(Resource.Id.textView13),
                (TextView)FindViewById(Resource.Id.textView14),
                (TextView)FindViewById(Resource.Id.textView15),
                (TextView)FindViewById(Resource.Id.textView16),
                (TextView)FindViewById(Resource.Id.textView17),
                (TextView)FindViewById(Resource.Id.textView18),
                (TextView)FindViewById(Resource.Id.textView19),
                (TextView)FindViewById(Resource.Id.textView20),
                (TextView)FindViewById(Resource.Id.textView21),
                (TextView)FindViewById(Resource.Id.textView22),
                (TextView)FindViewById(Resource.Id.textView23),
                (TextView)FindViewById(Resource.Id.textView24),
                (TextView)FindViewById(Resource.Id.textView25)
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
                (TextView)FindViewById(Resource.Id.textTitle12),
                (TextView)FindViewById(Resource.Id.textTitle13),
                (TextView)FindViewById(Resource.Id.textTitle14),
                (TextView)FindViewById(Resource.Id.textTitle15),
                (TextView)FindViewById(Resource.Id.textTitle16),
                (TextView)FindViewById(Resource.Id.textTitle17),
                (TextView)FindViewById(Resource.Id.textTitle18),
                (TextView)FindViewById(Resource.Id.textTitle19),
                (TextView)FindViewById(Resource.Id.textTitle20),
                (TextView)FindViewById(Resource.Id.textTitle21),
                (TextView)FindViewById(Resource.Id.textTitle22),
                (TextView)FindViewById(Resource.Id.textTitle23),
                (TextView)FindViewById(Resource.Id.textTitle24),
                (TextView)FindViewById(Resource.Id.textTitle25)
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
                (MaterialButton)FindViewById(Resource.Id.materialButton12),
                (MaterialButton)FindViewById(Resource.Id.materialButton13),
                (MaterialButton)FindViewById(Resource.Id.materialButton14),
                (MaterialButton)FindViewById(Resource.Id.materialButton15),
                (MaterialButton)FindViewById(Resource.Id.materialButton16),
                (MaterialButton)FindViewById(Resource.Id.materialButton17),
                (MaterialButton)FindViewById(Resource.Id.materialButton18),
                (MaterialButton)FindViewById(Resource.Id.materialButton19),
                (MaterialButton)FindViewById(Resource.Id.materialButton20),
                (MaterialButton)FindViewById(Resource.Id.materialButton21),
                (MaterialButton)FindViewById(Resource.Id.materialButton22),
                (MaterialButton)FindViewById(Resource.Id.materialButton23),
                (MaterialButton)FindViewById(Resource.Id.materialButton24),
                (MaterialButton)FindViewById(Resource.Id.materialButton25),

                ///////////////////////////////////////////////////////////////
                
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
                (MaterialButton)FindViewById(Resource.Id.downloadbutton12),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton13),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton14),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton15),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton16),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton17),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton18),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton19),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton20),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton21),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton22),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton23),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton24),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton25)
            };

            foreach (var material in materialButtons)
            {
                material.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Bold);
            }

            if (themes.ColorNumber == 0 || themes.ColorNumber == 1 || themes.ColorNumber == 4) // ==  "حالت شب "
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
            else if (themes.ColorNumber == 2 || themes.ColorNumber == 3 || themes.ColorNumber == 5)  // ==  "حالت روز "
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
            btn12.Click += Btn12_Click;
            btn13.Click += Btn13_Click;
            btn14.Click += Btn14_Click;
            btn15.Click += Btn15_Click;
            btn16.Click += Btn16_Click;
            btn17.Click += Btn17_Click;
            btn18.Click += Btn18_Click;
            btn19.Click += Btn19_Click;
            btn20.Click += Btn20_Click;
            btn21.Click += Btn21_Click;
            btn22.Click += Btn22_Click;
            btn23.Click += Btn23_Click;
            btn24.Click += Btn24_Click;
            btn25.Click += Btn25_Click;

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
            download12.Click += Download12_Click;
            download13.Click += Download13_Click;
            download14.Click += Download14_Click;
            download15.Click += Download15_Click;
            download16.Click += Download16_Click;
            download17.Click += Download17_Click;
            download18.Click += Download18_Click;
            download19.Click += Download19_Click;
            download20.Click += Download20_Click;
            download21.Click += Download21_Click;
            download22.Click += Download22_Click;
            download23.Click += Download23_Click;
            download24.Click += Download24_Click;
            download25.Click += Download25_Click;


        }

        private void Download25_Click(object sender, EventArgs e)
        {
            Download("https://ia800507.us.archive.org/14/items/25_20230821_20230821/25.mp4",
             "قسمت بیستو پنجم", "آموزش ویندوز فرم");
        }

        private void Download24_Click(object sender, EventArgs e)
        {
            Download("https://ia600505.us.archive.org/12/items/24_20230821_20230821/24.mp4",
             "قسمت بیستو چهارم", "آموزش ویندوز فرم");
        }

        private void Download23_Click(object sender, EventArgs e)
        {
            Download("https://ia903201.us.archive.org/8/items/23_20230821_20230821_0633/23.mp4",
             "قسمت بیستو سوم", "آموزش ویندوز فرم");
        }

        private void Download22_Click(object sender, EventArgs e)
        {
            Download("https://ia600509.us.archive.org/33/items/22_20230821_20230821/22.mp4",
             "قسمت بیستو دوم", "آموزش ویندوز فرم");
        }

        private void Download21_Click(object sender, EventArgs e)
        {
            Download("https://ia800505.us.archive.org/7/items/21_20230821_20230821/21.mp4",
             "قسمت بیستو یکم", "آموزش ویندوز فرم");
        }

        private void Download20_Click(object sender, EventArgs e)
        {
            Download("https://ia600508.us.archive.org/19/items/20_20230821_202308/20.mp4",
             "قسمت بیستم", "آموزش ویندوز فرم");
        }

        private void Download19_Click(object sender, EventArgs e)
        {
            Download("https://ia903203.us.archive.org/32/items/19_20230821_20230821_0626/19.mp4",
             "قسمت نوزدهم", "آموزش ویندوز فرم");
        }

        private void Download18_Click(object sender, EventArgs e)
        {
            Download("https://ia600509.us.archive.org/28/items/18_20230821_202308/18.mp4",
             "قسمت هجدهم", "آموزش ویندوز فرم");
        }

        private void Download17_Click(object sender, EventArgs e)
        {
            Download("https://ia803203.us.archive.org/2/items/17_20230821_20230821/17.mp4",
             "قسمت هفدهم", "آموزش ویندوز فرم");
        }

        private void Download16_Click(object sender, EventArgs e)
        {
            Download("https://ia600507.us.archive.org/16/items/16_20230821_20230821/16.mp4",
             "قسمت شانزدهم", "آموزش ویندوز فرم");
        }

        private void Download15_Click(object sender, EventArgs e)
        {
            Download("https://ia600505.us.archive.org/9/items/15_20230821_20230821/15.mp4",
             "قسمت پانزدهم", "آموزش ویندوز فرم");
        }

        private void Download14_Click(object sender, EventArgs e)
        {
            Download("https://ia800508.us.archive.org/16/items/14_20230821_202308/14.mp4",
             "قسمت چهاردهم", "آموزش ویندوز فرم");
        }

        private void Download13_Click(object sender, EventArgs e)
        {
            Download("https://ia600509.us.archive.org/21/items/13_20230821_202308/13.mp4",
             "قسمت سیزدهم", "آموزش ویندوز فرم");
        }

        private void Download12_Click(object sender, EventArgs e)
        {
            Download("https://ia800508.us.archive.org/12/items/12_20230821_20230821_0605/12.mp4",
             "قسمت دوازدهم", "آموزش ویندوز فرم");
        }

        private void Download11_Click(object sender, EventArgs e)
        {
            Download("https://ia903203.us.archive.org/13/items/11_20230821_20230821/11.mp4",
             "قسمت یازدهم", "آموزش ویندوز فرم");
        }

        private void Download10_Click(object sender, EventArgs e)
        {
            Download("https://ia800506.us.archive.org/27/items/10_20230821_20230821/10.mp4",
             "قسمت دهم", "آموزش ویندوز فرم");
        }

        private void Download9_Click(object sender, EventArgs e)
        {
            Download("https://ia903202.us.archive.org/19/items/9_20230821_202308/9.mp4",
             "قسمت نهم", "آموزش ویندوز فرم");
        }

        private void Download8_Click(object sender, EventArgs e)
        {
            Download("https://ia600506.us.archive.org/18/items/8_20230821_20230821/8.mp4",
             "قسمت هشتم", "آموزش ویندوز فرم");
        }

        private void Download7_Click(object sender, EventArgs e)
        {
            Download("https://ia801906.us.archive.org/34/items/7_20230821_202308/7.mp4",
             "قسمت هفتم", "آموزش ویندوز فرم");
        }

        private void Download6_Click(object sender, EventArgs e)
        {
            Download("https://ia800505.us.archive.org/31/items/6_20230821_20230821_0549/6.mp4",
             "قسمت ششم", "آموزش ویندوز فرم");
        }

        private void Download5_Click(object sender, EventArgs e)
        {
            Download("https://ia601908.us.archive.org/0/items/5_20230821_20230821/5.mp4",
             "قسمت پنجم", "آموزش ویندوز فرم");
        }

        private void Download4_Click(object sender, EventArgs e)
        {
            Download("https://ia600507.us.archive.org/16/items/4_20230821_20230821_0544/4.mp4",
             "قسمت چهارم", "آموزش ویندوز فرم");
        }

        private void Download3_Click(object sender, EventArgs e)
        {
            Download("https://ia600505.us.archive.org/35/items/3_20230815_20230815_192/3.mp4",
             "قسمت سوم", "آموزش ویندوز فرم");
        }

        private void Download2_Click(object sender, EventArgs e)
        {
            Download("https://ia800505.us.archive.org/8/items/2_20230815_20230815_1905/2.mp4",
             "قسمت دوم", "آموزش ویندوز فرم");
        }

        private void Download1_Click(object sender, EventArgs e)
        {
            Download("https://ia600507.us.archive.org/27/items/1_20230815_20230815_1900/1.mp4",
             "قسمت اول", "آموزش ویندوز فرم");
        }

        private void Btn25_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/FErvw/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "04:51 دقیقه";
            info_manager.DESCREPTION = "این بیستو پنجمین قسمت از آموزش ویندوز فرم است\r\n\r\nاگر برنامه‌ی زندگی‌تان را خودتان طراحی نکنید، اتفاقات و شانس، شما را به برنامه‌های زندگیِ کس دیگری پرتاب می‌کنند. حدس می‌زنید چه چیزی انتظارتان را خواهد کشید؟ هرچه باشد، قطعا چیز دندان‌گیری نیست.\r\n\r\n– جیم ران";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/FErvw?playlist=4929557";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn24_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/YFfgs/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "03:17 دقیقه";
            info_manager.DESCREPTION = "این بیستو چهارمین قسمت از آموزش ویندوز فرم است\r\n\r\nهیچ شوروشوقی در کار نخواهد بود، وقتی در زندگی کم‌کاری وجود داشته باشد. کم‌کاری یعنی نرسیدن به آنچه ظرفیتش را داری.\r\n\r\n– نلسون ماندلا";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/YFfgs?playlist=4929557";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn23_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/9umEi/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "03:32 دقیقه";
            info_manager.DESCREPTION = "این بیستو سومین قسمت از آموزش ویندوز فرم است\r\n\r\nدر آن لحظه که به این نتیجه می‌رسید که همه‌چیز درست خواهد شد، حقیقتا نیز چنان خواهد شد.\r\n\r\n– جان. اف. کندی";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/9umEi?playlist=4929557";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn22_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/jWz5x/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "07:08 دقیقه";
            info_manager.DESCREPTION = "این بیستو دومین قسمت از آموزش ویندوز فرم است\r\n\r\nمأموریت من در زندگی صرفا تلاشی برای زنده‌ماندن نیست، بلکه هدفم کامیابی و موفقیت است و این کامیابی و موفقیت به‌دست نمی‌آید مگر با شوق و شفقت، کمی شوخ‌ طبعی و داشتن سبْک و سیاق خود در زندگی.\r\n\r\n– مایا آنجلو";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/jWz5x?playlist=4929557";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn21_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/iusV0/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "06:55 دقیقه";
            info_manager.DESCREPTION = "این بیستو یکمین قسمت از آموزش ویندوز فرم است\r\n\r\nزندگی سراسر تجربه است. هرچه بیشتر تجربه کنید، بهتر است.\r\n\r\n– رالف. والدو. امرسون";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/iusV0?playlist=4929557";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn20_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/01whs/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "21:07 دقیقه";
            info_manager.DESCREPTION = "این بیستمین قسمت از آموزش ویندوز فرم است\r\n\r\nبا آنچه به‌دست می‌آوریم، زندگی و معیشت خود را می‌سازیم، اما با آنچه می‌بخشیم، گوهر زندگی را به‌دست می‌آوریم.\r\n\r\n– وینستون چرچیل";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/01whs?playlist=4929557";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn19_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/YGacw/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "14:33 دقیقه";
            info_manager.DESCREPTION = "این نوزدهمین قسمت از آموزش ویندوز فرم است\r\n\r\nخداوند محبت زندگی را به ما عطا کرده است. این وظیفه‌ی ماست که موهبت زندگی‌کردن را به خود ببخشاییم.\r\n\r\n– ولتر\r\n";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/YGacw?playlist=4929557";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn18_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/RcWAl/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "09:27 دقیقه";
            info_manager.DESCREPTION = "این هجدهمین قسمت از آموزش ویندوز فرم است\r\n\r\nوقتی زندگی سهل و ساده شد، باید همه‌ی ما، چه فقیر و چه غنی، حواس‌مان را جمع کنیم، اگرنه برای رویارویی با سختی‌هایی که دیر یا زود به سراغ‌مان می‌آیند، آماده نخواهیم بود.\r\n\r\n– النور روزولت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/RcWAl?playlist=4929557";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn17_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/fBsHu/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "10:50 دقیقه";
            info_manager.DESCREPTION = "این هفدهمین قسمت از آموزش ویندوز فرم است\r\n\r\nفقط حیاتی ارزشمند است که برای دیگران زیسته شده باشد.\r\n\r\n– آلبرت انیشتین";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/fBsHu?playlist=4929557";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn16_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/aNGfc/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "13:31 دقیقه";
            info_manager.DESCREPTION = "این شازندهمین قسمت از آموزش ویندوز فرم است\r\n\r\nتغییر، قانون زندگی است و هرکس به گذشته یا آینده چشم بدوزد، قطعا حال را از دست خواهد داد.\r\n\r\n– جان. اف. کندی";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/aNGfc?playlist=4929557";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn15_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/ONTwD/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "19:02 دقیقه";
            info_manager.DESCREPTION = "این پانزدهمین قسمت از آموزش ویندوز فرم است\r\n\r\nزندگی مجموعه‌ای است از تغییرات خودانگیخته و طبیعی. در مقابل این تغییرات نایستید که چیزی به‌جز اندوه برای‌تان به بار نخواهد آمد. بگذارید واقعیت، واقعیت بماند، بگذارید هرچیزی در مسیر جریان سیال و طبیعیِ خود پیش برود.\r\n\r\n– لایو تزو";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/ONTwD?playlist=4929557";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn14_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/i09xC/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "11:37 دقیقه";
            info_manager.DESCREPTION = "این چهاردهمین قسمت از آموزش ویندوز فرم است\r\n\r\nمهم‌ترین و همیشگی‌ترین پرسش زندگی این است: برای دیگران چه می‌کنی؟\r\n\r\n– مارتین لوتر کینگ";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/i09xC?playlist=4929557";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn13_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/Rbq2f/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "12:14 دقیقه";
            info_manager.DESCREPTION = "این سیزدهمین قسمت از آموزش ویندوز فرم است\r\n\r\n۳ چیز در زندگی ثابت است: تغییر، انتخاب و اصول.\r\n\r\n– استفان کو";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/Rbq2f?playlist=4929557";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn12_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/oa2nW/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "16:29 دقیقه";
            info_manager.DESCREPTION = "این دوازدهمین قسمت از آموزش ویندوز فرم است\r\n\r\nهدف اصلی ما در زندگی کمک به دیگران است. اگر نمی‌توانید دیگران را یاری کنید، حداقل آزارشان ندهید.\r\n\r\n– دالایی لاما";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/oa2nW?playlist=4929557";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn11_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/OYPcA/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "30:23 دقیقه";
            info_manager.DESCREPTION = "این یازدهمین قسمت از آموزش ویندوز فرم است\r\n\r\nزندگی واقعا ساده است، ما اصرار داریم آن را پیچیده کنیم.\r\n\r\n– کنفسیوس";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/OYPcA?playlist=4929557";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn10_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/Qr6kY/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "23:01 دقیقه";
            info_manager.DESCREPTION = "این دهمین قسمت از آموزش ویندوز فرم است\r\n\r\nزندگی چیزی است بزرگتر از افزایش سرعت و گذران تند لحظه‌ها.\r\n\r\n– ماهاتما گاندی";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/Qr6kY?playlist=4929557";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/F8yOL/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "15:36 دقیقه";
            info_manager.DESCREPTION = "این نهمین قسمت از آموزش ویندوز فرم است\r\n\r\nزندگی کشف خود نیست، ساختن خود است.\r\n\r\n– جرج برناردشاو";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/F8yOL?playlist=4929557";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/fZkMz/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "09:36 دقیقه";
            info_manager.DESCREPTION = "این هشتمین قسمت از آموزش ویندوز فرم است\r\n\r\nبیشتر وقت‌ها از قدرت لبخندی ساده، نوازشی ملایم، حرفی محبت‌آمیز، گوشی شنوا، تمجیدی صادقانه یا توجهی کوچک غافلیم. تمام این‌ها ظرفیت تغییر و توسعه‌ی زندگی ما را دارند.\r\n\r\n– لیو بوسکالیا";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/fZkMz?playlist=4929557";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/42ekz/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "17:32 دقیقه";
            info_manager.DESCREPTION = "این هفتمین قسمت از آموزش ویندوز فرم است\r\n\r\nتنها ناتوانی در زندگی نگرش و رفتار بد و منفی است.\r\n\r\n– اسکات هامیلتون";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/42ekz?playlist=4929557";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn6_Click(object sender, EventArgs e) // here
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/b8zHV/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "37:01 دقیقه";
            info_manager.DESCREPTION = "این ششمین قسمت از آموزش ویندوز فرم است\r\n\r\nباور کنید زندگی ارزش زیستن و ادامه‌دادن را دارد. این باور به خلق حقایق کمک خواهد کرد.\r\n\r\n– ویلیام جیمز";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/b8zHV?playlist=4929557";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/EfvTG/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "10:08 دقیقه";
            info_manager.DESCREPTION = "این پنجمین قسمت از آموزش ویندوز فرم است\r\n\r\n۱۰درصد از زندگی‌ تان وقایعی است که با آن روبه‌رو می‌شوید و ۹۰درصدِ باقی‌مانده شیوه‌ ی برخورد و پاسخ‌گویی به آنهاست.\r\n\r\n– لو هولتر";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/EfvTG?playlist=4929557";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/LkZsP/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "12:17 دقیقه";
            info_manager.DESCREPTION = "این چهارمین قسمت از آموزش ویندوز فرم است\r\n\r\nآنچه بدان می‌اندیشیم، برای ما رخ خواهد داد؛ پس اگر خواهان تغییر هستیم باید ذهن‌مان را باز نگاه داریم.\r\n\r\n– وین دایر";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/LkZsP?playlist=4929557";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/bvQ4r/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "26:24 دقیقه";
            info_manager.DESCREPTION = "این سومین قسمت از آموزش ویندوز فرم است\r\n\r\nزندگی مسئله‌ای برای حل‌کردن نیست، واقعیتی است که باید آن را تجربه کرد.\r\n\r\n– سورن کی‌یر‌کگارد";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/bvQ4r?playlist=4929557";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/KqSRm/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "19:14 دقیقه";
            info_manager.DESCREPTION = "این دومین قسمت از آموزش ویندوز فرم است\r\n\r\nبزرگ‌ ترین روز زندگیِ همه‌ی ما روزی است که مسئولیت تمام نگرش‌ها و رفتارهایمان را تمام‌وکمال بر عهده بگیریم.\r\n\r\n– جان. سی. مکسول";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/KqSRm?playlist=4929557";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/gajGs/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "17:10 دقیقه";
            info_manager.DESCREPTION = "این اولین قسمت از آموزش ویندوز فرم است\r\n\r\nدر پایان، تعداد سال‌های زندگی‌تان اهمیتی ندارد. آنچه مهم است، زندگی جاری در خلال این تعداد سال‌هاست.\r\n\r\n– آبراهام لینکلن\r\n";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/gajGs?playlist=4929557";

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