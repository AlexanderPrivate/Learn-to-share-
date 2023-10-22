using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Views;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;
using LearnToShare.Classes;
using LearnToShare.html;
using LearnToShare.ModelBuilder;

namespace LearnToShare.Activities
{
    [Activity(Label = "Activity_htmlcss")]
    public class Activity_htmlcss : AppCompatActivity
    {
        AndroidX.AppCompat.Widget.Toolbar toolbar;
        RecyclerView recycler;
        RecyclerView.LayoutManager layoutManager;
        html_css_adapter adapter;
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

            SetContentView(Resource.Layout.activity_htmlcss);

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

            adapter = new html_css_adapter(datas);

            recycler.SetAdapter(adapter);
        }
        public void initdatas()
        {
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 1",
                DescriptionID = "شروع کد نویسی وب با نوت پد در ویندوز"
            });

            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 2",
                DescriptionID = "نوشتن اولین تگ های طراحی وب"
            });

            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 3",
                DescriptionID = "نوشتن تگ های متنی"
            });

            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 4",
                DescriptionID = "دستور استایل"
            });

            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 5",
                DescriptionID = "کاربرد های تگ span"
            });

            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 6",
                DescriptionID = "قرار دادن لینک در سایت"
            });

            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 7",
                DescriptionID = "مدیریت سایت در دریم ویور"
            });

            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 8",
                DescriptionID = "آشنایی با دستور direction"
            });

            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 9",
                DescriptionID = "ایجاد کردن جدول در سایت"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 10",
                DescriptionID = "ویژگی های یک جدول"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 11",
                DescriptionID = "ایجاد جداول تو در تو"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 12",
                DescriptionID = "بخش بندی سایت"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 13",
                DescriptionID = "شروع کار با CSS"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 14",
                DescriptionID = "فایل CSS External"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 15",
                DescriptionID = "ویرایش کد های CSS"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 16",
                DescriptionID = "مفهوم Class و Id"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 17",
                DescriptionID = "ویژگی های Float و Clear"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 18",
                DescriptionID = "تنظیم حاشیه ها"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 19",
                DescriptionID = "وارد کردن تصاویر"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 20",
                DescriptionID = "ایجاد Background"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 21",
                DescriptionID = "ایجاد گالری عکس"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 22",
                DescriptionID = "2 ایجاد گالری عکس"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 23",
                DescriptionID = "3 ایجاد گالری عکس"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 24",
                DescriptionID = "آموزش وسط چین کردن"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 25",
                DescriptionID = "آموزش ایجاد List"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 26",
                DescriptionID = "ایجاد منو برای سایت 1"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 27",
                DescriptionID = "ایجاد منو برای سایت 2"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 28",
                DescriptionID = "ایجاد منو برای سایت 3"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 29",
                DescriptionID = "ایجاد منو برای سایت 4"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 30",
                DescriptionID = "ایجاد منو برای سایت 5"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 31",
                DescriptionID = "ایجاد کردن Iframe"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 32",
                DescriptionID = "ایجاد کردن Form"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 33",
                DescriptionID = "ایجاد کردن Form 2"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 34",
                DescriptionID = "ایجاد کردن Form 3"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 35",
                DescriptionID = "ایجاد انواع Buttons"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 36",
                DescriptionID = "دیگر Inputs"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 37",
                DescriptionID = "تگ Select"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 38",
                DescriptionID = "پخش فایل های مالتی پدیا"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 39",
                DescriptionID = "آموزش Transform"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 40",
                DescriptionID = "ترکیب رنگ ها"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 41",
                DescriptionID = "گرادیان"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 42",
                DescriptionID = "ایجاد سایه"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 43",
                DescriptionID = "فونت های سفارشی"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 44",
                DescriptionID = "شماره گذاری صفحات"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 45",
                DescriptionID = "ستون بندی"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 46",
                DescriptionID = "صفحات رسپانسیو"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 47",
                DescriptionID = "افکت گذاری"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 48",
                DescriptionID = "پوشش تصویر"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 49",
                DescriptionID = "مهم ترین تگ های Head"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_htmlcss,
                TitleID = "درس 50",
                DescriptionID = "استفاده از فونت گوگل"
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