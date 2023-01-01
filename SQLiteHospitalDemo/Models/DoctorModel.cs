using SQLiteHospitalDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteHospitalDemo.Models
{
    public class DoctorModel : TableData
    {
        public string DoctorName { get; set; }
        public string DoctorLastName { get; set; }
    }
}
