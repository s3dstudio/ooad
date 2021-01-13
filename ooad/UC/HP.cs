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
    public partial class HP : UserControl
    {
        public HP()
        {
            InitializeComponent();
            uC_DKHP1.Hide();
            uC_MNL1.Hide();

            LoadData();
          
        }
        public void LoadData()
        {
            var jsonString = Client.Client.Instance.Get("api/hocphan/dkhp/getdata/" + Client.User.Instance.iduser);
            List<DTO.DKHP> dkhpdata = DTO.DKHP.FromJson(jsonString);

            siticoneDataGridView1.DataSource = dkhpdata;
        }
        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            uC_MNL1.SetDKHP(uC_DKHP1);
            uC_MNL1.Show();
            uC_MNL1.BringToFront();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            uC_DKHP1.SetHP(this);
            uC_DKHP1.Show();
            uC_DKHP1.BringToFront();
        }
    }
}
