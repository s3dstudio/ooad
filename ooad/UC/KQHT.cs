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
    public partial class KQHT : UserControl   
    {
        private double DTB = 0.0;
        private int TongTinChi = 0;

        public KQHT()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            var jsonString = Client.Client.Instance.Get("api/ketquahoctap/getbyusername/" + Client.User.Instance.userName);
            List<DTO.CHITIETKQHT> listChitiet = DTO.CHITIETKQHT.FromJson(jsonString);

            siticoneDataGridView1.DataSource = listChitiet;

            double tong = 0.0;
            int count = listChitiet.Count();
            for (int i = 0; i < count; i++)
            {
                tong += listChitiet[i].Ketqua;
                if (listChitiet[i].Ketqua >= 5)
                    TongTinChi += (int)listChitiet[i].Sotinchi;

            }
            DTB = Math.Round((tong / count), 1);

            siticoneTextBox1.Text = DTB.ToString();
            siticoneTextBox2.Text = TongTinChi.ToString();
        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KQHT_Load(object sender, EventArgs e)
        {
           LoadData();
        }
    }
    
}
