using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.CardView.Widget;
using Google.Android.Material.Button;
using LearnToShare.Activities;
using System;
using System.Collections.Generic;

namespace LearnToShare.Fragments
{
    [Obsolete]
    public class Fragment_courses : Fragment
    {
        View This_View;

        MaterialButton btn2, btn3, btn4, btn5,
            btn6, btn7, btn8, btn10, btn13 ,btn16,btn17,btn18,btn19,
            btn20;

        LinearLayout linear;


        [Obsolete]
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

        }
        [Obsolete]
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            This_View = inflater.Inflate(Resource.Layout.fragment_courses, container, false);
            linear = (LinearLayout)This_View.FindViewById(Resource.Id.mylinear);

            linear.Animate().Alpha(1f).SetDuration(600).Start();


            btn2 = (MaterialButton)This_View.FindViewById(Resource.Id.materialButton2);
            btn3 = (MaterialButton)This_View.FindViewById(Resource.Id.materialButton3);
            btn4 = (MaterialButton)This_View.FindViewById(Resource.Id.materialButton4);
            btn5 = (MaterialButton)This_View.FindViewById(Resource.Id.materialButton5);
            btn6 = (MaterialButton)This_View.FindViewById(Resource.Id.materialButton6);
            btn7 = (MaterialButton)This_View.FindViewById(Resource.Id.materialButton7);
            btn8 = (MaterialButton)This_View.FindViewById(Resource.Id.materialButton8);
            btn10 = (MaterialButton)This_View.FindViewById(Resource.Id.materialButton10);
            btn13 = (MaterialButton)This_View.FindViewById(Resource.Id.materialButton13);
            btn16 = (MaterialButton)This_View.FindViewById(Resource.Id.materialButton16);
            btn17 = (MaterialButton)This_View.FindViewById(Resource.Id.materialButton17);
            btn18 = (MaterialButton)This_View.FindViewById(Resource.Id.materialButton18);
            btn19 = (MaterialButton)This_View.FindViewById(Resource.Id.materialButton19);
            btn20 = (MaterialButton)This_View.FindViewById(Resource.Id.materialButton20);

            List<CardView> ModeCards = new List<CardView>()
            {
                (CardView)This_View.FindViewById(Resource.Id.ModeCard2),
                (CardView)This_View.FindViewById(Resource.Id.ModeCard3),
                (CardView)This_View.FindViewById(Resource.Id.ModeCard4),
                (CardView)This_View.FindViewById(Resource.Id.ModeCard5),
                (CardView)This_View.FindViewById(Resource.Id.ModeCard6),
                (CardView)This_View.FindViewById(Resource.Id.ModeCard7),
                (CardView)This_View.FindViewById(Resource.Id.ModeCard8),
                (CardView)This_View.FindViewById(Resource.Id.ModeCard10),
                (CardView)This_View.FindViewById(Resource.Id.ModeCard13),
                (CardView)This_View.FindViewById(Resource.Id.ModeCard16),
                (CardView)This_View.FindViewById(Resource.Id.ModeCard17),
                (CardView)This_View.FindViewById(Resource.Id.ModeCard18),
                (CardView)This_View.FindViewById(Resource.Id.ModeCard19),
                (CardView)This_View.FindViewById(Resource.Id.ModeCard20),
            };

            List<TextView> texts_medium = new List<TextView>()
            {
               (TextView)This_View.FindViewById(Resource.Id.textView4),
               (TextView)This_View.FindViewById(Resource.Id.textView6),
               (TextView)This_View.FindViewById(Resource.Id.textView8),
               (TextView)This_View.FindViewById(Resource.Id.textView10),
               (TextView)This_View.FindViewById(Resource.Id.textView12),
               (TextView)This_View.FindViewById(Resource.Id.textView14),
               (TextView)This_View.FindViewById(Resource.Id.textView16),
               (TextView)This_View.FindViewById(Resource.Id.textView20),
               (TextView)This_View.FindViewById(Resource.Id.textView24),
               (TextView)This_View.FindViewById(Resource.Id.textView30),
               (TextView)This_View.FindViewById(Resource.Id.textView32),
               (TextView)This_View.FindViewById(Resource.Id.textView34),
               (TextView)This_View.FindViewById(Resource.Id.textView36),
               (TextView)This_View.FindViewById(Resource.Id.textView38)
            };


            foreach (var text in texts_medium)
            {
                text.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Normal);
            }
            List<TextView> texts_bold = new List<TextView>()
            {
               (TextView)This_View.FindViewById(Resource.Id.textView3),
               (TextView)This_View.FindViewById(Resource.Id.textView5),
               (TextView)This_View.FindViewById(Resource.Id.textView7),
               (TextView)This_View.FindViewById(Resource.Id.textView9),
               (TextView)This_View.FindViewById(Resource.Id.textView11),
               (TextView)This_View.FindViewById(Resource.Id.textView13),
               (TextView)This_View.FindViewById(Resource.Id.textView15),
               (TextView)This_View.FindViewById(Resource.Id.textView19),
               (TextView)This_View.FindViewById(Resource.Id.textView23),
               (TextView)This_View.FindViewById(Resource.Id.textView29),
               (TextView)This_View.FindViewById(Resource.Id.textView31),
               (TextView)This_View.FindViewById(Resource.Id.textView33),
               (TextView)This_View.FindViewById(Resource.Id.textView35),
               (TextView)This_View.FindViewById(Resource.Id.textView37),
           };
            foreach (var text in texts_bold)
            {
                text.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Bold);
            }

            List<MaterialButton> buttons = new List<MaterialButton>()
            {
               (MaterialButton)This_View.FindViewById(Resource.Id.materialButton2),
               (MaterialButton)This_View.FindViewById(Resource.Id.materialButton3),
               (MaterialButton)This_View.FindViewById(Resource.Id.materialButton4),
               (MaterialButton)This_View.FindViewById(Resource.Id.materialButton5),
               (MaterialButton)This_View.FindViewById(Resource.Id.materialButton6),
               (MaterialButton)This_View.FindViewById(Resource.Id.materialButton7),
               (MaterialButton)This_View.FindViewById(Resource.Id.materialButton8),
               (MaterialButton)This_View.FindViewById(Resource.Id.materialButton10),
               (MaterialButton)This_View.FindViewById(Resource.Id.materialButton16),
               (MaterialButton)This_View.FindViewById(Resource.Id.materialButton17),
               (MaterialButton)This_View.FindViewById(Resource.Id.materialButton18),
               (MaterialButton)This_View.FindViewById(Resource.Id.materialButton19),
               (MaterialButton)This_View.FindViewById(Resource.Id.materialButton20),
           };

            foreach (var button in buttons)
            {
                button.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Bold);
            }

            List<CardView> Cards = new List<CardView>
            {
                (CardView)This_View.FindViewById(Resource.Id.cardView2),
                (CardView)This_View.FindViewById(Resource.Id.cardView3),
                (CardView)This_View.FindViewById(Resource.Id.cardView4),
                (CardView)This_View.FindViewById(Resource.Id.cardView5),
                (CardView)This_View.FindViewById(Resource.Id.cardView6),
                (CardView)This_View.FindViewById(Resource.Id.cardView7),
                (CardView)This_View.FindViewById(Resource.Id.cardView8),
                (CardView)This_View.FindViewById(Resource.Id.cardView10),
                (CardView)This_View.FindViewById(Resource.Id.cardView13),
                (CardView)This_View.FindViewById(Resource.Id.cardView16),
                (CardView)This_View.FindViewById(Resource.Id.cardView17),
                (CardView)This_View.FindViewById(Resource.Id.cardView18),
                (CardView)This_View.FindViewById(Resource.Id.cardView19),
                (CardView)This_View.FindViewById(Resource.Id.cardView20),
            };

            if (Activity_main.theme_number == 0) // 0 ==  "حالت شب با رنگ آبی"
            {
                foreach (var txt in texts_bold)
                {
                    txt.SetTextColor(Color.White);
                }
                foreach (var card in Cards)
                {
                    card.SetCardBackgroundColor(Color.Rgb(30, 30, 30));
                }
                foreach (var txt in texts_medium)
                {
                    txt.SetTextColor(Color.Rgb(240, 240, 240));
                }
                foreach (var mode in ModeCards)
                {
                    mode.SetCardBackgroundColor(Color.ParseColor("#009dff"));
                }
            }
            else if (Activity_main.theme_number == 1)  // 1 ==   "حالت شب با رنگ خاکستری" 
            {
                foreach (var txt in texts_bold)
                {
                    txt.SetTextColor(Color.White);
                }
                foreach (var card in Cards)
                {
                    card.SetCardBackgroundColor(Color.Rgb(30, 30, 30));
                }
                foreach (var txt in texts_medium)
                {
                    txt.SetTextColor(Color.Rgb(240, 240, 240));
                }
                foreach (var mode in ModeCards)
                {
                    mode.SetCardBackgroundColor(Color.White);
                }
            }
            else if (Activity_main.theme_number == 2)  // 2 ==    "حالت روز با رنگ آبی"
            {
                foreach (var txt in texts_bold)
                {
                    txt.SetTextColor(Color.Black);
                }
                foreach (var card in Cards)
                {
                    card.SetCardBackgroundColor(Color.White);
                }
                foreach (var txt in texts_medium)
                {
                    txt.SetTextColor(Color.Rgb(30, 30, 30));
                }
                foreach (var mode in ModeCards)
                {
                    mode.SetCardBackgroundColor(Color.ParseColor("#009dff"));
                }
            }
            else if (Activity_main.theme_number == 3) // 3 ==     "حالت روز با خاکستری"
            {
                foreach (var txt in texts_bold)
                {
                    txt.SetTextColor(Color.Black);
                }
                foreach (var card in Cards)
                {
                    card.SetCardBackgroundColor(Color.White);
                }
                foreach (var txt in texts_medium)
                {
                    txt.SetTextColor(Color.Rgb(30, 30, 30));
                }
                foreach (var mode in ModeCards)
                {
                    mode.SetCardBackgroundColor(Color.ParseColor("#141414"));
                }
            }
            else if (Activity_main.theme_number == 4) // 4 ==     "حالت شب با رنگ آپارات"
            {
                foreach (var txt in texts_bold)
                {
                    txt.SetTextColor(Color.White);
                }
                foreach (var card in Cards)
                {
                    card.SetCardBackgroundColor(Color.Rgb(30, 30, 30));
                }
                foreach (var txt in texts_medium)
                {
                    txt.SetTextColor(Color.Rgb(240, 240, 240));
                }
                foreach (var mode in ModeCards)
                {
                    mode.SetCardBackgroundColor(Color.ParseColor("#ED145B"));
                }
            }
            else if (Activity_main.theme_number == 5) // 5 ==     "حالت روز با رنگ آپارات"
            {
                foreach (var txt in texts_bold)
                {
                    txt.SetTextColor(Color.Black);
                }
                foreach (var card in Cards)
                {
                    card.SetCardBackgroundColor(Color.White);
                }
                foreach (var txt in texts_medium)
                {
                    txt.SetTextColor(Color.Rgb(30, 30, 30));
                }
                foreach (var mode in ModeCards)
                {
                    mode.SetCardBackgroundColor(Color.ParseColor("#ED145B"));
                }
            }



            btn2.Click += vsCodeLearn;
            btn3.Click += AideLearn;
            btn4.Click += materialLearn;
            btn5.Click += AlgoritmLearn;
            btn6.Click += csharpLearn;
            btn7.Click += JAVAlEARN;
            btn8.Click += winformLearn;
            btn13.Click += python_1;
            btn10.Click += Ai_click;
            btn16.Click += htmlcss;
            btn17.Click += XamarinForm;
            btn18.Click += js;
            btn19.Click += xamarin_android;
            btn20.Click += git;

            return This_View;
        }

        private void git(object sender, EventArgs e)
        {
            Intent git = new Intent(This_View.Context, typeof(Activity_git));
            StartActivity(git);
        }

        private void xamarin_android(object sender, EventArgs e)
        {
            Intent xamarin_android = new Intent(This_View.Context, typeof(Activity_xamarin_android));
            StartActivity(xamarin_android);
        }

        private void js(object sender, EventArgs e)
        {
            Intent js = new Intent(This_View.Context, typeof(Activity_js));
            StartActivity(js);
        }

        private void XamarinForm(object sender, EventArgs e)
        {
            Intent XamarinForm = new Intent(This_View.Context, typeof(Activity_xamarin_form));
            StartActivity(XamarinForm);
        }

        private void htmlcss(object sender, EventArgs e)
        {
            Intent htmlcss = new Intent(This_View.Context, typeof(Activity_htmlcss));
            StartActivity(htmlcss);
        }
    

        private void Ai_click(object sender, EventArgs e)
        {
            Intent Ai = new Intent(This_View.Context, typeof(Activity_ai));
            StartActivity(Ai);
        }

   

        private void python_1(object sender, EventArgs e)
        {
            Intent python = new Intent(This_View.Context, typeof(Activity_python));
            StartActivity(python);
        }

        private void winformLearn(object sender, EventArgs e)
        {
            Intent winformGo = new Intent(This_View.Context, typeof(Activity_winform));
            StartActivity(winformGo);
        }

        private void JAVAlEARN(object sender, EventArgs e)
        {
            Intent JavaGo = new Intent(This_View.Context, typeof(Activity_java));
            StartActivity(JavaGo);
        }

        private void csharpLearn(object sender, EventArgs e)
        {
            Intent csharpGo = new Intent(This_View.Context, typeof(Activity_csharp));
            StartActivity(csharpGo);
        }

        private void AlgoritmLearn(object sender, EventArgs e)
        {
            Intent AlgoritmGo = new Intent(This_View.Context, typeof(Activity_algoritm));
            StartActivity(AlgoritmGo);
        }

        private void materialLearn(object sender, EventArgs e)
        {
            Intent materialGo = new Intent(This_View.Context, typeof(Activity_mtandroid));
            StartActivity(materialGo);
        }

        private void AideLearn(object sender, EventArgs e)
        {
            Intent AideGo = new Intent(This_View.Context, typeof(Activity_aide));
            StartActivity(AideGo);
        }

        private void vsCodeLearn(object sender, EventArgs e)
        {
            Intent vsGo = new Intent(This_View.Context, typeof(LearnToShare.Activities.Activity_vscode));
            StartActivity(vsGo);
        }
    }
}