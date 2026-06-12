using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


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

        public static void StopService(string serviceName)
        {
            try
            {
                System.Diagnostics.Process.Start("net", "stop " + serviceName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error stopping service: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void StartService(string serviceName)
        {
            try
            {
                System.Diagnostics.Process.Start("net", "start " + serviceName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting service: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
