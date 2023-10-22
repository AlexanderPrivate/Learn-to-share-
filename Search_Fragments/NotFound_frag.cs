using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using System;

namespace LearnToShare.Search_Fragments
{
    [Obsolete]
    public class NotFound_frag : Fragment
    {
        [Obsolete]
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

        }
        [Obsolete]
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            View This_View = inflater.Inflate(Resource.Layout.fragment_notfound, container, false);

            TextView txt = (TextView)This_View.FindViewById(Resource.Id.textView1);

            txt.SetTypeface(Activity_main.IranSansFont, Android.Graphics.TypefaceStyle.Normal);

            return This_View;
        }
    }
}