
namespace ooad.GUI
{
    partial class Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lollipopButton1 = new LollipopButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lollipopLabel1 = new LollipopLabel();
            this.lollipopLabel2 = new LollipopLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lollipopTextBox1 = new LollipopTextBox();
            this.lollipopTextBox2 = new LollipopTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::ooad.Properties.Resources._37;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(730, 650);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lollipopButton1
            // 
            this.lollipopButton1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopButton1.BGColor = "#508ef5";
            this.lollipopButton1.FontColor = "#ffffff";
            this.lollipopButton1.Location = new System.Drawing.Point(831, 401);
            this.lollipopButton1.Margin = new System.Windows.Forms.Padding(2);
            this.lollipopButton1.Name = "lollipopButton1";
            this.lollipopButton1.Size = new System.Drawing.Size(152, 38);
            this.lollipopButton1.TabIndex = 4;
            this.lollipopButton1.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Black", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(752, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Log in.";
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AllowDrop = true;
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(755, 158);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(292, 17);
            this.lollipopLabel1.TabIndex = 6;
            this.lollipopLabel1.Text = "Log in with your data that you entered during";
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AllowDrop = true;
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(755, 175);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(118, 17);
            this.lollipopLabel2.TabIndex = 7;
            this.lollipopLabel2.Text = "your registration.";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(754, 219);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(113, 20);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Your username";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(754, 285);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(77, 20);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Password";
            // 
            // lollipopTextBox1
            // 
            this.lollipopTextBox1.FocusedColor = "#508ef5";
            this.lollipopTextBox1.FontColor = "#999999";
            this.lollipopTextBox1.IsEnabled = true;
            this.lollipopTextBox1.Location = new System.Drawing.Point(758, 242);
            this.lollipopTextBox1.MaxLength = 32767;
            this.lollipopTextBox1.Multiline = false;
            this.lollipopTextBox1.Name = "lollipopTextBox1";
            this.lollipopTextBox1.ReadOnly = false;
            this.lollipopTextBox1.Size = new System.Drawing.Size(300, 24);
            this.lollipopTextBox1.TabIndex = 10;
            this.lollipopTextBox1.Text = "Enter your username...";
            this.lollipopTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.lollipopTextBox1.UseSystemPasswordChar = false;
            // 
            // lollipopTextBox2
            // 
            this.lollipopTextBox2.FocusedColor = "#508ef5";
            this.lollipopTextBox2.FontColor = "#999999";
            this.lollipopTextBox2.IsEnabled = true;
            this.lollipopTextBox2.Location = new System.Drawing.Point(758, 308);
            this.lollipopTextBox2.MaxLength = 32767;
            this.lollipopTextBox2.Multiline = false;
            this.lollipopTextBox2.Name = "lollipopTextBox2";
            this.lollipopTextBox2.ReadOnly = false;
            this.lollipopTextBox2.Size = new System.Drawing.Size(300, 24);
            this.lollipopTextBox2.TabIndex = 11;
            this.lollipopTextBox2.Text = "At least 6 characters";
            this.lollipopTextBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.lollipopTextBox2.UseSystemPasswordChar = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel1.Location = new System.Drawing.Point(836, 490);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(139, 18);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot your password?";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lollipopTextBox2);
            this.Controls.Add(this.lollipopTextBox1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lollipopLabel2);
            this.Controls.Add(this.lollipopLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lollipopButton1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private LollipopButton lollipopButton1;
        private System.Windows.Forms.Label label1;
        private LollipopLabel lollipopLabel1;
        private LollipopLabel lollipopLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private LollipopTextBox lollipopTextBox1;
        private LollipopTextBox lollipopTextBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}