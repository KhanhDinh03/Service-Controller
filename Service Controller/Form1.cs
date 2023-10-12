using System;
using System.Deployment.Internal;
using System.Management;
using System.ServiceProcess;
using System.Windows.Forms;


namespace Service_Controller
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void Service_controller_Load(object sender, EventArgs e)
        {
            Load_Service();

            btn_start.Enabled = false;
            btn_stop.Enabled = false;
            btn_restart.Enabled = false;
            btn_properties.Enabled = false;
        }

        /**/
        void Load_Service()
        {
            dgv_service.Rows.Clear();
            ServiceController[] scServices;
            scServices = ServiceController.GetServices();
            foreach (ServiceController scTemp in scServices)
            {
                ManagementObject wmiService;
                wmiService = new ManagementObject("Win32_Service.Name='" + scTemp.ServiceName + "'");
                wmiService.Get();

                if (scTemp.Status == ServiceControllerStatus.Running)
                {
                    dgv_service.Rows.Add(scTemp.ServiceName, scTemp.DisplayName, wmiService["Description"], "Running", scTemp.StartType);
                }
                else
                {
                    dgv_service.Rows.Add(scTemp.ServiceName, scTemp.DisplayName, wmiService["Description"], "", scTemp.StartType);
                }
            }
        }

        ServiceController sc = new ServiceController();
        private void dgv_service_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string service_name = "";
            string service_type = "";
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgv_service.Rows[e.RowIndex].Selected = true;
                service_name = dgv_service.Rows[e.RowIndex].Cells[0].Value.ToString();
                service_type = dgv_service.Rows[e.RowIndex].Cells[4].Value.ToString();
                btn_start.Enabled = true;
                btn_stop.Enabled = true;
                btn_restart.Enabled = true;
                btn_properties.Enabled = true;
            }
            else
            {
                btn_start.Enabled = false;
                btn_stop.Enabled = false;
                btn_restart.Enabled = false;
                btn_properties.Enabled = false;
            }
            
            if (service_type == "Disabled")
            {
                btn_start.Enabled = false;
                btn_stop.Enabled = false;
                btn_restart.Enabled = false;
                return;
            }

            ServiceController[] scServices;
            scServices = ServiceController.GetServices();
            foreach (ServiceController scTemp in scServices)
            {
                if (service_name == scTemp.ServiceName)
                {
                    sc = scTemp;
                    if (scTemp.Status == ServiceControllerStatus.Stopped)
                   {
                        btn_start.Enabled = true;
                        btn_stop.Enabled = false;
                        btn_restart.Enabled = false;
                   }
                   if (scTemp.Status == ServiceControllerStatus.Running)
                   {
                        btn_start.Enabled = false;
                        btn_stop.Enabled = true;
                   }
                }
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                sc.Start();
                sc.WaitForStatus(ServiceControllerStatus.Running);
                DialogResult result = MessageBox.Show("Start the service successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK) 
                { 
                    Load_Service(); 
                }
            }
            catch (InvalidOperationException)
            {
                DialogResult result =  MessageBox.Show("Could not start the service.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                if (result == DialogResult.OK)
                {
                    Load_Service();
                }
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            try
            {
                sc.Stop();
                sc.WaitForStatus(ServiceControllerStatus.Stopped);
                DialogResult result = MessageBox.Show("Stop the service successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Load_Service();
                }
            }
            catch (InvalidOperationException)
            {
                DialogResult result = MessageBox.Show("Could not stop the service.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                if (result == DialogResult.OK)
                {
                    Load_Service();
                }
            }
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            try
            {
                int timeoutMilliseconds = 1000;
                int millisec1 = Environment.TickCount;
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);
                sc.Stop();
                sc.WaitForStatus(ServiceControllerStatus.Stopped, timeout);


                int millisec2 = Environment.TickCount;
                timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds - (millisec2 - millisec1));
                sc.Start();
                sc.WaitForStatus(ServiceControllerStatus.Running, timeout);

                DialogResult result = MessageBox.Show("Restart the service successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Load_Service();
                }
            }
            catch 
            {
                DialogResult result = MessageBox.Show("Could not restart the service.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                if (result == DialogResult.OK)
                {
                    Load_Service();
                }
            }
        }

        private void btn_properties_Click(object sender, EventArgs e)
        {
            Form2 properties = new Form2(sc);
            properties.Text = sc.DisplayName + " Properties";
            properties.ShowDialog();
        }
    }
}
