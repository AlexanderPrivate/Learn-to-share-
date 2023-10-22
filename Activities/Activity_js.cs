using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Views;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;
using LearnToShare.Classes;
using LearnToShare.javascript;
using LearnToShare.ModelBuilder;

namespace LearnToShare.Activities
{
    [Activity(Label = "Activity_htmlcss")]
    public class Activity_js : AppCompatActivity
    {
        AndroidX.AppCompat.Widget.Toolbar toolbar;
        RecyclerView recycler;
        RecyclerView.LayoutManager layoutManager;
        java_script_adapter adapter;
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

            SetContentView(Resource.Layout.activity_js);

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

            adapter = new java_script_adapter(datas);

            recycler.SetAdapter(adapter);
        }
        public void initdatas()
        {
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 1",
                DescriptionID = "معرفی مدرس و نحوه تدریس"
            });

            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 2",
                DescriptionID = "راهندازی محیط توسعه"
            });

            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 3",
                DescriptionID = "جاوا اسکریپت در مرورگر"
            });

            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 4",
                DescriptionID = "جدا سازی فایل ها"
            });

            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 5",
                DescriptionID = "جاوا اسکریپت در Node.js"
            });

            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 6",
                DescriptionID = "متغیر ها"
            });

            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 7",
                DescriptionID = "ثابت ها"
            });

            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 8",
                DescriptionID = "داده های نوع اولیه"
            });

            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 9",
                DescriptionID = "داده های پویا"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 10",
                DescriptionID = "آبجکت ها"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 11",
                DescriptionID = "آرایه ها"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 12",
                DescriptionID = "فانکشن ها"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 13",
                DescriptionID = "انواع توابع"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 14",
                DescriptionID = "عملگر ها"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 15",
                DescriptionID = "عملگر های محاسباتی"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 16",
                DescriptionID = "عملگر های تخصیصی"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 17",
                DescriptionID = "عملگر های مقایسه ای"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 18",
                DescriptionID = "عملگر های سه جانبه"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 19",
                DescriptionID = "عملگر های منطقی"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 20",
                DescriptionID = "الویت عملگر ها"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 21",
                DescriptionID = "عبارت شرطی if else"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 22",
                DescriptionID = "عبارت شرطی تو در تو"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 23",
                DescriptionID = "عبارت شرطی switch case"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 24",
                DescriptionID = "حلقه for"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 25",
                DescriptionID = "for in .."
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 26",
                DescriptionID = "حلقه while"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 27",
                DescriptionID = "حلقه do - while"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 28",
                DescriptionID = "آموزش Break و Continue"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 29",
                DescriptionID = "آموزش Object Basics"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 30",
                DescriptionID = "نحوه ساختن یک شی"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 31",
                DescriptionID = "دسترسی و ارث بری اشیا"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 32",
                DescriptionID = "پاک کردن Property"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 33",
                DescriptionID ="تست اشیا"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 34",
                DescriptionID = "آموزش  - Enumerating Objects"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 35",
                DescriptionID ="آموزش Setter و Getter"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 36",
                DescriptionID = "گسترش اشیا Extending Objects"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 37",
                DescriptionID = "Extended Object Literal Syntax"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 38",
                DescriptionID = "ساخت آرایه create arrays"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 39",
                DescriptionID = "خواندن و نوشتن المان‌های آرایه"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 40",
                DescriptionID = "آرایه های sparse و متد length"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 41",
                DescriptionID = "پاک کردن و اضافه کردن المان‌ها"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 42",
                DescriptionID = "Iterating Array"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 43",
                DescriptionID = "متدهای آرایه - array methods"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 44",
                DescriptionID = "تعریف تابع Defining Function"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 45",
                DescriptionID = "مفهوم Hoisting"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 46",
                DescriptionID = "Function Argument and Parameters"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 47",
                DescriptionID = "Namespace in javascript"
            });
            datas.Add(new data()
            {
                ImageID = Resource.Drawable.image_javascript,
                TitleID = "درس 48",
                DescriptionID = "Closures"
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