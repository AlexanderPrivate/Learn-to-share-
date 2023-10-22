using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.CardView.Widget;
using AndroidX.RecyclerView.Widget;
using Google.Android.Material.Button;
using LearnToShare.Classes;
using LearnToShare.ModelBuilder;
using LearnToShare.MVVM;

namespace LearnToShare.javascript
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
    public class java_script_adapter : RecyclerView.Adapter
    {
        List<data> datas;
        public java_script_adapter(List<data> datas)
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

            holder.IsRecyclable = false;

            switch (position)
            {
                case 0:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_1();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_1();
                    };
                    break;
                case 1:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_2();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_2();
                    };
                    break;
                case 2:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_3();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_3();
                    };
                    break;
                case 3:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_4();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_4();
                    };
                    break;
                case 4:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_5();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_5();
                    };
                    break;
                case 5:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_6();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_6();
                    };
                    break;
                case 6:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_7();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_7();
                    };
                    break;
                case 7:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_8();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_8();
                    };
                    break;
                case 8:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_9();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_8();
                    };
                    break;
                case 9:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_10();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_10();
                    };
                    break;
                case 10:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_11();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_11();
                    };
                    break;
                case 11:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_12();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_12();
                    };
                    break;
                case 12:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_13();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_13();
                    };
                    break;
                case 13:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_14();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_14();
                    };
                    break;
                case 14:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_15();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_15();
                    };
                    break;
                case 15:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_16();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_16();
                    };
                    break;
                case 16:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_16();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_16();
                    };
                    break;
                case 17:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_18();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_18();
                    };
                    break;
                case 18:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_19();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_19();
                    };
                    break;
                case 19:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_20();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_20();
                    };
                    break;
                case 20:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_21();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_21();
                    };
                    break;
                case 21:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_22();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_21();
                    };
                    break;
                case 22:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_23();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_23();
                    };
                    break;
                case 23:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_24();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_24();
                    };
                    break;
                case 24:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_25();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_25();
                    };
                    break;
                case 25:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_26();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_26();
                    };
                    break;
                case 26:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_27();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_27();
                    };
                    break;
                case 27:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_28();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_28();
                    };
                    break;
                case 28:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_29();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_29();
                    };
                    break;
                case 29:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_30();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_30();
                    };
                    break;
                case 30:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_31();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_31();
                    };
                    break;
                case 31:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_32();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_32();
                    };
                    break;
                case 32:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_33();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_33();
                    };
                    break;
                case 33:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_34();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_34();
                    };
                    break;
                case 34:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_35();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_35();
                    };
                    break;
                case 35:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_36();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_36();
                    };
                    break;
                case 36:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_37();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_37();
                    };
                    break;
                case 37:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_38();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_38();
                    };
                    break;
                case 38:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_39();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_39();
                    };
                    break;
                case 39:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_40();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_40();
                    };
                    break;
                case 40:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_41();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_41();
                    };
                    break;
                case 41:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_42();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_42();
                    };
                    break;
                case 42:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_43();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_43();
                    };
                    break;
                case 43:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_44();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_44();
                    };
                    break;
                case 44:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_45();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_45();
                    };
                    break;
                case 45:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_46();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_46();
                    };
                    break;
                case 46:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_47();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_47();
                    };
                    break;
                case 47:
                    recycle.btn_Show.Click += delegate
                    {
                        Java_Script.Btn_48();
                    };
                    recycle.btn_Download.Click += delegate
                    {
                        Java_Script.Download_48();
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