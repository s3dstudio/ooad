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
    public partial class KHDT : UserControl
    {
        public KHDT()
        {
            InitializeComponent();
        }
        protected void check()
        {
            UC_Component uC_Component = new UC_Component();
        }
        private void load (object sender, EventArgs e)
        {
        }
        private void KHDT_Load(object sender, EventArgs e)
        {
            check();
            int count = 4;
            for (int i = 0; i < count; i++)
            {
                UC_Component uC_Component = new UC_Component();
                uC_Component.Location = new Point(20 + (i * 300), 0);
                tableLayoutPanel1.Controls.Add(uC_Component);
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
