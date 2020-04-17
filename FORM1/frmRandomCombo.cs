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
    public partial class frmRandomCombo : Form
    {
        public frmRandomCombo()
        {
            InitializeComponent();
        }

        private void BtnGeneratae_Click(object sender, EventArgs e)
        {
            CmbLT500.ResetText();
            CmbLT500.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 50) - 1; i++)
            {
                CmbLT500.Items.Add(r.Next(100, 99));
            }
        }
    }
}
