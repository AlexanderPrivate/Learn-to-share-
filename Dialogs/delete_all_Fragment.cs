using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using Google.Android.Material.Button;
using LearnToShare.Cloud_DataBase;
using LearnToShare.Fragments;
using SQLite;
using System;
using System.Collections.Generic;
using Xamarin.Essentials;

namespace LearnToShare.Dialogs
{
    [Obsolete]
    public class delete_all_Fragment : DialogFragment
    {
        MaterialButton Sumbit,Cancel;
        RelativeLayout relative;
        TextView Title;
        View This_View;
        private string _Path = System.IO.Path.Combine(FileSystem.AppDataDirectory, "Cloud.db3");

        [Obsolete]

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            This_View = inflater.Inflate(Resource.Layout.fragment_deleteall, container, false);

            relative = (RelativeLayout)This_View.FindViewById(Resource.Id.relative);
            Title = (TextView)This_View.FindViewById(Resource.Id.textView1);

            Sumbit = (MaterialButton)This_View.FindViewById(Resource.Id.SumbitButton);
            Cancel = (MaterialButton)This_View.FindViewById(Resource.Id.CancelButton);

            if (Activity_main.theme_number == 0 || Activity_main.theme_number == 1 || Activity_main.theme_number == 4)
            {
                Title.SetTextColor(Color.White);
                relative.SetBackgroundColor(Color.Rgb(30, 30, 30));
            }

            Sumbit.Click += Sumbit_Click;
            Cancel.Click += Cancel_Click;

            return This_View;
        }

        private void Sumbit_Click(object sender, EventArgs e)
        {
            var Connection = new SQLiteConnection(_Path);
            Connection.DropTable<Table_Cloud>();
            Connection.CreateTable<Table_Cloud>();
            Dismiss();
            ShowData(Connection);
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

        private void Cancel_Click(object sender, EventArgs e)
        {
            Dismiss();
        }
    }
}