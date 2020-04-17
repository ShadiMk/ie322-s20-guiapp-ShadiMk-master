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
    public partial class FrmRadio : Form
    {
        public FrmRadio()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void RdoRed_CheckedChanged(object sender, EventArgs e)
        {

            if (RdoRed.Checked == true)
            {
                RdoRed.ForeColor = Color.FromName("red");
            }
            else
            { RdoRed.ForeColor = Color.FromName("black"); } 
        }

        private void RdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoGreen.Checked == true)
            {
                RdoGreen.ForeColor = Color.FromName("green");
            }
            else
            { RdoGreen.ForeColor = Color.FromName("black"); }

        }

        private void RdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoBlue.Checked == true)
            {
                RdoBlue.ForeColor = Color.FromName("blue");
            }
            else
            { RdoGreen.ForeColor = Color.FromName("black"); }
        }

        private void RdoYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoYellow.Checked == true)
            {
                RdoYellow.ForeColor = Color.FromName("yellow");
            }
            else { RdoYellow.ForeColor = Color.FromName("black"); } 
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            RdoRed.Checked = false;
            RdoGreen.Checked = false;
            RdoBlue.Checked = false;
            RdoYellow.Checked =false; 

            RdoRed.ForeColor = Color.FromName("black");
            RdoGreen.ForeColor = Color.FromName("black");
            RdoGreen.ForeColor = Color.FromName("black");
            RdoYellow.ForeColor = Color.FromName("black");
        }

        private void FrmRadio_Load(object sender, EventArgs e)
        {

        }
    }
}
