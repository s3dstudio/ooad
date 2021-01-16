
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
            this.cHITIETKEHOACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siticoneGradientButton2 = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.siticoneGradientButton1 = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.tbChuyennganh = new Siticone.UI.WinForms.SiticoneTextBox();
            this.tbMaKHDT = new Siticone.UI.WinForms.SiticoneTextBox();
            this.tbHDT = new Siticone.UI.WinForms.SiticoneTextBox();
            this.btnSuaKHDT = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.idhocphan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhocphan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotinchi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotietlythuyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotietthuchanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotiettuhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotietthamquan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETKEHOACHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã KHDT: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 109);
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
            this.idhocphan,
            this.tenhocphan,
            this.sotinchi,
            this.sotietlythuyet,
            this.sotietthuchanh,
            this.sotiettuhoc,
            this.sotietthamquan});
            this.dataGridView1.DataSource = this.cHITIETKEHOACHBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(709, 343);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // cHITIETKEHOACHBindingSource
            // 
            this.cHITIETKEHOACHBindingSource.DataSource = typeof(ooad.DTO.CHITIETKEHOACH);
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
            // tbChuyennganh
            // 
            this.tbChuyennganh.Animated = false;
            this.tbChuyennganh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbChuyennganh.DefaultText = "";
            this.tbChuyennganh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbChuyennganh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbChuyennganh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbChuyennganh.DisabledState.Parent = this.tbChuyennganh;
            this.tbChuyennganh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbChuyennganh.Enabled = false;
            this.tbChuyennganh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbChuyennganh.FocusedState.Parent = this.tbChuyennganh;
            this.tbChuyennganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChuyennganh.ForeColor = System.Drawing.Color.Black;
            this.tbChuyennganh.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbChuyennganh.HoveredState.Parent = this.tbChuyennganh;
            this.tbChuyennganh.Location = new System.Drawing.Point(131, 128);
            this.tbChuyennganh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbChuyennganh.Name = "tbChuyennganh";
            this.tbChuyennganh.PasswordChar = '\0';
            this.tbChuyennganh.PlaceholderText = "";
            this.tbChuyennganh.SelectedText = "";
            this.tbChuyennganh.ShadowDecoration.Parent = this.tbChuyennganh;
            this.tbChuyennganh.Size = new System.Drawing.Size(275, 21);
            this.tbChuyennganh.TabIndex = 47;
            // 
            // tbMaKHDT
            // 
            this.tbMaKHDT.Animated = false;
            this.tbMaKHDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMaKHDT.DefaultText = "";
            this.tbMaKHDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMaKHDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMaKHDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMaKHDT.DisabledState.Parent = this.tbMaKHDT;
            this.tbMaKHDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMaKHDT.Enabled = false;
            this.tbMaKHDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMaKHDT.FocusedState.Parent = this.tbMaKHDT;
            this.tbMaKHDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaKHDT.ForeColor = System.Drawing.Color.Black;
            this.tbMaKHDT.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMaKHDT.HoveredState.Parent = this.tbMaKHDT;
            this.tbMaKHDT.Location = new System.Drawing.Point(131, 67);
            this.tbMaKHDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMaKHDT.Name = "tbMaKHDT";
            this.tbMaKHDT.PasswordChar = '\0';
            this.tbMaKHDT.PlaceholderText = "";
            this.tbMaKHDT.SelectedText = "";
            this.tbMaKHDT.ShadowDecoration.Parent = this.tbMaKHDT;
            this.tbMaKHDT.Size = new System.Drawing.Size(275, 25);
            this.tbMaKHDT.TabIndex = 48;
            // 
            // tbHDT
            // 
            this.tbHDT.Animated = false;
            this.tbHDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbHDT.DefaultText = "";
            this.tbHDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbHDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbHDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbHDT.DisabledState.Parent = this.tbHDT;
            this.tbHDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbHDT.Enabled = false;
            this.tbHDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbHDT.FocusedState.Parent = this.tbHDT;
            this.tbHDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHDT.ForeColor = System.Drawing.Color.Black;
            this.tbHDT.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbHDT.HoveredState.Parent = this.tbHDT;
            this.tbHDT.Location = new System.Drawing.Point(131, 97);
            this.tbHDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbHDT.Name = "tbHDT";
            this.tbHDT.PasswordChar = '\0';
            this.tbHDT.PlaceholderText = "";
            this.tbHDT.SelectedText = "";
            this.tbHDT.ShadowDecoration.Parent = this.tbHDT;
            this.tbHDT.Size = new System.Drawing.Size(275, 25);
            this.tbHDT.TabIndex = 49;
            // 
            // btnSuaKHDT
            // 
            this.btnSuaKHDT.BorderRadius = 10;
            this.btnSuaKHDT.CheckedState.Parent = this.btnSuaKHDT;
            this.btnSuaKHDT.CustomImages.Parent = this.btnSuaKHDT;
            this.btnSuaKHDT.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSuaKHDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSuaKHDT.ForeColor = System.Drawing.Color.White;
            this.btnSuaKHDT.HoveredState.Parent = this.btnSuaKHDT;
            this.btnSuaKHDT.Location = new System.Drawing.Point(642, 115);
            this.btnSuaKHDT.Name = "btnSuaKHDT";
            this.btnSuaKHDT.ShadowDecoration.Parent = this.btnSuaKHDT;
            this.btnSuaKHDT.Size = new System.Drawing.Size(112, 34);
            this.btnSuaKHDT.TabIndex = 50;
            this.btnSuaKHDT.Text = "Sửa KHĐT";
            this.btnSuaKHDT.Click += new System.EventHandler(this.btnSuaKHDT_Click);
            // 
            // idhocphan
            // 
            this.idhocphan.DataPropertyName = "Idhocphan";
            this.idhocphan.HeaderText = "Mã học phần";
            this.idhocphan.Name = "idhocphan";
            this.idhocphan.ReadOnly = true;
            this.idhocphan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tenhocphan
            // 
            this.tenhocphan.DataPropertyName = "Tenhocphan";
            this.tenhocphan.HeaderText = "Tên học phần";
            this.tenhocphan.Name = "tenhocphan";
            // 
            // sotinchi
            // 
            this.sotinchi.DataPropertyName = "Sotinchi";
            this.sotinchi.HeaderText = "Số tín chỉ";
            this.sotinchi.Name = "sotinchi";
            // 
            // sotietlythuyet
            // 
            this.sotietlythuyet.DataPropertyName = "Sotietlythuyet";
            this.sotietlythuyet.HeaderText = "Số tín chỉ LT";
            this.sotietlythuyet.Name = "sotietlythuyet";
            // 
            // sotietthuchanh
            // 
            this.sotietthuchanh.DataPropertyName = "Sotietthuchanh";
            this.sotietthuchanh.HeaderText = "Số tín chỉ TH";
            this.sotietthuchanh.Name = "sotietthuchanh";
            // 
            // sotiettuhoc
            // 
            this.sotiettuhoc.DataPropertyName = "Sotiettuhoc";
            this.sotiettuhoc.HeaderText = "Số tín chỉ Tự học";
            this.sotiettuhoc.Name = "sotiettuhoc";
            // 
            // sotietthamquan
            // 
            this.sotietthamquan.DataPropertyName = "Sotietthamquan";
            this.sotietthamquan.HeaderText = "Số tín chỉ tham quan";
            this.sotietthamquan.Name = "sotietthamquan";
            // 
            // KHDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.btnSuaKHDT);
            this.Controls.Add(this.tbHDT);
            this.Controls.Add(this.tbMaKHDT);
            this.Controls.Add(this.tbChuyennganh);
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
        private System.Windows.Forms.BindingSource cHITIETKEHOACHBindingSource;
        private Siticone.UI.WinForms.SiticoneTextBox tbChuyennganh;
        private Siticone.UI.WinForms.SiticoneTextBox tbMaKHDT;
        private Siticone.UI.WinForms.SiticoneTextBox tbHDT;
        private Siticone.UI.WinForms.SiticoneGradientButton btnSuaKHDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn idhocphan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhocphan;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotinchi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotietlythuyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotietthuchanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotiettuhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotietthamquan;
    }
}