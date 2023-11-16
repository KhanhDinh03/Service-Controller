namespace Service_Controller
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_properties = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_restart = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_stop = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_start = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_service = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_service)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 461);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_properties, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_restart, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_stop, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_start, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 404);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(834, 57);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btn_properties
            // 
            this.btn_properties.AllowAnimations = true;
            this.btn_properties.AllowMouseEffects = true;
            this.btn_properties.AllowToggling = false;
            this.btn_properties.AnimationSpeed = 200;
            this.btn_properties.AutoGenerateColors = false;
            this.btn_properties.AutoRoundBorders = false;
            this.btn_properties.AutoSizeLeftIcon = true;
            this.btn_properties.AutoSizeRightIcon = true;
            this.btn_properties.BackColor = System.Drawing.Color.Transparent;
            this.btn_properties.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_properties.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_properties.BackgroundImage")));
            this.btn_properties.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_properties.ButtonText = "Properties";
            this.btn_properties.ButtonTextMarginLeft = 0;
            this.btn_properties.ColorContrastOnClick = 45;
            this.btn_properties.ColorContrastOnHover = 45;
            this.btn_properties.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_properties.CustomizableEdges = borderEdges1;
            this.btn_properties.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_properties.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_properties.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_properties.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_properties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_properties.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_properties.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_properties.ForeColor = System.Drawing.Color.White;
            this.btn_properties.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_properties.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_properties.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_properties.IconMarginLeft = 11;
            this.btn_properties.IconPadding = 10;
            this.btn_properties.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_properties.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_properties.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_properties.IconSize = 25;
            this.btn_properties.IdleBorderColor = System.Drawing.Color.White;
            this.btn_properties.IdleBorderRadius = 20;
            this.btn_properties.IdleBorderThickness = 1;
            this.btn_properties.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_properties.IdleIconLeftImage = null;
            this.btn_properties.IdleIconRightImage = null;
            this.btn_properties.IndicateFocus = false;
            this.btn_properties.Location = new System.Drawing.Point(627, 3);
            this.btn_properties.Name = "btn_properties";
            this.btn_properties.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_properties.OnDisabledState.BorderRadius = 20;
            this.btn_properties.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_properties.OnDisabledState.BorderThickness = 1;
            this.btn_properties.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_properties.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_properties.OnDisabledState.IconLeftImage = null;
            this.btn_properties.OnDisabledState.IconRightImage = null;
            this.btn_properties.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btn_properties.onHoverState.BorderRadius = 20;
            this.btn_properties.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_properties.onHoverState.BorderThickness = 1;
            this.btn_properties.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_properties.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_properties.onHoverState.IconLeftImage = null;
            this.btn_properties.onHoverState.IconRightImage = null;
            this.btn_properties.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn_properties.OnIdleState.BorderRadius = 20;
            this.btn_properties.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_properties.OnIdleState.BorderThickness = 1;
            this.btn_properties.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_properties.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_properties.OnIdleState.IconLeftImage = null;
            this.btn_properties.OnIdleState.IconRightImage = null;
            this.btn_properties.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btn_properties.OnPressedState.BorderRadius = 20;
            this.btn_properties.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_properties.OnPressedState.BorderThickness = 1;
            this.btn_properties.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_properties.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_properties.OnPressedState.IconLeftImage = null;
            this.btn_properties.OnPressedState.IconRightImage = null;
            this.btn_properties.Size = new System.Drawing.Size(204, 51);
            this.btn_properties.TabIndex = 7;
            this.btn_properties.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_properties.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_properties.TextMarginLeft = 0;
            this.btn_properties.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_properties.UseDefaultRadiusAndThickness = true;
            this.btn_properties.Click += new System.EventHandler(this.btn_properties_Click);
            // 
            // btn_restart
            // 
            this.btn_restart.AllowAnimations = true;
            this.btn_restart.AllowMouseEffects = true;
            this.btn_restart.AllowToggling = false;
            this.btn_restart.AnimationSpeed = 200;
            this.btn_restart.AutoGenerateColors = false;
            this.btn_restart.AutoRoundBorders = false;
            this.btn_restart.AutoSizeLeftIcon = true;
            this.btn_restart.AutoSizeRightIcon = true;
            this.btn_restart.BackColor = System.Drawing.Color.Transparent;
            this.btn_restart.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_restart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_restart.BackgroundImage")));
            this.btn_restart.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_restart.ButtonText = "Restart";
            this.btn_restart.ButtonTextMarginLeft = 0;
            this.btn_restart.ColorContrastOnClick = 45;
            this.btn_restart.ColorContrastOnHover = 45;
            this.btn_restart.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_restart.CustomizableEdges = borderEdges2;
            this.btn_restart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_restart.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_restart.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_restart.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_restart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_restart.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_restart.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_restart.ForeColor = System.Drawing.Color.White;
            this.btn_restart.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_restart.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_restart.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_restart.IconMarginLeft = 11;
            this.btn_restart.IconPadding = 10;
            this.btn_restart.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_restart.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_restart.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_restart.IconSize = 25;
            this.btn_restart.IdleBorderColor = System.Drawing.Color.White;
            this.btn_restart.IdleBorderRadius = 20;
            this.btn_restart.IdleBorderThickness = 1;
            this.btn_restart.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_restart.IdleIconLeftImage = null;
            this.btn_restart.IdleIconRightImage = null;
            this.btn_restart.IndicateFocus = false;
            this.btn_restart.Location = new System.Drawing.Point(419, 3);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_restart.OnDisabledState.BorderRadius = 20;
            this.btn_restart.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_restart.OnDisabledState.BorderThickness = 1;
            this.btn_restart.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_restart.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_restart.OnDisabledState.IconLeftImage = null;
            this.btn_restart.OnDisabledState.IconRightImage = null;
            this.btn_restart.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btn_restart.onHoverState.BorderRadius = 20;
            this.btn_restart.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_restart.onHoverState.BorderThickness = 1;
            this.btn_restart.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_restart.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_restart.onHoverState.IconLeftImage = null;
            this.btn_restart.onHoverState.IconRightImage = null;
            this.btn_restart.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn_restart.OnIdleState.BorderRadius = 20;
            this.btn_restart.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_restart.OnIdleState.BorderThickness = 1;
            this.btn_restart.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_restart.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_restart.OnIdleState.IconLeftImage = null;
            this.btn_restart.OnIdleState.IconRightImage = null;
            this.btn_restart.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btn_restart.OnPressedState.BorderRadius = 20;
            this.btn_restart.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_restart.OnPressedState.BorderThickness = 1;
            this.btn_restart.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_restart.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_restart.OnPressedState.IconLeftImage = null;
            this.btn_restart.OnPressedState.IconRightImage = null;
            this.btn_restart.Size = new System.Drawing.Size(202, 51);
            this.btn_restart.TabIndex = 6;
            this.btn_restart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_restart.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_restart.TextMarginLeft = 0;
            this.btn_restart.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_restart.UseDefaultRadiusAndThickness = true;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.AllowAnimations = true;
            this.btn_stop.AllowMouseEffects = true;
            this.btn_stop.AllowToggling = false;
            this.btn_stop.AnimationSpeed = 200;
            this.btn_stop.AutoGenerateColors = false;
            this.btn_stop.AutoRoundBorders = false;
            this.btn_stop.AutoSizeLeftIcon = true;
            this.btn_stop.AutoSizeRightIcon = true;
            this.btn_stop.BackColor = System.Drawing.Color.Transparent;
            this.btn_stop.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_stop.BackgroundImage")));
            this.btn_stop.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_stop.ButtonText = "Stop";
            this.btn_stop.ButtonTextMarginLeft = 0;
            this.btn_stop.ColorContrastOnClick = 45;
            this.btn_stop.ColorContrastOnHover = 45;
            this.btn_stop.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btn_stop.CustomizableEdges = borderEdges3;
            this.btn_stop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_stop.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_stop.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_stop.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_stop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_stop.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_stop.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_stop.ForeColor = System.Drawing.Color.White;
            this.btn_stop.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stop.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_stop.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_stop.IconMarginLeft = 11;
            this.btn_stop.IconPadding = 10;
            this.btn_stop.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_stop.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_stop.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_stop.IconSize = 25;
            this.btn_stop.IdleBorderColor = System.Drawing.Color.White;
            this.btn_stop.IdleBorderRadius = 20;
            this.btn_stop.IdleBorderThickness = 1;
            this.btn_stop.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_stop.IdleIconLeftImage = null;
            this.btn_stop.IdleIconRightImage = null;
            this.btn_stop.IndicateFocus = false;
            this.btn_stop.Location = new System.Drawing.Point(211, 3);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_stop.OnDisabledState.BorderRadius = 20;
            this.btn_stop.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_stop.OnDisabledState.BorderThickness = 1;
            this.btn_stop.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_stop.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_stop.OnDisabledState.IconLeftImage = null;
            this.btn_stop.OnDisabledState.IconRightImage = null;
            this.btn_stop.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btn_stop.onHoverState.BorderRadius = 20;
            this.btn_stop.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_stop.onHoverState.BorderThickness = 1;
            this.btn_stop.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_stop.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_stop.onHoverState.IconLeftImage = null;
            this.btn_stop.onHoverState.IconRightImage = null;
            this.btn_stop.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn_stop.OnIdleState.BorderRadius = 20;
            this.btn_stop.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_stop.OnIdleState.BorderThickness = 1;
            this.btn_stop.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_stop.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_stop.OnIdleState.IconLeftImage = null;
            this.btn_stop.OnIdleState.IconRightImage = null;
            this.btn_stop.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btn_stop.OnPressedState.BorderRadius = 20;
            this.btn_stop.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_stop.OnPressedState.BorderThickness = 1;
            this.btn_stop.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_stop.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_stop.OnPressedState.IconLeftImage = null;
            this.btn_stop.OnPressedState.IconRightImage = null;
            this.btn_stop.Size = new System.Drawing.Size(202, 51);
            this.btn_stop.TabIndex = 5;
            this.btn_stop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_stop.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_stop.TextMarginLeft = 0;
            this.btn_stop.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_stop.UseDefaultRadiusAndThickness = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_start
            // 
            this.btn_start.AllowAnimations = true;
            this.btn_start.AllowMouseEffects = true;
            this.btn_start.AllowToggling = false;
            this.btn_start.AnimationSpeed = 200;
            this.btn_start.AutoGenerateColors = false;
            this.btn_start.AutoRoundBorders = false;
            this.btn_start.AutoSizeLeftIcon = true;
            this.btn_start.AutoSizeRightIcon = true;
            this.btn_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_start.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_start.BackgroundImage")));
            this.btn_start.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_start.ButtonText = "Start";
            this.btn_start.ButtonTextMarginLeft = 0;
            this.btn_start.ColorContrastOnClick = 45;
            this.btn_start.ColorContrastOnHover = 45;
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btn_start.CustomizableEdges = borderEdges4;
            this.btn_start.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_start.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_start.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_start.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_start.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_start.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.White;
            this.btn_start.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_start.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_start.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_start.IconMarginLeft = 11;
            this.btn_start.IconPadding = 10;
            this.btn_start.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_start.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_start.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_start.IconSize = 25;
            this.btn_start.IdleBorderColor = System.Drawing.Color.White;
            this.btn_start.IdleBorderRadius = 20;
            this.btn_start.IdleBorderThickness = 1;
            this.btn_start.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_start.IdleIconLeftImage = null;
            this.btn_start.IdleIconRightImage = null;
            this.btn_start.IndicateFocus = false;
            this.btn_start.Location = new System.Drawing.Point(3, 3);
            this.btn_start.Name = "btn_start";
            this.btn_start.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_start.OnDisabledState.BorderRadius = 20;
            this.btn_start.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_start.OnDisabledState.BorderThickness = 1;
            this.btn_start.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_start.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_start.OnDisabledState.IconLeftImage = null;
            this.btn_start.OnDisabledState.IconRightImage = null;
            this.btn_start.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btn_start.onHoverState.BorderRadius = 20;
            this.btn_start.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_start.onHoverState.BorderThickness = 1;
            this.btn_start.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_start.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_start.onHoverState.IconLeftImage = null;
            this.btn_start.onHoverState.IconRightImage = null;
            this.btn_start.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn_start.OnIdleState.BorderRadius = 20;
            this.btn_start.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_start.OnIdleState.BorderThickness = 1;
            this.btn_start.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_start.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_start.OnIdleState.IconLeftImage = null;
            this.btn_start.OnIdleState.IconRightImage = null;
            this.btn_start.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btn_start.OnPressedState.BorderRadius = 20;
            this.btn_start.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_start.OnPressedState.BorderThickness = 1;
            this.btn_start.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_start.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_start.OnPressedState.IconLeftImage = null;
            this.btn_start.OnPressedState.IconRightImage = null;
            this.btn_start.Size = new System.Drawing.Size(202, 51);
            this.btn_start.TabIndex = 4;
            this.btn_start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_start.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_start.TextMarginLeft = 0;
            this.btn_start.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_start.UseDefaultRadiusAndThickness = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_service);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 411);
            this.panel2.TabIndex = 0;
            // 
            // dgv_service
            // 
            this.dgv_service.AllowCustomTheming = true;
            this.dgv_service.AllowUserToAddRows = false;
            this.dgv_service.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgv_service.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_service.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_service.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_service.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dgv_service.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_service.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_service.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_service.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_service.ColumnHeadersHeight = 40;
            this.dgv_service.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_service.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgv_service.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_service.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_service.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgv_service.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_service.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgv_service.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgv_service.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgv_service.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv_service.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_service.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.dgv_service.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_service.CurrentTheme.Name = null;
            this.dgv_service.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgv_service.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_service.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_service.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgv_service.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_service.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_service.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_service.EnableHeadersVisualStyles = false;
            this.dgv_service.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgv_service.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgv_service.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_service.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_service.Location = new System.Drawing.Point(0, 0);
            this.dgv_service.MultiSelect = false;
            this.dgv_service.Name = "dgv_service";
            this.dgv_service.ReadOnly = true;
            this.dgv_service.RowHeadersVisible = false;
            this.dgv_service.RowTemplate.Height = 40;
            this.dgv_service.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_service.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_service.Size = new System.Drawing.Size(834, 411);
            this.dgv_service.TabIndex = 1;
            this.dgv_service.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            this.dgv_service.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_service_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Service Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Display Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Status";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Startup Type";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Controller";
            this.Load += new System.EventHandler(this.Service_controller_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_service)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_start;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_stop;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_properties;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_restart;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

