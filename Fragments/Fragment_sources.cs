using System;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Webkit;
using LearnToShare.Classes;

namespace LearnToShare.Fragments
{
    [Obsolete]
    public class Fragment_sources : Fragment
    {
       public static WebView web;
        [Obsolete]
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }
        [Obsolete]
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            View This_View = inflater.Inflate(Resource.Layout.fragment_sources, container, false);

            web = (WebView)This_View.FindViewById(Resource.Id.webView1);

            web.SetWebViewClient(new custom_webclient());

            SetSetting();

            web.LoadUrl("https://www.w3schools.com/");

            return This_View;
        }
        public void SetSetting()
        {
            WebSettings settings = web.Settings;
            settings.JavaScriptEnabled = true;
            settings.JavaScriptCanOpenWindowsAutomatically = true;
            settings.DomStorageEnabled = true;
            settings.AllowFileAccess = true;
            settings.AllowContentAccess = true;
            web.CanGoBack();
        }
     
    }
}