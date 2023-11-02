using abo_lib;
using adao_lib;
using global_lib;
using rsdao_lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace HCP
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private bool ViewReadOnly;
        //========================================================
        public void VerificationCheck()
        {
            string ssid = this.cboSession.Text.ToString().Split(' ')[0].Trim();
            if (!string.IsNullOrEmpty(ssid))
            {
                CheckUpdate cu = new CheckUpdate();
                DataTable dt = cu.getCheck(ssid);
                if (dt != null && dt.Rows.Count > 0)
                {
                    this.txtSessionStatus.Text = "Dữ liệu đã được kiểm tra";
                    this.txtSessionStatus.BackColor = Color.Blue;
                    this.txtSessionStatus.ForeColor = Color.White;
                }                       
                else
                {
                    this.txtSessionStatus.Text = "Dữ liệu chưa được kiểm tra";
                    this.txtSessionStatus.BackColor = Color.Red;
                    this.txtSessionStatus.ForeColor = Color.White;
                }    
                    
            }
            
        }

        public void LoadAlert()
        {
            string ssid = this.cboSession.Text.ToString().Split(' ')[0].Trim();
            AlertUpdate au = new AlertUpdate();
            DataTable ds = au.getDataTable_V(ssid);
            if (ds.Rows.Count > 0)
            {
                if(this.listView1.Items.Count > 0)
                {
                    for(int i=0; i<ds.Rows.Count; i++)
                        for (int j=0; j< this.listView1.Items.Count; j++)
                            if (this.listView1.Items[j].Text.Equals(ds.Rows[i]["PROFILE_ID"].ToString()))
                            {
                                if (ds.Rows[i]["SOLVED"].ToString().Equals("True"))
                                {
                                    this.listView1.Items[j].BackColor = Color.LightGray;
                                    this.listView1.Items[j].Checked = true;
                                }
                                else
                                {
                                    this.listView1.Items[j].BackColor = Color.Red;
                                    this.listView1.Items[j].ForeColor = Color.White;
                                }
                            }
                }
            }
        }

        public string getInfor()
        {
            string infor = "Theo ";
            int status = 0;
            string ssid = this.cboSession.Text.ToString().Split(' ')[0].Trim();
            AlertUpdate au = new AlertUpdate();           
           
            if (this.listView1.Items.Count > 0 && this.listView1.SelectedItems.Count > 0)
            {
                int selectedindex = listView1.SelectedIndices[0];
                DataTable ds = au.getDataTableResion_V(ssid, this.listView1.Items[selectedindex].Text);
                if(ds.Rows.Count > 0)                
                {
                            infor += ds.Rows[0]["LEGAL_TYPE"].ToString().Trim();
                            infor += " số ";
                            infor += ds.Rows[0]["NUMBER"].ToString().Trim();                           
                            infor += " ngày ";
                            infor += ds.Rows[0]["LEGALDATE"].ToString().Trim().Split(' ')[0];
                            infor += " của ";
                            infor += ds.Rows[0]["AUTHOR"].ToString();
                            infor += ": ";
                            infor += ds.Rows[0]["DESCRIPTION"].ToString().Trim();
                    if (ds.Rows[0]["SOLVED"].ToString().Trim().Equals("0"))
                        status = 1;
                    else
                        status = 0;

                }
                
             }            
            return infor + '&' + status.ToString().Trim();
        }
        public void LoadDetails()
        {
            this.txtDeagnoseDetails.Text = "";
            if (this.listView2.Items.Count > 0 && listView2.SelectedItems.Count > 0)
            {
                var item = this.listView1.SelectedItems[0];
                string patientid = item.SubItems[1].Text.Trim();
                DiagnoseUpdate rsu2 = new DiagnoseUpdate();
                DataTable diag = rsu2.getDataTable(patientid);               
                DateTime DATE = DateTime.Parse(this.listView2.SelectedItems[0].SubItems[0].Text.ToString());
                string d = DATE.ToString("yyyy-MM-dd");
                diag = rsu2.getDiagnose(patientid, d);
                if (diag.Rows.Count > 0)
                    this.txtDeagnoseDetails.Text = diag.Rows[0][0].ToString();
            }
        }

        public void LoadServiceMedicalMeterial()
        {
            this.lsvService.Items.Clear();
            this.lsvMedical.Items.Clear();
            this.lsvMaterial.Items.Clear();
            //Load All
            if (this.listView1.Items.Count > 0 && listView1.SelectedItems.Count > 0)
            {
                global_functions gf = new global_functions();
                var item = this.listView1.SelectedItems[0];
                string patientid = item.SubItems[1].Text.Trim();
                string ssid = this.cboSession.Text.ToString().Split(' ')[0].Trim();

                ServiceUpdate rsu2 = new ServiceUpdate();
                DataTable sv = rsu2.getDataTable(patientid, ssid);
                gf.LoadToListview(this.lsvService, sv);

                MedicineUpdate rsu3 = new MedicineUpdate();
                DataTable md = rsu3.getDataTable(patientid, ssid);
                gf.LoadToListview(this.lsvMedical, md);

                MaterialUpdate rsu4 = new MaterialUpdate();
                DataTable ma = rsu4.getDataTable(patientid, ssid);
                gf.LoadToListview(this.lsvMaterial, ma);
            }
        }
        public void LoadDiagnose()
        {
            this.listView2.Items.Clear();   
            if (this.listView1.Items.Count > 0 && listView1.SelectedItems.Count > 0)
            {
                global_functions gf = new global_functions();
                var item = this.listView1.SelectedItems[0];
                string patientid = item.SubItems[1].Text.Trim();
                DiagnoseUpdate rsu2 = new DiagnoseUpdate();
                DataTable diag = rsu2.getDataTable(patientid);
                gf.LoadToListview(this.listView2, diag);
                LoadDetails();

            }
        }
        public void LoadData(string sessionID)
        {
            if(sessionID != null)
            {
                this.listView1.Items.Clear();
                ProfileUpdate rsu = new ProfileUpdate();
                DataTable dt = new DataTable();
                if (rdoShowAll.Checked)
                {
                    dt = rsu.getProfile(sessionID);

                }
                else
                {
                    dt = rsu.getProfileV(sessionID);
                }
                if(dt.Rows.Count > 0)
                {
                    global_functions gf = new global_functions();
                    gf.LoadToListview(this.listView1, dt);
                    VerificationCheck();
                    LoadAlert();
                    this.listView1.Focus();
                }
                else
                {
                    this.listView1.Items.Clear();
                    this.txtSessionStatus.Text = "Dữ liệu chưa được đồng bộ";
                    this.txtSessionStatus.BackColor = Color.Gray;
                    this.txtSessionStatus.ForeColor = Color.DarkBlue;
                }
               
            }
                
        }
        //========================================================
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
           
            SessionUpdate ssu = new SessionUpdate();
            List<Session> lss = ssu.getListSession();
            this.cboSession.Items.Clear();
            foreach (Session x in lss)
            {
                this.cboSession.Items.Add(x.ID.ToString().Trim() + " " + x.date.ToString().Trim().Split(' ')[0]);
            }
            if (this.cboSession.Items.Count > 0) this.cboSession.SelectedIndex = 0;
            if (this.cboSession.Items.Count > 0 && this.cboSession.SelectedItem != null)
            {
                string s = this.cboSession.SelectedItem.ToString().Split(' ')[0];
                LoadData(s);
                LoadDiagnose();
                LoadServiceMedicalMeterial();             


            }
            ViewReadOnly = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblTime.Text = DateTime.Now.ToString();

        }

        private void cboSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = this.cboSession.SelectedItem.ToString().Split(' ')[0];
            LoadData(s);
            LoadDiagnose();
            LoadDetails();
            LoadServiceMedicalMeterial();
           
        }

       
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDiagnose();
            LoadDetails();
            LoadServiceMedicalMeterial();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            LoadDetails();
        }

        private void rdoShowAlertOnly_CheckedChanged(object sender, EventArgs e)
        {
            if(this.cboSession.Items.Count > 0 && this.cboSession.SelectedItem != null)
            {
                string s = this.cboSession.SelectedItem.ToString().Split(' ')[0];
                LoadData(s);
                LoadDiagnose();
                LoadDetails();
                LoadServiceMedicalMeterial();
            }
            
        }

        private void rdoShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cboSession.Items.Count > 0 && this.cboSession.SelectedItem != null)
            {
                string s = this.cboSession.SelectedItem.ToString().Split(' ')[0];
                LoadData(s);
                LoadDiagnose();
                LoadDetails();
                LoadServiceMedicalMeterial();
            }
        }

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (ViewReadOnly) e.NewValue = e.CurrentValue;
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string res = this.getInfor();
            string sta = res.Split('&')[1];
            string exp = res.Split('&')[0];

            frmExplannation frm = new frmExplannation(sta, exp);
            frm.Show();
        }
    }
}
