using abo_lib;
using global_lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace global_lib
{
    public class global_functions
    {
        public void LoadToListview(ListView lstv, DataTable dt)
        {
            lstv.Items.Clear();
            
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                lstv.Items.Add(item);
            }
            if(lstv.Items.Count > 0)
            {
                lstv.Items[0].Selected = true;
            }    
        }
    }
}
