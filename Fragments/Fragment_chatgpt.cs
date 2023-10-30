using Android.App;
using Android.OS;
using Android.Views;
using System;
using Newtonsoft.Json;
using Android.Widget;
using System.Threading;
using Google.Android.Material.FloatingActionButton;
using Xamarin.Essentials;
using System.Net.Http;
using LearnToShare.CHAT_GPT;
using Android.Graphics;
using Google.Android.Material.BottomNavigation;
using LearnToShare.Classes;
using Android.Content.Res;
using AndroidX.CardView.Widget;

namespace LearnToShare.Fragments
{
    [Obsolete]
    public class Fragment_chatgpt : Fragment
    {
        EditText _chatText;
        TextView TextView1;
        FloatingActionButton _chatActionButton;
        LinearLayout _chatLayout;
        CardView cardView;
        Thread _thread;
        ImageButton backbutton;
        public static View This_View;
        [Obsolete]
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            This_View = inflater.Inflate(Resource.Layout.fragment_chatgpt, container, false);

            _chatActionButton = (FloatingActionButton)This_View.FindViewById(Resource.Id.send_button);

            _chatText = (EditText)This_View.FindViewById(Resource.Id.editText1);
            backbutton = (ImageButton)This_View.FindViewById(Resource.Id.imageButton1);
            _chatLayout = (LinearLayout)This_View.FindViewById(Resource.Id.chatRoom);
            cardView = (CardView)This_View.FindViewById(Resource.Id.cardView1);
            TextView1 = (TextView)This_View.FindViewById(Resource.Id.textView1);

            if (themes.ColorNumber == 0 || themes.ColorNumber == 1 || themes.ColorNumber == 4) // "حالت شب "
            {
                _chatText.SetBackgroundResource(Resource.Drawable.search_dark_back);
                _chatText.SetHintTextColor(ColorStateList.ValueOf(Color.Rgb(230, 230, 230)));
                _chatText.SetTextColor(Color.White);
                cardView.SetCardBackgroundColor(Color.Rgb(30, 30, 30));
                TextView1.SetTextColor(Color.White);
                backbutton.SetImageResource(Resource.Drawable.back_icon);
            }

            _chatActionButton.Click += _chatActionButton_Click;
            backbutton.Click += Backbutton_Click;
            _chatText.TextChanged += _chatText_TextChanged;

            return This_View;
        }
        
        private void _chatText_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {

        }

        private void Backbutton_Click(object sender, EventArgs e)
        {    
            Activity_main.bottomNavigationView.Visibility = ViewStates.Visible;
            Activity_main.bottomNavigationView.SelectedItemId = Resource.Id.diploma;
        }

        private void _chatActionButton_Click(object sender, EventArgs e)
        {
            _thread = new Thread(UserMessage);
            _thread.Start();
        }
        public void UserMessage()
        {
            string Api = "https://chatgpt-api3.onrender.com?text=" + _chatText.Text;
            TextView _UserMessage = new TextView(Context);
            _UserMessage.Text = "شما: \n "+ _chatText.Text;
            _UserMessage.SetPadding(10, 10, 10, 10);
            _UserMessage.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Normal);
            _UserMessage.TextSize = 17;
            _UserMessage.SetTextColor(Color.White);
            if (themes.ColorNumber == 0)
            {
                _UserMessage.SetBackgroundResource(Resource.Drawable.user_blue);
            }
            else if (themes.ColorNumber == 1)
            {
                _UserMessage.SetBackgroundResource(Resource.Drawable.user_gray_dark);
            }
            else if (themes.ColorNumber == 2)
            {
                _UserMessage.SetBackgroundResource(Resource.Drawable.user_blue);
            }
            else if (themes.ColorNumber == 3)
            {
                _UserMessage.SetBackgroundResource(Resource.Drawable.user_gray_light);
            }
            else if (themes.ColorNumber == 4)
            {
                _UserMessage.SetBackgroundResource(Resource.Drawable.user_red);
            }
            else if (themes.ColorNumber == 5)
            {
                _UserMessage.SetBackgroundResource(Resource.Drawable.user_red);
            }
            MainThread.BeginInvokeOnMainThread(() =>
            {
                _chatLayout.AddView(_UserMessage);
                LinearLayout.LayoutParams layout = (LinearLayout.LayoutParams)_UserMessage.LayoutParameters;
                layout.SetMargins(20, 20, 20, 20);
                layout.Gravity = GravityFlags.Right;
                layout.Width = 650;
                _chatText.Text = "";
            });
            using (var Client = new HttpClient())
            {
                try
                {
                   TextView _BotMessage = new TextView(Context);
                    _BotMessage.SetPadding(10, 10, 10, 10);
                    _BotMessage.TextSize = 17;
                    _BotMessage.SetTypeface(Activity_main.IranSansFont, TypefaceStyle.Normal);
                    _BotMessage.SetBackgroundResource(Resource.Drawable.bot_message_background);
                    _BotMessage.SetTextColor(Color.White);
                    _BotMessage.Gravity = GravityFlags.Right;
                
                    var getJson = Client.GetStringAsync(Api).Result;
                    var MyModel = JsonConvert.DeserializeObject<Model>(getJson); 
                    _BotMessage.Click += delegate
                    {
                        Clipboard.SetTextAsync(MyModel.message);
                    };
                    _BotMessage.Text = $"هوش مصنوعی (ChatGPT 3.5, Open Ai): \n\n  {MyModel.message} \n\n ← با کلیک کردن بر روی پیام میتوانید متن را کپی کنید .";
                    MainThread.BeginInvokeOnMainThread(() =>
                    {
                        
                        _chatLayout.AddView(_BotMessage);
                        LinearLayout.LayoutParams layout2 = (LinearLayout.LayoutParams)_BotMessage.LayoutParameters;
                        layout2.SetMargins(20, 20, 20, 20);
                        layout2.Gravity = GravityFlags.Left;
                        layout2.Width = 750;
                    });
                }catch(Exception)
                {

                }
              
            }
        }

  
    }
}