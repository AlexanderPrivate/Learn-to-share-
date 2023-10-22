using SQLite;

namespace LearnToShare.Cloud_DataBase
{
    public class Table_Cloud
    {
        [AutoIncrement]
        [PrimaryKey]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descreption { get; set; }
    }
}