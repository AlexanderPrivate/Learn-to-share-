using System.Collections.Generic;
using Android.Graphics;
using Android.Views;
using Android.Widget;
using AndroidX.CardView.Widget;
using AndroidX.RecyclerView.Widget;
using Google.Android.Material.Button;
using LearnToShare.Classes;
using LearnToShare.ModelBuilder;
using LearnToShare.MVVM;

namespace LearnToShare.xamarin_android
{
    public class RecycleViewHolder : RecyclerView.ViewHolder
    {
        public ImageView ImageView { get; set; }
        public TextView TextTitle { get; set; }
        public TextView TextDescreption { get; set; }
        public MaterialButton btn_Show { get; set; }
        public MaterialButton btn_Download { get; set; }
        public CardView Cards { get; set; }
        public RecycleViewHolder(View ItemView) : base(ItemView)
        {
            ImageView = (ImageView)ItemView.FindViewById(Resource.Id.imageView1);
            TextTitle = (TextView)ItemView.FindViewById(Resource.Id.textTitle);
            TextDescreption = (TextView)ItemView.FindViewById(Resource.Id.textDescreption);
            btn_Show = (MaterialButton)ItemView.FindViewById(Resource.Id.showbutton);
            btn_Download = (MaterialButton)ItemView.FindViewById(Resource.Id.downloadbutton);
            Cards = (CardView)ItemView.FindViewById(Resource.Id.cardView1);

            TextTitle.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Bold);
            btn_Show.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Bold);
            btn_Download.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Bold);

            if (themes.ColorNumber == 0 || themes.ColorNumber == 1 || themes.ColorNumber == 4) // ==  "حالت شب "
            {
                TextTitle.SetTextColor(Color.White);
                TextDescreption.SetTextColor(Color.Rgb(240, 240, 240));
                Cards.SetCardBackgroundColor(Color.Rgb(30, 30, 30));
            }
            else if (themes.ColorNumber == 2 || themes.ColorNumber == 3 || themes.ColorNumber == 5)  // ==  "حالت روز "
            {
                TextTitle.SetTextColor(Color.Black);
                TextDescreption.SetTextColor(Color.Rgb(40, 40, 40));
                Cards.SetCardBackgroundColor(Color.White);
            }

        }
    }
    public class xamarin_android_adapter : RecyclerView.Adapter
    {
        List<data> datas;
        public xamarin_android_adapter(List<data> datas)
        {
            this.datas = datas;
        }

        public override int ItemCount
        {
            get { return datas.Count; }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            RecycleViewHolder recycle = holder as RecycleViewHolder;
            recycle.ImageView.SetImageResource(datas[position].ImageID);
            recycle.TextTitle.Text = datas[position].TitleID;
            recycle.TextDescreption.Text = datas[position].DescriptionID;

            switch (position)
            {
                case 0:
                    recycle.btn_Show.Click += delegate
                    {
                        Xamarin_Android.Btn_1();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Xamarin_Android.Download_1();
                    };
                    break;
                case 1:
                    recycle.btn_Show.Click += delegate
                    {
                        Xamarin_Android.Btn_2();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Xamarin_Android.Download_2();
                    };
                    break;
                case 2:
                    recycle.btn_Show.Click += delegate
                    {
                        Xamarin_Android.Btn_3();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Xamarin_Android.Download_3();
                    };
                    break;
            }
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            LayoutInflater inflater = LayoutInflater.From(parent.Context);
            var inflate = inflater.Inflate(Resource.Layout.item, parent, false);
            return new RecycleViewHolder(inflate);
        }
    }
}