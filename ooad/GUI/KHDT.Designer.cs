
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.siticoneGradientButton2 = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.siticoneGradientButton1 = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.idhocphanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhocphanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotinchiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotietlythuyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotietthuchanhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotiettuhocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotietthamquanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHITIETKEHOACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETKEHOACHBindingSource)).BeginInit();
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
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chuyên ngành: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idhocphanDataGridViewTextBoxColumn,
            this.tenhocphanDataGridViewTextBoxColumn,
            this.sotinchiDataGridViewTextBoxColumn,
            this.sotietlythuyetDataGridViewTextBoxColumn,
            this.sotietthuchanhDataGridViewTextBoxColumn,
            this.sotiettuhocDataGridViewTextBoxColumn,
            this.sotietthamquanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cHITIETKEHOACHBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(709, 343);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
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
            this.siticoneGradientButton2.Click += new System.EventHandler(this.siticoneGradientButton2_Click);
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
            this.siticoneGradientButton1.Click += new System.EventHandler(this.siticoneGradientButton1_Click);
            // 
            // idhocphanDataGridViewTextBoxColumn
            // 
            this.idhocphanDataGridViewTextBoxColumn.DataPropertyName = "Idhocphan";
            this.idhocphanDataGridViewTextBoxColumn.HeaderText = "Mã học phần";
            this.idhocphanDataGridViewTextBoxColumn.Name = "idhocphanDataGridViewTextBoxColumn";
            // 
            // tenhocphanDataGridViewTextBoxColumn
            // 
            this.tenhocphanDataGridViewTextBoxColumn.DataPropertyName = "Tenhocphan";
            this.tenhocphanDataGridViewTextBoxColumn.HeaderText = "Tên học phần";
            this.tenhocphanDataGridViewTextBoxColumn.Name = "tenhocphanDataGridViewTextBoxColumn";
            // 
            // sotinchiDataGridViewTextBoxColumn
            // 
            this.sotinchiDataGridViewTextBoxColumn.DataPropertyName = "Sotinchi";
            this.sotinchiDataGridViewTextBoxColumn.HeaderText = "Số tín chỉ";
            this.sotinchiDataGridViewTextBoxColumn.Name = "sotinchiDataGridViewTextBoxColumn";
            // 
            // sotietlythuyetDataGridViewTextBoxColumn
            // 
            this.sotietlythuyetDataGridViewTextBoxColumn.DataPropertyName = "Sotietlythuyet";
            this.sotietlythuyetDataGridViewTextBoxColumn.HeaderText = "Số tín chỉ LT";
            this.sotietlythuyetDataGridViewTextBoxColumn.Name = "sotietlythuyetDataGridViewTextBoxColumn";
            // 
            // sotietthuchanhDataGridViewTextBoxColumn
            // 
            this.sotietthuchanhDataGridViewTextBoxColumn.DataPropertyName = "Sotietthuchanh";
            this.sotietthuchanhDataGridViewTextBoxColumn.HeaderText = "Số tín chỉ TH";
            this.sotietthuchanhDataGridViewTextBoxColumn.Name = "sotietthuchanhDataGridViewTextBoxColumn";
            // 
            // sotiettuhocDataGridViewTextBoxColumn
            // 
            this.sotiettuhocDataGridViewTextBoxColumn.DataPropertyName = "Sotiettuhoc";
            this.sotiettuhocDataGridViewTextBoxColumn.HeaderText = "Số tín chỉ Tự học";
            this.sotiettuhocDataGridViewTextBoxColumn.Name = "sotiettuhocDataGridViewTextBoxColumn";
            // 
            // sotietthamquanDataGridViewTextBoxColumn
            // 
            this.sotietthamquanDataGridViewTextBoxColumn.DataPropertyName = "Sotietthamquan";
            this.sotietthamquanDataGridViewTextBoxColumn.HeaderText = "Số tín chỉ tham quan";
            this.sotietthamquanDataGridViewTextBoxColumn.Name = "sotietthamquanDataGridViewTextBoxColumn";
            // 
            // cHITIETKEHOACHBindingSource
            // 
            this.cHITIETKEHOACHBindingSource.DataSource = typeof(ooad.DTO.CHITIETKEHOACH);
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
            this.Load += new System.EventHandler(this.KHDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETKEHOACHBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Siticone.UI.WinForms.SiticoneGradientButton siticoneGradientButton2;
        private Siticone.UI.WinForms.SiticoneGradientButton siticoneGradientButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idhocphanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhocphanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotinchiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotietlythuyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotietthuchanhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotiettuhocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotietthamquanDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cHITIETKEHOACHBindingSource;
    }
}