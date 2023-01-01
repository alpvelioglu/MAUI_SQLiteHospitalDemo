using SQLiteHospitalDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteHospitalDemo.Models
{
    public class AppointmentModel : TableData
    {
        public int PatientID { get; set; }
        public DateTime Appoint_Date { get; set; }
        public string Appoint_Reason { get; set; }
    }
}
