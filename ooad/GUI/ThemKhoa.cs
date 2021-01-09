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
using MaterialSkin;
using MaterialSkin.Controls;
using ooad.DTO;
using ooad.UC;

namespace ooad.GUI
{
    public partial class ThemKhoa : MaterialForm
    {
        List<List<CHUYENNGANH>> _data;

        public ThemKhoa()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);
            this.Text = "THÊM KHOA";

        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            var bytes = Guid.NewGuid().ToByteArray();
            Array.Resize(ref bytes, 2);
            var bigInt = new BigInteger(bytes);
            if (bigInt < 0)
                bigInt = -bigInt;

            CHUYENNGANH chuyennganh = new CHUYENNGANH();
            chuyennganh.Idchuyennganh = long.Parse(bigInt.ToString());
            chuyennganh.Idkhoa = 1;
            chuyennganh.Tenchuyennganh = siticoneTextBox1.Text;

            Client.Client.Instance.Post("api/CHUYENNGANH/post", chuyennganh);

            CreateKHDT createKHDT = new CreateKHDT();
            createKHDT.Show();
            this.Close();
        }
    }
}
