using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using LearnToShare.Fragments;
using Android.Graphics;
using LearnToShare.Classes;
using Android.Content;
using Xamarin.Essentials;
using LearnToShare.Search_Fragments;
using LearnToShare.Activities;
using System;
using AndroidX.CardView.Widget;
using Android.Widget;
using Google.Android.Material.Chip;
using LearnToShare.HelpFragments;
using Android.Content.Res;
using Android.Views;

namespace LearnToShare
{
    [Activity(Label = "@string/app_name", Theme = "@style/LightBlue", MainLauncher = true,
        NoHistory = false)]
    public class Activity_main : AppCompatActivity
    {
        public static Typeface IranSansFont;
        public static ISharedPreferences preferences;
        public static ISharedPreferencesEditor MyEditor;
        public static int theme_number;
        public static bool Dialog, Source_Open, Song_Open;
        CardView card_search;
        ImageView imageView_Search;
        public static Chip Course_chip, Source_chip, Song_chip,Management_chip;
        RelativeLayout SearchBar_Relative;
        TextView textView_search;
        Google.Android.Material.BottomNavigation.BottomNavigationView bottomNavigationView;
        View view;

        [Obsolete]
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Platform.Init(this, savedInstanceState);

            preferences = GetSharedPreferences("Theme", FileCreationMode.Private);
            preferences = GetSharedPreferences("Version3_Notification", FileCreationMode.Private);
            preferences = GetSharedPreferences("Dialog", FileCreationMode.Private);
            preferences = GetSharedPreferences("Source_Open", FileCreationMode.Private);
            preferences = GetSharedPreferences("Song_Open", FileCreationMode.Private);

            MyEditor = preferences.Edit();

            Dialog = preferences.GetBoolean("Dialog", true);
            theme_number = preferences.GetInt("Theme", 2);
            Source_Open = preferences.GetBoolean("Source_Open", true);
            Song_Open = preferences.GetBoolean("Source_Open", true);

            themes.ColorNumber = theme_number;

            if (themes.ColorNumber == 0) // 0 ==  "حالت شب با رنگ آبی"
            {
                SetTheme(Resource.Style.DarkBlue);
            }
            else if (themes.ColorNumber == 1)  // 1 ==   "حالت شب با رنگ خاکستری" 
            {
                SetTheme(Resource.Style.DarkGray);
            }
            else if (themes.ColorNumber == 2)  // 2 ==    "حالت روز با رنگ آبی"
            {
                SetTheme(Resource.Style.LightBlue);
            }
            else if (themes.ColorNumber == 3) // 3 ==     "حالت روز با خاکستری"
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

            SetContentView(Resource.Layout.activity_main);

            IranSansFont = Typeface.CreateFromAsset(Assets, "IRANSans.ttf");

            Course_chip = (Chip)FindViewById(Resource.Id.chip1);
            Source_chip = (Chip)FindViewById(Resource.Id.chip2);
            Song_chip = (Chip)FindViewById(Resource.Id.chip3);
            Management_chip = (Chip)FindViewById(Resource.Id.chip4);
            textView_search = (TextView)FindViewById(Resource.Id.textView_search);
            SearchBar_Relative = (RelativeLayout)FindViewById(Resource.Id.SearchBar_Relative);
            card_search = (CardView)FindViewById(Resource.Id.cardView11);
            imageView_Search = (ImageView)FindViewById(Resource.Id.ImageSearch);
            view = FindViewById(Resource.Id.view1);

            Management_chip.SetTypeface(IranSansFont, TypefaceStyle.Bold);
            Course_chip.SetTypeface(IranSansFont, TypefaceStyle.Bold);
            Source_chip.SetTypeface(IranSansFont, TypefaceStyle.Bold);
            Song_chip.SetTypeface(IranSansFont, TypefaceStyle.Bold);
            textView_search.SetTypeface(IranSansFont, TypefaceStyle.Bold);


            if (Dialog)
            {
                var transaction = FragmentManager.BeginTransaction();
                detail_Dialog_Fragment _Dialog_Fragment = new detail_Dialog_Fragment();
                _Dialog_Fragment.Cancelable = false;
                _Dialog_Fragment.Show(transaction, "");
            }


            bottomNavigationView = (Google.Android.Material.BottomNavigation.BottomNavigationView)
                FindViewById(Resource.Id.bottomNavigationView1);

            if (themes.ColorNumber == 0) // 0 ==   "حالت شب با رنگ آبی"
            {
                Chip_Dark();
                view.SetBackgroundColor(Color.Rgb(40, 40, 40));
                card_search.SetCardBackgroundColor(Color.Rgb(30, 30, 30));
                imageView_Search.SetImageResource(Resource.Drawable.search_darktheme);
                bottomNavigationView.ItemIconTintList = GetColorStateList(Resource.Drawable.bottom_blue);
                bottomNavigationView.ItemTextColor = GetColorStateList(Resource.Drawable.bottom_blue);
                bottomNavigationView.SetBackgroundResource(Resource.Drawable.bottom_radius_dark);
            }
            else if (themes.ColorNumber == 1)  // 1 ==   "حالت شب با رنگ خاکستری" 
            {
                Chip_Dark();
                view.SetBackgroundColor(Color.Rgb(40, 40, 40));
                card_search.SetCardBackgroundColor(Color.Rgb(30, 30, 30));
                imageView_Search.SetImageResource(Resource.Drawable.search_darktheme);
                bottomNavigationView.ItemIconTintList = GetColorStateList(Resource.Drawable.bottom_gray);
                bottomNavigationView.ItemTextColor = GetColorStateList(Resource.Drawable.bottom_gray);
                bottomNavigationView.SetBackgroundResource(Resource.Drawable.bottom_radius_dark);
            }
            else if (themes.ColorNumber == 2)  // 2 ==    "حالت روز با رنگ آبی"
            {
                Chip_Light();
                view.SetBackgroundColor(Color.Rgb(240, 240, 240));
                bottomNavigationView.ItemIconTintList = GetColorStateList(Resource.Drawable.bottom_blue);
                bottomNavigationView.ItemTextColor = GetColorStateList(Resource.Drawable.bottom_blue);
                bottomNavigationView.SetBackgroundResource(Resource.Drawable.bottom_radius);
            }
            else if (themes.ColorNumber == 3) // 3 ==     "حالت روز با خاکستری"
            {
                Chip_Light();
                view.SetBackgroundColor(Color.Rgb(240, 240, 240));
                bottomNavigationView.ItemIconTintList = GetColorStateList(Resource.Drawable.bottom_lightgray_for_light);
                bottomNavigationView.ItemTextColor = GetColorStateList(Resource.Drawable.bottom_lightgray_for_light);
                bottomNavigationView.SetBackgroundResource(Resource.Drawable.bottom_radius);
            }
            else if (themes.ColorNumber == 4)  // 4 ==    "حالت شب با رنگ آپارات"
            {
                Chip_Dark();
                view.SetBackgroundColor(Color.Rgb(40, 40, 40));
                card_search.SetCardBackgroundColor(Color.Rgb(30, 30, 30));
                imageView_Search.SetImageResource(Resource.Drawable.search_darktheme);
                bottomNavigationView.ItemIconTintList = GetColorStateList(Resource.Drawable.bottom_aparat);
                bottomNavigationView.ItemTextColor = GetColorStateList(Resource.Drawable.bottom_aparat);
                bottomNavigationView.SetBackgroundResource(Resource.Drawable.bottom_radius_dark);
            }
            else if (themes.ColorNumber == 5) // 5 ==     "حالت روز با رنگ آپارات"
            {
                Chip_Light();
                view.SetBackgroundColor(Color.Rgb(240, 240, 240));
                bottomNavigationView.ItemIconTintList = GetColorStateList(Resource.Drawable.bottom_aparat);
                bottomNavigationView.ItemTextColor = GetColorStateList(Resource.Drawable.bottom_aparat);
                bottomNavigationView.SetBackgroundResource(Resource.Drawable.bottom_radius);
            }


            bottomNavigationView.NavigationItemSelected += BottomNavigationView_NavigationItemSelected;

            bottomNavigationView.SelectedItemId = Resource.Id.diploma;

            card_search.Click += Card_search_Click;
            Management_chip.Click += Management_chip_Click;
            Course_chip.Click += Course_chip_Click;
            Source_chip.Click += Source_chip_Click;
            Song_chip.Click += Song_chip_Click;
        }
        [Obsolete]
        private void Management_chip_Click(object sender, EventArgs e)
        {
            Management_Chip_Select();
            Fragment fragment = new Fragment_manage();
            var transaction = FragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.frameLayout1, fragment);
            transaction.Commit();
        }

        private void Chip_Light()
        {
            Management_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
            Course_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
            Source_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
            Song_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
        }

        private void Chip_Dark()
        {
            Course_chip.SetTextColor(Color.White);
            Source_chip.SetTextColor(Color.White);
            Song_chip.SetTextColor(Color.White);
            Management_chip.SetTextColor(Color.White);
            Course_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
            Source_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
            Song_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
            Management_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
        }

        [Obsolete]
        private void Song_chip_Click(object sender, EventArgs e)
        {
                bottomNavigationView.Visibility = ViewStates.Visible;
            Song_Chip_Select();
            if (Song_Open)
            {
                Fragment fragment = new Song_Help();
                var transaction = FragmentManager.BeginTransaction();
                transaction.Replace(Resource.Id.frameLayout1, fragment);
                transaction.Commit();
            }
            else
            {

                Fragment fragment = new Fragment_songs();
                var transaction = FragmentManager.BeginTransaction();
                transaction.Replace(Resource.Id.frameLayout1, fragment);
                transaction.Commit();
            }
        }
        [Obsolete]
        private void Source_chip_Click(object sender, EventArgs e)
        {
            bottomNavigationView.Visibility = ViewStates.Gone;
            Source_Chip_Select();
            if (Source_Open)
            {
                Fragment fragment = new Source_Help();
                var transaction = FragmentManager.BeginTransaction();
                transaction.Replace(Resource.Id.frameLayout1, fragment);
                transaction.Commit();
            }
            else
            {

                Fragment fragment = new Fragment_sources();
                var transaction = FragmentManager.BeginTransaction();
                transaction.Replace(Resource.Id.frameLayout1, fragment);
                transaction.Commit();

            }
        }
        [Obsolete]
        private void Course_chip_Click(object sender, EventArgs e)
        {
            bottomNavigationView.Visibility = ViewStates.Visible;
            Course_Chip_Select();
            Fragment fragment = new Fragment_courses();
            var transaction = FragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.frameLayout1, fragment);
            transaction.Commit();
        }


        private void Card_search_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Activity_search));
            StartActivity(intent);
        }

        [Obsolete]
        private void BottomNavigationView_NavigationItemSelected(object sender, Google.Android.Material.BottomNavigation.BottomNavigationView.NavigationItemSelectedEventArgs e)
        {
            Fragment fragment = null;

            switch (e.Item.ItemId)
            {
                case Resource.Id.diploma:
                    Course_Chip_Select();
                    SearchBar_Relative.Visibility = ViewStates.Visible;
                    fragment = new Fragment_courses();
                    break;
                case Resource.Id.ChatGpt:
                    SearchBar_Relative.Visibility = ViewStates.Gone;
                    fragment = new Fragment_chatgpt();
                    break;
                case Resource.Id.setting:
                    SearchBar_Relative.Visibility = ViewStates.Gone;
                    fragment = new Fragment_setting();
                    break;
                case Resource.Id.message:
                    SearchBar_Relative.Visibility = ViewStates.Gone;
                    fragment = new Fragment_messages();
                    break;
                case Resource.Id.cloud:
                    SearchBar_Relative.Visibility = ViewStates.Gone;
                    fragment = new Fragment_cloud();
                    break;

            }
            var transaction = FragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.frameLayout1, fragment);
            transaction.Commit();
        }

        [Obsolete]
        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back && Fragment_sources.web.CanGoBack())
            {
                Fragment_sources.web.GoBack();

                return true;
            }

            return base.OnKeyDown(keyCode, e);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private static void Song_Chip_Select()
        {
            if (themes.ColorNumber == 0) // 0 ==   "حالت شب با رنگ آبی"
            {
                Course_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Source_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Management_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Song_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.ParseColor("#009dff"));

            }
            else if (themes.ColorNumber == 1)  // 1 ==   "حالت شب با رنگ خاکستری" 
            {
                Course_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Source_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Management_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Song_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.ParseColor("#363636"));

            }
            else if (themes.ColorNumber == 2)  // 2 ==    "حالت روز با رنگ آبی"
            {
                Song_chip.SetTextColor(Color.White);
                Course_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Source_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Management_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Course_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Source_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Management_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Song_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.ParseColor("#009dff"));
            }
            else if (themes.ColorNumber == 3) // 3 ==     "حالت روز با خاکستری"
            {
                Song_chip.SetTextColor(Color.White);
                Course_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Source_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Management_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Course_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Source_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Management_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Song_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.ParseColor("#3E3E3E"));
            }
            else if (themes.ColorNumber == 4)  // 4 ==    "حالت شب با رنگ آپارات"
            {
                Course_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Management_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Source_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Song_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.ParseColor("#ED145B"));

            }
            else if (themes.ColorNumber == 5) // 5 ==     "حالت روز با رنگ آپارات"
            {
                Song_chip.SetTextColor(Color.White);
                Course_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Source_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Management_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Course_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Source_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Management_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Song_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.ParseColor("#ED145B"));
            }
        }
        private static void Source_Chip_Select()
        {
            if (themes.ColorNumber == 0) // 0 ==   "حالت شب با رنگ آبی"
            {
                Course_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Song_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Management_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Source_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.ParseColor("#009dff"));

            }
            else if (themes.ColorNumber == 1)  // 1 ==   "حالت شب با رنگ خاکستری" 
            {
                Course_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Song_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Management_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Source_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.ParseColor("#363636"));

            }
            else if (themes.ColorNumber == 2)  // 2 ==    "حالت روز با رنگ آبی"
            {
                Source_chip.SetTextColor(Color.White);
                Course_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Song_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Management_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Course_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Song_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Management_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Source_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.ParseColor("#009dff"));
            }
            else if (themes.ColorNumber == 3) // 3 ==     "حالت روز با خاکستری"
            {
                Source_chip.SetTextColor(Color.White);
                Course_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Song_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Management_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Course_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Song_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Management_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Source_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.ParseColor("#3E3E3E"));
            }
            else if (themes.ColorNumber == 4)  // 4 ==    "حالت شب با رنگ آپارات"
            {
                Course_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Song_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Management_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Source_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.ParseColor("#ED145B"));

            }
            else if (themes.ColorNumber == 5) // 5 ==     "حالت روز با رنگ آپارات"
            {
                Source_chip.SetTextColor(Color.White);
                Course_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Song_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Management_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Course_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Song_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Management_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Source_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.ParseColor("#ED145B"));
            }
        }
        private static void Course_Chip_Select()
        {
            if (themes.ColorNumber == 0) // 0 ==   "حالت شب با رنگ آبی"
            {
                Source_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Song_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Management_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Course_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.ParseColor("#009dff"));

            }
            else if (themes.ColorNumber == 1)  // 1 ==   "حالت شب با رنگ خاکستری" 
            {
                Source_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Song_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Management_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Course_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.ParseColor("#363636"));

            }
            else if (themes.ColorNumber == 2)  // 2 ==    "حالت روز با رنگ آبی"
            {
                Course_chip.SetTextColor(Color.White);
                Source_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Song_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Management_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Source_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Song_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Management_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Course_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.ParseColor("#009dff"));
            }
            else if (themes.ColorNumber == 3) // 3 ==     "حالت روز با خاکستری"
            {
                Course_chip.SetTextColor(Color.White);
                Source_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Song_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Management_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Source_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Song_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Management_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Course_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.ParseColor("#3E3E3E"));
            }
            else if (themes.ColorNumber == 4)  // 4 ==    "حالت شب با رنگ آپارات"
            {
                Source_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Song_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Management_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Course_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.ParseColor("#ED145B"));

            }
            else if (themes.ColorNumber == 5) // 5 ==     "حالت روز با رنگ آپارات"
            {
                Course_chip.SetTextColor(Color.White);
                Source_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Song_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Management_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Source_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Song_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Management_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Course_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.ParseColor("#ED145B"));
            }
        }

        private static void Management_Chip_Select()
        {
            if (themes.ColorNumber == 0) // 0 ==   "حالت شب با رنگ آبی"
            {
                Source_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Song_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Course_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Management_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.ParseColor("#009dff"));

            }
            else if (themes.ColorNumber == 1)  // 1 ==   "حالت شب با رنگ خاکستری" 
            {
                Source_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Song_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Course_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Management_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.ParseColor("#363636"));

            }
            else if (themes.ColorNumber == 2)  // 2 ==    "حالت روز با رنگ آبی"
            {
                Management_chip.SetTextColor(Color.White);
                Source_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Song_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Course_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Source_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Song_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Course_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Management_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.ParseColor("#009dff"));
            }
            else if (themes.ColorNumber == 3) // 3 ==     "حالت روز با خاکستری"
            {
                Management_chip.SetTextColor(Color.White);
                Source_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Song_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Course_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Source_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Song_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Course_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Management_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.ParseColor("#3E3E3E"));
            }
            else if (themes.ColorNumber == 4)  // 4 ==    "حالت شب با رنگ آپارات"
            {
                Source_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Song_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Course_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.Rgb(5, 5, 5));
                Management_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.ParseColor("#ED145B"));

            }
            else if (themes.ColorNumber == 5) // 5 ==     "حالت روز با رنگ آپارات"
            {
                Management_chip.SetTextColor(Color.White);
                Source_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Song_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Course_chip.SetTextColor(Color.Rgb(30, 30, 30));
                Source_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Song_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Course_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.White);
                Management_chip.ChipBackgroundColor = ColorStateList.ValueOf(Color.ParseColor("#ED145B"));
            }
        }

    }
}