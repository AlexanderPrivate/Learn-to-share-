using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
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
using static Android.Icu.Text.CaseMap;

namespace LearnToShare.Dialogs
{
    [Obsolete]
    public class delete_cloud_Fragment : DialogFragment
    {
        View This_View;
        MaterialButton Sumbit;
        EditText Code_Edit;
        RelativeLayout relative;
        private string _Path = System.IO.Path.Combine(FileSystem.AppDataDirectory, "Cloud.db3");
        [Obsolete]
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            This_View = inflater.Inflate(Resource.Layout.fragment_deletecloud, container, false);

            relative = (RelativeLayout)This_View.FindViewById(Resource.Id.relative);

            Sumbit = (MaterialButton)This_View.FindViewById(Resource.Id.Sumbit);
            Code_Edit = (EditText)This_View.FindViewById(Resource.Id.title_edit);

            var connection = new SQLiteConnection(_Path);

            connection.CreateTable<Table_Cloud>();


            if (Activity_main.theme_number == 0 || Activity_main.theme_number == 1 || Activity_main.theme_number == 4)
            {
                Code_Edit.SetTextColor(Color.White);
                relative.SetBackgroundColor(Color.Rgb(30, 30, 30));
                Code_Edit.SetHintTextColor(Color.Rgb(235, 235, 235));
            }


            Sumbit.Click += Sumbit_Click;


            return This_View;
        }

        private void Sumbit_Click(object sender, EventArgs e)
        {
            {
                var connection = new SQLiteConnection(_Path);

                if (!Code_Edit.Text.Equals(""))
                {
                    try
                    {
                        int Id = Convert.ToInt32(Code_Edit.Text);
                        var cloud = connection.Table<Table_Cloud>().FirstOrDefault(x => x.Id == Id);
                        if (cloud != null)
                        {
                            connection.Delete(cloud);
                        }
                        else
                        {
                            Toast.MakeText(This_View.Context, "کد کلود مورد نظر وجود ندارد", ToastLength.Long).Show();
                        }
                    }
                    catch (Exception)
                    {
                        Toast.MakeText(This_View.Context, "کد وارد شده باید انگلیسی باشد", ToastLength.Long).Show();
                    }
                }
                else
                {
                    Toast.MakeText(This_View.Context, "کد کلود نمیتواند خالی باشد", ToastLength.Long).Show();
                }
                ShowData(connection);
                Dismiss();
            }

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