using Android.App;
using Android.Content.Res;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.CardView.Widget;
using Google.Android.Material.Button;
using LearnToShare.Classes;
using System;
using System.Collections.Generic;
using System.IO;

namespace LearnToShare.Search_Fragments
{
    [Obsolete]
    public class detail_Dialog_Fragment : DialogFragment
    {
        [Obsolete]
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View This_View = inflater.Inflate(Resource.Layout.fragment_improvements, container, false);

            RelativeLayout relative = (RelativeLayout)This_View.FindViewById(Resource.Id.relativeLayout1);
            MaterialButton material = (MaterialButton)This_View.FindViewById(Resource.Id.materialButton1);

            material.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Bold);

            TextView txt_6 = (TextView)This_View.FindViewById(Resource.Id.Version_6);
            TextView txt_5 = (TextView)This_View.FindViewById(Resource.Id.Version_5);
            TextView txt_4 = (TextView)This_View.FindViewById(Resource.Id.Version_4);
            TextView txt_3 = (TextView)This_View.FindViewById(Resource.Id.Version_3);
            TextView txt_2 = (TextView)This_View.FindViewById(Resource.Id.Version_2);
            TextView txt_1 = (TextView)This_View.FindViewById(Resource.Id.Version_1);
          
            TextView Title = (TextView)This_View.FindViewById(Resource.Id.textView1);

            Title.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Bold);

            CardView CardTitle = (CardView)This_View.FindViewById(Resource.Id.view1);
            CardView CardTitle2 = (CardView)This_View.FindViewById(Resource.Id.view2);

            List<CardView> cards = new List<CardView>
            {
                (CardView)This_View.FindViewById(Resource.Id.MyCard1),
                (CardView)This_View.FindViewById(Resource.Id.MyCard2),
                (CardView)This_View.FindViewById(Resource.Id.MyCard3),
                (CardView)This_View.FindViewById(Resource.Id.MyCard4),
                (CardView)This_View.FindViewById(Resource.Id.MyCard5),
                (CardView)This_View.FindViewById(Resource.Id.MyCard6),
            };

            List<TextView> texts = new List<TextView>
            {
                (TextView)This_View.FindViewById(Resource.Id.Version_1),
                (TextView)This_View.FindViewById(Resource.Id.Version_2),
                (TextView)This_View.FindViewById(Resource.Id.Version_3),
                (TextView)This_View.FindViewById(Resource.Id.Version_4),
                (TextView)This_View.FindViewById(Resource.Id.Version_5),
                (TextView)This_View.FindViewById(Resource.Id.Version_6),
            };

            List<TextView> BoldTexts = new List<TextView>
            {
                (TextView)This_View.FindViewById(Resource.Id.textView2),
                (TextView)This_View.FindViewById(Resource.Id.textView3),
                (TextView)This_View.FindViewById(Resource.Id.textView4),
                (TextView)This_View.FindViewById(Resource.Id.textView5),
                (TextView)This_View.FindViewById(Resource.Id.textView6),
                (TextView)This_View.FindViewById(Resource.Id.textView7),
            };

            foreach(var b in BoldTexts)
            {
                b.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Bold);
            }

            foreach (var i in texts)
            {
                i.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Normal);
            }

            AssetManager assetManager = This_View.Context.Assets;

            using (StreamReader streamReader = new StreamReader(assetManager.Open("info_version_6.txt")))
            {
                string content = streamReader.ReadToEnd();
                txt_6.Text = content;
            }

            using (StreamReader streamReader = new StreamReader(assetManager.Open("info_version_5.txt")))
            {
                string content = streamReader.ReadToEnd();
                txt_5.Text = content;
            }
            using (StreamReader streamReader = new StreamReader(assetManager.Open("info_version_4.txt")))
            {
                string content = streamReader.ReadToEnd();
                txt_4.Text = content;
            }
            using (StreamReader streamReader = new StreamReader(assetManager.Open("info_version_3.txt")))
            {
                string content = streamReader.ReadToEnd();
                txt_3.Text = content;
            }
            using (StreamReader streamReader = new StreamReader(assetManager.Open("info_version_2.txt")))
            {
                string content = streamReader.ReadToEnd();
                txt_2.Text = content;
            }
            using (StreamReader streamReader = new StreamReader(assetManager.Open("info_version_1.txt")))
            {
                string content = streamReader.ReadToEnd();
                txt_1.Text = content;
            }

            if (themes.ColorNumber == 0 || themes.ColorNumber == 1 || themes.ColorNumber == 4) // 0 ==  "حالت شب "
            {
                Title.SetTextColor(Color.White);
                foreach (var card in cards)
                {
                    card.SetCardBackgroundColor(Color.Rgb(30, 30, 30));
                    CardTitle.SetCardBackgroundColor(Color.Rgb(20, 20, 20));
                    CardTitle2.SetCardBackgroundColor(Color.Rgb(20, 20, 20));
                    relative.SetBackgroundColor(Color.Rgb(15,15,15));
                }
            }
            else if (themes.ColorNumber == 2 || themes.ColorNumber == 3 || themes.ColorNumber == 5)  // 2 ==    "حالت روز "
            {
                Title.SetTextColor(Color.Black);
                foreach (var card in cards)
                {
                    card.SetCardBackgroundColor(Color.White);
                    CardTitle.SetCardBackgroundColor(Color.White);
                    CardTitle2.SetCardBackgroundColor(Color.White);
                    relative.SetBackgroundColor(Color.White);
                }
            }

            material.Click += Material_Click;

            return This_View;
        }

        private void Material_Click(object sender, EventArgs e)
        {
            Activity_main.MyEditor.PutBoolean("Dialog", false);
            Activity_main.MyEditor.Apply();
            Dismiss();
        }
    }
}