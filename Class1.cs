using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public partial class Class1 : Interface1
    {
        public string GetNow() {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");   
        }
    }
}
