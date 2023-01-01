using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteHospitalDemo.Abstract
{
    public class Constants
    {
        public const string DBName = "hospitaldb.db3";

        public static string DBPath
        {
            get
            {
                return Path.Combine(FileSystem.AppDataDirectory, DBName);
            }
        }
    }
}
