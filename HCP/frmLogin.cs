using adao_lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCP
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Show();
            this.txtUserName.Focus();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            UsersUpdate usu = new UsersUpdate();
            DataTable u = usu.getUserPass(this.txtUserName.Text.Trim(), this.txtPassword.Text.Trim());
            if (u.Rows.Count == 0)
            {
                DialogResult result = new DialogResult();
                result = MessageBox.Show("User name or password is wrong! Please checking again.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtUserName.Focus();
            }
            else
            {

                frmGeneral frm = new frmGeneral(this.txtUserName.Text.Trim());
                frm.FormClosed += new FormClosedEventHandler(frmLogin_Load);                
                frm.Show();
                frmMain frmm = new frmMain();
                frmm.MdiParent = frm;
                frmm.Show();
                this.Hide();
            }
        }
    }
}
