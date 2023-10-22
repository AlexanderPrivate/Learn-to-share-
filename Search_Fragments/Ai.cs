using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.CardView.Widget;
using Google.Android.Material.Button;
using System;
using System.Collections.Generic;

namespace LearnToShare.Search_Fragments
{
    [Obsolete]
    public class Ai : Fragment
    {
        View This_View;

        MaterialButton btn1;

        [Obsolete]
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }
        [Obsolete]
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            This_View = inflater.Inflate(Resource.Layout.fragment_ai_search, container, false);


            btn1 = (MaterialButton)This_View.FindViewById(Resource.Id.materialButton1);


            List<CardView> ModeCards = new List<CardView>()
            {
                (CardView)This_View.FindViewById(Resource.Id.ModeCard1),
            };


            List<TextView> texts_medium = new List<TextView>()
            {
                     (TextView)This_View.FindViewById(Resource.Id.textView2),
            };


            foreach (var text in texts_medium)
            {
                text.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Normal);
            }
            List<TextView> texts_bold = new List<TextView>()
            {
                  (TextView)This_View.FindViewById(Resource.Id.textView1),
            };

            foreach (var text in texts_bold)
            {
                text.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Bold);
            }

            List<MaterialButton> buttons = new List<MaterialButton>()
            {
               (MaterialButton)This_View.FindViewById(Resource.Id.materialButton1),
            };


            foreach (var button in buttons)
            {
                button.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Bold);
            }

            List<CardView> Cards = new List<CardView>
            {
                (CardView)This_View.FindViewById(Resource.Id.cardView1),
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

            btn1.Click += Btn1_Click;


            return This_View;
        }
    

        private void Btn1_Click(object sender, EventArgs e)
        {
            Intent Ai = new Intent(This_View.Context, typeof(Activities.Activity_ai));
            StartActivity(Ai);
        }
    }
}