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
        List<UC_Component> _listComponents = new List<UC_Component>();
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

            var jsonString = Client.Client.Instance.Get("api/KHOAHOC/get");
            var listKHOAHOC = DTO.KHOAHOC.FromJson(jsonString);

            int count = listKHOAHOC.Count();

            for (int i = 0; i < count; i++)
            {
                if (!listKHOAHOC[i].Active)
                {
                    UC_Component uC_Component = new UC_Component(listKHOAHOC[i],false);
                    uC_Component.Location = new Point(20 + (i * 300), 0);
                    tableLayoutPanel1.Controls.Add(uC_Component);
                    _listComponents.Add(uC_Component);
                }
            }
        }

        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            foreach(var item in _listComponents)
            {
                if (item.isCheck())
                {
                    var list = item.GetListKHDT();

                    var khoahoc = item.GetNamKhoaHoc();
                    khoahoc.Active = true;
                    Client.Client.Instance.Put("api/KHOAHOC/edit/",khoahoc);

                    foreach (var khdt in list)
                    {
                        khdt.Active = true;
                        Client.Client.Instance.Put("api/KHDT/edit/", khdt);
                    }

                    
                }
            }

            this.SendToBack();

        }
    }
}
