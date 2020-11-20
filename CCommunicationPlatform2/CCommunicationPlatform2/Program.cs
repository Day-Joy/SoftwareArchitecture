using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCommunicationPlatform2
{
    static class Program
    {
        static public bool isStudent = true;
        static public Models.UserInfo user;
        static public MainWindow mainWindow;

        /// <summary>
        /// 应用程序的主入口点
        /// </summary>
        [STAThread]
        static void Main()
        {
            user = new Models.UserInfo();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn());
        }
    }
}
