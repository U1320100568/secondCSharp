using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    partial class Class1
    {
        public string GetDate() {
            return DateTime.Now.ToString("yyyy-MM--dd");
        }
    }
}
