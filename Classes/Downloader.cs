using Android.App;
using Android.Content;

namespace LearnToShare.Classes
{
    public static class Downloader
    {
        public static void Download_Movie(string URL, string TITLE, string DESCREPTION)
        {
            DownloadManager.Request request = new DownloadManager.Request(Android.Net.Uri.Parse(URL));
            request.SetTitle(TITLE);
            request.SetDescription(DESCREPTION);
            request.SetNotificationVisibility(DownloadVisibility.VisibleNotifyCompleted);
            request.SetDestinationInExternalPublicDir(Android.OS.Environment.DirectoryDownloads, TITLE + ".mp4");
            DownloadManager manager = (DownloadManager)Application.Context.GetSystemService(Context.DownloadService);
            manager.Enqueue(request);
        }
    }
}