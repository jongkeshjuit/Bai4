namespace BaiTap.Bai1
{
    partial class Form1
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
            GetMethod = new MaterialSkin.Controls.MaterialButton();
            txtURL = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            rtbContent = new Krypton.Toolkit.KryptonRichTextBox();
            SuspendLayout();
            // 
            // GetMethod
            // 
            GetMethod.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GetMethod.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            GetMethod.Depth = 0;
            GetMethod.HighEmphasis = true;
            GetMethod.Icon = null;
            GetMethod.Location = new Point(496, 108);
            GetMethod.Margin = new Padding(4, 6, 4, 6);
            GetMethod.MouseState = MaterialSkin.MouseState.HOVER;
            GetMethod.Name = "GetMethod";
            GetMethod.NoAccentTextColor = Color.Empty;
            GetMethod.Size = new Size(64, 36);
            GetMethod.TabIndex = 0;
            GetMethod.Text = "GET";
            GetMethod.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            GetMethod.UseAccentColor = false;
            GetMethod.UseVisualStyleBackColor = true;
            GetMethod.Click += GetMethod_Click;
            // 
            // txtURL
            // 
            txtURL.AnimateReadOnly = false;
            txtURL.BorderStyle = BorderStyle.None;
            txtURL.Depth = 0;
            txtURL.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtURL.LeadingIcon = null;
            txtURL.Location = new Point(139, 105);
            txtURL.MaxLength = 50;
            txtURL.MouseState = MaterialSkin.MouseState.OUT;
            txtURL.Multiline = false;
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(269, 50);
            txtURL.TabIndex = 1;
            txtURL.Text = "";
            txtURL.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(79, 119);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(34, 19);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "URL:";
            // 
            // rtbContent
            // 
            rtbContent.Location = new Point(79, 171);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(574, 228);
            rtbContent.TabIndex = 3;
            rtbContent.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbContent);
            Controls.Add(materialLabel1);
            Controls.Add(txtURL);
            Controls.Add(GetMethod);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton GetMethod;
        private MaterialSkin.Controls.MaterialTextBox txtURL;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Krypton.Toolkit.KryptonRichTextBox rtbContent;
    }
}