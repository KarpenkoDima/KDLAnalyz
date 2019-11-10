using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDLAnalize.MainWinForms.BAL
{
    class POCO
    {
    }
    public class TypeAnalize
    {
        public int TypeAnalizeID { get; set; }
        public string Name { get; set; }
    }

    public class Log
    {
        public int LogID { get; set; }
        public DateTime DateStart { get; set; }
        public string Name { get; set; }
        public DateTime? DateFinish { get; set; }
    }
}
