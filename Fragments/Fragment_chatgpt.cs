using Android.App;
using Android.OS;
using Android.Views;
using System;

namespace LearnToShare.Fragments
{
    [Obsolete]
    public class Fragment_chatgpt : Fragment
    {
        [Obsolete]
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View This_View = inflater.Inflate(Resource.Layout.fragment_chatgpt, container, false);

            return This_View;
        }
    }
}