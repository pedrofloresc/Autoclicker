using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoclicker
{
    class Program
    {
        static void Main(string[] args)
        {
            ActivateApp("wowclassic");

            while (true)
            { 
                SendKeys.SendWait(" ");
                Thread.Sleep(5000);
            }
        }

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        static void ActivateApp(string processName)
        {
            Process[] p = Process.GetProcessesByName(processName);

            // Activate the first application we find with this name
            if (p.Count() > 0)
                SetForegroundWindow(p[0].MainWindowHandle);
        }
    }
}
