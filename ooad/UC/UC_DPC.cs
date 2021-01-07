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
    public partial class UC_DPC : UserControl
    {
        public UC_DPC()
        {
            InitializeComponent();
        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();
        }

        private void UC_DPC_Load(object sender, EventArgs e)
        {
            int count = 4;
            for (int i = 0; i < count; i++)
            {
                UC_Duyet uC_Duyet = new UC_Duyet();
                uC_Duyet.Location = new Point(20 + (i * 300), 0);
                tableLayoutPanel1.Controls.Add(uC_Duyet);
            }
        }
    }
}
