
namespace ooad.UC
{
    partial class UC_Component
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
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneShadowForm1 = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.siticoneSeparator1 = new Siticone.UI.WinForms.SiticoneSeparator();
            this.siticoneLabel2 = new Siticone.UI.WinForms.SiticoneLabel();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.lollipopCheckBox1 = new LollipopCheckBox();
            this.SuspendLayout();
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Acre Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.Location = new System.Drawing.Point(188, 28);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(136, 27);
            this.siticoneLabel1.TabIndex = 1;
            this.siticoneLabel1.Text = "Add function";
            // 
            // siticoneSeparator1
            // 
            this.siticoneSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(172)))), ((int)(((byte)(239)))));
            this.siticoneSeparator1.FillColor = System.Drawing.Color.White;
            this.siticoneSeparator1.Location = new System.Drawing.Point(26, 65);
            this.siticoneSeparator1.Name = "siticoneSeparator1";
            this.siticoneSeparator1.Size = new System.Drawing.Size(200, 10);
            this.siticoneSeparator1.TabIndex = 5;
            // 
            // siticoneLabel2
            // 
            this.siticoneLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(172)))), ((int)(((byte)(239)))));
            this.siticoneLabel2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel2.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel2.Location = new System.Drawing.Point(26, 34);
            this.siticoneLabel2.Name = "siticoneLabel2";
            this.siticoneLabel2.Size = new System.Drawing.Size(96, 25);
            this.siticoneLabel2.TabIndex = 4;
            this.siticoneLabel2.Text = "Khoá 2018";
            // 
            // metroListView1
            // 
            this.metroListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(172)))), ((int)(((byte)(239)))));
            this.metroListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(0, 0);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(250, 400);
            this.metroListView1.TabIndex = 6;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            // 
            // lollipopCheckBox1
            // 
            this.lollipopCheckBox1.AutoSize = true;
            this.lollipopCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopCheckBox1.CheckColor = "#508ef5";
            this.lollipopCheckBox1.Location = new System.Drawing.Point(227, 3);
            this.lollipopCheckBox1.Name = "lollipopCheckBox1";
            this.lollipopCheckBox1.Size = new System.Drawing.Size(20, 20);
            this.lollipopCheckBox1.TabIndex = 8;
            this.lollipopCheckBox1.UseVisualStyleBackColor = false;
            // 
            // UC_Component
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lollipopCheckBox1);
            this.Controls.Add(this.siticoneSeparator1);
            this.Controls.Add(this.siticoneLabel2);
            this.Controls.Add(this.metroListView1);
            this.Name = "UC_Component";
            this.Size = new System.Drawing.Size(250, 400);
            this.Load += new System.EventHandler(this.UC_Component_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm1;
        private Siticone.UI.WinForms.SiticoneSeparator siticoneSeparator1;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel2;
        private MetroFramework.Controls.MetroListView metroListView1;
        private LollipopCheckBox lollipopCheckBox1;
    }
}
