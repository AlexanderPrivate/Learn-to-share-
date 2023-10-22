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
    [Activity(Label = "java_easy_list_Activity")]
    public class Activity_java : AppCompatActivity
    {
        AndroidX.AppCompat.Widget.Toolbar toolbar;

        MaterialButton btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11,
            btn12,btn13,btn14,btn15,btn16,btn17,btn18,btn19,btn20,btn21,btn22,btn23,btn24,btn25,btn26;

        MaterialButton download1, download2, download3, download4, download5, download6,
            download7, download8, download9, download10, download11, download12, download13,
            download14, download15, download16, download17, download18, download19, download20,
            download21, download22, download23, download24, download25, download26;
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

            SetContentView(Resource.Layout.activity_java);

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
            btn26 = (MaterialButton)FindViewById(Resource.Id.materialButton26);

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
            download26 = (MaterialButton)FindViewById(Resource.Id.downloadbutton26);


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
                (CardView)FindViewById(Resource.Id.cardView26)
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
                (TextView)FindViewById(Resource.Id.textView25),
                (TextView)FindViewById(Resource.Id.textView26)
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
                (TextView)FindViewById(Resource.Id.textTitle25),
                (TextView)FindViewById(Resource.Id.textTitle26)
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
                (MaterialButton)FindViewById(Resource.Id.materialButton26),

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
                (MaterialButton)FindViewById(Resource.Id.downloadbutton25),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton26)
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
            btn26.Click += Btn26_Click;


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
            download26.Click += Download26_Click;
        }

        private void Download26_Click(object sender, System.EventArgs e)
        {
            Download("https://ia902704.us.archive.org/19/items/26_20230723/26.mp4",
             "قسمت بیستو ششم", "آموزش برنامه نویسی جاوا مقدماتی تا متوسط");
        }

        private void Download25_Click(object sender, System.EventArgs e)
        {
            Download("https://ia902706.us.archive.org/19/items/25_20230723/25.mp4",
             "قسمت بیستو پنجم", "آموزش برنامه نویسی جاوا مقدماتی تا متوسط");
        }

        private void Download24_Click(object sender, System.EventArgs e)
        {
            Download("https://ia802704.us.archive.org/33/items/24_20230723_202307/24.mp4",
             "قسمت بیستو چهارم", "آموزش برنامه نویسی جاوا مقدماتی تا متوسط");
        }

        private void Download23_Click(object sender, System.EventArgs e)
        {
            Download("https://ia802706.us.archive.org/0/items/23_20230723/23.mp4",
             "قسمت بیستو سوم", "آموزش برنامه نویسی جاوا مقدماتی تا متوسط");
        }

        private void Download22_Click(object sender, System.EventArgs e)
        {
            Download("https://ia802700.us.archive.org/11/items/22_20230723/22.mp4",
             "قسمت بیستو دوم", "آموزش برنامه نویسی جاوا مقدماتی تا متوسط");
        }

        private void Download21_Click(object sender, System.EventArgs e)
        {
            Download("https://ia802704.us.archive.org/15/items/21_20230723/21.mp4",
             "قسمت بیستو یکم", "آموزش برنامه نویسی جاوا مقدماتی تا متوسط");
        }

        private void Download20_Click(object sender, System.EventArgs e)
        {
            Download("https://ia802700.us.archive.org/34/items/20_20230723/20.mp4",
             "قسمت بیستم", "آموزش برنامه نویسی جاوا مقدماتی تا متوسط");
        }

        private void Download19_Click(object sender, System.EventArgs e)
        {
            Download("https://ia802700.us.archive.org/24/items/19_20230723/19.mp4",
             "قسمت نوزدهم", "آموزش برنامه نویسی جاوا مقدماتی تا متوسط");
        }

        private void Download18_Click(object sender, System.EventArgs e)
        {
            Download("https://ia902700.us.archive.org/35/items/18_20230723/18.mp4",
             "قسمت هجدهم", "آموزش برنامه نویسی جاوا مقدماتی تا متوسط");
        }

        private void Download17_Click(object sender, System.EventArgs e)
        {
            Download("https://ia802702.us.archive.org/28/items/17_20230723/17.mp4",
             "قسمت هفدهم", "آموزش برنامه نویسی جاوا مقدماتی تا متوسط");
        }

        private void Download16_Click(object sender, System.EventArgs e)
        {
            Download("https://ia902706.us.archive.org/6/items/16_20230723/16.mp4",
             "قسمت شانزدهم", "آموزش برنامه نویسی جاوا مقدماتی تا متوسط");
        }

        private void Download15_Click(object sender, System.EventArgs e)
        {
            Download("https://ia802705.us.archive.org/28/items/15_20230723/15.mp4",
             "قسمت پانزدهم", "آموزش برنامه نویسی جاوا مقدماتی تا متوسط");
        }

        private void Download14_Click(object sender, System.EventArgs e)
        {
            Download("https://ia802706.us.archive.org/2/items/14_20230723_202307/14.mp4",
             "قسمت چهاردهم", "آموزش برنامه نویسی جاوا مقدماتی تا متوسط");
        }

        private void Download13_Click(object sender, System.EventArgs e)
        {
            Download("https://ia902703.us.archive.org/32/items/13_20230723/13.mp4",
             "قسمت سیزدهم", "آموزش برنامه نویسی جاوا مقدماتی تا متوسط");
        }

        private void Download12_Click(object sender, System.EventArgs e)
        {
            Download("https://ia802705.us.archive.org/8/items/12_20230723_202307/12.mp4",
             "قسمت دوازدهم", "آموزش برنامه نویسی جاوا مقدماتی تا متوسط");
        }

        private void Download11_Click(object sender, System.EventArgs e)
        {
            Download("https://ia902707.us.archive.org/23/items/11_20230723/11.mp4",
             "قسمت یازدهم", "آموزش برنامه نویسی جاوا مقدماتی تا متوسط");
        }

        private void Download10_Click(object sender, System.EventArgs e)
        {
            Download("https://ia902709.us.archive.org/21/items/10_20230723_202307/10.mp4",
             "قسمت دهم", "آموزش برنامه نویسی جاوا مقدماتی تا متوسط");
        }

        private void Download9_Click(object sender, System.EventArgs e)
        {
            Download("https://ia802707.us.archive.org/20/items/9_20230723/9.mp4",
             "قسمت نهم", "آموزش برنامه نویسی جاوا مقدماتی تا متوسط");
        }

        private void Download8_Click(object sender, System.EventArgs e)
        {
            Download("https://ia802705.us.archive.org/35/items/8_20230723/8.mp4",
             "قسمت هشتم", "آموزش برنامه نویسی جاوا مقدماتی تا متوسط");
        }

        private void Download7_Click(object sender, System.EventArgs e)
        {
            Download("https://ia802706.us.archive.org/34/items/7_20230723/7.mp4",
             "قسمت هفتم", "آموزش برنامه نویسی جاوا مقدماتی تا متوسط");
        }

        private void Download6_Click(object sender, System.EventArgs e)
        {
            Download("https://ia802703.us.archive.org/33/items/6_20230723_20230723/6.mp4",
             "قسمت ششم", "آموزش برنامه نویسی جاوا مقدماتی تا متوسط");
        }

        private void Download5_Click(object sender, System.EventArgs e)
        {
            Download("https://ia902707.us.archive.org/9/items/5_20230723/5.mp4",
             "قسمت پنجم", "آموزش برنامه نویسی جاوا مقدماتی تا متوسط");
        }

        private void Download4_Click(object sender, System.EventArgs e)
        {
            Download("https://ia802707.us.archive.org/23/items/4_20230723/4.mp4",
             "قسمت چهارم", "آموزش برنامه نویسی جاوا مقدماتی تا متوسط");
        }

        private void Download3_Click(object sender, System.EventArgs e)
        {
            Download("https://ia902706.us.archive.org/21/items/3_20230723/3.mp4",
             "قسمت سوم", "آموزش برنامه نویسی جاوا مقدماتی تا متوسط");
        }

        private void Download2_Click(object sender, System.EventArgs e)
        {
            Download("https://ia902705.us.archive.org/32/items/2_20230723_20230723_0845/2.mp4",
             "قسمت دوم", "آموزش برنامه نویسی جاوا مقدماتی تا متوسط");
        }

        private void Download1_Click(object sender, System.EventArgs e)
        {
            Download("https://ia802707.us.archive.org/10/items/1_20230723_20230723_0842/1.mp4",
             "قسمت اول", "آموزش برنامه نویسی جاوا مقدماتی تا متوسط");
        }

        private void Btn26_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/5JokW/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "27:02 دقیقه";
            info_manager.DESCREPTION = "این بیستو ششمین قسمت آموزش مقدماتی تا متوسطه جاوا است.\r\n\r\nبرای انجام کارهای بزرگ، گاهی لازم است ریسک های بزرگ بکنید\r\n\r\nبیل گیتس";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/5JokW";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn25_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/NHTn0/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "30:59 دقیقه";
            info_manager.DESCREPTION = "این بیستو پنجمین قسمت آموزش مقدماتی تا متوسطه جاوا است.\r\n\r\nموفقیت ما به شکل اساسی وابسته و بر مبنای همکاری و تشریک مساعی، از همان ابتدای کار است.\r\n\r\nبیل گیتس";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/NHTn0";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn24_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/wFSe3/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "37:47 دقیقه";
            info_manager.DESCREPTION = "این بیستو چهارمین قسمت آموزش مقدماتی تا متوسطه جاوا است.\r\n\r\n اگر نمی‌توانید اثری خوب و زیبا خلق کنید، حداقل آن را با ظاهری زیبا و خوب خلق کنید.\r\n\r\nبیل گیتس";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/wFSe3";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn23_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/DsvXN/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "27:48 دقیقه";
            info_manager.DESCREPTION = "این بیستو سومین قسمت آموزش مقدماتی تا متوسطه جاوا است.\r\n\r\nهیچ گاه خود را با هیچ کس دیگری در این دنیا مقایسه نکنید. در غیر این صورت به خودتان توهین کرده اید.\r\n\r\nبیل گیتس";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/DsvXN";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn22_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/BRiaQ/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "34:11 دقیقه";
            info_manager.DESCREPTION = "این بیستو دومین قسمت آموزش مقدماتی تا متوسطه جاوا است.\r\n\r\nاغلب افراد در مورد آنچه در یک سال می‌توان انجام داد غلو و اغراق می‌کنند و آنچه در ده سال می‌توان انجام داد، ‌دست کم می‌گیرند.\r\n\r\nبیل گیتس";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/BRiaQ";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn21_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/X8jYc/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "40:20 دقیقه";
            info_manager.DESCREPTION = "این بیستو یکمین قسمت آموزش مقدماتی تا متوسطه جاوا است.\r\n\r\nانسان همیشه از تغییر هراس دارد.\r\n\r\nبیل گیتس";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/X8jYc";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn20_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/sXxuq/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "21:04 دقیقه";
            info_manager.DESCREPTION = "این بیستمین قسمت آموزش مقدماتی تا متوسطه جاوا است.\r\n\r\nناراضی ترین مشتریان شما برترین و بهترین منابع برای فراگیری و پیشرفت شما هستند.\r\n\r\nبیل گیتس";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/sXxuq";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn19_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/GndRh/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "24:41 دقیقه";
            info_manager.DESCREPTION = "این نوزدهمین قسمت آموزش مقدماتی تا متوسطه جاوا است.\r\n\r\n همه ما همواره به کسانی نیاز داریم که به ما بازخورد بدهند. به این روش است که ما پیشرفت کرده و اصلاح می‌شویم.\r\n\r\nبیل گیتس";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/GndRh";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn18_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/5Xf9e/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "28:49 دقیقه";
            info_manager.DESCREPTION = "این هجدهمین قسمت آموزش مقدماتی تا متوسطه جاوا است.\r\n\r\nجشن گرفتن برای پیروزی و بزرگداشت موفقیت خوب است، اما مهم تر از آن درس گرفتن از شکست است.\r\n\r\nبیل گیتس";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/5Xf9e";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn17_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/8tJV9/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "25:26 دقیقه";
            info_manager.DESCREPTION = "این هفدهمین قسمت آموزش مقدماتی تا متوسطه جاوا است.\r\n\r\nموفقیت یک معلم پست و بدجنس است که افراد باهوش را به این ذهنیت می اندازد که آنها هیچ گاه شکست نخواهند خورد.\r\n\r\nبیل گیتس";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/8tJV9";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn16_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/5LRuc/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "29:20 دقیقه";
            info_manager.DESCREPTION = "این شانزدهمین قسمت آموزش مقدماتی تا متوسطه جاوا است.\r\n\r\nتا آنجایی که ممکن است، از استخدام افرادی که در رشته MBA تحصیل کرده اند، خودداری کنید. برنامه های MBA نحوه ایجاد شرکت ها را به افراد نمی آموزند.\r\n\r\n\r\nایلان ماسک";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/5LRuc";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn15_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/HW6Xh/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "40:13 دقیقه";
            info_manager.DESCREPTION = "این پانزدهمین قسمت آموزش مقدماتی تا متوسطه جاوا است.\r\n\r\nکارآفرین بودن مثل خوردن خرده شیشه و خیره شدن به پرتگاه مرگ است.\r\n\r\nایلان ماسک";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/HW6Xh";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn14_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/GK7kA/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "29:51 دقیقه";
            info_manager.DESCREPTION = "این چهاردهمین قسمت آموزش مقدماتی تا متوسطه جاوا است.\r\n\r\nوقتی چیزی خوب پیش نمی رود، خود را گول نزنید و نگویید که خوب پیش می رود و یا اینکه خود را با یک راه حل بد، مشغول نکنید.\r\n\r\nایلان ماسک";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/GK7kA";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn13_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/iudIv/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "33:04 دقیقه";
            info_manager.DESCREPTION = "این سیزدهمین قسمت آموزش مقدماتی تا متوسطه جاوا است.\r\n\r\nاگر انجام کاری خیلی مهم است، حتی اگر احتمال موفقیت شما کم باشد، باید آن را انجام دهید.\r\n\r\n\r\nایلان ماسک";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/iudIv";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn12_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/lH6bJ/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "26:33 دقیقه";
            info_manager.DESCREPTION = "این دوازدهمین قسمت آموزش مقدماتی تا متوسطه جاوا است.\r\n\r\nبه نظرم مردم معمولی هم می توانند فوق العاده بودن را انتخاب کنند.\r\n\r\n\r\nایلان ماسک";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/lH6bJ";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn11_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/IBu7V/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "21:48 دقیقه";
            info_manager.DESCREPTION = "این یازدهمین قسمت آموزش مقدماتی تا متوسطه جاوا است.\r\n\r\nتا زمانی که کنترل اتفاقاتی که برای سبد شما می افتد در دست شما باشد اشکالی ندارد تخم مرغ های خود را در یک سبد قرار دهید.\r\n\r\n\r\nایلان ماسک";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/IBu7V";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn10_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/r2xhu/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "21:21 دقیقه";
            info_manager.DESCREPTION = "این دهمین قسمت آموزش مقدماتی تا متوسطه جاوا است.\r\n\r\nنمی گویم نمی ترسم، در واقع من دوست دارم ترسم کمتر شود چون خیلی دیوانه کننده است و سیستم عصبی من را برشته می کند!\r\n\r\n\r\nایلان ماسک";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/r2xhu";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn9_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/2u7J6/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "22:53 دقیقه";
            info_manager.DESCREPTION = "این نهمین قسمت آموزش مقدماتی تا متوسطه جاوا است.\r\n\r\nدائما به این فکر کنید که چگونه می توانید کارها را بهتر انجام دهید، به زیر سوال بردن خودتان ادامه دهید.\r\n\r\nایلان ماسک";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/2u7J6";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn8_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/BNbjm/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "19:14 دقیقه";
            info_manager.DESCREPTION = "این هشتمین قسمت آموزش مقدماتی تا متوسطه جاوا است.\r\n\r\nراه اندازی شرکت درست مانند پختن کیک است، شما باید همه مواد لازم را به نسبت مناسب در اختیار داشته باشید.\r\n\r\nایلان ماسک";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/BNbjm";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn7_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/aNzAr/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "28:33 دقیقه";
            info_manager.DESCREPTION = "این هفتمین قسمت آموزش مقدماتی تا متوسطه جاوا است.\r\n\r\nانگیزه من برای تاسیس همه شرکت هایم درگیر شدن در کاری بوده است که فکر کردم تاثیر قابل توجهی در جهان خواهد داشت.\r\n\r\n\r\nایلان ماسک";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/aNzAr";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn6_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/Q7TZz/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "29:38 دقیقه";
            info_manager.DESCREPTION = "این ششمین قسمت آموزش مقدماتی تا متوسطه جاوا است.\r\n\r\nهمین حالا ریسک کنید و کاری جسورانه انجام دهید، پیشمان نخواهید شد.\r\n\r\nایلان ماسک";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/Q7TZz";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn5_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/EeuyK/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "48:27 دقیقه";
            info_manager.DESCREPTION = "این پنجمین قسمت آموزش مقدماتی تا متوسطه جاوا است.\r\n\r\nاگر قوانین به گونه ای است که نمی توانید پیشرفت کنید باید با قوانین بجنگید.\r\n\r\nایلان ماسک";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/EeuyK";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn4_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/m1Fc5/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "18:16 دقیقه";
            info_manager.DESCREPTION = "این چهارمین قسمت آموزش مقدماتی تا متوسطه جاوا است.\r\n\r\nشرکت های عالی بر اساس محصولات عالی ساخته شده اند.\r\n\r\nایلان ماسک";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/m1Fc5";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn3_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/85X9N/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "17:07 دقیقه";
            info_manager.DESCREPTION = "این سومین قسمت آموزش مقدماتی تا متوسطه جاوا است.\r\n\r\nبرخی آدم ها تغییر را دوست ندارند اما وقتی گزینه موجود دیگر فاجعه باشد باید تغییر را با آغوش باز بپذیرید.\r\n\r\nایلان ماسک";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/85X9N";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn2_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/GOueN/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "30:14 دقیقه";
            info_manager.DESCREPTION = "این دومین قسمت آموزش مقدماتی تا متوسطه جاوا است.\r\n\r\nبه بازخوردهای منفی (انتقادات) توجه کنید و آن را به خصوص از دوستان خود بخواهید … این کار سخت اما فوق العاده مفید است.\r\n\r\nایلان ماسک";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/GOueN";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn1_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/Tf9bM/vt/frame";
            info_manager.TEACHER_NAME = "مهدی عباسی";
            info_manager.TIME_OF_VIDEO = "28:07 دقیقه";
            info_manager.DESCREPTION = "این اولین قسمت آموزش مقدماتی تا متوسطه جاوا است.\r\n\r\nدوست داشتن افرادی که با آن ها کار می کنید بسیار مهم است، در غیر این صورت وضعیت زندگی و شغل شما دچار سیاه بختی می شود.\r\n\r\nایلان ماسک\r\n";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/Tf9bM";

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