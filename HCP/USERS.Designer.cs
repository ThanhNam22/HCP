namespace HCP
{
    partial class frmUSERS
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
            txtUSERNAME = new TextBox();
            txtPassword = new TextBox();
            txtFullName = new TextBox();
            txtStaff = new TextBox();
            chkActive = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtUSERNAME
            // 
            txtUSERNAME.Location = new Point(182, 28);
            txtUSERNAME.Margin = new Padding(3, 4, 3, 4);
            txtUSERNAME.Name = "txtUSERNAME";
            txtUSERNAME.ReadOnly = true;
            txtUSERNAME.Size = new Size(297, 27);
            txtUSERNAME.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(182, 77);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(297, 27);
            txtPassword.TabIndex = 1;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(182, 127);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.ReadOnly = true;
            txtFullName.Size = new Size(294, 27);
            txtFullName.TabIndex = 2;
            txtFullName.TextChanged += txtFullName_TextChanged;
            // 
            // txtStaff
            // 
            txtStaff.Location = new Point(182, 176);
            txtStaff.Margin = new Padding(3, 4, 3, 4);
            txtStaff.Name = "txtStaff";
            txtStaff.ReadOnly = true;
            txtStaff.Size = new Size(297, 27);
            txtStaff.TabIndex = 3;
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Enabled = false;
            chkActive.Location = new Point(182, 225);
            chkActive.Margin = new Padding(3, 4, 3, 4);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(18, 17);
            chkActive.TabIndex = 4;
            chkActive.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 32);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 5;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 84);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 6;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 130);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 176);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 8;
            label4.Text = "Staff";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 279);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(887, 256);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(30, 557);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(129, 35);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(176, 557);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(129, 35);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(322, 557);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(129, 35);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(469, 557);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(129, 35);
            btnLuu.TabIndex = 13;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(615, 557);
            btnHuy.Margin = new Padding(3, 4, 3, 4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(129, 35);
            btnHuy.TabIndex = 14;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(761, 557);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(129, 35);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 225);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 16;
            label5.Text = "Active";
            // 
            // frmUSERS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 613);
            Controls.Add(label5);
            Controls.Add(btnThoat);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chkActive);
            Controls.Add(txtStaff);
            Controls.Add(txtFullName);
            Controls.Add(txtPassword);
            Controls.Add(txtUSERNAME);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmUSERS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "USERS";
            Load += frmUSERS_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUSERNAME;
        private TextBox txtPassword;
        private TextBox txtFullName;
        private TextBox txtStaff;
        private CheckBox chkActive;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnHuy;
        private Button btnThoat;
        private Label label5;
    }
}