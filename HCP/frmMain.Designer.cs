namespace HCP
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.rdoShowAlertOnly = new System.Windows.Forms.RadioButton();
            this.rdoShowAll = new System.Windows.Forms.RadioButton();
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cboSession = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colPROFILEID = new System.Windows.Forms.ColumnHeader();
            this.colPATIENTID = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.lsvService = new System.Windows.Forms.ListView();
            this.colServiceDate = new System.Windows.Forms.ColumnHeader();
            this.colServiceCode = new System.Windows.Forms.ColumnHeader();
            this.cmdRuleCompose = new System.Windows.Forms.Button();
            this.txtDeagnoseDetails = new System.Windows.Forms.TextBox();
            this.lsvMedical = new System.Windows.Forms.ListView();
            this.colMedicalDate = new System.Windows.Forms.ColumnHeader();
            this.colMedicalCode = new System.Windows.Forms.ColumnHeader();
            this.lsvMaterial = new System.Windows.Forms.ListView();
            this.colMaterialDate = new System.Windows.Forms.ColumnHeader();
            this.colMaterialCode = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.colDate = new System.Windows.Forms.ColumnHeader();
            this.colDiasea = new System.Windows.Forms.ColumnHeader();
            this.txtSessionStatus = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // rdoShowAlertOnly
            // 
            this.rdoShowAlertOnly.AutoSize = true;
            this.rdoShowAlertOnly.Location = new System.Drawing.Point(911, 28);
            this.rdoShowAlertOnly.Name = "rdoShowAlertOnly";
            this.rdoShowAlertOnly.Size = new System.Drawing.Size(169, 19);
            this.rdoShowAlertOnly.TabIndex = 5;
            this.rdoShowAlertOnly.Text = "Chỉ hiện hồ sơ có cảnh báo";
            this.rdoShowAlertOnly.UseVisualStyleBackColor = true;
            this.rdoShowAlertOnly.CheckedChanged += new System.EventHandler(this.rdoShowAlertOnly_CheckedChanged);
            // 
            // rdoShowAll
            // 
            this.rdoShowAll.AutoSize = true;
            this.rdoShowAll.Checked = true;
            this.rdoShowAll.Location = new System.Drawing.Point(791, 27);
            this.rdoShowAll.Name = "rdoShowAll";
            this.rdoShowAll.Size = new System.Drawing.Size(114, 19);
            this.rdoShowAll.TabIndex = 4;
            this.rdoShowAll.TabStop = true;
            this.rdoShowAll.Text = "Hiện tất cả hồ sơ";
            this.rdoShowAll.UseVisualStyleBackColor = true;
            this.rdoShowAll.CheckedChanged += new System.EventHandler(this.rdoShowAll_CheckedChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTime.Location = new System.Drawing.Point(561, 25);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(72, 21);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "08:59:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hôm nay:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cboSession
            // 
            this.cboSession.FormattingEnabled = true;
            this.cboSession.Location = new System.Drawing.Point(21, 23);
            this.cboSession.Name = "cboSession";
            this.cboSession.Size = new System.Drawing.Size(218, 23);
            this.cboSession.TabIndex = 1;
            this.cboSession.SelectedIndexChanged += new System.EventHandler(this.cboSession_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn một phiên làm việc";
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AutoArrange = false;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPROFILEID,
            this.colPATIENTID,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(21, 72);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(462, 554);
            this.listView1.TabIndex = 3;
            this.toolTip1.SetToolTip(this.listView1, "Why you see this alert ?");
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listView1_ItemCheck);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // colPROFILEID
            // 
            this.colPROFILEID.Text = "Mã HS";
            this.colPROFILEID.Width = 120;
            // 
            // colPATIENTID
            // 
            this.colPATIENTID.Text = "Mã bệnh nhân";
            this.colPATIENTID.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày nhập viện";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã phòng";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mã khoa";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Doctor";
            this.columnHeader8.Width = 120;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hồ sơ y tế";
            // 
            // lsvService
            // 
            this.lsvService.BackColor = System.Drawing.Color.White;
            this.lsvService.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colServiceDate,
            this.colServiceCode});
            this.lsvService.FullRowSelect = true;
            this.lsvService.GridLines = true;
            this.lsvService.Location = new System.Drawing.Point(500, 281);
            this.lsvService.Name = "lsvService";
            this.lsvService.Size = new System.Drawing.Size(271, 345);
            this.lsvService.TabIndex = 6;
            this.lsvService.UseCompatibleStateImageBehavior = false;
            this.lsvService.View = System.Windows.Forms.View.Details;
            // 
            // colServiceDate
            // 
            this.colServiceDate.Text = "Ngày sử dụng";
            this.colServiceDate.Width = 120;
            // 
            // colServiceCode
            // 
            this.colServiceCode.Text = "Mã dịch vụ";
            this.colServiceCode.Width = 148;
            // 
            // cmdRuleCompose
            // 
            this.cmdRuleCompose.Location = new System.Drawing.Point(1227, 12);
            this.cmdRuleCompose.Name = "cmdRuleCompose";
            this.cmdRuleCompose.Size = new System.Drawing.Size(118, 41);
            this.cmdRuleCompose.TabIndex = 10;
            this.cmdRuleCompose.Text = "Soạn luật";
            this.cmdRuleCompose.UseVisualStyleBackColor = true;
            // 
            // txtDeagnoseDetails
            // 
            this.txtDeagnoseDetails.BackColor = System.Drawing.SystemColors.Info;
            this.txtDeagnoseDetails.Location = new System.Drawing.Point(787, 72);
            this.txtDeagnoseDetails.Multiline = true;
            this.txtDeagnoseDetails.Name = "txtDeagnoseDetails";
            this.txtDeagnoseDetails.Size = new System.Drawing.Size(558, 169);
            this.txtDeagnoseDetails.TabIndex = 2;
            // 
            // lsvMedical
            // 
            this.lsvMedical.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMedicalDate,
            this.colMedicalCode});
            this.lsvMedical.FullRowSelect = true;
            this.lsvMedical.GridLines = true;
            this.lsvMedical.Location = new System.Drawing.Point(787, 281);
            this.lsvMedical.Name = "lsvMedical";
            this.lsvMedical.Size = new System.Drawing.Size(271, 345);
            this.lsvMedical.TabIndex = 11;
            this.lsvMedical.UseCompatibleStateImageBehavior = false;
            this.lsvMedical.View = System.Windows.Forms.View.Details;
            // 
            // colMedicalDate
            // 
            this.colMedicalDate.Text = "Ngày chỉ định";
            this.colMedicalDate.Width = 120;
            // 
            // colMedicalCode
            // 
            this.colMedicalCode.Text = "Mã thuốc";
            this.colMedicalCode.Width = 148;
            // 
            // lsvMaterial
            // 
            this.lsvMaterial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaterialDate,
            this.colMaterialCode});
            this.lsvMaterial.FullRowSelect = true;
            this.lsvMaterial.GridLines = true;
            this.lsvMaterial.Location = new System.Drawing.Point(1074, 281);
            this.lsvMaterial.Name = "lsvMaterial";
            this.lsvMaterial.Size = new System.Drawing.Size(271, 345);
            this.lsvMaterial.TabIndex = 12;
            this.lsvMaterial.UseCompatibleStateImageBehavior = false;
            this.lsvMaterial.View = System.Windows.Forms.View.Details;
            // 
            // colMaterialDate
            // 
            this.colMaterialDate.Text = "Ngày chỉ định";
            this.colMaterialDate.Width = 120;
            // 
            // colMaterialCode
            // 
            this.colMaterialCode.Text = "Mã vật tư/ hóa chất";
            this.colMaterialCode.Width = 148;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Chỉ định dịch vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(790, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Chỉ định thuốc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1074, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Chỉ định vật tư y tế/ hóa chất";
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.Info;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDate,
            this.colDiasea});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(498, 74);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(271, 167);
            this.listView2.TabIndex = 18;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // colDate
            // 
            this.colDate.Text = "Ngày chẩn đoán";
            this.colDate.Width = 120;
            // 
            // colDiasea
            // 
            this.colDiasea.Text = "Mã bệnh";
            this.colDiasea.Width = 148;
            // 
            // txtSessionStatus
            // 
            this.txtSessionStatus.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSessionStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSessionStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSessionStatus.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtSessionStatus.Location = new System.Drawing.Point(245, 23);
            this.txtSessionStatus.Name = "txtSessionStatus";
            this.txtSessionStatus.Size = new System.Drawing.Size(237, 23);
            this.txtSessionStatus.TabIndex = 19;
            this.txtSessionStatus.Text = "Dữ liệu chưa được đồng bộ";
            this.txtSessionStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 645);
            this.Controls.Add(this.txtSessionStatus);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lsvMaterial);
            this.Controls.Add(this.lsvMedical);
            this.Controls.Add(this.txtDeagnoseDetails);
            this.Controls.Add(this.cmdRuleCompose);
            this.Controls.Add(this.lsvService);
            this.Controls.Add(this.rdoShowAlertOnly);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdoShowAll);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSession);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Hỗ trợ tra soát hồ sơ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblTime;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private RadioButton rdoShowAlertOnly;
        private RadioButton rdoShowAll;
        private ComboBox cboSession;
        private Label label2;
        private ListView listView1;
        private Label label3;
        private ListView lsvService;
        private Button cmdRuleCompose;
        private ColumnHeader colPROFILEID;
        private ColumnHeader colPATIENTID;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader8;
        private TextBox txtDeagnoseDetails;
        private ListView lsvMedical;
        private ListView lsvMaterial;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListView listView2;
        private ColumnHeader colDate;
        private ColumnHeader colDiasea;
        private ColumnHeader colServiceDate;
        private ColumnHeader colServiceCode;
        private ColumnHeader colMedicalDate;
        private ColumnHeader colMedicalCode;
        private ColumnHeader colMaterialDate;
        private ColumnHeader colMaterialCode;
        private TextBox txtSessionStatus;
        private ToolTip toolTip1;
    }
}