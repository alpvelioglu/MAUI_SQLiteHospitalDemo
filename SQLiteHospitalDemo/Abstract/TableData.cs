using SQLite;


namespace SQLiteHospitalDemo.Abstract
{
    public class TableData
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
    }
}
