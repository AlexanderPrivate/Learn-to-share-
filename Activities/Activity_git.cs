using System.Collections.Generic;
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
using LearnToShare.MVVM;

namespace LearnToShare.Activities
{
    [Activity(Label = "Activity_git")]
    public class Activity_git : AppCompatActivity
    {
        AndroidX.AppCompat.Widget.Toolbar toolbar;

        MaterialButton btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8;

        MaterialButton download1, download2, download3, download4, download5, download6,
            download7, download8;

        public static Context context;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            context = this;

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

            SetContentView(Resource.Layout.activity_git);

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

            download1 = (MaterialButton)FindViewById(Resource.Id.downloadbutton1);
            download2 = (MaterialButton)FindViewById(Resource.Id.downloadbutton2);
            download3 = (MaterialButton)FindViewById(Resource.Id.downloadbutton3);
            download4 = (MaterialButton)FindViewById(Resource.Id.downloadbutton4);
            download5 = (MaterialButton)FindViewById(Resource.Id.downloadbutton5);
            download6 = (MaterialButton)FindViewById(Resource.Id.downloadbutton6);
            download7 = (MaterialButton)FindViewById(Resource.Id.downloadbutton7);
            download8 = (MaterialButton)FindViewById(Resource.Id.downloadbutton8);

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
            };

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
             };

            List<TextView> TextBold = new List<TextView>()
            {
                (TextView)FindViewById(Resource.Id.textView1),
                (TextView)FindViewById(Resource.Id.textView2),
                (TextView)FindViewById(Resource.Id.textView3),
                (TextView)FindViewById(Resource.Id.textView4),
                (TextView)FindViewById(Resource.Id.textView5),
                (TextView)FindViewById(Resource.Id.textView6),
                (TextView)FindViewById(Resource.Id.textView7),
                (TextView)FindViewById(Resource.Id.textView8),
            };


            foreach (var i in TextBold)
            {
                i.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Bold);
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

                //////////////////////////////////////////////////////////////////////////////////////////////
                
                (MaterialButton)FindViewById(Resource.Id.downloadbutton1),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton2),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton3),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton4),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton5),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton6),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton7),
                (MaterialButton)FindViewById(Resource.Id.downloadbutton8),

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
                foreach (var txt in TextBold)
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
                foreach (var txt in TextBold)
                {
                    txt.SetTextColor(Color.Black);
                }
                foreach (var txt in textsNormal)
                {
                    txt.SetTextColor(Color.Rgb(40, 40, 40));
                }
            }


            btn1.Click += delegate
            {
                GIT.Btn_1();
            };
            btn2.Click += delegate
            {
                GIT.Btn_2();
            };
            btn3.Click += delegate
            {
                GIT.Btn_3();
            };
            btn4.Click += delegate
            {
                GIT.Btn_4();
            };
            btn5.Click += delegate
            {
                GIT.Btn_5();
            };
            btn6.Click += delegate
            {
                GIT.Btn_6();
            };
            btn7.Click += delegate
            {
                GIT.Btn_7();
            };
            btn8.Click += delegate
            {
                GIT.Btn_8();
            };
            download1.Click += delegate
            {
                GIT.Download_1();
            };
            download2.Click += delegate
            {
                GIT.Download_2();
            };
            download3.Click += delegate
            {
                GIT.Download_3();
            };
            download4.Click += delegate
            {
                GIT.Download_4();
            };
            download5.Click += delegate
            {
                GIT.Download_5();
            };
            download6.Click += delegate
            {
                GIT.Download_6();
            };
            download7.Click += delegate
            {
                GIT.Download_7();
            };
            download8.Click += delegate
            {
                GIT.Download_8();
            };

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