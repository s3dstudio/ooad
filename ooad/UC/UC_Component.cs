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
    public partial class UC_Component : UserControl
    {
        public UC_Component()
        {
            InitializeComponent();
        }
        private void UC_Component_Load(object sender, EventArgs e)
        {
            int count = 5;
            for (int i = 0; i < count; i++)
            {
                LinkLabel linkLabel = new LinkLabel();
                linkLabel.Text = "LinkLabel " + i.ToString();
                linkLabel.Location = new Point(17, 90+(20*i));
                linkLabel.LinkColor = Color.White;
                this.metroListView1.Controls.Add(linkLabel);
                this.Height = 150 + (20 * i);
            }
        }
    }
}
