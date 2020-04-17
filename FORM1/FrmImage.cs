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
    public partial class FrmImage : Form
    {
        public FrmImage()
        {
            InitializeComponent();
        }

        private void BtnImage_Click(object sender, EventArgs e)
        {
            PicTry.Image = Image.FromFile("D:\\IE322_1636375\\Liv1.png");
        }
    }
}
