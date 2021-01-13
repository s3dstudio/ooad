using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooad.UC
{
    public partial class UC_MNL : UserControl
    {
        UC.UC_DKHP _dkhp;
        public UC_MNL()
        {
            InitializeComponent();
        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            this.Hide();
        }

        private void siticoneGradientButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();
        }

        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            DTO.NHOMLOP nhomlop = new DTO.NHOMLOP();

            nhomlop.Idnhomlop = lollipopTextBox4.Text;
            nhomlop.Idhocphan = lollipopTextBox1.Text;
            nhomlop.Ten = lollipopTextBox2.Text;
            nhomlop.Thoigianmo = DateTimeOffset.Parse(lollipopTextBox3.Text);

            var bytes = Guid.NewGuid().ToByteArray();
            Array.Resize(ref bytes, 2);
            var bigInt = new BigInteger(bytes);
            if (bigInt < 0)
                bigInt = -bigInt;

            DTO.TKBNHOMLOP tkbnl = new DTO.TKBNHOMLOP();
            tkbnl.Hocky = lollipopTextBox5.Text;
            tkbnl.Idgiangvien = long.Parse(lollipopTextBox6.Text);
            tkbnl.Idnhomlop = lollipopTextBox4.Text;
            tkbnl.Idphonglt = long.Parse(lollipopTextBox7.Text);
            tkbnl.Idphongth = long.Parse(lollipopTextBox8.Text);
            tkbnl.Idtkbnhomlop = long.Parse(bigInt.ToString());
            tkbnl.Thu = long.Parse(lollipopTextBox9.Text);
            tkbnl.Tietbatdau = long.Parse(lollipopTextBox10.Text);
            tkbnl.Tietketthuc = long.Parse(lollipopTextBox11.Text);
            tkbnl.Tuan = "1,2,3,4,5";

            Client.Client.Instance.Post("api/nhomlop/post", nhomlop);
            Client.Client.Instance.Post("api/tkbnhomlop/post", tkbnl);

            _dkhp.LoadData();

            this.Hide();
            this.SendToBack();
        }
        public void SetDKHP(UC.UC_DKHP dk)
        {
            _dkhp = dk;
        }
    }
}
