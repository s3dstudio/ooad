using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ooad.GUI
{
    public partial class User : MaterialForm
    {
        public User()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);
            this.Text = "Thông tin cá nhân";
            this.Name = "Show";
            if(this.Name=="Show")
            {
                siticoneRoundedTextBox1.Enabled = false;
                siticoneRoundedTextBox2.Enabled = false;
                siticoneRoundedTextBox3.Enabled = false;
                siticoneRoundedTextBox4.Enabled = false;
                siticoneRoundedTextBox5.Enabled = false;
                siticoneRoundedTextBox6.Enabled = false;
                siticoneRoundedTextBox7.Enabled = false;
            }
        }
    }
}
