using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace lab4_ltm
{
    public partial class lab4_bai1 : Form
    {
        public lab4_bai1()
        {
            InitializeComponent();
        }

        private string GetHTMLFromURL(string strUrl)
        {
            WebRequest request = WebRequest.Create(strUrl);
            WebResponse response = request.GetResponse();
            Stream readStr = response.GetResponseStream();
            StreamReader dataStr = new StreamReader(readStr);
            response.Close();
            return dataStr.ReadToEnd(); 
            
        }
        private void btnGET_Click(object sender, EventArgs e)
        {
            try
            {
                tbContent.Text = GetHTMLFromURL(tbURL.Text);
                MessageBox.Show("Request successful !","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
