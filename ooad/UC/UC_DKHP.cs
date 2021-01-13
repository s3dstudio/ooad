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
    public partial class UC_DKHP : UserControl
    {
        public UC_DKHP()
        {
            InitializeComponent();

            siticoneDataGridView1.AllowUserToAddRows = false;

            var jsonString = Client.Client.Instance.Get("api/hocphan/dkhp/get");
            List<DTO.DKHP> dkhp = DTO.DKHP.FromJson(jsonString);

            siticoneDataGridView1.DataSource = dkhp;

        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();
        }

        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            int c = 0;
            for(int i =0;i<siticoneDataGridView1.Rows.Count;i++)
            {
                bool check = Convert.ToBoolean(siticoneDataGridView1.Rows[i].Cells["check"].Value?.ToString());
                
                if(check)
                {
                    c++;
                }
            }
            Console.WriteLine(c.ToString());
            this.SendToBack();
        }
    }
}
