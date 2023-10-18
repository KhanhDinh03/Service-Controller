using System;
using System.Diagnostics;
using System.Management;
using System.ServiceProcess;
using System.Windows.Forms;

namespace Service_Controller
{
    public partial class Form2 : Form
    {
        ServiceController sc = new ServiceController();
        string status = "";
        string startup_type = "";

        public Form2(ServiceController sc, string status, string startup_type)
        {
            InitializeComponent();
            this.sc = sc;
            this.status = status;
            this.startup_type = startup_type;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ManagementObject wmiService;
            wmiService = new ManagementObject("Win32_Service.Name='" + sc.ServiceName + "'");
            wmiService.Get();

            lb_sv_name.Text = sc.ServiceName;
            lb_dp_name.Text = sc.DisplayName;
            tb_description.Text = (string)wmiService["Description"];
            tb_path.Text = (string)wmiService["PathName"];

            if (sc.StartType == ServiceStartMode.Automatic)
            {
                cb_startup_type.SelectedIndex = 0;
            } else if (sc.StartType == ServiceStartMode.Manual)
            {
                cb_startup_type.SelectedIndex = 1;
            } else
            {
                cb_startup_type.SelectedIndex = 2;
            }


            if (sc.Status == ServiceControllerStatus.Running)
            {
                lb_sv_status.Text = "Running";
                btn_start.Enabled = false;
            }
            else
            {
                lb_sv_status.Text = "Stopped";
                btn_stop.Enabled = false;
            }

            btn_apply.Enabled = false;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                sc.Start();
                sc.WaitForStatus(ServiceControllerStatus.Running);
                MessageBox.Show("Start the service successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lb_sv_status.Text = "Running";
                btn_start.Enabled = false;
                btn_stop.Enabled = true;
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Could not start the service.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            try
            {
                sc.Stop();
                sc.WaitForStatus(ServiceControllerStatus.Stopped);
                MessageBox.Show("Stop the service successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lb_sv_status.Text = "Stopped";
                btn_start.Enabled = true;
                btn_stop.Enabled = false;
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Could not stop the service.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public event EventHandler<Tuple<string, string>> DataReady;
        private void OnDataReady(string status, string startup_type)
        {
            DataReady?.Invoke(this, Tuple.Create(status, startup_type));
        }
        private void btnnn_ok_Click(object sender, EventArgs e)
        {
            this.Hide();
            OnDataReady(lb_sv_status.Text, cb_startup_type.Text);
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            if (cb_startup_type.SelectedIndex == 0)
            {
                string promp = "sc config "+ sc.ServiceName +" start= auto";
                Set_Startup_Type(promp);
            }
            else if (cb_startup_type.SelectedIndex == 1)
            {
                string promp = "sc config "+ sc.ServiceName +" start= demand";
                Set_Startup_Type(promp);
            } 
            else
            {
                string promp = "sc config "+ sc.ServiceName +" start= disabled";
                Set_Startup_Type(promp);
            }
            btn_apply.Enabled = false;
        }

        void Set_Startup_Type(string promp)
        {
            Process cmdProcess = new Process();

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Verb = "runas",
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            cmdProcess.StartInfo = startInfo;
            cmdProcess.Start();
            cmdProcess.StandardInput.WriteLine(promp);
            cmdProcess.StandardInput.Close();
            cmdProcess.WaitForExit();
            cmdProcess.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnDataReady(lb_sv_status.Text, cb_startup_type.Text);
        }

        private void cb_startup_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_apply.Enabled = true;
        }
    }
}
