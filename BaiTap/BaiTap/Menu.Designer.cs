namespace BaiTap
{
    partial class Menu
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
            Form1 = new MaterialSkin.Controls.MaterialButton();
            Form2 = new MaterialSkin.Controls.MaterialButton();
            Form3 = new MaterialSkin.Controls.MaterialButton();
            Form4 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // Form1
            // 
            Form1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Form1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Form1.Depth = 0;
            Form1.HighEmphasis = true;
            Form1.Icon = null;
            Form1.Location = new Point(216, 163);
            Form1.Margin = new Padding(4, 6, 4, 6);
            Form1.MouseState = MaterialSkin.MouseState.HOVER;
            Form1.Name = "Form1";
            Form1.NoAccentTextColor = Color.Empty;
            Form1.Size = new Size(88, 36);
            Form1.TabIndex = 0;
            Form1.Text = "Bài tập 1";
            Form1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Form1.UseAccentColor = false;
            Form1.UseVisualStyleBackColor = true;
            Form1.Click += Form1_Click;
            // 
            // Form2
            // 
            Form2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Form2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Form2.Depth = 0;
            Form2.HighEmphasis = true;
            Form2.Icon = null;
            Form2.Location = new Point(449, 163);
            Form2.Margin = new Padding(4, 6, 4, 6);
            Form2.MouseState = MaterialSkin.MouseState.HOVER;
            Form2.Name = "Form2";
            Form2.NoAccentTextColor = Color.Empty;
            Form2.Size = new Size(88, 36);
            Form2.TabIndex = 1;
            Form2.Text = "Bài tập 2";
            Form2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Form2.UseAccentColor = false;
            Form2.UseVisualStyleBackColor = true;
            Form2.Click += Form2_Click;
            // 
            // Form3
            // 
            Form3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Form3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Form3.Depth = 0;
            Form3.HighEmphasis = true;
            Form3.Icon = null;
            Form3.Location = new Point(216, 263);
            Form3.Margin = new Padding(4, 6, 4, 6);
            Form3.MouseState = MaterialSkin.MouseState.HOVER;
            Form3.Name = "Form3";
            Form3.NoAccentTextColor = Color.Empty;
            Form3.Size = new Size(88, 36);
            Form3.TabIndex = 2;
            Form3.Text = "Bài tập 3";
            Form3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Form3.UseAccentColor = false;
            Form3.UseVisualStyleBackColor = true;
            Form3.Click += Form3_Click;
            // 
            // Form4
            // 
            Form4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Form4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Form4.Depth = 0;
            Form4.HighEmphasis = true;
            Form4.Icon = null;
            Form4.Location = new Point(449, 263);
            Form4.Margin = new Padding(4, 6, 4, 6);
            Form4.MouseState = MaterialSkin.MouseState.HOVER;
            Form4.Name = "Form4";
            Form4.NoAccentTextColor = Color.Empty;
            Form4.Size = new Size(88, 36);
            Form4.TabIndex = 3;
            Form4.Text = "Bài tập 4";
            Form4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Form4.UseAccentColor = false;
            Form4.UseVisualStyleBackColor = true;
            Form4.Click += Form4_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Form4);
            Controls.Add(Form3);
            Controls.Add(Form2);
            Controls.Add(Form1);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton Form1;
        private MaterialSkin.Controls.MaterialButton Form2;
        private MaterialSkin.Controls.MaterialButton Form3;
        private MaterialSkin.Controls.MaterialButton Form4;
    }
}