using SQLiteHospitalDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteHospitalDemo.Models
{
    public class PrescriptionModel : TableData
    {
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public DateTime Prescription_Date { get; set; }
        public string Prescription_List { get; set; }
    }
}
