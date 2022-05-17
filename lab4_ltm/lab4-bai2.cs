using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace lab4_ltm
{
    public partial class lab4_bai2 : Form
    {
        public lab4_bai2()
        {
            InitializeComponent();
        }

        private void btnPUSH_Click(object sender, EventArgs e)
        {
            try
            {
                WebRequest request = WebRequest.Create("http://www.contoso.com/PostAccepter.aspx");
                request.Method = "POST";
                string postData = tbPushContent.Text;
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteArray.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                MessageBox.Show("Post successful");
                dataStream.Close();

                WebResponse response = request.GetResponse();
                dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                
                tbContent.Text = reader.ReadToEnd();
                response.Close();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }
    }
}
