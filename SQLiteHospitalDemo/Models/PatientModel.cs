using SQLiteHospitalDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteHospitalDemo.Models
{
    public class PatientModel : TableData
    {
        public string PatientName { get; set; }
        public string PatientLastName { get; set; }
    }
}
