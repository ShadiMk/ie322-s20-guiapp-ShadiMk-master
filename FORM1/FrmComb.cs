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
    public partial class FrmComb : Form
    {
        public FrmComb()
        {
            InitializeComponent();

            Cmbdays.Items.Add("Sunday");
            Cmbdays.Items.Add("Monday");
            Cmbdays.Items.Add("Tuesday");
            Cmbdays.Items.Add("Wednsday");
            Cmbdays.Items.Add("Thursday");
            Cmbdays.Items.Add("Friday");
            Cmbdays.Items.Add("Saturday");

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(Cmbdays.Text);
        }

        private void FrmComb_Load(object sender, EventArgs e)
        {

        }

        private void BtnR1I_Click(object sender, EventArgs e)
        {
            if (Cmbdays.Items.Count >=1 )
            {
                ContextMenuStrip.Items.RemoveAt(Cmbdays.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("can't remove last item");
            }
        }
    }
}
