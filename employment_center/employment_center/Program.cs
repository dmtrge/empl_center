using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employment_center
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            headband form2 = new headband();
            DateTime end = DateTime.Now + TimeSpan.FromSeconds(3);
            form2.Show();
            while (end > DateTime.Now)
            {
                Application.DoEvents();
            }
            form2.Close();
            form2.Dispose();
            Application.Run(new genform());
        }
    }
}
