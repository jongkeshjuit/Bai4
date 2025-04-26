using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                filePath = Path.ChangeExtension(filePath, ".html");
                filePathTextBox.Text = filePath; // Update the textbox
            }

            // --- Download and Display ---
            htmlTextBox.Text = "Đang tải, vui lòng đợi..."; // Show status
            Application.DoEvents(); // Allow UI update

            try
            {
                using (WebClient client = new WebClient())
                {
                    client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");
                    client.Encoding = Encoding.UTF8;

                    // Download the file
                    client.DownloadFile(url, filePath);

                    // Verify if the file exists after download
                    if (File.Exists(filePath))
                    {
                        string htmlContent = File.ReadAllText(filePath, Encoding.UTF8);
                        htmlTextBox.Text = htmlContent;

                        MessageBox.Show($"Tải và lưu file thành công!\nĐã lưu tại: {filePath}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        htmlTextBox.Text = "File không tồn tại sau khi tải.";
                        MessageBox.Show("File không tồn tại sau khi tải. Vui lòng kiểm tra đường dẫn hoặc quyền ghi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (WebException webEx)
            {
                string errorDetails = $"Lỗi mạng hoặc URL: {webEx.Message}";
                if (webEx.Response is HttpWebResponse errorResponse)
                {
                    errorDetails += $"\nStatus Code: {errorResponse.StatusCode} ({errorResponse.StatusDescription})";
                }
                htmlTextBox.Text = $"Lỗi khi tải từ {url}:\n{errorDetails}";
                MessageBox.Show(errorDetails, "Lỗi WebClient", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ioEx)
            {
                htmlTextBox.Text = $"Lỗi khi lưu hoặc đọc file {filePath}:\n{ioEx.Message}";
                MessageBox.Show($"Lỗi truy cập file: {ioEx.Message}\nVui lòng kiểm tra đường dẫn và quyền ghi.", "Lỗi File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                htmlTextBox.Text = $"Đã xảy ra lỗi không mong muốn:\n{ex.Message}";
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
