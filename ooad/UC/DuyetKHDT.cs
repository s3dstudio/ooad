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
        private List<UC_Component> _listComponents = new List<UC_Component>();

        private UC.KHDT _khdtUC;

        private GUI.Main _MainForm;

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
            //LoadData();
        }

        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            DTO.KHOAHOC khoahoc = new DTO.KHOAHOC();
            foreach (var item in _listComponents)
            {
                if (item.isCheck())
                {
                    var list = item.GetListKHDT();

                    khoahoc = item.GetNamKhoaHoc();
                  //  Console.WriteLine("idkhoahoc {0}", khoahoc.Idkhoahoc);
                    khoahoc.Active = true;
                    Client.Client.Instance.Put("api/KHOAHOC/edit/", khoahoc);

                    foreach (var khdt in list)
                    {
                        khdt.Active = true;
                        Client.Client.Instance.Put("api/KHDT/edit/", khdt);
                    }

                    this.tableLayoutPanel1.Controls.Remove(item);
                }
            }

            _khdtUC.AddUcComponents(khoahoc, _khdtUC.CountUcComponents());

            this.SendToBack();

            _MainForm.LoadNumberOfDuyet();

        }

        public void AddUcComponents(DTO.KHOAHOC kh,int count)
        {
            UC_Component uC_Component = new UC_Component(kh, false);
            uC_Component.Location = new Point(20 + (count * 300), 0);
            tableLayoutPanel1.Controls.Add(uC_Component);
            _listComponents.Add(uC_Component);
        }

        public int CountUcComponents() { return tableLayoutPanel1.Controls.Count; }

        public void LoadData()
        {
            _listComponents.Clear();
            tableLayoutPanel1.Controls.Clear();

            var jsonString = Client.Client.Instance.Get("api/KHOAHOC/get");
            var listKHOAHOC = DTO.KHOAHOC.FromJson(jsonString);

            int count = listKHOAHOC.Count();

            for (int i = 0; i < count; i++)
            {
                if (!listKHOAHOC[i].Active)
                {
                    AddUcComponents(listKHOAHOC[i],i);
                }
            }
        }

        public void SetKHDTUC(UC.KHDT kHDT)
        {
            _khdtUC = kHDT;
        }
        public void SetMainForm(GUI.Main main)
        {
            _MainForm = main;
        }
    }
}
