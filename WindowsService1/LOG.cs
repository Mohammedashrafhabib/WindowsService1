using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WindowsService1
{
    internal class LOG
    {
        internal static void write(string v)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\mando\OneDrive\Desktop\service.txt", true);
            sw.WriteLine(v);
            sw.Close();
        }
    }
}
