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

        LinkLabel[] linkLabel = new LinkLabel[5];
        private void UC_Component_Load(object sender, EventArgs e)
        {
            //dynamic funtion
            int count = 5;
            for (int i = 0; i < count; i++)
            {
                linkLabel[i] = new LinkLabel();
                linkLabel[i].Text = $"LinkLabel {i.ToString()}";
                linkLabel[i].Name = "ll" + i.ToString();
                linkLabel[i].Location = new Point(17, 90 + (20 * i));
                linkLabel[i].LinkColor = Color.White;
                this.Height = 150 + (20 * i);

                //áp dụng lambda funtion để handle linklabel
                linkLabel[i].Click += new EventHandler(delegate (object s, EventArgs args)
                {
                   MessageBox.Show(((LinkLabel)s).Name+" Clicked"); //lưu ý handle như dòng này
                });
                this.metroListView1.Controls.Add(linkLabel[i]);
            }
        }
    }
}
