using SQLite;
using SQLiteHospitalDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteHospitalDemo.Models
{
    public class RoomModel : TableData
    {
        [Unique]
        public int DoctorID { get; set; }
        [Unique]
        public int RoomNumber { get; set; }
    }
}
