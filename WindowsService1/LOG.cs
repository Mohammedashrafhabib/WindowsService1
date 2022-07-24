using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

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
        

        public static int time = 10000;
        public static void Print_to_File(object id)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\mando\OneDrive\Desktop\"+"thread " + (int)id + ".txt",true);
            while (true)
            {
                file.WriteLine($"thread {(int)id}:" + DateTime.Now.ToString());
                file.Flush();
                Thread.Sleep(time);
            }

        }
    }
}
