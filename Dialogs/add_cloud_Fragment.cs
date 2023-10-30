using System;
using System.Collections.Generic;
using System.IO;
using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using Google.Android.Material.Button;
using LearnToShare.Cloud_DataBase;
using LearnToShare.Fragments;
using SQLite;
using Xamarin.Essentials;

namespace LearnToShare.Dialogs
{
    [Obsolete]
    public class add_cloud_Fragment : DialogFragment
    {
        View This_View;
        MaterialButton Sumbit;
        EditText Title, Des;
        RelativeLayout relative;

        private string _Path = System.IO.Path.Combine(FileSystem.AppDataDirectory, "Cloud.db3");
        [Obsolete]
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            This_View =  inflater.Inflate(Resource.Layout.fragment_addcloud, container, false);

            relative = (RelativeLayout)This_View.FindViewById(Resource.Id.myrelative);

            Sumbit = (MaterialButton)This_View.FindViewById(Resource.Id.Sumbit);
            Title = (EditText)This_View.FindViewById(Resource.Id.title_edit);
            Des = (EditText)This_View.FindViewById(Resource.Id.title_Des);

            var connection = new SQLiteConnection(_Path);

            connection.CreateTable<Table_Cloud>();

            if (Activity_main.theme_number == 0 || Activity_main.theme_number == 1 || Activity_main.theme_number == 4)
            {
                relative.SetBackgroundColor(Color.Rgb(30,30,30));
                Des.SetHintTextColor(Color.Rgb(235, 235, 235));
                Title.SetHintTextColor(Color.Rgb(235, 235, 235));
                Des.SetTextColor(Color.White);
                Title.SetTextColor(Color.White);
            }
  

            Sumbit.Click += Sumbit_Click;

            return This_View;
        }

        private void Sumbit_Click(object sender, EventArgs e)
        {
            var connection = new SQLiteConnection(_Path);
            if (!Title.Text.Equals("") && Title.Text.Length > 0)
            {
                Table_Cloud cloud = new Table_Cloud
                {
                    Title = Title.Text,
                    Descreption = Des.Text
                };

                connection.Insert(cloud);
            }
            else
            {
                Toast.MakeText(This_View.Context, "عنوان نمیتواند خالی باشد", ToastLength.Long).Show();
            }
            ShowData(connection);
            Dismiss();
        }
        private void ShowData(SQLiteConnection connection)
        {
            var Query = connection.Table<Table_Cloud>().ToList();

            List<string> Data = new List<string>();

            foreach (var item in Query)
            {
                Data.Add($" عنوان کلود: {item.Title}\n توضیحات: {item.Descreption}\n کد کلود: {item.Id}");
            }

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(This_View.Context, Resource.Layout.item_cloud,
                Data);

            Fragment_cloud.List_Show.Adapter = adapter;
        }

    }
}