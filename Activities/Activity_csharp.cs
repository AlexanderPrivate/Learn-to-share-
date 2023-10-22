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
    [Activity(Label = "csharp_easy_list_Activity")]
    public class Activity_csharp : AppCompatActivity
    {
        AndroidX.AppCompat.Widget.Toolbar toolbar;

        MaterialButton btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11,
            btn12, btn13, btn14, btn15, btn16;

        MaterialButton download1, download2, download3, download4, download5, download6,
            download7, download8, download9, download10, download11, download12, download13,
            download14, download15, download16;
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

            SetContentView(Resource.Layout.activity_csharp);

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
                (CardView)FindViewById(Resource.Id.cardView16)
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
                (TextView)FindViewById(Resource.Id.textView16)
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
                (TextView)FindViewById(Resource.Id.textTitle16)
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
                (MaterialButton)FindViewById(Resource.Id.downloadbutton16)
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
            btn12.Click += Btn12_Click;
            btn13.Click += Btn13_Click;
            btn14.Click += Btn14_Click;
            btn15.Click += Btn15_Click;
            btn16.Click += Btn16_Click;

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
        }

        private void Download16_Click(object sender, EventArgs e)
        {
            Download("https://ia902602.us.archive.org/23/items/20230519_20230519_1913/%D9%82%D8%B3%D9%85%D8%AA%20%D9%BE%D8%A7%DB%8C%D8%A7%D9%86%DB%8C%20-%20%D8%AA%D9%88%D8%B6%DB%8C%D8%AD%D8%A7%D8%AA%20%D9%85%D9%87%D9%85.mp4",
             "قسمت اخر - شانزدهم", "آموزش مقدماتی تا متوسطه زبان سی شارپ");
        }

        private void Download15_Click(object sender, EventArgs e)
        {
            Download("https://ia802601.us.archive.org/31/items/foreach/%D8%AD%D9%84%D9%82%D9%87%20foreach%20%D8%AF%D8%B1%20%D8%B3%DB%8C%20%D8%B4%D8%A7%D8%B1%D9%BE.mp4",
             "قسمت پانزدهم", "آموزش مقدماتی تا متوسطه زبان سی شارپ");
        }

        private void Download14_Click(object sender, EventArgs e)
        {
            Download("https://ia802603.us.archive.org/9/items/20230519_20230519_1849/%D9%84%DB%8C%D8%B3%D8%AA%20%D9%87%D8%A7%20%D8%AF%D8%B1%20%D8%B3%DB%8C%20%D8%B4%D8%A7%D8%B1%D9%BE.mp4",
             "قسمت چهاردهم", "آموزش مقدماتی تا متوسطه زبان سی شارپ");
        }

        private void Download13_Click(object sender, EventArgs e)
        {
            Download("https://ia601601.us.archive.org/21/items/if_20230519_202305/%D8%A7%D8%B3%D8%AA%D9%81%D8%A7%D8%AF%D9%87%20%D8%A7%D8%B2%20if%20%D8%AF%D8%A7%D8%AE%D9%84%20%D8%AD%D9%84%D9%82%D9%87.mp4",
             "قسمت سیزدهم", "آموزش مقدماتی تا متوسطه زبان سی شارپ");
        }

        private void Download12_Click(object sender, EventArgs e)
        {
            Download("https://ia802601.us.archive.org/2/items/20230519_20230519_1627/%D8%AD%D9%84%D9%82%D9%87%20%D9%87%D8%A7%DB%8C%20%D8%AA%D9%88%20%D8%AF%D8%B1%20%D8%AA%D9%88%20%D8%AF%D8%B1%20%D8%B3%DB%8C%20%D8%B4%D8%A7%D8%B1%D9%BE.mp4",
             "قسمت دوازدهم", "آموزش مقدماتی تا متوسطه زبان سی شارپ");
        }

        private void Download11_Click(object sender, EventArgs e)
        {
            Download("https://ia801604.us.archive.org/6/items/while/%D8%A2%D9%85%D9%88%D8%B2%D8%B4%20%D8%AD%D9%84%D9%82%D9%87%20%D9%87%D8%A7%20-%20While.mp4",
             "قسمت یازدهم", "آموزش مقدماتی تا متوسطه زبان سی شارپ");
        }

        private void Download10_Click(object sender, EventArgs e)
        {
            Download("https://ia802608.us.archive.org/23/items/for_20230518/%D8%AD%D9%84%D9%82%D9%87%20%D9%87%D8%A7%20-%20%D8%AD%D9%84%D9%82%D9%87%20for.mp4",
             "قسمت دهم", "آموزش مقدماتی تا متوسطه زبان سی شارپ");
        }

        private void Download9_Click(object sender, EventArgs e)
        {
            Download("https://ia902609.us.archive.org/27/items/do-while/%D8%AD%D9%84%D9%82%D9%87%20%D9%87%D8%A7%20-%20%D8%AD%D9%84%D9%82%D9%87%20do%20while.mp4",
             "قسمت نهم", "آموزش مقدماتی تا متوسطه زبان سی شارپ");
        }

        private void Download8_Click(object sender, EventArgs e)
        {
            Download("https://ia801601.us.archive.org/1/items/20230511_20230511_2315/%D8%AA%D9%88%D8%A7%D8%A8%D8%B9%20%D8%A7%D8%B3%D8%AA%D8%B1%DB%8C%D9%86%DA%AF.mp4",
             "قسمت هشتم", "آموزش مقدماتی تا متوسطه زبان سی شارپ");
        }

        private void Download7_Click(object sender, EventArgs e)
        {
            Download("https://ia601603.us.archive.org/7/items/2_20230511_20230511_2202/%D8%B3%D8%A7%D8%AE%D8%AA%D8%A7%D8%B1%20%D9%87%D8%A7%DB%8C%20%D8%B4%D8%B1%D8%B7%DB%8C%202.mp4",
             "قسمت هفتم", "آموزش مقدماتی تا متوسطه زبان سی شارپ");
        }

        private void Download6_Click(object sender, EventArgs e)
        {
            Download("https://ia802602.us.archive.org/7/items/1_20230511_20230511_2038/%D8%B3%D8%A7%D8%AE%D8%AA%D8%A7%D8%B1%20%D9%87%D8%A7%DB%8C%20%D8%B4%D8%B1%D8%B7%DB%8C%201.mp4",
             "قسمت ششم", "آموزش مقدماتی تا متوسطه زبان سی شارپ");
        }

        private void Download5_Click(object sender, EventArgs e)
        {
            Download("https://ia801607.us.archive.org/0/items/20230508_20230508/%D8%A2%D9%85%D9%88%D8%B2%D8%B4%20%D9%85%D8%AA%D8%BA%DB%8C%DB%8C%D8%B1%20%D9%87%D8%A7%20%D9%86%D9%88%D8%B9%20%D8%AF%D8%A7%D8%AF%D9%87%20%D9%87%D8%A7%20%D9%88%20%D8%B9%D9%85%D9%84%DA%AF%D8%B1%20%D9%87%D8%A7.mp4",
             "قسمت پنجم", "آموزش مقدماتی تا متوسطه زبان سی شارپ");
        }

        private void Download4_Click(object sender, EventArgs e)
        {
            Download("https://ia801609.us.archive.org/1/items/20230506_20230506_0102/%D8%B3%D8%A7%D8%AE%D8%AA%20%D9%BE%D8%B1%D9%88%DA%98%D9%87.mp4",
             "قسمت چهارم", "آموزش مقدماتی تا متوسطه زبان سی شارپ");
        }

        private void Download3_Click(object sender, EventArgs e)
        {
            Download("https://ia802606.us.archive.org/4/items/20230505_202305/%D9%86%D8%B5%D8%A8%20%D9%88%DB%8C%DA%98%D9%88%D8%A7%D9%84%20%D8%A7%D8%B3%D8%AA%D9%88%D8%AF%DB%8C%D9%88.mp4",
             "قسمت سوم", "آموزش مقدماتی تا متوسطه زبان سی شارپ");
        }

        private void Download2_Click(object sender, EventArgs e)
        {
            Download("https://ia802607.us.archive.org/20/items/20230503_20230503_1914/%D8%B3%DB%8C%20%D8%B4%D8%A7%D8%B1%D9%BE.mp4",
             "قسمت دوم", "آموزش مقدماتی تا متوسطه زبان سی شارپ");
        }

        private void Download1_Click(object sender, EventArgs e)
        {
            Download("https://ia902609.us.archive.org/20/items/20230503_20230503_1722/%D9%BE%DB%8C%D8%B4%20%D9%86%D9%85%D8%A7%DB%8C%D8%B4%20%D8%AF%D9%88%D8%B1%D9%87.mp4",
             "قسمت اول", "آموزش مقدماتی تا متوسطه زبان سی شارپ");
        }

        private void Btn16_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/vuqiU/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "03:37 دقیقه";
            info_manager.DESCREPTION = "این شانزدهمین قسمت از دوره آموزش سی شارپ است.\r\n\r\nبه مشتری های خود نزدیک باشید\r\nآنقدر نزدیک که شما به آنها بگویید که به چه چیزهایی نیاز دارند\r\nقبل از اینکه خودشان متوجه شوند.\r\n\r\nاستیو جابز";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/vuqiU?playlist=5774816";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn15_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/S6gWt/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "03:52 دقیقه";
            info_manager.DESCREPTION = "این پانزدهمین قسمت از دوره آموزش سی شارپ است.\r\n\r\nثروتمندترین مرد قبرستان بودن برای من مهم نیست\r\nشب رفتن به رختخواب با گفتن اینکه ما کار فوق العاده ای انجام داده ایم …\r\nاین چیزی است که برای من مهم است.\r\n\r\nاستیو جابز";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/S6gWt?playlist=5774816";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn14_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/ybvTK/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "05:20 دقیقه";
            info_manager.DESCREPTION = "این چهاردهمین قسمت از دوره آموزش سی شارپ است.\r\n\r\nمن به همه ی کار هایی که انجام داده ام\r\nافتخار می کنم.\r\n\r\nاستیو جابز";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/ybvTK?playlist=5774816";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn13_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/1esyC/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "05:20 دقیقه";
            info_manager.DESCREPTION = "این سیزدهمین قسمت از دوره آموزش سی شارپ است.\r\n\r\nبه یاد آوردن اینکه من به زودی خواهم مرد\r\nمهم ترین چیزی است که تا به حال با آن روبرو شده ام\r\nچون به من کمک می کند\r\nتا بتوانم انتخاب های بزرگی را در زندگی ام انجام دهم.\r\n\r\nاستیو جابز";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/1esyC?playlist=5774816";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn12_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/sIoeW/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "03:29 دقیقه";
            info_manager.DESCREPTION = "این دوازدهمین قسمت از دوره آموزش سی شارپ است.\r\n\r\nمن با دیگران با ملایمت رفتار نمی کنم\r\nچون می خواهم که آن ها را قوی تر و بهتر کنم.\r\n\r\nاستیو جابز";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/sIoeW?playlist=5774816";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn11_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/GqzUV/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "01:53 دقیقه";
            info_manager.DESCREPTION = "این یازدهمین قسمت از دوره آموزش سی شارپ است.\r\n\r\nمن معتقدم که زندگی یک چیز هوشمندانه است\r\nو هیچ چیز در آن تصادفی نیست.\r\n\r\nاستیو جابز";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/GqzUV?playlist=5774816";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn10_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/snJDK/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "03:36 دقیقه";
            info_manager.DESCREPTION = "این دهمین قسمت از دوره آموزش سی شارپ است.\r\n\r\nاگر امروز آخرین روز زندگی‌تان بود\r\nآیا کاری که قصد دارید آن را انجام دهید را انجام می‌دادید؟\r\n\r\nاستیو جابز";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/snJDK?playlist=5774816";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/LNUEZ/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "04:07 دقیقه";
            info_manager.DESCREPTION = "این نهمین قسمت از دوره آموزش سی شارپ است.\r\n\r\nبیایید فردا را بسازیم\r\nنه اینکه درباره آنچه که ممکن است اتفاق بیفتد\r\nنگران باشیم.\r\n\r\nاستیو جابز";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/LNUEZ?playlist=5774816";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/TFjQN/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "12:13 دقیقه";
            info_manager.DESCREPTION = "این هشتمین قسمت از دوره آموزش سی شارپ است.\r\n\r\nمن همیشه به مردم توصیه می کنم که صبر نکنید!\r\nوقتی جوان هستید هر کاری که دوست دارید را انجام دهید\r\nچیزی برای از دست دادن ندارید\r\nو این را همیشه به خاطر داشته باشید.\r\n\r\nاستیو جابز";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/TFjQN?playlist=5774816";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/pZfEh/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "06:53 دقیقه";
            info_manager.DESCREPTION = "این هفتمین قسمت از دوره آموزش سی شارپ است.\r\n\r\nاستخدام کار بسیار سختی است\r\nدرست مثل پیدا کردن سوزن در انبار یونجه!\r\n\r\nاستیو جابز";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/pZfEh?playlist=5774816";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/nGWL6/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "09:34 دقیقه";
            info_manager.DESCREPTION = "این ششمین قسمت از دوره آموزش سی شارپ است.\r\n\r\nمن فکر می‌ کنم بزرگ‌ ترین افسوس‌ های شما\r\nدر مورد کار هایی است که هرگز انجام نداده‌ اید.\r\n\r\nاستیو جابز";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/nGWL6?playlist=5774816";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/vDVpN/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "14:44 دقیقه";
            info_manager.DESCREPTION = "این پنجمین قسمت از دوره آموزش سی شارپ است.\r\n\r\nاگر کاری را دوست نداشته باشید\r\nدر آن شکست می خورید.\r\n\r\nاستیو جابز";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/vDVpN?playlist=5774816";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/1pGoF/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "02:06 دقیقه";
            info_manager.DESCREPTION = "این چهارمین قسمت از دوره آموزش سی شارپ است.\r\n\r\nیک روز به این واقعیت ساده پی می برید\r\nکه هر چیزی در اطراف شما که زندگی نامیده می شود\r\nتوسط افرادی ساخته شده که به هیچ وجه از شما با هوش تر نبوده اند.\r\n\r\nاستیو جابز";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/1pGoF?playlist=5774816";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/lsVGh/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "02:14 دقیقه";
            info_manager.DESCREPTION = "این سومین قسمت از دوره آموزش سی شارپ است.\r\n\r\nزمان شما محدود است\r\nپس این زمان محدود را با زندگی بر اساس اعتقادات و نگرش دیگران هدر ندهید.\r\n\r\nاستیو جابز";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/lsVGh?playlist=5774816";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/K5TtD/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "03:52 دقیقه";
            info_manager.DESCREPTION = "این دومین قسمت از دوره آموزش سی شارپ است.\r\n\r\nمن معتقدم تنها چیزی که باعث شد من به کارم ادامه دهم\r\nاین بود که عاشق کاری که انجام می دادم، بودم\r\nشما باید کاری را که دوست دارید، پیدا کنید.\r\n\r\nاستیو جابز";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/K5TtD?playlist=5774816";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/ULuPV/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "04:50 دقیقه";
            info_manager.DESCREPTION = "این اولین قسمت از دوره آموزش سی شارپ است.\r\n\r\nهیچکس نمی خواهد بمیرد\r\nحتی افرادی که می خواهند به بهشت بروند\r\nنمی خواهند برای رسیدن به آن جا بمیرند.\r\n\r\nاستیو جابز";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/ULuPV?playlist=5774816";

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