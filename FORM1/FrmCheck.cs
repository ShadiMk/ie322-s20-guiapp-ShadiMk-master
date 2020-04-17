using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM1
{
    public partial class FrmCheck : Form
    {
        public FrmCheck()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkCoff_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (ChkCoff.Checked == true)
            {
                msg = ChkCoff.Text;
            }
            if (ChkDou.Checked == true)
            {
                msg = msg + " " + ChkDou.Text;
            }
            if (ChkBro.Checked == true)
            {
                msg = msg + " " + ChkBro.Text;
            }
            // now display the order 
            if (msg.Length == 0 )     
            {
                msg = "Nothing Selected";
            }
            MessageBox.Show(msg + " Orderd ");
        }

        private void FrmCheck_Load(object sender, EventArgs e)
        {

        }
    }
}
