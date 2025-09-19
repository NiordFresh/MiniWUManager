using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace MiniWindowsUpdateManager
{
    public partial class MiniWindowsUpdateManager : Form
    {
        private DateTime chooseDate;
        private Size orgSize;
        private bool msgInit = true;

        public MiniWindowsUpdateManager()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Width = 320;
            this.Height = 280;
            orgSize = this.Size;
            applybutton.FlatStyle = FlatStyle.Flat;
            applybutton.FlatAppearance.BorderSize = 0;

            this.Load += MiniWindowsUpdateManager_Load;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.Width = 320;
                this.Height = 500;
            }
            else
            {
                this.Size = orgSize;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            chooseDate = e.Start;
            string date = chooseDate.ToString("yyyy-MM-dd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = chooseDate.ToString("yyyy-MM-dd'T'00:00:00'Z'");
            using (RegistryKey key = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\WindowsUpdate\UX\Settings"))
            {
                key.SetValue("PauseFeatureUpdatesStartTime", "2025-01-01T00:00:01Z", RegistryValueKind.String);
                key.SetValue("PauseQualityUpdatesStartTime", "2025-01-01T00:00:01Z", RegistryValueKind.String);
                key.SetValue("PauseUpdatesExpiryTime", data, RegistryValueKind.String);
                key.SetValue("PauseFeatureUpdatesEndTime", data, RegistryValueKind.String);
                key.SetValue("PauseQualityUpdatesEndTime", data, RegistryValueKind.String);
                key.SetValue("PauseUpdatesStartTime", "2025-01-01T00:00:01Z", RegistryValueKind.String);
                key.SetValue("PendingRebootStartTime", "2025-01-01T00:00:01Z", RegistryValueKind.String);
                MessageBox.Show("Done!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void updateMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            int au = 2;

            switch (updateMode.SelectedIndex)
            {
                case 0:
                    au = 1;
                    break;
                case 1:
                    au = 2;
                    break;
                case 2:
                    au = 3;
                    break;
                case 3:
                    au = 4;
                    break;
                case 4:
                    au = 5;
                    break;
            }

            try
            {
                using (RegistryKey key = Registry.LocalMachine.CreateSubKey(
                    @"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU"))
                {
                    if (key != null)
                    {
                        key.SetValue("AUOptions", au, RegistryValueKind.DWord);
                        MessageBox.Show("Done!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void featureUpdateBox_CheckedChanged(object sender, EventArgs e)
        {
            if (msgInit) return;
            if (featureUpdateBox.Checked)
            {
                try
                {
                    using (RegistryKey key = Registry.LocalMachine.CreateSubKey(
                        @"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate"))
                    {
                        if (key != null)
                        {
                            key.SetValue("TargetReleaseVersionInfo", "1507", RegistryValueKind.String);
                            key.SetValue("TargetReleaseVersion", 1, RegistryValueKind.DWord);
                            MessageBox.Show("Done!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    using (RegistryKey key = Registry.LocalMachine.CreateSubKey(
                        @"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate"))
                    {
                        if (key != null)
                        {
                            if (key.GetValue("TargetReleaseVersionInfo") != null)
                                key.DeleteValue("TargetReleaseVersionInfo");

                            if (key.GetValue("TargetReleaseVersion") != null)
                                key.DeleteValue("TargetReleaseVersion");

                            MessageBox.Show("Done!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Not Founded!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void driverUpdateBox_CheckedChanged(object sender, EventArgs e)
        {
            if (msgInit) return;
            if (driverUpdateBox.Checked)
            {
                try
                {
                    using (RegistryKey key = Registry.LocalMachine.CreateSubKey(
                        @"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate"))
                    {
                        if (key != null)
                        {
                            key.SetValue("ExcludeWUDriversInQualityUpdate", 1, RegistryValueKind.DWord);
                            MessageBox.Show("Done!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    using (RegistryKey key = Registry.LocalMachine.CreateSubKey(
                        @"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate"))
                    {
                        if (key != null)
                        {
                            if (key.GetValue("ExcludeWUDriversInQualityUpdate") != null)
                                key.DeleteValue("ExcludeWUDriversInQualityUpdate");
                            MessageBox.Show("Done!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Not Founded!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void wuauservBox_CheckedChanged(object sender, EventArgs e)
        {
            if (msgInit) return;
            int startValue = wuauservBox.Checked ? 4 : 2;

            try
            {
                using (RegistryKey key = Registry.LocalMachine.CreateSubKey(
                    @"SYSTEM\CurrentControlSet\Services\wuauserv", true))
                {
                    if (key != null)
                    {
                        key.SetValue("Start", startValue, RegistryValueKind.DWord);
                        MessageBox.Show("Done!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void doSvcBox_CheckedChanged(object sender, EventArgs e)
        {
            if (msgInit) return;
            int startValue = doSvcBox.Checked ? 4 : 2;

            try
            {
                using (RegistryKey key = Registry.LocalMachine.CreateSubKey(
                    @"SYSTEM\CurrentControlSet\Services\dosvc", true))
                {
                    if (key != null)
                    {
                        key.SetValue("Start", startValue, RegistryValueKind.DWord);
                        MessageBox.Show("Done!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bitsBox_CheckedChanged(object sender, EventArgs e)
        {
            if (msgInit) return;
            int startValue = bitsBox.Checked ? 4 : 2;

            try
            {
                using (RegistryKey key = Registry.LocalMachine.CreateSubKey(
                    @"SYSTEM\CurrentControlSet\Services\bits", true))
                {
                    if (key != null)
                    {
                        key.SetValue("Start", startValue, RegistryValueKind.DWord);
                        MessageBox.Show("Done!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MiniWindowsUpdateManager_Load(object sender, EventArgs e)
        {
            TransparentSettings();
            LoadTransparencyState();
            LoadServiceState(@"SYSTEM\CurrentControlSet\Services\wuauserv", wuauservBox);
            LoadServiceState(@"SYSTEM\CurrentControlSet\Services\dosvc", doSvcBox);
            LoadServiceState(@"SYSTEM\CurrentControlSet\Services\BITS", bitsBox);
            LoadFeatureUpdateState(featureUpdateBox);
            LoadDriverUpdateState(driverUpdateBox);

            msgInit = false;
        }

        private void TransparentSettings()
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\NiordFresh\MiniWUManager\set"))
                {
                    if (key != null)
                    {
                        object value = key.GetValue("transparency");
                        if (value == null)
                        {
                            key.SetValue("transparency", 1, RegistryValueKind.DWord);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadTransparencyState()
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\NiordFresh\MiniWUManager\set", false))
                {
                    if (key != null)
                    {
                        object value = key.GetValue("transparency");
                        if (value != null && value is int transparencyValue)
                        {
                            transparent.Checked = (transparencyValue == 1);

                            ApplyTransparency(transparencyValue == 1);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyTransparency(bool isTransparent)
        {
            if (isTransparent)
            {
                this.Opacity = 0.95;
            }
            else
            {
                this.Opacity = 1.0;
            }
        }

        private void LoadServiceState(string registryPath, CheckBox checkBox)
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(registryPath, false))
                {
                    if (key != null)
                    {
                        object value = key.GetValue("Start");
                        if (value != null && value is int startValue)
                        {
                            checkBox.Checked = (startValue == 4);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFeatureUpdateState(CheckBox checkBox)
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", false))
                {
                    if (key != null)
                    {
                        object x1 = key.GetValue("TargetReleaseVersion");
                        object x2 = key.GetValue("TargetReleaseVersionInfo");
                        checkBox.Checked = (x1 != null && x2 != null);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDriverUpdateState(CheckBox checkBox)
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", false))
                {
                    if (key != null)
                    {
                        object x = key.GetValue("ExcludeWUDriversInQualityUpdate");
                        checkBox.Checked = (x != null && (int)x == 1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MiniWindowsUpdateManager_Load_1(object sender, EventArgs e)
        {

        }
        private void transparent_CheckedChanged(object sender, EventArgs e)
        {
            if (msgInit) return;
            int trs = transparent.Checked ? 1 : 0;
            try
            {
                using (RegistryKey key = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\NiordFresh\MiniWUManager\set"))
                {
                    if (key != null)
                    {
                        key.SetValue("transparency", trs, RegistryValueKind.DWord);
                        ApplyTransparency(transparent.Checked);

                        MessageBox.Show("Done!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}