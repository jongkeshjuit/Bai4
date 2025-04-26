using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;

namespace BaiTap.Bai3
{
    public partial class Form3 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Form3(MaterialSkinManager materialSkinManager)
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

        private void btn_Download_Click(object sender, EventArgs e)
        {
            //string url = txt_URL.Text.Trim(); // Lấy URL từ TextBox
            //string filePath = txt_SavePath.Text.Trim(); // Lấy đường dẫn file từ TextBox

            //if (string.IsNullOrWhiteSpace(url) || string.IsNullOrWhiteSpace(filePath))
            //{
            //    MessageBox.Show("Vui lòng nhập URL và đường dẫn file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //try
            //{
            //    // Sử dụng WebClient để tải nội dung
            //    using (WebClient client = new WebClient())
            //    {
            //        // Tải file HTML từ URL và lưu vào file
            //        client.DownloadFile(url, filePath);
            //    }

            //    // Đọc nội dung file vừa tải và hiển thị trong TextBox
            //    string htmlContent = File.ReadAllText(filePath);
            //    rtbContent.Text = htmlContent;

            //    MessageBox.Show("Tải file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            // Cái code trên theo ý của thầy nhưng hơi thiếu agent vì một số trang web yêu cầu agent để tải nội dung
            string url = urlTextBox.Text.Trim();
            string filePath = filePathTextBox.Text.Trim();

            // --- Input Validation ---
            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("Vui lòng nhập URL.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                urlTextBox.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show("Vui lòng nhập đường dẫn lưu file.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                filePathTextBox.Focus();
                return;
            }

            // --- Ensure URL starts with http:// or https:// ---
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "http://" + url;
                urlTextBox.Text = url; // Update the textbox
            }

            // --- Ensure filePath ends with .html (optional but good practice) ---
            if (!filePath.EndsWith(".html", StringComparison.OrdinalIgnoreCase) && !filePath.EndsWith(".htm", StringComparison.OrdinalIgnoreCase))
            {
                // Append .html if no extension or a different one is present
                filePath = Path.ChangeExtension(filePath, ".html");
                // Or simply append if you prefer: filePath += ".html";
                filePathTextBox.Text = filePath; // Update the textbox
            }


            // --- Download and Display ---
            htmlTextBox.Text = "Đang tải, vui lòng đợi..."; // Show status
            Application.DoEvents(); // Allow UI update

            try
            {
                using (WebClient client = new WebClient())
                {
                    // Add User-Agent header to mimic a browser (helps avoid blocks)
                    client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");

                    // Set encoding to handle different character sets (like Vietnamese)
                    client.Encoding = Encoding.UTF8; // Use UTF8 by default, adjust if needed based on site

                    // Download the file
                    client.DownloadFile(url, filePath);

                    // Read the downloaded file content
                    // Specify UTF8 encoding when reading to match download encoding
                    string htmlContent = File.ReadAllText(filePath, Encoding.UTF8);

                    // Display the content
                    htmlTextBox.Text = htmlContent;

                    MessageBox.Show($"Tải và lưu file thành công!\nĐã lưu tại: {filePath}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (WebException webEx) // Catch specific web errors
            {
                string errorDetails = $"Lỗi mạng hoặc URL: {webEx.Message}";
                if (webEx.Response is HttpWebResponse errorResponse)
                {
                    errorDetails += $"\nStatus Code: {errorResponse.StatusCode} ({errorResponse.StatusDescription})";
                }
                htmlTextBox.Text = $"Lỗi khi tải từ {url}:\n{errorDetails}";
                MessageBox.Show(errorDetails, "Lỗi WebClient", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ioEx) // Catch file access errors
            {
                htmlTextBox.Text = $"Lỗi khi lưu hoặc đọc file {filePath}:\n{ioEx.Message}";
                MessageBox.Show($"Lỗi truy cập file: {ioEx.Message}\nVui lòng kiểm tra đường dẫn và quyền ghi.", "Lỗi File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) // Catch any other errors
            {
                htmlTextBox.Text = $"Đã xảy ra lỗi không mong muốn:\n{ex.Message}";
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

