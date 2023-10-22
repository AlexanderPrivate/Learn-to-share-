using System;
using System.Threading;
using System.Timers;
using Android.App;
using Android.Graphics;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.AppCompat.Widget;
using AndroidX.CardView.Widget;
using Google.Android.Material.FloatingActionButton;
using LearnToShare.Classes;

namespace LearnToShare.Activities
{
    [Activity(Label = "Activity_songplayer")]
    public class Activity_songplayer : AppCompatActivity
    {
        MediaPlayer player;
        TextView Name;
        FloatingActionButton button_float;
        AndroidX.AppCompat.Widget.Toolbar toolbar;
        CardView card;
        Thread thread;
        System.Timers.Timer timer;
        AppCompatSeekBar seekBar;
        bool change = false;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

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


            SetContentView(Resource.Layout.activity_songplayer);
            // Typeface typeface = Typeface.CreateFromAsset(Assets, "roboto.ttf");

            toolbar = (AndroidX.AppCompat.Widget.Toolbar)FindViewById(Resource.Id.toolbar1);
            SetSupportActionBar(toolbar);

            Name = (TextView)FindViewById(Resource.Id.text_name);
            //  Name.SetTypeface(typeface, TypefaceStyle.Normal);
            button_float = (FloatingActionButton)FindViewById(Resource.Id.floatingActionButton1);
            card = (CardView)FindViewById(Resource.Id.card1);
            seekBar = (AppCompatSeekBar)FindViewById(Resource.Id.appCompatSeekBar1);

            thread = new Thread(StartSong);
            thread.Start();

            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            Name.Text = song_info.song_name;
            if (themes.ColorNumber == 0 || themes.ColorNumber == 1 || themes.ColorNumber == 4) // 0 ==  "حالت شب"
            {
                toolbar.SetBackgroundResource(Resource.Drawable.toolbar_back_dark);
                toolbar.SetTitleTextColor(Color.White);
                card.SetCardBackgroundColor(Color.Rgb(30, 30, 30));

            }
            else if (themes.ColorNumber == 2 || themes.ColorNumber == 3 || themes.ColorNumber == 5)  // 2 ==    "حالت روز "
            {
                toolbar.SetBackgroundResource(Resource.Drawable.toolbar_back);
                toolbar.SetTitleTextColor(Color.Black);
                card.SetCardBackgroundColor(Color.White);
            }

            button_float.Click += Button_float_Click;
        }
   
        public void StartSong()
        {
            try
            {
                player = new MediaPlayer();
                player.SetDataSource(song_info.song_url);
                player.Prepare();
                player.Start();
                seekBar.Max = player.Duration;
            }
            catch (Exception e)
            {
                // nothing
            }
        }
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            seekBar.Progress = player.CurrentPosition;
        }

        private void Button_float_Click(object sender, System.EventArgs e)
        {
            if (player.IsPlaying)
            {
                player.Pause();
                button_float.SetImageResource(Resource.Drawable.play);
                timer.Stop();
            }
            else
            {
                player.Start();
                button_float.SetImageResource(Resource.Drawable.stop);
                timer.Start();
            }
        }
        public override bool OnKeyDown([GeneratedEnum] Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back)
            {
                player.Pause();
            }
            return base.OnKeyDown(keyCode, e);
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
                    player.Pause();
                    Finish();
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }

    }
}