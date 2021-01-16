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
using ooad.DTO;
using ooad.GUI;
namespace ooad.UC
{
    public partial class UC_MNL : UserControl
    {
        UC.UC_DKHP _dkhp;
        private string jsonString,jsonString1, jsonString2, jsonString3;

        private List<ComboBox> _listCombobox,_listCombobox1,_listCombobox2,_listCombobox3;

        private void siticoneRoundedComboBox1_DisplayMemberChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedComboBox1_BindingContextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<HOCPHAN> hp = HOCPHAN.FromJson(jsonString);
            foreach(var item in hp)
            {
                if (item.Idhocphan == siticoneRoundedComboBox1.Text)
                {
                    siticoneRoundedComboBox5.Text = item.Tenhocphan;
                    break;
                }

            }
            
        }

        public UC_MNL()
        {
            InitializeComponent();

            jsonString = Client.Client.Instance.Get("api/HOCPHAN/get");

            siticoneRoundedComboBox1.DataSource = HOCPHAN.FromJson(jsonString);
            siticoneRoundedComboBox1.ValueMember = "idhocphan";
            siticoneRoundedComboBox1.DisplayMember = "idhocphan";

            siticoneRoundedComboBox5.DataSource = HOCPHAN.FromJson(jsonString);
            siticoneRoundedComboBox5.ValueMember = "idhocphan";
            siticoneRoundedComboBox5.DisplayMember = "tenhocphan";

            _listCombobox = new List<ComboBox>();
            _listCombobox.Add(siticoneRoundedComboBox1);

            jsonString1 = Client.Client.Instance.Get("api/GIANGVIEN/get");

            siticoneRoundedComboBox2.DataSource = GIANGVIEN.FromJson(jsonString1);
            siticoneRoundedComboBox2.ValueMember = "idgiangvien";
            siticoneRoundedComboBox2.DisplayMember = "tengv";

            _listCombobox1 = new List<ComboBox>();
            _listCombobox1.Add(siticoneRoundedComboBox2);

            jsonString2 = Client.Client.Instance.Get("api/PHONGHOC/get");

            siticoneRoundedComboBox3.DataSource = PHONGHOC.FromJson(jsonString2);
            siticoneRoundedComboBox3.ValueMember = "idphonghoc";
            siticoneRoundedComboBox3.DisplayMember = "sohieu";

            _listCombobox2 = new List<ComboBox>();
            _listCombobox2.Add(siticoneRoundedComboBox3);

            siticoneRoundedComboBox4.DataSource = PHONGHOC.FromJson(jsonString2);
            siticoneRoundedComboBox4.ValueMember = "idphonghoc";
            siticoneRoundedComboBox4.DisplayMember = "sohieu";

            _listCombobox3 = new List<ComboBox>();
            _listCombobox3.Add(siticoneRoundedComboBox4);
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
            nhomlop.Idhocphan = siticoneRoundedComboBox1.Text;
            nhomlop.Ten = siticoneRoundedComboBox5.Text;
            nhomlop.Thoigianmo = DateTimeOffset.Parse(lollipopTextBox3.Text);

            var bytes = Guid.NewGuid().ToByteArray();
            Array.Resize(ref bytes, 2);
            var bigInt = new BigInteger(bytes);
            if (bigInt < 0)
                bigInt = -bigInt;

            DTO.TKBNHOMLOP tkbnl = new DTO.TKBNHOMLOP();
            tkbnl.Hocky = lollipopTextBox5.Text;
            List<GIANGVIEN> listgv = GIANGVIEN.FromJson(jsonString1);
            var temp = siticoneRoundedComboBox2.SelectedItem as GIANGVIEN;
            tkbnl.Idgiangvien = long.Parse(temp.Idgiangvien.ToString());
            tkbnl.Idnhomlop = lollipopTextBox4.Text;
            var phonghoclt = siticoneRoundedComboBox3.SelectedItem as PHONGHOC;
            tkbnl.Idphonglt = long.Parse(phonghoclt.Idphonghoc.ToString());
            var phonghocth = siticoneRoundedComboBox4.SelectedItem as PHONGHOC;
            tkbnl.Idphongth = long.Parse(phonghocth.Idphonghoc.ToString());
            tkbnl.Idtkbnhomlop = long.Parse(bigInt.ToString());
            tkbnl.Thu = long.Parse(lollipopTextBox7.Text);
            tkbnl.Tietbatdau = long.Parse(lollipopTextBox6.Text);
            tkbnl.Tietketthuc = long.Parse(lollipopTextBox11.Text);
            tkbnl.Tuan = "1,2,3,4,5,6,7,8,9,10";

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

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

           
        }
    }
}
