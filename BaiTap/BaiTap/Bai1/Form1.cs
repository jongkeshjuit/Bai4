using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Net;

namespace BaiTap.Bai1
{
    public partial class Form1 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Form1(MaterialSkinManager materialSkinManager)
        {
            InitializeComponent();
            this.materialSkinManager = materialSkinManager;
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            // Set theme and color scheme
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue200, Accent.LightBlue200,
                TextShade.WHITE);
        }

        
        private string GetHTML(string szurl)
        {
            WebRequest request = WebRequest.Create(szurl);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            //reader.Close();
            response.Close();
            return responseFromServer;
        }
        
         private void GetMethod_Click(object sender, EventArgs e)
        {
            try
            {
                string url = txtURL.Text.Trim();
                if(string.IsNullOrEmpty(url))
                {
                    MessageBox.Show("Please enter a URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(!url.StartsWith("http://") && !url.StartsWith("https://"))
                {
                    url = "http://" + url;
                }
                rtbContent.Text = "Đang tải, đợi 1 lát ...";
                Application.DoEvents();
                string htmlContent = GetHTML(url);
                rtbContent.Text = htmlContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
