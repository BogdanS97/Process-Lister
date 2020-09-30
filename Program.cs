using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace ProcessesList
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcesses();

            foreach (Process process in processes)
            {
                try
                {
                    Console.WriteLine(process.ProcessName + " / " + process.MainModule.FileName + "\t" +
                        process.Id + "\t" +
                        (process.PagedSystemMemorySize64 / 1024));
                }
                catch (System.ComponentModel.Win32Exception ex)
                {
                    Console.WriteLine(process.ProcessName);
                }
            }
        }
    }
}