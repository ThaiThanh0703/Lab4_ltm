using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_ltm
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            Form bai1 = new lab4_bai1();
            bai1.ShowDialog();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            Form bai2 = new lab4_bai2();
            bai2.ShowDialog();  
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            Form bai3   = new lab4_bai3();
            bai3.ShowDialog();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            Form bai4 = new lab4_bai4();
            bai4.ShowDialog();
        }
    }
}
