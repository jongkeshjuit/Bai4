namespace BaiTap.Bai3
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            urlTextBox = new MaterialSkin.Controls.MaterialTextBox();
            filePathTextBox = new MaterialSkin.Controls.MaterialTextBox();
            btn_Download = new MaterialSkin.Controls.MaterialButton();
            htmlTextBox = new Krypton.Toolkit.KryptonRichTextBox();
            SuspendLayout();
            // 
            // urlTextBox
            // 
            urlTextBox.AnimateReadOnly = false;
            urlTextBox.BorderStyle = BorderStyle.None;
            urlTextBox.Depth = 0;
            urlTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            urlTextBox.LeadingIcon = null;
            urlTextBox.Location = new Point(123, 112);
            urlTextBox.MaxLength = 50;
            urlTextBox.MouseState = MaterialSkin.MouseState.OUT;
            urlTextBox.Multiline = false;
            urlTextBox.Name = "urlTextBox";
            urlTextBox.Size = new Size(193, 50);
            urlTextBox.TabIndex = 0;
            urlTextBox.Text = "";
            urlTextBox.TrailingIcon = null;
            // 
            // filePathTextBox
            // 
            filePathTextBox.AnimateReadOnly = false;
            filePathTextBox.BorderStyle = BorderStyle.None;
            filePathTextBox.Depth = 0;
            filePathTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            filePathTextBox.LeadingIcon = null;
            filePathTextBox.Location = new Point(123, 185);
            filePathTextBox.MaxLength = 50;
            filePathTextBox.MouseState = MaterialSkin.MouseState.OUT;
            filePathTextBox.Multiline = false;
            filePathTextBox.Name = "filePathTextBox";
            filePathTextBox.Size = new Size(193, 50);
            filePathTextBox.TabIndex = 1;
            filePathTextBox.Text = "";
            filePathTextBox.TrailingIcon = null;
            // 
            // btn_Download
            // 
            btn_Download.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Download.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_Download.Depth = 0;
            btn_Download.HighEmphasis = true;
            btn_Download.Icon = null;
            btn_Download.Location = new Point(432, 152);
            btn_Download.Margin = new Padding(4, 6, 4, 6);
            btn_Download.MouseState = MaterialSkin.MouseState.HOVER;
            btn_Download.Name = "btn_Download";
            btn_Download.NoAccentTextColor = Color.Empty;
            btn_Download.Size = new Size(102, 36);
            btn_Download.TabIndex = 2;
            btn_Download.Text = "Download";
            btn_Download.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_Download.UseAccentColor = false;
            btn_Download.UseVisualStyleBackColor = true;
            btn_Download.Click += btn_Download_Click;
            // 
            // htmlTextBox
            // 
            htmlTextBox.Location = new Point(199, 256);
            htmlTextBox.Name = "htmlTextBox";
            htmlTextBox.Size = new Size(574, 228);
            htmlTextBox.TabIndex = 4;
            htmlTextBox.Text = "";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 558);
            Controls.Add(htmlTextBox);
            Controls.Add(btn_Download);
            Controls.Add(filePathTextBox);
            Controls.Add(urlTextBox);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox urlTextBox;
        private MaterialSkin.Controls.MaterialTextBox filePathTextBox;
        private MaterialSkin.Controls.MaterialButton btn_Download;
        private Krypton.Toolkit.KryptonRichTextBox htmlTextBox;
    }
}