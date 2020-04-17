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
    public partial class Form1 : Form
    {
        string Username = "shadi";
        string MyPassword = "1234";
        bool loggedin = false;

        int a = 1;
        int b = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnABC.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void BtnTime_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (!loggedin)
            {
                while (a <= b)
                {
                    if (txtusername.Text != Username) //username is incorrect 
                    {
                        MessageBox.Show("invaild username" + (b - a) + "2");
                        a++;
                        return;
                    }
                    else
                    {
                        if (txtpass.Text != "1234")
                        {
                            MessageBox.Show("incorrect password" + (b - a) + "2");
                            return;
                        }
                        else
                        {
                            a = 1;
                            MessageBox.Show("login successful");
                            loggedin = true;
                            BtnLogin.Text = "logout";
                            break;

                        }

                    }
                }



            }
        }

        private void BtnRad_Click(object sender, EventArgs e)
        {
            FrmRadio frm = new FrmRadio();
            frm.ShowDialog();

        }

        private void BtnCom_Click(object sender, EventArgs e)
        {

            FrmComb frm = new FrmComb();
            frm.ShowDialog();
        }

        private void BtnChb_Click(object sender, EventArgs e)
        {

            FrmCheck frm = new FrmCheck();
            frm.ShowDialog();
        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnRan_Click(object sender, EventArgs e)
        {
            FrmRandom frm = new FrmRandom();
            frm.ShowDialog();
            


        }

        private void BtnRanC_Click(object sender, EventArgs e)
        {
            frmRandomCombo frm = new frmRandomCombo();
            frm.ShowDialog();

        }

        private void BtnPB1_Click(object sender, EventArgs e)
        {
            FrmImage frm = new FrmImage();
            frm.ShowDialog();

        }
    }
}




















