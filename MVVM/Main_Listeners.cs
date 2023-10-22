using Android.App;
using Android.Content;
using LearnToShare.Activities;
using LearnToShare.Classes;

namespace LearnToShare.MVVM
{
    public static class GIT 
    {
        public static void Btn_1()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/iH3K1/vt/frame";
            info_manager.TEACHER_NAME = "اشکان";
            info_manager.TIME_OF_VIDEO = "09:24 دقیقه";
            info_manager.DESCREPTION = "آشنایی با مدرس و توضیحات در مورد گیت این اموزش آموزش از دوره آموزش گیت بصورت کاربردی است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/iH3K1";
            Intent intent = new Intent(Activity_git.context, typeof(Activity_playvideo));
            Activity_git.context.StartActivity(intent);
        }
        public static void Btn_2()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/NUw95/vt/frame";
            info_manager.TEACHER_NAME = "اشکان";
            info_manager.TIME_OF_VIDEO = "16:17 دقیقه";
            info_manager.DESCREPTION = "این دومین قسمت از آموزش گیت هست";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/NUw95";
            Intent intent = new Intent(Activity_git.context, typeof(Activity_playvideo));
            Activity_git.context.StartActivity(intent);
        }
        public static void Btn_3()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/7wuck/vt/frame";
            info_manager.TEACHER_NAME = "اشکان";
            info_manager.TIME_OF_VIDEO = "16:19 دقیقه";
            info_manager.DESCREPTION = "این سومین قسمت از آموزش گیت هست";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/7wuck?playlist=7553116";
            Intent intent = new Intent(Activity_git.context, typeof(Activity_playvideo));
            Activity_git.context.StartActivity(intent);
        }
        public static void Btn_4()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/RMniF/vt/frame";
            info_manager.TEACHER_NAME = "اشکان";
            info_manager.TIME_OF_VIDEO = "34:05 دقیقه";
            info_manager.DESCREPTION = "این چهارمین قسمت از آموزش گیت هست";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/RMniF?playlist=7553116";
            Intent intent = new Intent(Activity_git.context, typeof(Activity_playvideo));
            Activity_git.context.StartActivity(intent);
        }
        public static void Btn_5()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/Byx9G/vt/frame";
            info_manager.TEACHER_NAME = "اشکان";
            info_manager.TIME_OF_VIDEO = "22:41 دقیقه";
            info_manager.DESCREPTION = "این پنجمین قسمت از آموزش گیت هست";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/RMniF?playlist=7553116";
            Intent intent = new Intent(Activity_git.context, typeof(Activity_playvideo));
            Activity_git.context.StartActivity(intent);
        }
        public static void Btn_6()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/km1MB/vt/frame";
            info_manager.TEACHER_NAME = "اشکان";
            info_manager.TIME_OF_VIDEO = "41:12 دقیقه";
            info_manager.DESCREPTION = "این ششمین قسمت از آموزش گیت هست";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/km1MB?playlist=7553116";
            Intent intent = new Intent(Activity_git.context, typeof(Activity_playvideo));
            Activity_git.context.StartActivity(intent);
        }
        public static void Btn_7()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/9XRNn/vt/frame";
            info_manager.TEACHER_NAME = "اشکان";
            info_manager.TIME_OF_VIDEO = "21:53 دقیقه";
            info_manager.DESCREPTION = "این هفتمین قسمت از آموزش گیت هست";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/9XRNn?playlist=7553116";
            Intent intent = new Intent(Activity_git.context, typeof(Activity_playvideo));
            Activity_git.context.StartActivity(intent);
        }
        public static void Btn_8()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/WHZXT/vt/frame";
            info_manager.TEACHER_NAME = "اشکان";
            info_manager.TIME_OF_VIDEO = "15:55 دقیقه";
            info_manager.DESCREPTION = "این هشتمین قسمت از آموزش گیت هست";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/WHZXT?playlist=7553116";
            Intent intent = new Intent(Activity_git.context, typeof(Activity_playvideo));
            Activity_git.context.StartActivity(intent);
        }
        public static void Download_1()
        {
            Downloader.Download_Movie("https://ia902604.us.archive.org/9/items/1_20231006_20231006_2318/1.mp4", "درس 1", "آموزش گیت بصورت کاربردی");
        }
        public static void Download_2()
        {
            Downloader.Download_Movie("https://ia802506.us.archive.org/6/items/2_20231006_20231006_2320/2.mp4", "درس 2", "آموزش گیت بصورت کاربردی");
        }
        public static void Download_3()
        {
            Downloader.Download_Movie("https://ia800502.us.archive.org/28/items/3_20231006_20231006_2322/3.mp4", "درس 3", "آموزش گیت بصورت کاربردی");
        }
        public static void Download_4()
        {
            Downloader.Download_Movie("https://ia600509.us.archive.org/0/items/4_20231006_20231006/4.mp4", "درس 4", "آموزش گیت بصورت کاربردی");
        }
        public static void Download_5()
        {
            Downloader.Download_Movie("https://ia902607.us.archive.org/1/items/5_20231006_20231006_2330/5.mp4", "درس 5", "آموزش گیت بصورت کاربردی");
        }
        public static void Download_6()
        {
            Downloader.Download_Movie("https://ia800509.us.archive.org/18/items/6_20231006_202310/6.mp4", "درس 6", "آموزش گیت بصورت کاربردی");
        }
        public static void Download_7()
        {
            Downloader.Download_Movie("https://ia800502.us.archive.org/8/items/7_20231006_20231006_2340/7.mp4", "درس 7", "آموزش گیت بصورت کاربردی");
        }
        public static void Download_8()
        {
            Downloader.Download_Movie("https://ia800509.us.archive.org/1/items/8_20231006_20231006/8.mp4", "درس 8", "آموزش گیت بصورت کاربردی");
        }

    }
    public static class Java_Script
    {
        public static void Btn_1()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/VCdvU/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "04:34 دقیقه";
            info_manager.DESCREPTION = "آشنایی با مدرس و نحوه تدریس آن این اولین قسمت از آموزش جاوا اسکریپت هست";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/VCdvU";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_1()
        {
            Downloader.Download_Movie("https://ia800500.us.archive.org/28/items/1_20231006_20231006_2345/1.mp4", "درس 1", "آموزش جاوا اسکریپت");
        }
        public static void Btn_2()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/1MVUy/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "02:56 دقیقه";
            info_manager.DESCREPTION = "درس دوم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/1MVUy";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_2()
        {
            Downloader.Download_Movie("https://ia600503.us.archive.org/14/items/2_20231006_20231006_2346/2.mp4", "درس 2", "آموزش جاوا اسکریپت");
        }
        public static void Btn_3()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/7IpsM/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "02:42 دقیقه";
            info_manager.DESCREPTION = "درس سوم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/7IpsM";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_3()
        {
            Downloader.Download_Movie("https://ia802600.us.archive.org/17/items/3_20231006_20231006_2348/3.mp4", "درس 3", "آموزش جاوا اسکریپت");
        }
        public static void Btn_4()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/wrf9M/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "02:38 دقیقه";
            info_manager.DESCREPTION = "درس چهارم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/wrf9M";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_4()
        {
            Downloader.Download_Movie("https://ia802502.us.archive.org/26/items/4_20231006_20231006_2349/4.mp4", "درس 4", "آموزش جاوا اسکریپت");
        }
        public static void Btn_5()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/msxJj/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "01:55 دقیقه";
            info_manager.DESCREPTION = "درس پنجم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/msxJj";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_5()
        {
            Downloader.Download_Movie("https://ia802607.us.archive.org/26/items/5_20231006_20231006_2351/5.mp4", "درس 5", "آموزش جاوا اسکریپت");
        }
        public static void Btn_6()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/ASBgi/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "05:34 دقیقه";
            info_manager.DESCREPTION = "درس ششم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/ASBgi";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_6()
        {
            Downloader.Download_Movie("https://ia600507.us.archive.org/4/items/6_20231007/6.mp4", "درس 6", "آموزش جاوا اسکریپت");
        }
        public static void Btn_7()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/gAXn5/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "02:04 دقیقه";
            info_manager.DESCREPTION = "درس هفتم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/gAXn5";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_7()
        {
            Downloader.Download_Movie("https://ia902501.us.archive.org/5/items/7_20231007/7.mp4", "درس 7", "آموزش جاوا اسکریپت");
        }
        public static void Btn_8()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/zEgDW/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "01:48 دقیقه";
            info_manager.DESCREPTION = "درس هشتم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/zEgDW";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_8()
        {
            Downloader.Download_Movie("https://ia800501.us.archive.org/25/items/8_20231007/8.mp4", "درس 8", "آموزش جاوا اسکریپت");
        }
        public static void Btn_9()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/946RF/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "01:35 دقیقه";
            info_manager.DESCREPTION = "درس نهم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/946RF";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_9()
        {
            Downloader.Download_Movie("https://ia600504.us.archive.org/18/items/9_20231007/9.mp4", "درس 9", "آموزش جاوا اسکریپت");
        }
        public static void Btn_10()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/QJuyI/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "05:51 دقیقه";
            info_manager.DESCREPTION = "درس دهم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/QJuyI";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_10()
        {
            Downloader.Download_Movie("https://ia902604.us.archive.org/16/items/10_20231007/10.mp4", "درس 10", "آموزش جاوا اسکریپت");
        }
        public static void Btn_11()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/G8gYc/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "04:06 دقیقه";
            info_manager.DESCREPTION = "درس یازدهم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/G8gYc";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_11()
        {
            Downloader.Download_Movie("https://ia802508.us.archive.org/34/items/11_20231007/11.mp4", "درس 11", "آموزش جاوا اسکریپت");
        }
        public static void Btn_12()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/ZwAoL/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "04:27 دقیقه";
            info_manager.DESCREPTION = "درس دوازدهم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/ZwAoL";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_12()
        {
            Downloader.Download_Movie("https://ia802504.us.archive.org/20/items/12_20231007/12.mp4", "درس 12", "آموزش جاوا اسکریپت");
        }
        public static void Btn_13()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/rGo0C/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "03:08 دقیقه";
            info_manager.DESCREPTION = "درس سیزدهم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/rGo0C";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_13()
        {
            Downloader.Download_Movie("https://ia802607.us.archive.org/22/items/13_20231007/13.mp4", "درس 13", "آموزش جاوا اسکریپت");
        }
        public static void Btn_14()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/aBCpA/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "00:50 ثانیه";
            info_manager.DESCREPTION = "درس چهاردهم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/aBCpA";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_14()
        {
            Downloader.Download_Movie("https://ia800502.us.archive.org/26/items/14_20231007/14.mp4", "درس 14", "آموزش جاوا اسکریپت");
        }
        public static void Btn_15()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/w6KbE/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "04:54 ثانیه";
            info_manager.DESCREPTION = "درس پانزدهم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/w6KbE";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_15()
        {
            Downloader.Download_Movie("https://ia802504.us.archive.org/12/items/15_20231007/15.mp4", "درس 15", "آموزش جاوا اسکریپت");
        }
        public static void Btn_16()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/F2GCW/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "01:42 ثانیه";
            info_manager.DESCREPTION = "درس شازندهم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/F2GCW";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_16()
        {
            Downloader.Download_Movie("https://ia800506.us.archive.org/18/items/16_20231008_20231008_2206/16.mp4", "درس 16", "آموزش جاوا اسکریپت");
        }
        public static void Btn_17()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/Kre4l/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "03:25 ثانیه";
            info_manager.DESCREPTION = "درس هفدهم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/Kre4l";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_17()
        {
            Downloader.Download_Movie("https://ia902602.us.archive.org/6/items/17_20231008_20231008/17.mp4", "درس 17", "آموزش جاوا اسکریپت");
        }
        public static void Btn_18()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/E0g2r/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "03:33 ثانیه";
            info_manager.DESCREPTION = "درس هجدهم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/E0g2r";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_18()
        {
            Downloader.Download_Movie("https://ia600504.us.archive.org/17/items/18_20231008_20231008_2209/18.mp4", "درس 18", "آموزش جاوا اسکریپت");
        }
        public static void Btn_19()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/WFSN1/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "05:55 دقیقه";
            info_manager.DESCREPTION = "درس نوزدهم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/WFSN1";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_19()
        {
            Downloader.Download_Movie("https://ia802603.us.archive.org/33/items/19_20231008_20231008/19.mp4", "درس 19", "آموزش جاوا اسکریپت");
        }
        public static void Btn_20()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/hDYLB/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "02:14 دقیقه";
            info_manager.DESCREPTION = "درس بیستم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/hDYLB";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_20()
        {
            Downloader.Download_Movie("https://ia902502.us.archive.org/3/items/20_20231008_20231008_2211/20.mp4", "درس 20", "آموزش جاوا اسکریپت");
        }
        public static void Btn_21()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/Vm2Ba/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "05:04 دقیقه";
            info_manager.DESCREPTION = "درس بیستو یک از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/Vm2Ba";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_21()
        {
            Downloader.Download_Movie("https://ia600502.us.archive.org/6/items/21_20231008_20231008/21.mp4", "درس 21", "آموزش جاوا اسکریپت");
        }
        public static void Btn_22()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/O5RSe/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "03:48 دقیقه";
            info_manager.DESCREPTION = "درس بیستو دوم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/O5RSe";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_22()
        {
            Downloader.Download_Movie("https://ia600505.us.archive.org/10/items/22_20231008_20231008_2215/22.mp4", "درس 22", "آموزش جاوا اسکریپت");
        }
        public static void Btn_23()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/B0pHz/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "04:48 دقیقه";
            info_manager.DESCREPTION = "درس بیستو سوم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/B0pHz";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_23()
        {
            Downloader.Download_Movie("https://ia800505.us.archive.org/27/items/23_20231008_202310/23.mp4", "درس 23", "آموزش جاوا اسکریپت");
        }
        public static void Btn_24()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/95bFV/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "06:59 دقیقه";
            info_manager.DESCREPTION = "درس بیستو چهارم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/95bFV";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_24()
        {
            Downloader.Download_Movie("https://ia800506.us.archive.org/20/items/24_20231008_20231008_2217/24.mp4", "درس 24", "آموزش جاوا اسکریپت");
        }
        public static void Btn_25()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/93RW4/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "04:58 دقیقه";
            info_manager.DESCREPTION = "درس بیستو پنجم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/93RW4";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_25()
        {
            Downloader.Download_Movie("https://ia600507.us.archive.org/9/items/25_20231008_202310/25.mp4", "درس 25", "آموزش جاوا اسکریپت");
        }
        public static void Btn_26()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/93RW4/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "05:48 دقیقه";
            info_manager.DESCREPTION = "درس بیستو ششم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/DdtX3";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_26()
        {
            Downloader.Download_Movie("https://ia802504.us.archive.org/21/items/26_20231008_20231008/26.mp4", "درس 26", "آموزش جاوا اسکریپت");
        }
        public static void Btn_27()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/Ek05G/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "01:57 دقیقه";
            info_manager.DESCREPTION = "درس بیستو هفتم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/Ek05G";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_27()
        {
            Downloader.Download_Movie("https://ia902601.us.archive.org/1/items/27_20231008_20231008/27.mp4", "درس 27", "آموزش جاوا اسکریپت");
        }
        public static void Btn_28()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/Eg2fy/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "08:24 دقیقه";
            info_manager.DESCREPTION = "درس بیستو هشتم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/Eg2fy";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_28()
        {
            Downloader.Download_Movie("https://ia800504.us.archive.org/35/items/27_20231008_20231008_2224/28.mp4", "درس 28", "آموزش جاوا اسکریپت");
        }
        public static void Btn_29()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/1qgGT/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "06:28 دقیقه";
            info_manager.DESCREPTION = "درس بیستو نهم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/1qgGT";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_29()
        {
            Downloader.Download_Movie("https://ia600508.us.archive.org/4/items/29_20231008_20231008/29.mp4", "درس 29", "آموزش جاوا اسکریپت");
        }
        public static void Btn_30()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/W5gTN/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "08:19 دقیقه";
            info_manager.DESCREPTION = "درس سی از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/W5gTN";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_30()
        {
            Downloader.Download_Movie("https://ia802507.us.archive.org/2/items/30_20231008_20231008/30.mp4", "درس 30", "آموزش جاوا اسکریپت");
        }
        public static void Btn_31()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/4mycC/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "06:57 دقیقه";
            info_manager.DESCREPTION = "درس سی و یک از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/4mycC";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_31()
        {
            Downloader.Download_Movie("https://ia802504.us.archive.org/18/items/31_20231008/31.mp4", "درس 31", "آموزش جاوا اسکریپت");
        }
        public static void Btn_32()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/z5RGZ/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "02:46 دقیقه";
            info_manager.DESCREPTION = "درس سی و دو از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/z5RGZ";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_32()
        {
            Downloader.Download_Movie("https://ia902507.us.archive.org/3/items/32_20231008_202310/32.mp4", "درس 32", "آموزش جاوا اسکریپت");
        }
        public static void Btn_33()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/7L2R8/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "06:04 دقیقه";
            info_manager.DESCREPTION = "درس سی و سه از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/7L2R8";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_33()
        {
            Downloader.Download_Movie("https://ia800504.us.archive.org/35/items/33_20231008/33.mp4", "درس 33", "آموزش جاوا اسکریپت");
        }
        public static void Btn_34()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/4kfrw/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "08:24 دقیقه";
            info_manager.DESCREPTION = "درس سی و چهار از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/4kfrw";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_34()
        {
            Downloader.Download_Movie("https://ia802603.us.archive.org/1/items/34_20231008/34.mp4", "درس 34", "آموزش جاوا اسکریپت");
        }
        public static void Btn_35()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/jMU8A/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "04:01 دقیقه";
            info_manager.DESCREPTION = "درس سی و پنج از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/jMU8A";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_35()
        {
            Downloader.Download_Movie("https://ia800500.us.archive.org/19/items/35_20231008/35.mp4", "درس 35", "آموزش جاوا اسکریپت");
        }
        public static void Btn_36()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/nBMR0/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "05:25 دقیقه";
            info_manager.DESCREPTION = "درس سی و شش از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/nBMR0";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_36()
        {
            Downloader.Download_Movie("https://ia802601.us.archive.org/27/items/36_20231008/36.mp4", "درس 36", "آموزش جاوا اسکریپت");
        }
        public static void Btn_37()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/rTxOy/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "10:24 دقیقه";
            info_manager.DESCREPTION = "درس سی و هفتم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/rTxOy";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_37()
        {
            Downloader.Download_Movie("https://ia800504.us.archive.org/29/items/37_20231008/37.mp4", "درس 37", "آموزش جاوا اسکریپت");
        }
        public static void Btn_38()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/FMsiC/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "17:09 دقیقه";
            info_manager.DESCREPTION = "درس سی و هشتم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/FMsiC";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_38()
        {
            Downloader.Download_Movie("https://ia800502.us.archive.org/15/items/38_20231008/38.mp4", "درس 38", "آموزش جاوا اسکریپت");
        }
        public static void Btn_39()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/Gkh31/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "08:12 دقیقه";
            info_manager.DESCREPTION = "درس سی و نهم از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/Gkh31";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_39()
        {
            Downloader.Download_Movie("https://ia902607.us.archive.org/14/items/39_20231008/39.mp4", "درس 39", "آموزش جاوا اسکریپت");
        }
        public static void Btn_40()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/7p5hJ/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "05:04 دقیقه";
            info_manager.DESCREPTION = "درس چهل از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/7p5hJ";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_40()
        {
            Downloader.Download_Movie("https://ia902607.us.archive.org/4/items/40_20231008/40.mp4", "درس 40", "آموزش جاوا اسکریپت");
        }
        public static void Btn_41()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/8z7MA/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "04:21 دقیقه";
            info_manager.DESCREPTION = "درس چهل و یک از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/8z7MA";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_41()
        {
            Downloader.Download_Movie("https://ia800504.us.archive.org/13/items/41_20231008/41.mp4", "درس 41", "آموزش جاوا اسکریپت");
        }
        public static void Btn_42()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/vB9Mp/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "14:02 دقیقه";
            info_manager.DESCREPTION = "درس چهل و دو از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/vB9Mp";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_42()
        {
            Downloader.Download_Movie("https://ia800504.us.archive.org/16/items/42_20231008_202310/42.mp4", "درس 42", "آموزش جاوا اسکریپت");
        }
        public static void Btn_43()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/KgOVa/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "10:47 دقیقه";
            info_manager.DESCREPTION = "درس چهل و سه از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/KgOVa";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_43()
        {
            Downloader.Download_Movie("https://ia800505.us.archive.org/15/items/43_20231008_202310/43.mp4", "درس 43", "آموزش جاوا اسکریپت");
        }
        public static void Btn_44()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/nzcCl/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "05:41 دقیقه";
            info_manager.DESCREPTION = "درس چهل و چهار از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/nzcCl";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_44()
        {
            Downloader.Download_Movie("https://ia800507.us.archive.org/4/items/44_20231008_202310/44.mp4", "درس 44", "آموزش جاوا اسکریپت");
        }
        public static void Btn_45()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/Zvmcp/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "02:48 دقیقه";
            info_manager.DESCREPTION = "درس چهل و پنج از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/Zvmcp";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_45()
        {
            Downloader.Download_Movie("https://ia902508.us.archive.org/16/items/45_20231008/45.mp4", "درس 45", "آموزش جاوا اسکریپت");
        }
        public static void Btn_46()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/s0cPd/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "06:53 دقیقه";
            info_manager.DESCREPTION = "درس چهل و شش از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/s0cPd";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_46()
        {
            Downloader.Download_Movie("https://ia800500.us.archive.org/11/items/46_20231008/46.mp4", "درس 46", "آموزش جاوا اسکریپت");
        }
        public static void Btn_47()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/xbKHZ/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "04:06 دقیقه";
            info_manager.DESCREPTION = "درس چهل و هفت از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/xbKHZ";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_47()
        {
            Downloader.Download_Movie("https://ia800503.us.archive.org/5/items/47_20231008/47.mp4", "درس 47", "آموزش جاوا اسکریپت");
        }
        public static void Btn_48()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/y70GI/vt/frame";
            info_manager.TEACHER_NAME = "منصور کلاگر";
            info_manager.TIME_OF_VIDEO = "04:59 دقیقه";
            info_manager.DESCREPTION = "درس چهل و هشت از دوره آموزش جاوا اسکریپت";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/y70GI";
            Intent intent = new Intent(Activity_js.context, typeof(Activity_playvideo));
            Activity_js.context.StartActivity(intent);
        }
        public static void Download_48()
        {
            Downloader.Download_Movie("https://ia800501.us.archive.org/5/items/48_20231008_202310/48.mp4", "درس 48", "آموزش جاوا اسکریپت");
        }
    }
    public static class Xamarin_Form
    {
        public static void Btn_1()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/z5UrN/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "09:10 دقیقه";
            info_manager.DESCREPTION = "این اولین قسمت از آموزش زامارین فرم است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/z5UrN";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_1()
        {
            Downloader.Download_Movie("https://ia802603.us.archive.org/27/items/1_20231008_20231008_2311/1.mp4", "درس 1", "زامارین فرم");
        }
        public static void Btn_2()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/lyQ7z/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "12:56 دقیقه";
            info_manager.DESCREPTION = "این دومین قسمت از آموزش زامارین فرم است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/lyQ7z";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_2()
        {
            Downloader.Download_Movie("https://ia800509.us.archive.org/21/items/2_20231008_20231008_2313/2.mp4", "درس 2", "زامارین فرم");
        }
        public static void Btn_3()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/9dlIE/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "44:19 دقیقه";
            info_manager.DESCREPTION = "این سومین قسمت از آموزش زامارین فرم است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/9dlIE";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_3()
        {
            Downloader.Download_Movie("https://ia802507.us.archive.org/29/items/3_20231008_20231008/3.mp4", "درس 3", "زامارین فرم");
        }
        public static void Btn_4()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/AvEzf/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "14:20 دقیقه";
            info_manager.DESCREPTION = "این چهارمین قسمت از آموزش زامارین فرم است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/AvEzf";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_4()
        {
            Downloader.Download_Movie("https://ia902502.us.archive.org/12/items/4_20231008_20231008/4.mp4", "درس 4", "زامارین فرم");
        }
        public static void Btn_5()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/V1Dq2/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "11:21 دقیقه";
            info_manager.DESCREPTION = "این پنجمین قسمت از آموزش زامارین فرم است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/V1Dq2";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_5()
        {
            Downloader.Download_Movie("https://ia800500.us.archive.org/13/items/5_20231008/5.mp4", "درس 5", "زامارین فرم");
        }
        public static void Btn_6()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/sTx9U/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "14:28 دقیقه";
            info_manager.DESCREPTION = "این ششمین قسمت از آموزش زامارین فرم است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/sTx9U";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_6()
        {
            Downloader.Download_Movie("https://ia800505.us.archive.org/21/items/6_20231008_20231008_2319/6.mp4", "درس 6", "زامارین فرم");
        }
        public static void Btn_7()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/OJDzR/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "14:22 دقیقه";
            info_manager.DESCREPTION = "این هفتمین قسمت از آموزش زامارین فرم است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/OJDzR";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_7()
        {
            Downloader.Download_Movie("https://ia802504.us.archive.org/25/items/7_20231008_20231008/7.mp4", "درس 7", "زامارین فرم");
        }
        public static void Btn_8()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/RxiA9/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "15:19 دقیقه";
            info_manager.DESCREPTION = "این هشتمین قسمت از آموزش زامارین فرم است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/RxiA9";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_8()
        {
            Downloader.Download_Movie("https://ia802504.us.archive.org/22/items/8_20231008_202310/8.mp4", "درس 8", "زامارین فرم");
        }
        public static void Btn_9()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/1iop3/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "10:45 دقیقه";
            info_manager.DESCREPTION = "این نهمین قسمت از آموزش زامارین فرم است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/1iop3";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_9()
        {
            Downloader.Download_Movie("https://ia601409.us.archive.org/32/items/9_20231008/9.mp4", "درس 9", "زامارین فرم");
        }
        public static void Btn_10()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/S2A1D/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "12:36 دقیقه";
            info_manager.DESCREPTION = "این دهمین قسمت از آموزش زامارین فرم است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/S2A1D";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_10()
        {
            Downloader.Download_Movie("https://ia600508.us.archive.org/5/items/10_20231008_20231008_2327/10.mp4", "درس 10", "زامارین فرم");
        }
        public static void Btn_11()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/jgRQ5/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "16:32 دقیقه";
            info_manager.DESCREPTION = "این یازدهمین قسمت از آموزش زامارین فرم است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/jgRQ5";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_11()
        {
            Downloader.Download_Movie("https://ia800504.us.archive.org/17/items/11_20231008_20231008_2329/11.mp4", "درس 11", "زامارین فرم");
        }
        public static void Btn_12()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/pXOfb/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "08:50 دقیقه";
            info_manager.DESCREPTION = "این دوازدهمین قسمت از آموزش زامارین فرم است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/pXOfb";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_12()
        {
            Downloader.Download_Movie("https://ia600507.us.archive.org/29/items/12_20231008_20231008_2330/12.mp4", "درس 12", "زامارین فرم");
        }
        public static void Btn_13()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/r3Tet/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "14:13 دقیقه";
            info_manager.DESCREPTION = "این سیزدهمین قسمت از آموزش زامارین فرم است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/r3Tet";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_13()
        {
            Downloader.Download_Movie("https://ia600504.us.archive.org/18/items/13_20231008_20231008_2331/13.mp4", "درس 13", "زامارین فرم");
        }
        public static void Btn_14()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/Jv1ik/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "12:27 دقیقه";
            info_manager.DESCREPTION = "این چهاردهمین قسمت از آموزش زامارین فرم است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/Jv1ik";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_14()
        {
            Downloader.Download_Movie("https://ia800509.us.archive.org/15/items/14_20231008_20231008_2333/14.mp4", "درس 14", "زامارین فرم");
        }
        public static void Btn_15()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/Zmxu1/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "18:01 دقیقه";
            info_manager.DESCREPTION = "این پانزدهمین قسمت از آموزش زامارین فرم است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/Zmxu1";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_15()
        {
            Downloader.Download_Movie("https://ia800509.us.archive.org/22/items/15_20231008_20231008_2336/15.mp4", "درس 15", "زامارین فرم");
        }
        public static void Btn_16()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/KcDdC/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "11:19 دقیقه";
            info_manager.DESCREPTION = "این شانزدهمین قسمت از آموزش زامارین فرم است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/KcDdC";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_16()
        {
            Downloader.Download_Movie("https://ia802600.us.archive.org/28/items/16_20231008_20231008_2337/16.mp4", "درس 16", "زامارین فرم");
        }
        public static void Btn_17()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/HQkvO/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "08:56 دقیقه";
            info_manager.DESCREPTION = "این هفدهمین قسمت از آموزش زامارین فرم است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/HQkvO";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_17()
        {
            Downloader.Download_Movie("https://ia802501.us.archive.org/14/items/17_20231008_20231008_2339/17.mp4", "درس 17", "زامارین فرم");
        }
        public static void Btn_18()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/Orsx9/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "23:44 دقیقه";
            info_manager.DESCREPTION = "این هجدهمین قسمت از آموزش زامارین فرم است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/Orsx9";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_18()
        {
            Downloader.Download_Movie("https://ia902607.us.archive.org/18/items/18_20231008_20231008_2342/18.mp4", "درس 18", "زامارین فرم");
        }
        public static void Btn_19()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/hlsL6/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "25:36 دقیقه";
            info_manager.DESCREPTION = "این نوزدهمین قسمت از آموزش زامارین فرم است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/hlsL6";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_19()
        {
            Downloader.Download_Movie("https://ia800504.us.archive.org/27/items/19_20231008_20231008_2344/19.mp4", "درس 19", "زامارین فرم");
        }
        public static void Btn_20()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/46ywF/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "14:02 دقیقه";
            info_manager.DESCREPTION = "این قسمت 20 از آموزش زامارین فرم است";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/46ywF";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_20()
        {
            Downloader.Download_Movie("https://ia600501.us.archive.org/4/items/20_20231008_20231008_2346/20.mp4", "درس 20", "زامارین فرم");
        }
        public static void Btn_21()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/TySCA/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "14:27 دقیقه";
            info_manager.DESCREPTION = "این قسمت 21 از آموزش زامارین فرم است";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/TySCA";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_21()
        {
            Downloader.Download_Movie("https://ia802502.us.archive.org/7/items/21_20231008_20231008_2348/21.mp4", "درس 21", "زامارین فرم");
        }
        public static void Btn_22()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/BPhuZ/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "22:20 دقیقه";
            info_manager.DESCREPTION = "این قسمت 22 از آموزش زامارین فرم است";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/BPhuZ";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_22()
        {
            Downloader.Download_Movie("https://ia802508.us.archive.org/19/items/22_20231008_20231008_2351/22.mp4", "درس 22", "زامارین فرم");
        }
        public static void Btn_23()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/QGnId/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "10:53 دقیقه";
            info_manager.DESCREPTION = "این قسمت 23 از آموزش زامارین فرم است";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/QGnId";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_23()
        {
            Downloader.Download_Movie("https://ia800506.us.archive.org/34/items/23_20231008_20231008/23.mp4", "درس 23", "زامارین فرم");
        }
        public static void Btn_24()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/ePfKZ/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "23:09 دقیقه";
            info_manager.DESCREPTION = "این قسمت 24 از آموزش زامارین فرم است";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/ePfKZ";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_24()
        {
            Downloader.Download_Movie("https://ia601600.us.archive.org/34/items/24_20231013_202310/24.mp4", "درس 24", "زامارین فرم");
        }
        public static void Btn_25()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/jQuBl/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "16:11 دقیقه";
            info_manager.DESCREPTION = "این قسمت 25 از آموزش زامارین فرم است";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/jQuBl";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_25()
        {
            Downloader.Download_Movie("https://ia801601.us.archive.org/15/items/25_20231013/25.mp4", "درس 25", "زامارین فرم");
        }
        public static void Btn_26()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/bfmPi/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "09:49 دقیقه";
            info_manager.DESCREPTION = "این قسمت 26 از آموزش زامارین فرم است";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/bfmPi";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_26()
        {
            Downloader.Download_Movie("https://ia801601.us.archive.org/21/items/26_20231014/26.mp4", "درس 26", "زامارین فرم");
        }
        public static void Btn_27()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/1bJU7/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "14:11 دقیقه";
            info_manager.DESCREPTION = "این قسمت 27 از آموزش زامارین فرم است";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/1bJU7";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_27()
        {
            Downloader.Download_Movie("https://ia600509.us.archive.org/35/items/27_20231008_20231008_2354/27.mp4", "درس 27", "زامارین فرم");
        }
        public static void Btn_28()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/POk6h/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "10:53 دقیقه";
            info_manager.DESCREPTION = "این قسمت 28 از آموزش زامارین فرم است";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/POk6h";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_28()
        {
            Downloader.Download_Movie("https://ia802504.us.archive.org/32/items/28_20231008_202310/28.mp4", "درس 28", "زامارین فرم");
        }
        public static void Btn_29()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/JjD4d/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "25:41 دقیقه";
            info_manager.DESCREPTION = "این قسمت 29 از آموزش زامارین فرم است";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/JjD4d";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_29()
        {
            Downloader.Download_Movie("https://ia800504.us.archive.org/26/items/29_20231008_20231008_2357/29.mp4", "درس 29", "زامارین فرم");
        }
        public static void Btn_30()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/m7Xy1/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "15:01 دقیقه";
            info_manager.DESCREPTION = "این قسمت 30 از آموزش زامارین فرم است";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/m7Xy1";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_30()
        {
            Downloader.Download_Movie("https://ia800501.us.archive.org/8/items/30_20231009/30.mp4", "درس 30", "زامارین فرم");
        }
        public static void Btn_31()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/sX9JP/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "11:54 دقیقه";
            info_manager.DESCREPTION = "این قسمت 31 از آموزش زامارین فرم است";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/sX9JP";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_31()
        {
            Downloader.Download_Movie("https://ia804703.us.archive.org/4/items/31_20231009/31.mp4", "درس 31", "زامارین فرم");
        }
        public static void Btn_32()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/QzctB/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "16:05 دقیقه";
            info_manager.DESCREPTION = "این قسمت 32 از آموزش زامارین فرم است";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/QzctB";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_32()
        {
            Downloader.Download_Movie("https://ia800504.us.archive.org/17/items/32_20231009/32.mp4", "درس 32", "زامارین فرم");
        }
        public static void Btn_33()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/G0kVE/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "14:53 دقیقه";
            info_manager.DESCREPTION = "این قسمت 33 از آموزش زامارین فرم است";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/G0kVE";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_33()
        {
            Downloader.Download_Movie("https://ia804703.us.archive.org/0/items/33_20231009/33.mp4", "درس 33", "زامارین فرم");
        }
        public static void Btn_34()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/qB8vz/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "12:32 دقیقه";
            info_manager.DESCREPTION = "این قسمت 34 از آموزش زامارین فرم است";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/qB8vz";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_34()
        {
            Downloader.Download_Movie("https://ia600505.us.archive.org/35/items/34_20231009/34.mp4", "درس 34", "زامارین فرم");
        }
        public static void Btn_35()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/XLvSr/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "24:24 دقیقه";
            info_manager.DESCREPTION = "این قسمت 35 از آموزش زامارین فرم است";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/XLvSr";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_35()
        {
            Downloader.Download_Movie("https://ia902507.us.archive.org/2/items/35_20231009/35.mp4", "درس 35", "زامارین فرم");
        }
        public static void Btn_36()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/MXmbq/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "17:27 دقیقه";
            info_manager.DESCREPTION = "این قسمت 36 از آموزش زامارین فرم است";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/MXmbq";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_36()
        {
            Downloader.Download_Movie("https://ia802501.us.archive.org/32/items/36_20231009/36.mp4", "درس 36", "زامارین فرم");
        }
        public static void Btn_37()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/uOlzW/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "12:51 دقیقه";
            info_manager.DESCREPTION = "این قسمت 37 از آموزش زامارین فرم است";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/uOlzW";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_37()
        {
            Downloader.Download_Movie("https://ia800504.us.archive.org/29/items/37_20231009/37.mp4", "درس 37", "زامارین فرم");
        }
        public static void Btn_38()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/J8HXf/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "23:10 دقیقه";
            info_manager.DESCREPTION = "این قسمت 38 از آموزش زامارین فرم است";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/J8HXf";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_38()
        {
            Downloader.Download_Movie("https://ia802607.us.archive.org/7/items/38_20231009/38.mp4", "درس 38", "زامارین فرم");
        }
        public static void Btn_39()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/Qltpo/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "12:52 دقیقه";
            info_manager.DESCREPTION = "این قسمت 39 از آموزش زامارین فرم است";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/Qltpo";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_39()
        {
            Downloader.Download_Movie("https://ia600502.us.archive.org/8/items/39_20231009/39.mp4", "درس 39", "زامارین فرم");
        }
        public static void Btn_40()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/dT2ic/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "20:15 دقیقه";
            info_manager.DESCREPTION = "این قسمت 40 از آموزش زامارین فرم است";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/dT2ic";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_40()
        {
            Downloader.Download_Movie("https://ia600506.us.archive.org/8/items/40_20231009/40.mp4", "درس 40", "زامارین فرم");
        }
        public static void Btn_41()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/l2TeA/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "16:26 دقیقه";
            info_manager.DESCREPTION = "این قسمت 41 از آموزش زامارین فرم است";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/l2TeA";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_41()
        {
            Downloader.Download_Movie("https://ia800507.us.archive.org/22/items/41_20231009/41.mp4", "درس 41", "زامارین فرم");
        }
        public static void Btn_42()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/AJM9p/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "15:43 دقیقه";
            info_manager.DESCREPTION = "این قسمت 42 از آموزش زامارین فرم است";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/AJM9p";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_42()
        {
            Downloader.Download_Movie("https://ia600506.us.archive.org/28/items/42_20231009/42.mp4", "درس 42", "زامارین فرم");
        }
        public static void Btn_43()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/Ttryc/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "14:46 دقیقه";
            info_manager.DESCREPTION = "این قسمت 43 از آموزش زامارین فرم است";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/Ttryc";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_43()
        {
            Downloader.Download_Movie("https://ia802501.us.archive.org/15/items/43_20231009/43.mp4", "درس 43", "زامارین فرم");
        }
        public static void Btn_44()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/UJ2o6/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "13:55 دقیقه";
            info_manager.DESCREPTION = "این قسمت 44 از آموزش زامارین فرم است";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/UJ2o6";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_44()
        {
            Downloader.Download_Movie("https://ia600506.us.archive.org/25/items/44_20231009/44.mp4", "درس 44", "زامارین فرم");
        }
        public static void Btn_45()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/5IYZQ/vt/frame";
            info_manager.TEACHER_NAME = "گروه تخصصی پامکین";
            info_manager.TIME_OF_VIDEO = "10:42 دقیقه";
            info_manager.DESCREPTION = "این قسمت 45 از آموزش زامارین فرم است";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/5IYZQ";
            Intent intent = new Intent(Activity_xamarin_form.context, typeof(Activity_playvideo));
            Activity_xamarin_form.context.StartActivity(intent);
        }
        public static void Download_45()
        {
            Downloader.Download_Movie("https://ia800505.us.archive.org/10/items/45_20231009/45.mp4", "درس 45", "زامارین فرم");
        }
    }
    public static class Html_Css
    {
        public static void Btn_1()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/5hGUv/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "17:55 دقیقه";
            info_manager.DESCREPTION = "این قسمت 1 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/5hGUv";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_1()
        {
            Downloader.Download_Movie("https://ia800504.us.archive.org/13/items/1_20231009/1.mp4", "درس 1", "آموزش html & Css");
        }
        public static void Btn_2()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/ZLgKQ/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "17:09 دقیقه";
            info_manager.DESCREPTION = "این قسمت 2 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/ZLgKQ";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_2()
        {
            Downloader.Download_Movie("https://ia800504.us.archive.org/31/items/2_20231009/2.mp4", "درس 2", "آموزش html & Css");
        }
        public static void Btn_3()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/G8k3C/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "19:29 دقیقه";
            info_manager.DESCREPTION = "این قسمت 3 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/G8k3C";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_3()
        {
            Downloader.Download_Movie("https://ia802508.us.archive.org/21/items/3_20231009_202310/3.mp4", "درس 3", "آموزش html & Css");
        }
        public static void Btn_4()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/14qNB/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "22:02 دقیقه";
            info_manager.DESCREPTION = "این قسمت 4 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/14qNB";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_4()
        {
            Downloader.Download_Movie("https://ia800509.us.archive.org/13/items/4_20231009/4.mp4", "درس 4", "آموزش html & Css");
        }
        public static void Btn_5()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/KAbpf/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "12:15 دقیقه";
            info_manager.DESCREPTION = "این قسمت 5 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/KAbpf";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_5()
        {
            Downloader.Download_Movie("https://ia600509.us.archive.org/3/items/5_20231009/5.mp4", "درس 5", "آموزش html & Css");
        }
        public static void Btn_6()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/YSHzt/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "10:43 دقیقه";
            info_manager.DESCREPTION = "این قسمت 6 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/YSHzt";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_6()
        {
            Downloader.Download_Movie("https://ia800507.us.archive.org/3/items/6_20231009/6.mp4", "درس 6", "آموزش html & Css");
        }
        public static void Btn_7()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/j3BGd/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "26:48 دقیقه";
            info_manager.DESCREPTION = "این قسمت 7 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/j3BGd";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_7()
        {
            Downloader.Download_Movie("https://ia800503.us.archive.org/31/items/7_20231009/7.mp4", "درس 7", "آموزش html & Css");
        }
        public static void Btn_8()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/OenfY/vt/framee";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "13:10 دقیقه";
            info_manager.DESCREPTION = "این قسمت 8 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/OenfY";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_8()
        {
            Downloader.Download_Movie("https://ia802600.us.archive.org/11/items/8_20231009/8.mp4", "درس 8", "آموزش html & Css");
        }
        public static void Btn_9()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/v2bRu/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "14:47 دقیقه";
            info_manager.DESCREPTION = "این قسمت 9 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/v2bRu";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_9()
        {
            Downloader.Download_Movie("https://ia600504.us.archive.org/29/items/9_20231009/9.mp4", "درس 9", "آموزش html & Css");
        }
        public static void Btn_10()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/9tmap/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "14:02 دقیقه";
            info_manager.DESCREPTION = "این قسمت 10 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/9tmap";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_10()
        {
            Downloader.Download_Movie("https://ia802600.us.archive.org/15/items/10_20231009/10.mp4", "درس 10", "آموزش html & Css");
        }
        public static void Btn_11()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/dvrK7/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "12:54 دقیقه";
            info_manager.DESCREPTION = "این قسمت 11 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/dvrK7";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_11()
        {
            Downloader.Download_Movie("https://ia800505.us.archive.org/16/items/11_20231009/11.mp4", "درس 11", "آموزش html & Css");
        }
        public static void Btn_12()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/QY8Ac/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "17:17 دقیقه";
            info_manager.DESCREPTION = "این قسمت 12 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/QY8Ac";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_12()
        {
            Downloader.Download_Movie("https://ia800506.us.archive.org/21/items/12_20231009/12.mp4", "درس 12", "آموزش html & Css");
        }
        public static void Btn_13()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/apceL/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "13:24 دقیقه";
            info_manager.DESCREPTION = "این قسمت 13 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/apceL";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_13()
        {
            Downloader.Download_Movie("https://ia902606.us.archive.org/8/items/13_20231009/13.mp4", "درس 13", "آموزش html & Css");
        }
        public static void Btn_14()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/FKTV8/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "12:15 دقیقه";
            info_manager.DESCREPTION = "این قسمت 14 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/FKTV8";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_14()
        {
            Downloader.Download_Movie("https://ia902601.us.archive.org/34/items/14_20231009/14.mp4", "درس 14", "آموزش html & Css");
        }
        public static void Btn_15()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/JD0th/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "13:06 دقیقه";
            info_manager.DESCREPTION = "این قسمت 15 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/JD0th";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_15()
        {
            Downloader.Download_Movie("https://ia802502.us.archive.org/0/items/15_20231009/15.mp4", "درس 15", "آموزش html & Css");
        }
        public static void Btn_16()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/L0137/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "13:30 دقیقه";
            info_manager.DESCREPTION = "این قسمت 16 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/L0137";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_16()
        {
            Downloader.Download_Movie("https://ia800502.us.archive.org/33/items/16_20231009/16.mp4", "درس 16", "آموزش html & Css");
        }
        public static void Btn_17()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/O7Xxt/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "17:19 دقیقه";
            info_manager.DESCREPTION = "این قسمت 17 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/O7Xxt";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_17()
        {
            Downloader.Download_Movie("https://ia800505.us.archive.org/12/items/17_20231009/17.mp4", "درس 17", "آموزش html & Css");
        }
        public static void Btn_18()
        {
            info_manager.IFRAME_URL ="https://www.aparat.com/video/video/embed/videohash/QVpca/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "16:20 دقیقه";
            info_manager.DESCREPTION = "این قسمت 18 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/QVpca";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_18()
        {
            Downloader.Download_Movie("https://ia600509.us.archive.org/35/items/18_20231009_202310/18.mp4", "درس 18", "آموزش html & Css");
        }
        public static void Btn_19()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/8S2zE/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "19:19 دقیقه";
            info_manager.DESCREPTION = "این قسمت 19 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/8S2zE";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_19()
        {
            Downloader.Download_Movie("https://ia902502.us.archive.org/7/items/19_20231009/19.mp4", "درس 19", "آموزش html & Css");
        }
        public static void Btn_20()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/bM7FX/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "17:26 دقیقه";
            info_manager.DESCREPTION = "این قسمت 20 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/bM7FX";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_20()
        {
            Downloader.Download_Movie("https://ia600504.us.archive.org/15/items/20_20231009/20.mp4", "درس 20", "آموزش html & Css");
        }
        public static void Btn_21()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/DZpQ1/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "20:35 دقیقه";
            info_manager.DESCREPTION = "این قسمت 21 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/DZpQ1";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_21()
        {
            Downloader.Download_Movie("https://ia802506.us.archive.org/23/items/21_20231009_20231009/21.mp4", "درس 21", "آموزش html & Css");
        }
        public static void Btn_22()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/B0E1l/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "13:55 دقیقه";
            info_manager.DESCREPTION = "این قسمت 22 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/B0E1l";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_22()
        {
            Downloader.Download_Movie("https://ia802506.us.archive.org/32/items/22_20231009/22.mp4", "درس 22", "آموزش html & Css");
        }
        public static void Btn_23()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/gPqhn/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "18:08 دقیقه";
            info_manager.DESCREPTION = "این قسمت 23 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/gPqhn";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_23()
        {
            Downloader.Download_Movie("https://ia902607.us.archive.org/22/items/23_20231009/23.mp4", "درس 23", "آموزش html & Css");
        }
        public static void Btn_24()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/ZODvc/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "19:21 دقیقه";
            info_manager.DESCREPTION = "این قسمت 24 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/ZODvc";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_24()
        {
            Downloader.Download_Movie("https://ia800500.us.archive.org/11/items/24_20231009/24.mp4", "درس 24", "آموزش html & Css");
        }
        public static void Btn_25()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/WPSZR/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "15:02 دقیقه";
            info_manager.DESCREPTION = "این قسمت 25 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/WPSZR";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_25()
        {
            Downloader.Download_Movie("https://ia800504.us.archive.org/9/items/25_20231009/25.mp4", "درس 25", "آموزش html & Css");
        }
        public static void Btn_26()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/IpAtj/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "13:55 دقیقه";
            info_manager.DESCREPTION = "این قسمت 26 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/IpAtj";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_26()
        {
            Downloader.Download_Movie("https://ia800500.us.archive.org/18/items/26_20231009/26.mp4", "درس 26", "آموزش html & Css");
        }
        public static void Btn_27()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/rZEma/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "10:11 دقیقه";
            info_manager.DESCREPTION = "این قسمت 27 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/rZEma";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_27()
        {
            Downloader.Download_Movie("https://ia802508.us.archive.org/1/items/27_20231009/27.mp4", "درس 27", "آموزش html & Css");
        }
        public static void Btn_28()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/gMtH1/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "17:03 دقیقه";
            info_manager.DESCREPTION = "این قسمت 28 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/gMtH1";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_28()
        {
            Downloader.Download_Movie("https://ia800506.us.archive.org/24/items/28_20231009/28.mp4", "درس 28", "آموزش html & Css");
        }
        public static void Btn_29()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/4SNkf/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "19:19 دقیقه";
            info_manager.DESCREPTION = "این قسمت 29 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/4SNkf";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_29()
        {
            Downloader.Download_Movie("https://ia600509.us.archive.org/23/items/29_20231009/29.mp4", "درس 29", "آموزش html & Css");
        }
        public static void Btn_30()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/HpOax/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "13:35 دقیقه";
            info_manager.DESCREPTION = "این قسمت 30 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/HpOax";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_30()
        {
            Downloader.Download_Movie("https://ia600509.us.archive.org/22/items/30_20231009_202310/30.mp4", "درس 30", "آموزش html & Css");
        }
        public static void Btn_31()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/rBnKh/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "17:06 دقیقه";
            info_manager.DESCREPTION = "این قسمت 31 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/rBnKh";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_31()
        {
            Downloader.Download_Movie("https://ia802603.us.archive.org/33/items/31_20231009_202310/31.mp4", "درس 31", "آموزش html & Css");
        }
        public static void Btn_32()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/nTjs2/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "15:24 دقیقه";
            info_manager.DESCREPTION = "این قسمت 32 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/nTjs2";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_32()
        {
            Downloader.Download_Movie("https://ia902603.us.archive.org/25/items/32_20231009_202310/32.mp4", "درس 32", "آموزش html & Css");
        }
        public static void Btn_33()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/kXACu/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "15:49 دقیقه";
            info_manager.DESCREPTION = "این قسمت 33 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/kXACu";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_33()
        {
            Downloader.Download_Movie("https://ia802603.us.archive.org/7/items/33_20231009_202310/33.mp4", "درس 33", "آموزش html & Css");
        }
        public static void Btn_34()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/nva9g/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "11:46 دقیقه";
            info_manager.DESCREPTION = "این قسمت 34 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/nva9g";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_34()
        {
            Downloader.Download_Movie("https://ia802600.us.archive.org/8/items/34_20231009_202310/34.mp4", "درس 34", "آموزش html & Css");
        }
        public static void Btn_35()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/YF1gf/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "14:40 دقیقه";
            info_manager.DESCREPTION = "این قسمت 35 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/YF1gf";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_35()
        {
            Downloader.Download_Movie("https://ia800500.us.archive.org/3/items/35_20231009_202310/35.mp4", "درس 35", "آموزش html & Css");
        }
        public static void Btn_36()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/A6mv5/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "18:34 دقیقه";
            info_manager.DESCREPTION = "این قسمت 36 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/A6mv5";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_36()
        {
            Downloader.Download_Movie("https://ia600508.us.archive.org/3/items/36_20231009_202310/36.mp4", "درس 36", "آموزش html & Css");
        }
        public static void Btn_37()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/1iA9a/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "13:08 دقیقه";
            info_manager.DESCREPTION = "این قسمت 37 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/1iA9a";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_37()
        {
            Downloader.Download_Movie("https://ia600504.us.archive.org/2/items/37_20231009_202310/37.mp4", "درس 37", "آموزش html & Css");
        }
        public static void Btn_38()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/JpsE6/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "12:31 دقیقه";
            info_manager.DESCREPTION = "این قسمت 38 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/JpsE6";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_38()
        {
            Downloader.Download_Movie("https://ia800504.us.archive.org/33/items/38_20231009_202310/38.mp4", "درس 38", "آموزش html & Css");
        }
        public static void Btn_39()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/B8pN5/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "14:15 دقیقه";
            info_manager.DESCREPTION = "این قسمت 39 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/B8pN5";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_39()
        {
            Downloader.Download_Movie("https://ia800505.us.archive.org/31/items/39_20231009_202310/39.mp4", "درس 39", "آموزش html & Css");
        }
        public static void Btn_40()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/aTw2G/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "15:50 دقیقه";
            info_manager.DESCREPTION = "این قسمت 40 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/aTw2G";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_40()
        {
            Downloader.Download_Movie("https://ia600506.us.archive.org/33/items/40_20231009_202310/40.mp4", "درس 40", "آموزش html & Css");
        }
        public static void Btn_41()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/P2f1N/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "12:03 دقیقه";
            info_manager.DESCREPTION = "این قسمت 41 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/P2f1N";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_41()
        {
            Downloader.Download_Movie("https://ia600509.us.archive.org/23/items/41_20231009_202310/41.mp4", "درس 41", "آموزش html & Css");
        }
        public static void Btn_42()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/o3gYy/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "12:22 دقیقه";
            info_manager.DESCREPTION = "این قسمت 42 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/o3gYy";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_42()
        {
            Downloader.Download_Movie("https://ia802600.us.archive.org/33/items/42_20231009_202310/42.mp4", "درس 42", "آموزش html & Css");
        }
        public static void Btn_43()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/vyzCr/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "14:19 دقیقه";
            info_manager.DESCREPTION = "این قسمت 43 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/vyzCr";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_43()
        {
            Downloader.Download_Movie("https://ia600507.us.archive.org/12/items/43_20231009_202310/43.mp4", "درس 43", "آموزش html & Css");
        }
        public static void Btn_44()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/IfajH/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "19:25 دقیقه";
            info_manager.DESCREPTION = "این قسمت 44 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/IfajH";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_44()
        {
            Downloader.Download_Movie("https://ia902600.us.archive.org/15/items/44_20231009_202310/44.mp4", "درس 44", "آموزش html & Css");
        }
        public static void Btn_45()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/eJBZ2/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "13:16 دقیقه";
            info_manager.DESCREPTION = "این قسمت 45 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/eJBZ2";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_45()
        {
            Downloader.Download_Movie("https://ia600500.us.archive.org/2/items/45_20231009_202310/45.mp4", "درس 45", "آموزش html & Css");
        }
        public static void Btn_46()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/CaZFt/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "12:50 دقیقه";
            info_manager.DESCREPTION = "این قسمت 46 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/CaZFt";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_46()
        {
            Downloader.Download_Movie("https://ia800508.us.archive.org/3/items/46_20231009/46.mp4", "درس 46", "آموزش html & Css");
        }
        public static void Btn_47()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/9keLg/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "18:11 دقیقه";
            info_manager.DESCREPTION = "این قسمت 47 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/9keLg";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_47()
        {
            Downloader.Download_Movie("https://ia800501.us.archive.org/35/items/47_20231009/47.mp4", "درس 47", "آموزش html & Css");
        }
        public static void Btn_48()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/h9Q5j/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "20:09 دقیقه";
            info_manager.DESCREPTION = "این قسمت 48 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/h9Q5j";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_48()
        {
            Downloader.Download_Movie("https://ia800501.us.archive.org/31/items/48_20231009/48.mp4", "درس 48", "آموزش html & Css");
        }
        public static void Btn_49()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/gDezZ/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "12:45 دقیقه";
            info_manager.DESCREPTION = "این قسمت 49 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/gDezZ";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_49()
        {
            Downloader.Download_Movie("https://ia800501.us.archive.org/10/items/49_20231009/49.mp4", "درس 49", "آموزش html & Css");
        }
        public static void Btn_50()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/h0cC7/vt/frame";
            info_manager.TEACHER_NAME = "رضا نظربیگی";
            info_manager.TIME_OF_VIDEO = "15:21 دقیقه";
            info_manager.DESCREPTION = "این قسمت 50 از آموزش Html و css است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/h0cC7";
            Intent intent = new Intent(Activity_htmlcss.context, typeof(Activity_playvideo));
            Activity_htmlcss.context.StartActivity(intent);
        }
        public static void Download_50()
        {
            Downloader.Download_Movie("https://ia902507.us.archive.org/7/items/50_20231009/50.mp4", "درس 50", "آموزش html & Css");
        }
    }
    public static class Xamarin_Android
    {
        public static void Btn_1()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/1yFOU/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "11:28 دقیقه";
            info_manager.DESCREPTION = "این اولین قسمت از آموزش زامارین اندروید است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/1yFOU";
            Intent intent = new Intent(Activity_xamarin_android.context, typeof(Activity_playvideo));
            Activity_xamarin_android.context.StartActivity(intent);
        }
        public static void Download_1()
        {
            Downloader.Download_Movie("https://ia902607.us.archive.org/31/items/xamarin-button-1/Xamarin%20Button%201.mp4", "درس 1", "زامارین اندروید");
        }
        public static void Btn_2()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/tbKjG/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "09:54 دقیقه";
            info_manager.DESCREPTION = "این دومین قسمت از آموزش زامارین اندروید است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/tbKjG";
            Intent intent = new Intent(Activity_xamarin_android.context, typeof(Activity_playvideo));
            Activity_xamarin_android.context.StartActivity(intent);
        }
        public static void Download_2()
        {
            Downloader.Download_Movie("https://ia600508.us.archive.org/2/items/xamarin-text-view-gravity-simple-app.-2/Xamarin%20-%20TextView%2C%20Gravity%2C%20Simple%20App.%202.mp4", "درس 2", "زامارین اندروید");
        }
        public static void Btn_3()
        {
            info_manager.IFRAME_URL = "https://www.aparat.com/video/video/embed/videohash/7jZSY/vt/frame";
            info_manager.TEACHER_NAME = "محمدرضا محمدزاده";
            info_manager.TIME_OF_VIDEO = "08:35 دقیقه";
            info_manager.DESCREPTION = "این سومین قسمت از آموزش زامارین اندروید است.";
            info_manager.APARAT_LINK = "https://www.aparat.com/v/7jZSY";
            Intent intent = new Intent(Activity_xamarin_android.context, typeof(Activity_playvideo));
            Activity_xamarin_android.context.StartActivity(intent);
        }
        public static void Download_3()
        {
            Downloader.Download_Movie("https://ia800505.us.archive.org/22/items/xamarin-edit-text-loginrofm-orientation-3/Xamarin%20-%20EditText%2C%20Loginrofm%2C%20Orientation%203.mp4", "درس 3", "زامارین اندروید");
        }
    }
}