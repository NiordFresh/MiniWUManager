using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MiniWindowsUpdateManager
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {

            // need to be updated soon...
            if (!IsAdm())
            {
                MessageBox.Show("run as an admin!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MiniWindowsUpdateManager());
        }

        static bool IsAdm()
        {
            WindowsIdentity i = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(i);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
