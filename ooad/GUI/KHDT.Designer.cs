
namespace ooad.GUI
{
    partial class KHDT
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siticoneGradientButton2 = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.siticoneGradientButton1 = new Siticone.UI.WinForms.SiticoneGradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hệ đào tạo: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khoa: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(45, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(709, 343);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Học kỳ";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã học phần";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Học phần";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tín chỉ";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tiết LT";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tiết TH";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Tiết tự học";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Tiết tham quan";
            this.Column8.Name = "Column8";
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
            this.siticoneGradientButton2.Location = new System.Drawing.Point(642, 511);
            this.siticoneGradientButton2.Name = "siticoneGradientButton2";
            this.siticoneGradientButton2.ShadowDecoration.Parent = this.siticoneGradientButton2;
            this.siticoneGradientButton2.Size = new System.Drawing.Size(112, 45);
            this.siticoneGradientButton2.TabIndex = 14;
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
            this.siticoneGradientButton1.Location = new System.Drawing.Point(508, 511);
            this.siticoneGradientButton1.Name = "siticoneGradientButton1";
            this.siticoneGradientButton1.ShadowDecoration.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Size = new System.Drawing.Size(112, 45);
            this.siticoneGradientButton1.TabIndex = 13;
            this.siticoneGradientButton1.Text = "Huỷ";
            // 
            // KHDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.siticoneGradientButton2);
            this.Controls.Add(this.siticoneGradientButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KHDT";
            this.Text = "KHDT";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private Siticone.UI.WinForms.SiticoneGradientButton siticoneGradientButton2;
        private Siticone.UI.WinForms.SiticoneGradientButton siticoneGradientButton1;
    }
}