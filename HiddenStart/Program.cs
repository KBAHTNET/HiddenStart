using System;
using System.Diagnostics;
using System.IO;

namespace HiddenStart
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = Environment.CurrentDirectory + "/" + name;
            psi.UseShellExecute = false;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.CreateNoWindow = true;
            Process.Start(psi);
        }
    }
}
