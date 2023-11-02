using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HCP
{
    public partial class frmExplannation : Form
    {
        string status;
        string explaination;
        public frmExplannation(string sta, string exp)
        {
            InitializeComponent();
            status = sta;
            explaination = exp;
        }


        private void txtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmExplannation_Load(object sender, EventArgs e)
        {
            this.txtStatus.Text = status;
            this.txtExp.Text = explaination;
        }
    }
}
