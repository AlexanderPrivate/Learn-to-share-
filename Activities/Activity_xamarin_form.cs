using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Views;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;
using LearnToShare.Adapters;
using LearnToShare.Classes;
using LearnToShare.html;
using LearnToShare.ModelBuilder;
using LearnToShare.xamarin_android;

namespace LearnToShare.Activities
{
    [Activity(Label = "Activity_htmlcss")]
    public class Activity_xamarin_form : AppCompatActivity
    {
        AndroidX.AppCompat.Widget.Toolbar toolbar;
        RecyclerView recycler;
        RecyclerView.LayoutManager layoutManager;
        xamarin_form_adapter adapter;
        List<data> datas = new List<data>();
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

            SetContentView(Resource.Layout.activity_xamarin_form);

            toolbar = (AndroidX.AppCompat.Widget.Toolbar)FindViewById(Resource.Id.toolbar1);

            SetSupportActionBar(toolbar);

            if (themes.ColorNumber == 0 || themes.ColorNumber == 1 || themes.ColorNumber == 4) // ==  "حالت شب "
            {
                toolbar.SetBackgroundResource(Resource.Drawable.toolbar_back_dark);
                toolbar.SetTitleTextColor(Color.White);
            }
            else if (themes.ColorNumber == 2 || themes.ColorNumber == 3 || themes.ColorNumber == 5)  // ==  "حالت روز "
            {
                toolbar.SetBackgroundResource(Resource.Drawable.toolbar_back);
                toolbar.SetTitleTextColor(Color.Black);
            }

            recycler = (RecyclerView)FindViewById(Resource.Id.recyclerView1);


            initdatas();

            layoutManager = new LinearLayoutManager(this);

            recycler.SetLayoutManager(layoutManager);

            adapter = new xamarin_form_adapter(datas);

            recycler.SetAdapter(adapter);
        }
        public void initdatas()
        {
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 1",
                DescriptionID = "توضیحات در مورد زامارین فرم"
            });

            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 2",
                DescriptionID = "راهندازی سیستم عامل Android"
            });

            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 3",
                DescriptionID = "راهندازی سیستم عامل Ios"
            });

            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 4",
                DescriptionID = "مبحث Xamarin Essentials"
            });

            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 5",
                DescriptionID = "بررسی اتصال به اینترنت"
            });

            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 6",
                DescriptionID = "وضعیت Vibrate گوشی"
            });

            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 7",
                DescriptionID = "ارسال ایمیل در زامارین فرم"
            });

            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 8",
                DescriptionID = "مبحت Battery"
            });

            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 9",
                DescriptionID = "مبحث App Information"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 10",
                DescriptionID = "تکمیل مبحت Xamarin Essentials"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 11",
                DescriptionID = "آخرین مبحث از Xamarin Essentials"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 12",
                DescriptionID = "آشنایی با Xaml"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 13",
                DescriptionID = "Content Page در زامارین فرم"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 14",
                DescriptionID = "Master Detail Page در زامارین فرم"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 15",
                DescriptionID = "Navigation Page در زامارین فرم"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 16",
                DescriptionID = "ادامه مبحث page ها"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 17",
                DescriptionID = "بررسی Slider ها"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 18",
                DescriptionID = "بررسی Layouts"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 19",
                DescriptionID = "آموزش StackLayouts"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 20",
                DescriptionID = "آشنایی با Absolute layouts"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 21",
                DescriptionID = "آشنایی با Relative Layouts"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 22",
                DescriptionID = "آموزش Grids"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 23",
                DescriptionID = "آشنایی با Scroll View"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 24",
                DescriptionID = "نصب و آموزش Sqlite"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 25",
                DescriptionID = "عملیات CRUD"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 26",
                DescriptionID = "نمایش اطلاعات در List View"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 27",
                DescriptionID = "ادامه عملیات CRUD در Xamarin Form"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 28",
                DescriptionID = "تکمیل عملیات CRUD"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 29",
                DescriptionID = "شروع ساخت اپلیکیشن دیوار"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 30",
                DescriptionID = "طراحی صفحه اسپلش اسکرین"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 31",
                DescriptionID = "طراحی صفحه اول اپ دیوار"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 32",
                DescriptionID = "استفاده از Grid ها"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 33",
                DescriptionID = "ایجاد Api"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 34",
                DescriptionID = "تکمیل بخش Api"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 35",
                DescriptionID ="فراخوانی اطلاعات از Api"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 36",
                DescriptionID = "فراخوانی دسته بندی ها"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 37",
                DescriptionID ="نمایش شهر و ..."
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 38",
                DescriptionID = "صفحه جزئیات آگهی"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 39",
                DescriptionID = "نمایش شماره آگهی دهنده"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 40",
                DescriptionID = "لود تصویر آگهی"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 41",
                DescriptionID = "ادامه بحث نمایش تصاویر"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 42",
                DescriptionID = "ادامه بحث"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 43",
                DescriptionID = "صفحه لاگین"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 44",
                DescriptionID = "کامل کردن طراحی"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_xamarinform,
                TitleID = "درس 45",
                DescriptionID = "تکمیل پروژه"
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