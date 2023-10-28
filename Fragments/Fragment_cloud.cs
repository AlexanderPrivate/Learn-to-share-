using System;
using System.Collections.Generic;
using System.IO;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using Google.Android.Material.Button;
using Google.Android.Material.FloatingActionButton;
using LearnToShare.Cloud_DataBase;
using SQLite;
using Xamarin.Essentials;

namespace LearnToShare.Fragments
{
    [Obsolete]
    public class Fragment_cloud : Fragment
    {
        View This_View;
        FloatingActionButton floatingAction;
        MaterialButton Button_Add, Button_Delete, Button_DeleteAll;
        public static ListView List_Show;
        private string _Path = Path.Combine(FileSystem.AppDataDirectory, "Cloud.db3");

        [Obsolete]
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            This_View = inflater.Inflate(Resource.Layout.fragment_cloud, container, false);

            floatingAction = (FloatingActionButton)This_View.FindViewById(Resource.Id.fab);

            Button_Add = (MaterialButton)This_View.FindViewById(Resource.Id.Add);
            Button_Delete = (MaterialButton)This_View.FindViewById(Resource.Id.Delete);
            Button_DeleteAll = (MaterialButton)This_View.FindViewById(Resource.Id.DeleteAll);
            List_Show = (ListView)This_View.FindViewById(Resource.Id.list_show);

            var connection = new SQLiteConnection(_Path);

            connection.CreateTable<Table_Cloud>();


            ShowData(connection);

            floatingAction.Click += FloatingAction_Click;
            Button_Add.Click += Button_Add_Click;
            Button_Delete.Click += Button_Delete_Click;
            Button_DeleteAll.Click += Button_DeleteAll_Click;
            return This_View;
        }

        private void Button_DeleteAll_Click(object sender, EventArgs e)
        {
            floatingAction.PerformClick();
            DialogFragment delete_cloud = new Dialogs.delete_all_Fragment();
            var Transaction = FragmentManager.BeginTransaction();
            delete_cloud.Cancelable = false;
            delete_cloud.Show(Transaction, "Delete All");
        }
        private void Button_Delete_Click(object sender, EventArgs e)
        {
            floatingAction.PerformClick();
            DialogFragment delete_cloud = new Dialogs.delete_cloud_Fragment();
            var Transaction = FragmentManager.BeginTransaction();
            delete_cloud.Cancelable = false;
            delete_cloud.Show(Transaction, "Add Cloud");
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            floatingAction.PerformClick();
            DialogFragment add_cloud = new Dialogs.add_cloud_Fragment();
            var Transaction = FragmentManager.BeginTransaction();
            add_cloud.Cancelable = false;
            add_cloud.Show(Transaction, "Add Cloud");
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

            List_Show.Adapter = adapter;
        }

        private void FloatingAction_Click(object sender, EventArgs e)
        {
            if (Button_Add.Visibility == ViewStates.Invisible)
            {

                Button_Add.Visibility = ViewStates.Visible;
                Button_Delete.Visibility = ViewStates.Visible;
                Button_DeleteAll.Visibility = ViewStates.Visible;
            }
            else
            {
                Button_Add.Visibility = ViewStates.Invisible;
                Button_Delete.Visibility = ViewStates.Invisible;
                Button_DeleteAll.Visibility = ViewStates.Invisible;
            }
        }
    }
}