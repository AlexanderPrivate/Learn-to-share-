using Android.App;
using Android.OS;
using Android.Views;
using Android.Webkit;
using System.Linq.Expressions;

namespace LearnToShare.Fragments
{
    [System.Obsolete]
    public class Fragment_messages : Fragment
    {
        [System.Obsolete]
        View This_View;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }
        [System.Obsolete]
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            This_View = inflater.Inflate(Resource.Layout.fragment_messages, container, false);

            WebView web = (WebView)This_View.FindViewById(Resource.Id.webView1);

            WebSettings settings = web.Settings;

            settings.DomStorageEnabled = true;
            settings.JavaScriptCanOpenWindowsAutomatically = true;
            settings.JavaScriptEnabled = true;
            settings.AllowContentAccess = true;
            settings.AllowFileAccess = true;
            settings.AllowUniversalAccessFromFileURLs = true;
            settings.AllowFileAccessFromFileURLs = true;

            web.LoadUrl("https://www.goftino.com/c/lU2hC7");

            return This_View;
        }
    }
}