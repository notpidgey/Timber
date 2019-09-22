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
            Console.Write("Please choose MS interval \nRecommended 145+ \nInterval: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please choose a score: ");
            int scorewanted = Convert.ToInt32(Console.ReadLine());

            Process[] processes = Process.GetProcessesByName("Timberman");

            foreach (Process p in processes)
            {
                IntPtr windowHandle = p.MainWindowHandle;
                Actions.Move(windowHandle);
                Thread.Sleep(2000);
                Actions.SendKeyss(windowHandle, "d");

                int score = 0;
                string left = Actions.GetColorAt(483, 467).ToString();
                string right = Actions.GetColorAt(799, 478).ToString();

                while (true)
                {
                    while (left == Actions.GetColorAt(483, 467).ToString())
                    {
                        Actions.SendKeyss(windowHandle, "a");
                        score++;
                        Thread.Sleep(number);
                    }

                    while (right == Actions.GetColorAt(799, 478).ToString())
                    {
                        Actions.SendKeyss(windowHandle, "d");
                        score++;
                        Thread.Sleep(number);
                    }
                }
            }
        }
    }
}
