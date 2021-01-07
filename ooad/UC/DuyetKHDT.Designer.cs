
namespace ooad.UC
{
    partial class DuyetKHDT
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.siticoneGradientButton2 = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.siticoneGradientButton1 = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // siticoneGradientButton2
            // 
            this.siticoneGradientButton2.BorderRadius = 10;
            this.siticoneGradientButton2.CheckedState.Parent = this.siticoneGradientButton2;
            this.siticoneGradientButton2.CustomImages.Parent = this.siticoneGradientButton2;
            this.siticoneGradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneGradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGradientButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneGradientButton2.HoveredState.Parent = this.siticoneGradientButton2;
            this.siticoneGradientButton2.Location = new System.Drawing.Point(730, 534);
            this.siticoneGradientButton2.Name = "siticoneGradientButton2";
            this.siticoneGradientButton2.ShadowDecoration.Parent = this.siticoneGradientButton2;
            this.siticoneGradientButton2.Size = new System.Drawing.Size(112, 45);
            this.siticoneGradientButton2.TabIndex = 10;
            this.siticoneGradientButton2.Text = "Đồng ý";
            // 
            // siticoneGradientButton1
            // 
            this.siticoneGradientButton1.BorderColor = System.Drawing.Color.DimGray;
            this.siticoneGradientButton1.BorderRadius = 10;
            this.siticoneGradientButton1.BorderThickness = 1;
            this.siticoneGradientButton1.CheckedState.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.CustomImages.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.FillColor = System.Drawing.Color.White;
            this.siticoneGradientButton1.FillColor2 = System.Drawing.Color.White;
            this.siticoneGradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGradientButton1.ForeColor = System.Drawing.Color.DimGray;
            this.siticoneGradientButton1.HoveredState.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Location = new System.Drawing.Point(596, 534);
            this.siticoneGradientButton1.Name = "siticoneGradientButton1";
            this.siticoneGradientButton1.ShadowDecoration.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Size = new System.Drawing.Size(112, 45);
            this.siticoneGradientButton1.TabIndex = 9;
            this.siticoneGradientButton1.Text = "Huỷ";
            this.siticoneGradientButton1.Click += new System.EventHandler(this.siticoneGradientButton1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 95);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(821, 403);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // DuyetKHDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.siticoneGradientButton2);
            this.Controls.Add(this.siticoneGradientButton1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DuyetKHDT";
            this.Size = new System.Drawing.Size(894, 604);
            this.Load += new System.EventHandler(this.DuyetKHDT_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.UI.WinForms.SiticoneGradientButton siticoneGradientButton2;
        private Siticone.UI.WinForms.SiticoneGradientButton siticoneGradientButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
