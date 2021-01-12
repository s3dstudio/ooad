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
using MaterialSkin.Controls;

namespace ooad.GUI
{
    public partial class Login : Form
    {
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
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lollipopLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lollipopButton1_Click(object sender, EventArgs e)
        {
            string userName = lollipopTextBox1.Text;
            string passWord = lollipopTextBox2.Text;

            var jsonString = Client.Client.Instance.Get("api/user/getbyusername/" + userName);
            DTO.USER users = DTO.USER.FromJsonToObject(jsonString);

            if (users != null)
            {
                if (users.Username == userName && users.Password == passWord)
                {
                    GUI.Main main = new Main();

                    main.Show();

                    this.Hide();
                }
            }
            else MessageBox.Show("Sai Tài khoản hoặc mật khẩu");
            

            
        }
    }
}
