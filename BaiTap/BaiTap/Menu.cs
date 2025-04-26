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
namespace BaiTap
{
    public partial class Menu : MaterialForm
    {
        public Menu(MaterialSkinManager materialSkinManager)
        {
            InitializeComponent();
            materialSkinManager.AddFormToManage(this);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // Add any initialization logic here if needed
            // Set the theme color
            MaterialSkinManager.Instance.AddFormToManage(this);
            MaterialSkinManager.Instance.Theme = MaterialSkinManager.Themes.LIGHT;
            MaterialSkinManager.Instance.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            var form1 = new Bai1.Form1(materialSkinManager);
            form1.Show();
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            var form2 = new Bai2.Form2(materialSkinManager);
            form2.Show();
        }

        private void Form3_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            var form3 = new Bai3.Form3(materialSkinManager);
            form3.Show();
        }

        private void Form4_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            var form4 = new Bai4.Form4(materialSkinManager);
            form4.Show();
        }
    }
}
