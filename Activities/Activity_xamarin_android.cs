using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Views;
using AndroidX.AppCompat.App;
using AndroidX.CardView.Widget;
using AndroidX.RecyclerView.Widget;
using LearnToShare.Classes;
using LearnToShare.ModelBuilder;
using LearnToShare.xamarin_android;

namespace LearnToShare.Activities
{
    [Activity(Label = "Xamarin android")]
    public class Activity_xamarin_android : AppCompatActivity
    {
        AndroidX.AppCompat.Widget.Toolbar toolbar;
        RecyclerView recycler;
        RecyclerView.LayoutManager layoutManager;
        xamarin_android_adapter adapter;
        List<data> datas = new List<data>();
        CardView card;
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

            SetContentView(Resource.Layout.activity_xamarinandroid);

            toolbar = (AndroidX.AppCompat.Widget.Toolbar)FindViewById(Resource.Id.toolbar1);
            card = (CardView)FindViewById(Resource.Id.cardView1);

            SetSupportActionBar(toolbar);

            if (themes.ColorNumber == 0 || themes.ColorNumber == 1 || themes.ColorNumber == 4) // ==  "حالت شب "
            {
                toolbar.SetBackgroundResource(Resource.Drawable.toolbar_back_dark);
                toolbar.SetTitleTextColor(Color.White);
                card.SetCardBackgroundColor(Color.Rgb(30,30,30));
            }
            else if (themes.ColorNumber == 2 || themes.ColorNumber == 3 || themes.ColorNumber == 5)  // ==  "حالت روز "
            {
                toolbar.SetBackgroundResource(Resource.Drawable.toolbar_back);
                toolbar.SetTitleTextColor(Color.Black);
                card.SetCardBackgroundColor(Color.Rgb(255, 255, 255));
            }

            recycler = (RecyclerView)FindViewById(Resource.Id.recyclerView1);


            initdatas();

            layoutManager = new LinearLayoutManager(this);

            recycler.SetLayoutManager(layoutManager);

            adapter = new xamarin_android_adapter(datas);

            recycler.SetAdapter(adapter);
        }
        public void initdatas()
        {
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinandroid,
                TitleID = "درس 1",
                DescriptionID = "آشنایی با solution و Button"
            });

            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinandroid,
                TitleID = "درس 2",
                DescriptionID = "مبحث TextView و Gravity"
            });

            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinandroid,
                TitleID = "درس 3",
                DescriptionID = "مبحث EditText ساخت فرم ثبت نام"
            });

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