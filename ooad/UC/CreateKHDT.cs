using ooad.DTO;
using System;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;
using ooad.GUI;

namespace ooad.UC
{
    public partial class CreateKHDT : UserControl
    {
        public CreateKHDT()
        {
            InitializeComponent();
        }
        private int temp = 1;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Label label = new Label();
            label.Text = "Khoa :";
            label.Location = new Point(siticoneLabel3.Location.X, siticoneLabel3.Location.Y + (50 * temp));
            linkLabel1.Location = new Point(label.Location.X, label.Location.Y + 50);
            label.Width = siticoneLabel1.Width/5;
            label.Font = new Font("Roboto", 9, FontStyle.Regular);
            this.Controls.Add(label);
            Siticone.UI.WinForms.SiticoneRoundedComboBox siticoneRoundedComboBox = new Siticone.UI.WinForms.SiticoneRoundedComboBox();
            siticoneRoundedComboBox.Location = new Point(siticoneRoundedComboBox2.Location.X, siticoneRoundedComboBox2.Location.Y + (50 * temp));
            siticoneRoundedComboBox.Width = 199;
            siticoneRoundedComboBox.Name = "tb" + temp.ToString();
            this.Controls.Add(siticoneRoundedComboBox);
            temp++;
        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            //var bytes = Guid.NewGuid().ToByteArray();
            //Array.Resize(ref bytes, 2);
            //var bigInt = new BigInteger(bytes);
            //if (bigInt < 0)
            //    bigInt = -bigInt;

            //KHOAHOC kh = new KHOAHOC();
            //kh.Idkhoahoc = long.Parse(bigInt.ToString());
            //if(textBox1.Text != "")
            //    kh.Namkhoahoc = Int32.Parse(textBox1.Text);

            //Client.Client.Instance.Post("api/khoahoc/post/", kh);

            this.SendToBack();
        }

        private void siticoneCircleButton1_Click(object sender, EventArgs e)
        {
            ThemKhoa tk = new ThemKhoa();
            tk.Show();
        }
    }
}
