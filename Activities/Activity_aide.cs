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
    [Activity(Label = "Aide_list_Activity")]
    public class Activity_aide : AppCompatActivity
    {
        AndroidX.AppCompat.Widget.Toolbar toolbar;

        MaterialButton btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9,
            btn10, btn11, btn12, btn13, btn14, btn15;

        MaterialButton download1, download2, download3, download4, download5, download6,
            download7, download8, download9, download10, download11, download12,
            download13, download14, download15;

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


            SetContentView(Resource.Layout.activity_aide);

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
            btn12 = (MaterialButton)FindViewById(Resource.Id.materialButton12);
            btn13 = (MaterialButton)FindViewById(Resource.Id.materialButton13);
            btn14 = (MaterialButton)FindViewById(Resource.Id.materialButton14);
            btn15 = (MaterialButton)FindViewById(Resource.Id.materialButton15);


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
                (AndroidX.CardView.Widget.CardView)FindViewById(Resource.Id.cardView10),
                (AndroidX.CardView.Widget.CardView)FindViewById(Resource.Id.cardView11),
                (AndroidX.CardView.Widget.CardView)FindViewById(Resource.Id.cardView12),
                (AndroidX.CardView.Widget.CardView)FindViewById(Resource.Id.cardView13),
                (AndroidX.CardView.Widget.CardView)FindViewById(Resource.Id.cardView14),
                (AndroidX.CardView.Widget.CardView)FindViewById(Resource.Id.cardView15)
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
                (TextView)FindViewById(Resource.Id.textTitle15)
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
                    txt.SetTextColor(Color.Rgb(70,70,70));
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
        }

        private void Download15_Click(object sender, System.EventArgs e)
        {
            Download("https://ia804605.us.archive.org/9/items/15_20230815/15.mp4",
            "قسمت پانزدهم", "آموزش برنامه نویسی اندروید در محیط Aide");
        }

        private void Download14_Click(object sender, System.EventArgs e)
        {
            Download("https://ia804602.us.archive.org/14/items/14_20230815/14.mp4",
            "قسمت چهاردهم", "آموزش برنامه نویسی اندروید در محیط Aide");
        }

        private void Download13_Click(object sender, System.EventArgs e)
        {
            Download("https://ia804608.us.archive.org/24/items/13_20230815_202308/13.mp4",
            "قسمت سیزدهم", "آموزش برنامه نویسی اندروید در محیط Aide");
        }

        private void Download12_Click(object sender, System.EventArgs e)
        {
            Download("https://ia804600.us.archive.org/24/items/12_20230815/12.mp4",
            "قسمت دوازدهم", "آموزش برنامه نویسی اندروید در محیط Aide");
        }

        private void Download11_Click(object sender, System.EventArgs e)
        {
            Download("https://ia904601.us.archive.org/25/items/11_20230815_202308/11.mp4",
            "قسمت یازدهم", "آموزش برنامه نویسی اندروید در محیط Aide");
        }

        private void Download10_Click(object sender, System.EventArgs e)
        {
            Download("https://ia800505.us.archive.org/19/items/10_20230815/10.mp4",
           "قسمت دهم", "آموزش برنامه نویسی اندروید در محیط Aide");
        }

        private void Download9_Click(object sender, System.EventArgs e)
        {
            Download("https://ia904603.us.archive.org/34/items/9_20230815_20230815/9.mp4",
           "قسمت نهم", "آموزش برنامه نویسی اندروید در محیط Aide");
        }

        private void Download8_Click(object sender, System.EventArgs e)
        {
            Download("https://ia904604.us.archive.org/14/items/8_20230815_202308/8.mp4",
           "قسمت هشتم", "آموزش برنامه نویسی اندروید در محیط Aide");
        }

        private void Download7_Click(object sender, System.EventArgs e)
        {
            Download("https://ia804603.us.archive.org/2/items/7_20230815/7.mp4",
           "قسمت هفتم", "آموزش برنامه نویسی اندروید در محیط Aide");
        }

        private void Download6_Click(object sender, System.EventArgs e)
        {
            Download("https://ia601703.us.archive.org/22/items/6_20230815_202308/6.mp4",
           "قسمت ششم", "آموزش برنامه نویسی اندروید در محیط Aide");
        }

        private void Download5_Click(object sender, System.EventArgs e)
        {
            Download("https://ia902701.us.archive.org/15/items/5_20230815_202308/5.mp4",
           "قسمت پنجم", "آموزش برنامه نویسی اندروید در محیط Aide");
        }

        private void Download4_Click(object sender, System.EventArgs e)
        {
            Download("https://ia600506.us.archive.org/20/items/4_20230815_202308/4.mp4",
           "قسمت چهارم", "آموزش برنامه نویسی اندروید در محیط Aide");
        }

        private void Download3_Click(object sender, System.EventArgs e)
        {
            Download("https://ia804604.us.archive.org/34/items/3_20230815_202308/3.mp4",
           "قسمت سوم", "آموزش برنامه نویسی اندروید در محیط Aide");
        }

        private void Download2_Click(object sender, System.EventArgs e)
        {
            Download("https://ia800509.us.archive.org/16/items/2_20230815_20230815/2.mp4",
            "قسمت دوم", "آموزش برنامه نویسی اندروید در محیط Aide");
        }

        private void Download1_Click(object sender, System.EventArgs e)
        {
            Download("https://ia904604.us.archive.org/14/items/1_20230815_20230815_0908/%D9%82%D8%B3%D9%85%D8%AA%201.mp4",
            "قسمت اول", "آموزش برنامه نویسی اندروید در محیط Aide");
        }

        private void Btn15_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/fZS3N/vt/frame";
            info_manager.TEACHER_NAME = "مصطفی آصفی";
            info_manager.TIME_OF_VIDEO = "09:03 دقیقه";
            info_manager.DESCREPTION = "این قسمت پانزدهم از آموزش برنامه نویسی اندروید در محیط Aide است.\r\n\r\nزبان PHP مانند مسواک شما هیجان انگیز است. شما هر روز از آن استفاده می کنید، کار را انجام می‌دهد، ابزار ساده ای است،\r\n پس چه چیزی می‌خواهید؟ چه کسی دوست دارد در مورد مسواک بخواند؟";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/fZS3N";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn14_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/khOmI/vt/frame";
            info_manager.TEACHER_NAME = "مصطفی آصفی";
            info_manager.TIME_OF_VIDEO = "13:30 دقیقه";
            info_manager.DESCREPTION = "این قسمت چهاردهم از آموزش برنامه نویسی اندروید در محیط  Aide است.\r\n\r\nمشکل استفاده از زبان ++C این است که شما را مجبور می‌کند قبل از انجام هر کاری همه چیز را بدانید.\r\n\r\nلَری وال برنامه‌نویس کامپیوتر و خالق زبان برنامه نویسی Perl است.\r\n";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/khOmI?playlist=7075180";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn13_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/dPWmA/vt/frame";
            info_manager.TEACHER_NAME = "مصطفی آصفی";
            info_manager.TIME_OF_VIDEO = "4:21 دقیقه";
            info_manager.DESCREPTION = "این قسمت سیزدهم از آموزش برنامه نویسی اندروید در محیط  Aide است.\r\n\r\nبرنامه نویسی به شما این امکان را می‌دهد که به فکر کردن فکر کنید و در حین اشکال زدایی (Debug)، یاد گرفتن را یاد بگیرید.\r\n\r\nطرح یک لپ‌تاپ برای هر کودک (One Laptop per Child)، طرحی است که به منظور نظارت بر ایجاد دستگاه‌های آموزشی مقرون به صرفه در کشورهای در حال توسعه راه‌اندازی شده است. هدف از این طرح، دادن یک لپ‌تاپ به هر کودک است. رئیس آن نیکلاس نگروپونته است.\r\n";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/dPWmA?playlist=7075180";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn12_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/UEt7m/vt/frame";
            info_manager.TEACHER_NAME = "مصطفی آصفی";
            info_manager.TIME_OF_VIDEO = "11:43 دقیقه";
            info_manager.DESCREPTION = "این قسمت دوازدهم از آموزش برنامه نویسی اندروید در محیط  Aide است.\r\n\r\nیکی از پربارترین روزهای من حذف 1000 خط کد بود.\r\n\r\nکنت لین تامسون که در محفل هکرها معمولا با نام ken شناخته می‌شود، یکی از پیشگامان علوم رایانه است. تامسون سیستم‌عامل اصلی Unix را طراحی و پیاده‌سازی کرده‌است. او همچنین مخترع زبان برنامه‌نویسی B است، زبانی که جد زبان C به حساب می‌آید.\r\n";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/UEt7m?playlist=7075180";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn11_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/GzreM/vt/frame";
            info_manager.TEACHER_NAME = "مصطفی آصفی";
            info_manager.TIME_OF_VIDEO = "4:44 دقیقه";
            info_manager.DESCREPTION = "این قسمت یازدهم از آموزش برنامه نویسی اندروید در محیط  Aide است.\r\n\r\nزبان Java مانند ++C بدون تفنگ است.\r\n\r\nجیمز آرتور گاسلینگ از دانشمندان کامپیوتر و زاده کانادا است. او به عنوان پدر زبان برنامه‌نویسی جاوا شناخته می‌شود.\r\n";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/GzreM?playlist=7075180";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn10_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/9XWEw/vt/frame";
            info_manager.TEACHER_NAME = "مصطفی آصفی";
            info_manager.TIME_OF_VIDEO = "14:49 دقیقه";
            info_manager.DESCREPTION = "این قسمت دهم از آموزش برنامه نویسی اندروید در محیط  Aide است.\r\n\r\nبا زبان برنامه نویسی C، به راحتی می‌توانید به پای خود شلیک کنید. اما زبان برنامه نویسی ++C این کار را دشوار می‌کند؛ اما اگر با ++C موفق به این کار شوید، تمام پای شما را قطع خواهد کرد.\r\n\r\nبیارنه استراس تروپ اهل دانمارک، دانشمند علوم کامپیوتر، به‌خاطر ایجاد و توسعه زبان ++C به‌شهرت رسید. او در حال حاضر پروفسور دانشگاه A&M تگزاس است.\r\n";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/9XWEw?playlist=7075180";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn9_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/JtIXG/vt/frame";
            info_manager.TEACHER_NAME = "مصطفی آصفی";
            info_manager.TIME_OF_VIDEO = "12:54 دقیقه";
            info_manager.DESCREPTION = "این قسمت نهم از آموزش برنامه نویسی اندروید در محیط Aide است.\r\nیونیکس اساسا یک سیستم عامل ساده است، اما برای درک سادگی آن باید نابغه باشید.\r\n\r\nدنیس مک‌آلیستر ریچی، دانشمند علوم رایانه اهل آمریکا بود که به عنوان خالق زبان برنامه نویسی C و مشارکت‌هایش در توسعه سیستم‌عامل یونیکس (Unix)، به همراه کن تامسون، شناخته می‌شود.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/JtIXG?playlist=7075180";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn8_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/cdBCi/vt/frame";
            info_manager.TEACHER_NAME = "مصطفی آصفی";
            info_manager.TIME_OF_VIDEO = "13:54 دقیقه";
            info_manager.DESCREPTION = "این قسمت هشتم از آموزش برنامه نویسی اندروید در محیط Aide است.\r\nهر احمقی می‌تواند کدی بنویسد که کامپیوتر آن را بفهمد. برنامه نویسان خوب کدی را می‌نویسند که انسان بتواند آن را درک کند.\r\n\r\nمارتین فولر مهندس نرم‌افزار اهل بریتانیایی است، نویسنده و سخنران بین‌المللی پیرامون توسعه نرم‌افزار، متخصص طراحی و آنالیز برنامه‌نویسی شیءگرا، یو ام‌ال، الگوی طراحی\r\n، و روش‌شناس باشگاه توسعه نرم‌افزار، از جمله برنامه‌سازی مفرط می‌باشد. ";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/cdBCi?playlist=7075180";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn7_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/aemio/vt/frame";
            info_manager.TEACHER_NAME = "مصطفی آصفی";
            info_manager.TIME_OF_VIDEO = "10:47 دقیقه";
            info_manager.DESCREPTION = "این قسمت هفتم از آموزش برنامه نویسی اندروید در محیط Aide است.\r\nاگر تمام سرمایه ام را از دست بدهم و به من یک لبتاب و اینترنت بدهید میتونم دوباره بدست بیارم حتی در بیابان!\r\n\r\nبیل گیتس.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/aemio?playlist=7075180";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn6_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/Gq0Oy/vt/frame";
            info_manager.TEACHER_NAME = "مصطفی آصفی";
            info_manager.TIME_OF_VIDEO = "8:00 دقیقه";
            info_manager.DESCREPTION = "این قسمت ششم از آموزش برنامه نویسی اندروید در محیط Aide است.\r\nسورس‌کد مثل یک جوک (لطیفه) است؛ اگه مجبور به توضیح آن شدید، بدانید که اصلاً خوب نوشته نشده است.\r\n\r\nکوری هاوس متخصص React و JavaScript است. ";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/Gq0Oy?playlist=7075180";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn5_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/gOQ59/vt/frame";
            info_manager.TEACHER_NAME = "مصطفی آصفی";
            info_manager.TIME_OF_VIDEO = "8:37 دقیقه";
            info_manager.DESCREPTION = "این قسمت پنجم از آموزش برنامه نویسی اندروید در محیط Aide است.\r\nRuby آشغال است. PHP فوق‌العاده است.\r\n\r\nیکیتا پوپوف، در حال حاضر مهندس ارشد نرم‌افزار در شرکت RedHat است.\r\n قبل از RedHat، او در شرکت JetBrains به عنوان یک توسعه‌دهنده اصلی برای پروژه PHP کار می‌کرد.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/gOQ59?playlist=7075180";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn4_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/0VTpG/vt/frame";
            info_manager.TEACHER_NAME = "مصطفی آصفی";
            info_manager.TIME_OF_VIDEO = "11:24 دقیقه";
            info_manager.DESCREPTION = "این قسمت چهارم از آموزش برنامه نویسی اندروید در محیط Aide است.\r\nگاهی‌ اوقات بهتر است در روز تعطیل، در رختخواب خوابید تا اینکه تمام هفته‌ی بعد را مجبور به دیباگ کردن کدهای آن روز، تعطیل کرد.\r\n\r\nدن سالومون";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/0VTpG?playlist=7075180";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn3_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/dpmkR/vt/frame";
            info_manager.TEACHER_NAME = "مصطفی آصفی";
            info_manager.TIME_OF_VIDEO = "10:48 دقیقه";
            info_manager.DESCREPTION = "این قسمت سوم از آموزش برنامه نویسی اندروید در محیط Aide است.\r\nشباهت Java با JavaScript مانند شباهت Car با Carpet است.\r\n\r\nکریستین هایلمن مدیر برنامه اصلی در مایکروسافت، 20 سال آخر عمر خود را وقف کارکرد و پیشرفت وب کرد. \r\nاو نویسنده چندین کتاب در زمینه جاوا اسکریپت و کتاب راهنمای توسعه‌دهندگان است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/dpmkR?playlist=7075180";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn2_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/aNu0r/vt/frame";
            info_manager.TEACHER_NAME = "مصطفی آصفی";
            info_manager.TIME_OF_VIDEO = "11:10 دقیقه";
            info_manager.DESCREPTION = "این قسمت دوم از آموزش برنامه نویسی اندروید در محیط Aide است.\r\nاول مشکل را حل کنید. سپس، کدش را بنویسید.\r\n\r\nسخنی از جان جانسون، جان جانسون مدرس سیستم های اطلاعات کامپیوتری.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/aNu0r?playlist=7075180";

            Intent intent = new Intent(this, typeof(Activity_playvideo));
            StartActivity(intent);
        }

        private void Btn1_Click(object sender, System.EventArgs e)
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/uKBSt/vt/frame";
            info_manager.TEACHER_NAME = "مصطفی آصفی";
            info_manager.TIME_OF_VIDEO = "09:23 دقیقه";
            info_manager.DESCREPTION = "این قسمت اول از آموزش برنامه نویسی اندروید در محیط Aide است.\r\nخوش‌بینی، یک آفت شغلی در برنامه‌ نویسی است. بازخورد گرفتن از کاربران نیز درمان آن است.\r\n\r\nسخنی از کنت بک، کنت بک خالق برنامه‌سازی مفرط و یکی از 17 بنیان‌گذار توسعه نرم‌افزاری چابک است";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/uKBSt";

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