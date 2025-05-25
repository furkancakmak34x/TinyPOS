using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyPOS
{
    internal static class Program
    {
        static readonly Mutex mutex = new Mutex(true, "{464F3407-F172-482D-B14D-17D6DD1AC869}");

        [STAThread] 
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Main());
                mutex.ReleaseMutex();
            }

            else
            {
                MessageBox.Show("Uygulama zaten çalışıyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}