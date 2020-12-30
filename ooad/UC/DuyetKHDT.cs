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
    public partial class DuyetKHDT : UserControl
    {
        public DuyetKHDT()
        {
            InitializeComponent();
        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void DuyetKHDT_Load(object sender, EventArgs e)
        {
            int count = 4;
            for (int i = 0; i < count; i++)
            {
                UC_Component uC_Component = new UC_Component();
                uC_Component.Location = new Point(20 + (i * 300), 0);
                tableLayoutPanel1.Controls.Add(uC_Component);
            }
        }
    }
}
