namespace HCP
{
    partial class frmExplannation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtClose = new System.Windows.Forms.Button();
            this.txtExp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tại sao bạn thấy cảnh báo này ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tình trạng của hồ sơ";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(146, 14);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(506, 23);
            this.txtStatus.TabIndex = 2;
            // 
            // txtClose
            // 
            this.txtClose.Location = new System.Drawing.Point(548, 340);
            this.txtClose.Name = "txtClose";
            this.txtClose.Size = new System.Drawing.Size(104, 35);
            this.txtClose.TabIndex = 3;
            this.txtClose.Text = "Thoát";
            this.txtClose.UseVisualStyleBackColor = true;
            this.txtClose.Click += new System.EventHandler(this.txtClose_Click);
            // 
            // txtExp
            // 
            this.txtExp.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtExp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExp.Location = new System.Drawing.Point(17, 91);
            this.txtExp.Multiline = true;
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(635, 233);
            this.txtExp.TabIndex = 4;
            // 
            // frmExplannation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(664, 387);
            this.Controls.Add(this.txtExp);
            this.Controls.Add(this.txtClose);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "frmExplannation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information in details";
            this.Load += new System.EventHandler(this.frmExplannation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtStatus;
        private Button txtClose;
        private TextBox txtExp;
    }
}