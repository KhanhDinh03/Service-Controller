namespace Service_Controller
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label8 = new System.Windows.Forms.Label();
            this.btnnn_ok = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.lb_sv_status = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_startup_type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_dp_name = new System.Windows.Forms.Label();
            this.lb_sv_name = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-12, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(409, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------------------------";
            // 
            // btnnn_ok
            // 
            this.btnnn_ok.Location = new System.Drawing.Point(141, 362);
            this.btnnn_ok.Name = "btnnn_ok";
            this.btnnn_ok.Size = new System.Drawing.Size(68, 23);
            this.btnnn_ok.TabIndex = 53;
            this.btnnn_ok.Text = "OK";
            this.btnnn_ok.UseVisualStyleBackColor = true;
            this.btnnn_ok.Click += new System.EventHandler(this.btnnn_ok_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(409, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------------------------";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(216, 362);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(68, 23);
            this.btn_cancel.TabIndex = 51;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(226, 297);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(112, 23);
            this.btn_stop.TabIndex = 50;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(38, 297);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(112, 23);
            this.btn_start.TabIndex = 49;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lb_sv_status
            // 
            this.lb_sv_status.AutoSize = true;
            this.lb_sv_status.Location = new System.Drawing.Point(104, 258);
            this.lb_sv_status.Name = "lb_sv_status";
            this.lb_sv_status.Size = new System.Drawing.Size(0, 13);
            this.lb_sv_status.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Service status:";
            // 
            // cb_startup_type
            // 
            this.cb_startup_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_startup_type.FormattingEnabled = true;
            this.cb_startup_type.Items.AddRange(new object[] {
            "Automatic",
            "Manual",
            "Disabled"});
            this.cb_startup_type.Location = new System.Drawing.Point(107, 208);
            this.cb_startup_type.Name = "cb_startup_type";
            this.cb_startup_type.Size = new System.Drawing.Size(255, 21);
            this.cb_startup_type.TabIndex = 46;
            this.cb_startup_type.SelectedIndexChanged += new System.EventHandler(this.cb_startup_type_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Startup type:";
            // 
            // tb_path
            // 
            this.tb_path.BackColor = System.Drawing.Color.White;
            this.tb_path.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_path.Location = new System.Drawing.Point(17, 165);
            this.tb_path.Multiline = true;
            this.tb_path.Name = "tb_path";
            this.tb_path.ReadOnly = true;
            this.tb_path.Size = new System.Drawing.Size(345, 32);
            this.tb_path.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Path to executable:";
            // 
            // lb_dp_name
            // 
            this.lb_dp_name.AutoSize = true;
            this.lb_dp_name.Location = new System.Drawing.Point(104, 53);
            this.lb_dp_name.Name = "lb_dp_name";
            this.lb_dp_name.Size = new System.Drawing.Size(75, 13);
            this.lb_dp_name.TabIndex = 42;
            this.lb_dp_name.Text = "Service name:";
            // 
            // lb_sv_name
            // 
            this.lb_sv_name.AutoSize = true;
            this.lb_sv_name.Location = new System.Drawing.Point(104, 20);
            this.lb_sv_name.Name = "lb_sv_name";
            this.lb_sv_name.Size = new System.Drawing.Size(75, 13);
            this.lb_sv_name.TabIndex = 41;
            this.lb_sv_name.Text = "Service name:";
            // 
            // tb_description
            // 
            this.tb_description.BackColor = System.Drawing.Color.White;
            this.tb_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_description.Location = new System.Drawing.Point(83, 81);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.ReadOnly = true;
            this.tb_description.Size = new System.Drawing.Size(279, 61);
            this.tb_description.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Display name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Service name:";
            // 
            // btn_apply
            // 
            this.btn_apply.Enabled = false;
            this.btn_apply.Location = new System.Drawing.Point(294, 362);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(68, 23);
            this.btn_apply.TabIndex = 55;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 397);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnnn_ok);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lb_sv_status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_startup_type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_dp_name);
            this.Controls.Add(this.lb_sv_name);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Properties";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnnn_ok;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lb_sv_status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_startup_type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_dp_name;
        private System.Windows.Forms.Label lb_sv_name;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_apply;
    }
}