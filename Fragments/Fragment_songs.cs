using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using Google.Android.Material.Button;
using LearnToShare.Activities;
using LearnToShare.Classes;
using System;
using System.Collections.Generic;

namespace LearnToShare.Fragments
{
    [Obsolete]
    public class Fragment_songs : Fragment
    {
        public static View This_View;
        MaterialButton Play1, Play2, Play3, Play4, Play5;
        MaterialButton download1, download2, download3, download4, download5;


        [Obsolete]
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
        [Obsolete]
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            This_View = inflater.Inflate(Resource.Layout.fragment_songs, container, false);

       //     Typeface typeface = Typeface.CreateFromAsset(Context.Assets, "roboto.ttf");

            Play1 = (MaterialButton)This_View.FindViewById(Resource.Id.play_button1);
            Play2 = (MaterialButton)This_View.FindViewById(Resource.Id.play_button2);
            Play3 = (MaterialButton)This_View.FindViewById(Resource.Id.play_button3);
            Play4 = (MaterialButton)This_View.FindViewById(Resource.Id.play_button4);
            Play5 = (MaterialButton)This_View.FindViewById(Resource.Id.play_button5);

            download1 = (MaterialButton)This_View.FindViewById(Resource.Id.download_button1);
            download2 = (MaterialButton)This_View.FindViewById(Resource.Id.download_button2);
            download3 = (MaterialButton)This_View.FindViewById(Resource.Id.download_button3);
            download4 = (MaterialButton)This_View.FindViewById(Resource.Id.download_button4);
            download5 = (MaterialButton)This_View.FindViewById(Resource.Id.download_button5);




            List<TextView> textviews = new List<TextView>
            {
                (TextView)This_View.FindViewById(Resource.Id.textTitle1),
                (TextView)This_View.FindViewById(Resource.Id.textTitle2),
                (TextView)This_View.FindViewById(Resource.Id.textTitle3),
                (TextView)This_View.FindViewById(Resource.Id.textTitle4),
                (TextView)This_View.FindViewById(Resource.Id.textTitle5),
                (TextView)This_View.FindViewById(Resource.Id.text_descreption1),
                (TextView)This_View.FindViewById(Resource.Id.text_descreption2),
                (TextView)This_View.FindViewById(Resource.Id.text_descreption3),
                (TextView)This_View.FindViewById(Resource.Id.text_descreption4),
                (TextView)This_View.FindViewById(Resource.Id.text_descreption5),
            };

            //foreach (var text in textviews)
            //{
            //    text.SetTypeface(typeface, TypefaceStyle.Normal);
            //}

            List<AndroidX.CardView.Widget.CardView> cardViews = new List<AndroidX.CardView.Widget.CardView>
            {
                (AndroidX.CardView.Widget.CardView)This_View.FindViewById(Resource.Id.card1),
                (AndroidX.CardView.Widget.CardView)This_View.FindViewById(Resource.Id.card2),
                (AndroidX.CardView.Widget.CardView)This_View.FindViewById(Resource.Id.card3),
                (AndroidX.CardView.Widget.CardView)This_View.FindViewById(Resource.Id.card4),
                (AndroidX.CardView.Widget.CardView)This_View.FindViewById(Resource.Id.card5),
            };

            if (themes.ColorNumber == 0 || themes.ColorNumber == 1 || themes.ColorNumber == 4) // 0 ==  "حالت شب"
            {
                foreach (var card in cardViews)
                {
                    card.SetCardBackgroundColor(Color.Rgb(30, 30, 30));
                }
            }
            else if (themes.ColorNumber == 2 || themes.ColorNumber == 3 || themes.ColorNumber == 5)  // 2 ==    "حالت روز "
            {
                foreach (var card in cardViews)
                {
                    card.SetCardBackgroundColor(Color.White);
                }
            }

            Play1.Click += Play1_Click;
            Play2.Click += Play2_Click;
            Play3.Click += Play3_Click;
            Play4.Click += Play4_Click;
            Play5.Click += Play5_Click;

            download1.Click += Download1_Click;
            download2.Click += Download2_Click;
            download3.Click += Download3_Click;
            download4.Click += Download4_Click;
            download5.Click += Download5_Click;

            return This_View;
        }

        private void Download5_Click(object sender, EventArgs e)
        {
            Download("https://ia600504.us.archive.org/12/items/song5_202310/song5.mp3",
               "Someone loved you", "lewis capaldi");
        }

        private void Download4_Click(object sender, EventArgs e)
        {
            Download("https://ia800506.us.archive.org/18/items/song4_202310/song4.mp3",
            "I'm good", "Cupido");
        }

        private void Download3_Click(object sender, EventArgs e)
        {
            Download("https://ia600507.us.archive.org/22/items/song3_202310/song3.mp3",
             "Lonely", "Alan walker");
        }

        private void Download2_Click(object sender, EventArgs e)
        {
            Download("https://ia803407.us.archive.org/8/items/song1_202309/song1.mp3",
             "on my way", "Alan walker");
        }

        private void Download1_Click(object sender, EventArgs e)
        {
            Download("https://ia903407.us.archive.org/10/items/song2_202309/song2.mp3",
                "another love", "Tom odel");
        }

        private void Play5_Click(object sender, EventArgs e)
        {
            song_info.song_name = "From: lewis capaldi, someone loved you";
            song_info.song_url = "https://ia600504.us.archive.org/12/items/song5_202310/song5.mp3";
            Intent intent = new Intent(This_View.Context, typeof(Activity_songplayer));
            StartActivity(intent);
        }

        private void Play4_Click(object sender, EventArgs e)
        {
            song_info.song_name = "From: Cupido, I'm good";
            song_info.song_url = "https://ia800506.us.archive.org/18/items/song4_202310/song4.mp3";
            Intent intent = new Intent(This_View.Context, typeof(Activity_songplayer));
            StartActivity(intent);
        }

        private void Play3_Click(object sender, EventArgs e)
        {
            song_info.song_name = "From: Alan Walker, lonely";
            song_info.song_url = "https://ia600507.us.archive.org/22/items/song3_202310/song3.mp3";
            Intent intent = new Intent(This_View.Context, typeof(Activity_songplayer));
            StartActivity(intent);
        }

        private void Play2_Click(object sender, EventArgs e)
        {
            song_info.song_name = "From: Alan Walker, on my way";
            song_info.song_url = "https://ia803407.us.archive.org/8/items/song1_202309/song1.mp3";
            Intent intent = new Intent(This_View.Context, typeof(Activity_songplayer));
            StartActivity(intent);
        }

        private void Play1_Click(object sender, EventArgs e)
        {
            song_info.song_name = "From: Tom odel, another love";
            song_info.song_url = "https://ia903407.us.archive.org/10/items/song2_202309/song2.mp3";
            Intent intent = new Intent(This_View.Context, typeof(Activity_songplayer));
            StartActivity(intent);
        }
        public void Download(string URL, string TITLE, string DESCREPTION)
        {
            DownloadManager.Request request = new DownloadManager.Request(Android.Net.Uri.Parse(URL));
            request.SetTitle(TITLE);
            request.SetDescription(DESCREPTION);
            request.SetNotificationVisibility(DownloadVisibility.VisibleNotifyCompleted);
            request.SetDestinationInExternalPublicDir(Android.OS.Environment.DirectoryDownloads, TITLE + ".mp3");
            DownloadManager manager = (DownloadManager)Application.Context.GetSystemService(Context.DownloadService);
            manager.Enqueue(request);
        }
    }
}