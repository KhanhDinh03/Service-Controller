using System;
using System.Management;
using System.ServiceProcess;
using System.Windows.Forms;

namespace Service_Controller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Service_controller_Load(object sender, EventArgs e)
        {
            // Load danh sách dịch vụ khi form được tải
            Load_Service();

            // Vô hiệu hóa các nút khi form được nạp
            btn_start.Enabled = false;
            btn_stop.Enabled = false;
            btn_restart.Enabled = false;
            btn_properties.Enabled = false;
        }

        // Hàm để nạp danh sách dịch vụ
        void Load_Service()
        {
            // Xóa tất cả các dòng hiện có trong DataGridView
            dgv_service.Rows.Clear();

            // Lấy danh sách dịch vụ và thêm chúng vào DataGridView
            ServiceController[] scServices;
            scServices = ServiceController.GetServices();
            foreach (ServiceController scTemp in scServices)
            {
                ManagementObject wmiService;
                wmiService = new ManagementObject("Win32_Service.Name='" + scTemp.ServiceName + "'");
                wmiService.Get();

                // Thêm dịch vụ vào DataGridView
                dgv_service.Rows.Add(scTemp.ServiceName, scTemp.DisplayName, wmiService["Description"], scTemp.Status, scTemp.StartType);
            }
        }

        ServiceController sc = new ServiceController();
        int row = -1;

        private void dgv_service_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xác định hàng được chọn khi người dùng nhấp vào DataGridView
            row = dgv_service.CurrentCell.RowIndex;
            string service_name = "";
            string service_type = "";

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Đánh dấu hàng đã chọn và lấy thông tin dịch vụ
                dgv_service.Rows[e.RowIndex].Selected = true;
                service_name = dgv_service.Rows[e.RowIndex].Cells[0].Value.ToString();
                service_type = dgv_service.Rows[e.RowIndex].Cells[4].Value.ToString();

                // Kích hoạt các nút điều khiển dịch vụ
                btn_start.Enabled = true;
                btn_stop.Enabled = true;
                btn_restart.Enabled = true;
                btn_properties.Enabled = true;
            }
            else
            {
                // Vô hiệu hóa nút khi không có hàng nào được chọn
                btn_start.Enabled = false;
                btn_stop.Enabled = false;
                btn_restart.Enabled = false;
                btn_properties.Enabled = false;
            }

            if (service_type == "Disabled")
            {
                // Vô hiệu hóa nút Start và Stop nếu dịch vụ đã bị tắt
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
                        // Nếu dịch vụ đã dừng, kích hoạt nút Start
                        btn_start.Enabled = true;
                        btn_stop.Enabled = false;
                        btn_restart.Enabled = false;
                    }
                    if (scTemp.Status == ServiceControllerStatus.Running)
                    {
                        // Nếu dịch vụ đang chạy, kích hoạt nút Stop
                        btn_start.Enabled = false;
                        btn_stop.Enabled = true;
                    }
                }
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            // Thử bắt đầu dịch vụ và hiển thị thông báo
            try
            {
                sc.Start();
                sc.WaitForStatus(ServiceControllerStatus.Running);
                DialogResult result = MessageBox.Show("Start the service successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    dgv_service.Rows[row].Cells[3].Value = "Running";
                    btn_start.Enabled = false;
                    btn_stop.Enabled = true;
                    btn_restart.Enabled = true;
                }
            }
            catch (InvalidOperationException)
            {
                // Hiển thị thông báo lỗi nếu không thể bắt đầu dịch vụ
                DialogResult result = MessageBox.Show("Could not start the service.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                if (result == DialogResult.OK)
                {
                    // Nếu người dùng chọn OK, tải lại danh sách dịch vụ
                    Load_Service();
                }
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            // Thử dừng dịch vụ và hiển thị thông báo
            try
            {
                // Thử dừng dịch vụ và hiển thị thông báo
                sc.Stop();
                sc.WaitForStatus(ServiceControllerStatus.Stopped);
                DialogResult result = MessageBox.Show("Stop the service successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    // Cập nhật trạng thái dịch vụ và nút điều khiển
                    dgv_service.Rows[row].Cells[3].Value = "Stopped";
                    btn_start.Enabled = true;
                    btn_stop.Enabled = false;
                    btn_restart.Enabled = false;
                }
            }
            catch (InvalidOperationException)
            {
                // Hiển thị thông báo lỗi nếu không thể dừng dịch vụ
                DialogResult result = MessageBox.Show("Could not stop the service.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                if (result == DialogResult.OK)
                {
                    // Nếu người dùng chọn OK, tải lại danh sách dịch vụ
                    Load_Service();
                }
            }
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            // Thử khởi động lại dịch vụ và hiển thị thông báo
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
                    // Nếu người dùng chọn OK, tải lại danh sách dịch vụ
                    Load_Service();
                }
            }
            catch
            {
                // Hiển thị thông báo lỗi nếu không thể khởi động lại dịch vụ
                DialogResult result = MessageBox.Show("Could not restart the service.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                if (result == DialogResult.OK)
                {
                    // Nếu người dùng chọn OK, tải lại danh sách dịch vụ
                    Load_Service();
                }
            }
        }

        private void btn_properties_Click(object sender, EventArgs e)
        {
            // Mở form Properties và chuyển dữ liệu cần thiết
            string status = dgv_service.Rows[row].Cells[3].ToString();
            string startup_type = dgv_service.Rows[row].Cells[4].ToString();
            Form2 properties = new Form2(sc, status, startup_type);
            properties.DataReady += Form2_DataReady;
            properties.Text = sc.DisplayName + " Properties";
            properties.ShowDialog();
        }

        private void Form2_DataReady(object sender, Tuple<string, string> data)
        {
            // Cập nhật thông tin về trạng thái và khởi động của dịch vụ
            dgv_service.Rows[row].Cells[3].Value = data.Item1;
            dgv_service.Rows[row].Cells[4].Value = data.Item2;
            dgv_service.InvalidateRow(row);
        }
    }
}
