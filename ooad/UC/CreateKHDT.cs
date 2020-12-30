using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            TextBox textBox = new TextBox();
            textBox.Location = new Point(textBox2.Location.X, textBox2.Location.Y + (50 * temp));
            textBox.Width = 199;
            this.Controls.Add(textBox);
            LollipopFileInput lollipopFileInput = new LollipopFileInput();
            lollipopFileInput.Width = lollipopFileInput1.Width;
            lollipopFileInput.Location = new Point(lollipopFileInput1.Location.X, textBox2.Location.Y + (50 * temp));
            this.Controls.Add(lollipopFileInput);
            temp++;
        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
