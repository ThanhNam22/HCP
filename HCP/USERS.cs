using abo_lib;
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
    public partial class frmUSERS : Form
    {
        public frmUSERS()
        {
            InitializeComponent();
        }

        public bool S;

        public bool checkdata()
        {
            DialogResult result = new DialogResult();

            if (this.txtUSERNAME.Text.Trim().Length == 0)
            {
                result = MessageBox.Show("User name khong duoc trong", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtUSERNAME.Focus();
                return false;
            }
            UsersUpdate usu = new UsersUpdate();
            DataTable dt = usu.getdatatableUser(this.txtUSERNAME.Text.Trim());
            if (dt.Rows.Count > 0)
            {
                result = MessageBox.Show("User name da ton tai", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            if (this.txtPassword.Text.Trim().Length == 0)
            {
                result = MessageBox.Show("Password khong duoc trong", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtPassword.Focus();
                return false;
            }
            return true;
        }

        public void setstatus()

        {
            this.txtFullName.ReadOnly = false;
            this.txtUSERNAME.ReadOnly = false;
            this.txtPassword.ReadOnly = false;
            this.txtStaff.ReadOnly = false;
            this.chkActive.Enabled = false;

            this.btnThem.Enabled = true;
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            if (this.dataGridView1.Rows.Count > 0)
            {
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
            }
            else
            {
                this.btnSua.Enabled = false;
                this.btnXoa.Enabled = false;
            }
        }
        public void FillData()
        {
            if (this.dataGridView1.Rows.Count > 0)
            {

                this.txtUSERNAME.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                this.txtPassword.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.txtFullName.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.txtStaff.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();

                this.chkActive.Checked = bool.Parse(this.dataGridView1.CurrentRow.Cells[4].Value.ToString());

            }
        }
        public void Loaddata()
        {
            UsersUpdate us = new UsersUpdate();
            DataTable dt = us.getAllUsers();
            this.dataGridView1.DataSource = dt;
            if (this.dataGridView1.Rows.Count > 0) this.dataGridView1.Rows[0].Selected = true;
            //========================
            FillData();

        }
        private void frmUSERS_Load(object sender, EventArgs e)
        {
            Loaddata();
            setstatus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillData();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            S = true;
            this.txtUSERNAME.Text = string.Empty;
            this.txtPassword.Text = string.Empty;
            this.txtStaff.Text = string.Empty;
            this.txtFullName.Text = string.Empty;
            this.chkActive.Enabled = true;
            this.chkActive.Checked = false;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.txtUSERNAME.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            S = false;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.txtUSERNAME.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FillData();
            setstatus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Users ru = new Users();
            ru.loginname = this.txtUSERNAME.Text.Trim();
            ru.password = this.txtPassword.Text.Trim();
            ru.name = this.txtFullName.Text.Trim();
            ru.staffcode = this.txtStaff.Text.Trim();
            ru.active = this.chkActive.Checked;

            UsersUpdate ssu = new UsersUpdate();

            if (S)
            {
                if (checkdata())
                {
                    ssu.Insert(ru);
                    Loaddata();
                    FillData();
                    setstatus();
                }

            }
            else
            {
                ssu.update(ru);

            }

        }
    }
}
