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
        private double dtb= 0 ,tong = 0.0;
        public KQHT()
        {
            InitializeComponent();

            var jsonString = Client.Client.Instance.Get("api/ketquahoctap/getbyusername/" + Client.User.Instance.userName);
            List<DTO.CHITIETKQHT> listChitiet = DTO.CHITIETKQHT.FromJson(jsonString);

            siticoneDataGridView1.DataSource = listChitiet;

            int count = listChitiet.Count();
            for (i = 0; i < count; i++)
            {
                tong += listChitiet[i].Ketqua;

            }
            dtb = Math.Round((tong / count),1);

            siticoneTextBox1.Text = dtb.ToString();

        }


        int i;
    }
    
}
