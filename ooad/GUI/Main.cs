using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooad.GUI
{
    public partial class Main : Form
    {
        public string tempM { get; set; }
        public string idCTKHDT { get; set; }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        public Main()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        public void khdt_load (object sender, EventArgs args)
        {
            KHDT k = new KHDT();
            k.tenKHDT = this.tempM;
            k.Text = this.tempM;
            k.LoadData(idCTKHDT);
            k.Show();
            //siticoneButton8.Hide();
        }
        public void LoadNumberOfDuyet()
        {
            var jsonString = Client.Client.Instance.Get("api/KHOAHOC/get");
            var listKHOAHOC = DTO.KHOAHOC.FromJson(jsonString);

            int count = listKHOAHOC.Count();

            int value = 0;
            for (int i = 0; i < count; i++)
            {
                if (!listKHOAHOC[i].Active)
                    value++;

            }
            siticoneCircleButton2.Text = value.ToString();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            siticoneShadowForm1.SetShadowForm(this);

            LoadNumberOfDuyet();
            User.Text = Client.User.Instance.hoten;
            
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void siticoneButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneButton1.Checked)
            {
                khdt1.BringToFront();
                siticoneButton6.BringToFront();
                siticoneButton7.BringToFront();
                siticoneCircleButton2.BringToFront();
               // siticoneButton8.BringToFront();
            }
        }

        private void siticoneButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneButton2.Checked)
            {
                pcgd1.LoadData();
                pcgd1.BringToFront();
            }
        }

        private void siticoneButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneButton3.Checked)
            {
                //tkb1.BringToFront();
                tkB_DEV1.LoadData();
                tkB_DEV1.BringToFront();
            }
        }

        private void siticoneButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneButton4.Checked)
            {
                kqht1.LoadData();
                kqht1.BringToFront();
            }
        }

        private void siticoneButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneButton5.Checked)
            {
                hp1.LoadData();
                hp1.BringToFront();
            }
        }
        
        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            createKHDT1.SetDuyetKHDTUC(duyetKHDT1);
            createKHDT1.SetMainForm(this);
            createKHDT1.BringToFront();
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            duyetKHDT1.LoadData();
            duyetKHDT1.SetKHDTUC(khdt1);
            duyetKHDT1.SetMainForm(this);
            duyetKHDT1.BringToFront();
        }

        private void siticoneButton8_Click(object sender, EventArgs e)
        {
            //ooad.GUI.KHDT k = new KHDT();
            ////k.LoadData("6");
            //k.Show();
        }

        private void siticoneCircleButton2_Click(object sender, EventArgs e)
        {

        }


        private void User_Click(object sender, EventArgs e)
        {
            GUI.User userForm = new User();
            userForm.Show();
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
