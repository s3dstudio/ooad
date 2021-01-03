
namespace ooad.UC
{
    partial class TKB_DEV
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
            this.components = new System.ComponentModel.Container();
            this.schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.thu2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thu3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thu4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thu5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thu6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thu7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chunhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerDataStorage1
            // 
            // 
            // 
            // 
            this.schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.thu2,
            this.thu3,
            this.thu4,
            this.thu5,
            this.thu6,
            this.thu7,
            this.chunhat});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(871, 479);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // thu2
            // 
            this.thu2.HeaderText = "Thứ 2";
            this.thu2.Name = "thu2";
            // 
            // thu3
            // 
            this.thu3.HeaderText = "Thứ 3";
            this.thu3.Name = "thu3";
            // 
            // thu4
            // 
            this.thu4.HeaderText = "Thứ 4";
            this.thu4.Name = "thu4";
            // 
            // thu5
            // 
            this.thu5.HeaderText = "Thứ 5";
            this.thu5.Name = "thu5";
            // 
            // thu6
            // 
            this.thu6.HeaderText = "Thứ 6";
            this.thu6.Name = "thu6";
            // 
            // thu7
            // 
            this.thu7.HeaderText = "Thứ 7";
            this.thu7.Name = "thu7";
            // 
            // chunhat
            // 
            this.chunhat.HeaderText = "Chủ Nhật";
            this.chunhat.Name = "chunhat";
            // 
            // TKB_DEV
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "TKB_DEV";
            this.Size = new System.Drawing.Size(871, 479);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Controls.CalendarControl calendarControl1;
        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn thu2;
        private System.Windows.Forms.DataGridViewTextBoxColumn thu3;
        private System.Windows.Forms.DataGridViewTextBoxColumn thu4;
        private System.Windows.Forms.DataGridViewTextBoxColumn thu5;
        private System.Windows.Forms.DataGridViewTextBoxColumn thu6;
        private System.Windows.Forms.DataGridViewTextBoxColumn thu7;
        private System.Windows.Forms.DataGridViewTextBoxColumn chunhat;
    }
}
