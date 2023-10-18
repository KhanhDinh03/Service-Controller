using System;
using System.Management;
using System.ServiceProcess;
using System.Windows.Forms;

namespace Service_Controller
{
    public partial class Form2 : Form
    {
        ServiceController sc = new ServiceController();

        public Form2(ServiceController sc)
        {
            InitializeComponent();
            this.sc = sc;
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

            if (sc.StartType == ServiceStartMode.Disabled)
            {
                cb_status_type.SelectedIndex = 2;
            }
            else if (sc.StartType == ServiceStartMode.Manual)
            {
                cb_status_type.SelectedIndex = 1;
            }
            else
            {
                cb_status_type.SelectedIndex = 0;
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

        private void btnnn_ok_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            
        }

        private void cb_status_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_apply.Enabled = true;
        }
    }
}
