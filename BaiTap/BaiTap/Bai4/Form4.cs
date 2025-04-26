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
using System.IO;
namespace BaiTap.Bai4
{
    public partial class Form4: MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Form4(MaterialSkinManager materialSkinManager)
        {
            InitializeComponent();
            materialSkinManager.AddFormToManage(this);
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            // Add any initialization logic here if needed
            // Set the theme color
            MaterialSkinManager.Instance.AddFormToManage(this);
            MaterialSkinManager.Instance.Theme = MaterialSkinManager.Themes.LIGHT;
            MaterialSkinManager.Instance.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }
    }
}
