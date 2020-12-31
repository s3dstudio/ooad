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
    public partial class PCGD : UserControl
    {
        public PCGD()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            uC_DKGD1.Show();
            uC_DKGD1.BringToFront();
        }

        private void uC_DKGD1_Load(object sender, EventArgs e)
        {
            uC_DKGD1.Hide();
            uC_PCGD1.Hide();
            uC_DPC1.Hide();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            uC_PCGD1.Show();
            uC_PCGD1.BringToFront();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            uC_DPC1.Show();
            uC_DPC1.BringToFront();
        }
    }
}
