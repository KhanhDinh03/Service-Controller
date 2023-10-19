using System;
using System.Diagnostics;
using System.Management;
using System.ServiceProcess;
using System.Windows.Forms;

namespace Service_Controller
{
    public partial class Form2 : Form
    {
        // ServiceController và các biến trạng thái và khởi động của dịch vụ
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
            // Truy vấn thông tin dịch vụ
            ManagementObject wmiService = new ManagementObject("Win32_Service.Name='" + sc.ServiceName + "'");
            wmiService.Get();

            // Hiển thị thông tin dịch vụ
            lb_sv_name.Text = sc.ServiceName;
            lb_dp_name.Text = sc.DisplayName;
            tb_description.Text = (string)wmiService["Description"];
            tb_path.Text = (string)wmiService["PathName"];

            // Xác định và đặt giá trị khởi động dịch vụ trong ComboBox
            if (sc.StartType == ServiceStartMode.Automatic)
            {
                cb_startup_type.SelectedIndex = 0;
            }
            else if (sc.StartType == ServiceStartMode.Manual)
            {
                cb_startup_type.SelectedIndex = 1;
            }
            else
            {
                cb_startup_type.SelectedIndex = 2;
            }

            // Cập nhật trạng thái và trạng thái của nút Start và Stop
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

            // Vô hiệu hóa nút "Apply" ban đầu
            btn_apply.Enabled = false;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            // Thử bắt đầu dịch vụ và hiển thị thông báo
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
            // Thử dừng dịch vụ và hiển thị thông báo
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
            // Đóng form
            this.Hide();
        }

        public event EventHandler<Tuple<string, string>> DataReady;
        private void OnDataReady(string status, string startup_type)
        {
            // Gửi dữ liệu cập nhật về trạng thái và khởi động
            DataReady?.Invoke(this, Tuple.Create(status, startup_type));
        }
        private void btnnn_ok_Click(object sender, EventArgs e)
        {
            // Đóng form và gửi dữ liệu cập nhật
            this.Hide();
            OnDataReady(lb_sv_status.Text, cb_startup_type.Text);
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            // Lấy lựa chọn từ ComboBox và thiết lập loại khởi động tương ứng
            string prompt = "sc config " + sc.ServiceName + " start=";
            switch (cb_startup_type.SelectedIndex)
            {
                case 0:
                    prompt += "auto";
                    break;
                case 1:
                    prompt += "demand";
                    break;
                case 2:
                    prompt += "disabled";
                    break;
            }

            // Gọi hàm để thiết lập loại khởi động
            SetStartupType(prompt);
            btn_apply.Enabled = false;
        }

        void SetStartupType(string prompt)
        {
            // Sử dụng Process để thực hiện lệnh cmd
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
            cmdProcess.StandardInput.WriteLine(prompt);
            cmdProcess.StandardInput.Close();
            cmdProcess.WaitForExit();
            cmdProcess.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Gửi dữ liệu cập nhật khi form bị đóng
            OnDataReady(lb_sv_status.Text, cb_startup_type.Text);
        }

        private void cb_startup_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi lựa chọn ComboBox thay đổi, cho phép nút "Apply"
            btn_apply.Enabled = true;
        }
    }
}
