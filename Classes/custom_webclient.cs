using System;
using Android.Content;
using Android.Webkit;
namespace LearnToShare.Classes
{
    public class custom_webclient : WebViewClient
    {
        [Obsolete]
        public override bool ShouldOverrideUrlLoading(WebView view, string url)
        {
            if (Android.Net.Uri.Parse(url).Host.EndsWith("www.w3schools.com"))
            {
                return false;
            }
            Intent intent = new Intent(Intent.ActionView, Android.Net.Uri.Parse(url));
            view.Context.StartActivity(intent);

            return true;
        }
    }
}