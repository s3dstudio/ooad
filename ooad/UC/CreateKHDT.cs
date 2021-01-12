using ooad.DTO;
using System;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;
using ooad.GUI;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ooad.UC
{
    public partial class CreateKHDT : UserControl
    {
        private string jsonString;

        private List<ComboBox> _listCombobox;

        private UC.DuyetKHDT _duyetKHDT;

        private GUI.Main _MainForm;


        public CreateKHDT()
        {
            InitializeComponent();

            jsonString = Client.Client.Instance.Get("api/CHUYENNGANH/get");

            siticoneRoundedComboBox2.DataSource = CHUYENNGANH.FromJson(jsonString);
            siticoneRoundedComboBox2.ValueMember = "idchuyennganh";
            siticoneRoundedComboBox2.DisplayMember = "tenchuyennganh";

            _listCombobox = new List<ComboBox>();
            _listCombobox.Add(siticoneRoundedComboBox2);
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
            siticoneRoundedComboBox.Name = "cbb" + temp.ToString();

            siticoneRoundedComboBox.DataSource = CHUYENNGANH.FromJson(jsonString); ;
            siticoneRoundedComboBox.ValueMember = "idchuyennganh";
            siticoneRoundedComboBox.DisplayMember = "tenchuyennganh";

            this.Controls.Add(siticoneRoundedComboBox);
            _listCombobox.Add(siticoneRoundedComboBox);
            temp++;
        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            var bytes = Guid.NewGuid().ToByteArray();
            Array.Resize(ref bytes, 2);
            var bigInt = new BigInteger(bytes);
            if (bigInt < 0)
                bigInt = -bigInt;

            KHOAHOC kh = new KHOAHOC();
            kh.Idkhoahoc = long.Parse(bigInt.ToString());
            if (lollipopTextBox1.Text != "")
                kh.Namkhoahoc = Int32.Parse(lollipopTextBox1.Text);
            kh.Active = false;

            Client.Client.Instance.Post("api/khoahoc/post/", kh);

            foreach (var item in _listCombobox)
            {
                CHUYENNGANH chuyennganh = (CHUYENNGANH)item.SelectedItem;

                DTO.KHDT khdt = new DTO.KHDT();

                bytes = Guid.NewGuid().ToByteArray();
                Array.Resize(ref bytes, 2);
                bigInt = new BigInteger(bytes);
                if (bigInt < 0)
                    bigInt = -bigInt;

                khdt.Idkhdt = long.Parse(bigInt.ToString());
                khdt.Tenkhdt = chuyennganh.Tenchuyennganh;
                khdt.Idhdt = 1;
                khdt.Idchuyennganh = chuyennganh.Idchuyennganh;
                khdt.Idlhdt = 1;
                khdt.Idkhoahoc = kh.Idkhoahoc;
                khdt.Active = false;

                Client.Client.Instance.Post("api/KHDT/post/", khdt);
            }

            this._duyetKHDT.AddUcComponents(kh, _duyetKHDT.CountUcComponents());
            this._MainForm.LoadNumberOfDuyet();

            this.SendToBack();
        }

        private void siticoneCircleButton1_Click(object sender, EventArgs e)
        {
            //List<List<CHUYENNGANH>> data = new List<List<CHUYENNGANH>>();
            //foreach(var item in _listCombobox)
            //{
            //    data.Add((List<CHUYENNGANH>)item.DataSource);
            //}
            ThemKhoa tk = new ThemKhoa();
            tk.Show();
        }

        public void SetDuyetKHDTUC(UC.DuyetKHDT duyetKHDT)
        {
            this._duyetKHDT = duyetKHDT;
        }
        public void SetMainForm(GUI.Main main)
        {
            this._MainForm = main;
        }
    }
}
