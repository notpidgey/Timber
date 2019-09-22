using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Timber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please choose MS interval \nRecommended 140+ \nInterval: ");
            int number = Console.Read();
            Process[] processes = Process.GetProcessesByName("Timberman");

            foreach (Process p in processes)
            {
                IntPtr windowHandle = p.MainWindowHandle;
                Actions.Move(windowHandle);
                Thread.Sleep(2000);
                Actions.SendKeyss(windowHandle, "d");
                Console.WriteLine("tt");


                string left = Actions.GetColorAt(483, 467).ToString();
                string right = Actions.GetColorAt(799, 478).ToString();

                while (true)
                {
                    if (left == Actions.GetColorAt(483, 467).ToString())
                    {
                        Actions.SendKeyss(windowHandle, "a");
                        Thread.Sleep(142);
                    }
                    else
                    {
                        while(right == Actions.GetColorAt(799, 478).ToString())
                        {
                            Actions.SendKeyss(windowHandle, "d");
                            Thread.Sleep(142);
                        }
                    }
                }
            }
        }
    }
}
