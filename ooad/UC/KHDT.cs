using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ooad.Client;

namespace ooad.UC
{
    public partial class KHDT : UserControl
    {
        private List<UC_Component> _listComponents = new List<UC_Component>();
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

            this.LoadData();

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            
        }

        public void AddUcComponents(DTO.KHOAHOC kh,int count)
        {

            UC_Component uC_Component = new UC_Component(kh);
            uC_Component.Location = new Point(20 + (count * 300), 0);
            tableLayoutPanel1.Controls.Add(uC_Component);
            _listComponents.Add(uC_Component);

        }

        public int CountUcComponents()
        {
            return tableLayoutPanel1.Controls.Count;
        }
        public void LoadData()
        {
            tableLayoutPanel1.Controls.Clear();

            var jsonString = Client.Client.Instance.Get("api/KHOAHOC/get");
            var listKHOAHOC = DTO.KHOAHOC.FromJson(jsonString);

            int count = listKHOAHOC.Count();
            for (int i = 0; i < count; i++)
            {
                if (listKHOAHOC[i].Active)
                {
                    AddUcComponents(listKHOAHOC[i],i);
                    //_listComponents.Add(uC_Component);
                }
            }
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            DTO.KHOAHOC khoahoc = new DTO.KHOAHOC();
            DTO.KHDT khdt = new DTO.KHDT();
            DTO.CHITIETKEHOACH chitietkehoach = new DTO.CHITIETKEHOACH();

            foreach (var item in _listComponents)
            {
                if (item.isCheck())
                {
                    var list = item.GetListKHDT();

                    khoahoc = item.GetNamKhoaHoc();

                   // Console.WriteLine("idkhoahoc {0}", khoahoc.Idkhoahoc);

                    var jsonString = Client.Client.Instance.Get("api/KHDT/get");
                    var listKHDT = DTO.KHDT.FromJson(jsonString);

                    foreach(var khdtdata in listKHDT)
                    {
                        if(khdtdata.Idkhoahoc == khoahoc.Idkhoahoc)
                        {
                            //  Console.WriteLine("idkhdt {0}", khdtdata.Idkhdt);

                            var jsonString1 = Client.Client.Instance.Get("api/chitietkhdt/get");
                            var listChiTietKHDT = DTO.CHITIETKEHOACH.FromJson(jsonString1);
                            
                            foreach(var chitietkhdt in listChiTietKHDT)
                            {
                                if (chitietkhdt.Idkhdt == khdtdata.Idkhdt)
                                {
                                    // Console.WriteLine("idchitietkhdt {0}", chitietkhdt.Idchitietkhdt);

                                    Client.Client.Instance.Delete("api/chitietkhdt/delete/", chitietkhdt.Idchitietkhdt.ToString());
                                }
                            }

                            Client.Client.Instance.Delete("api/khdt/delete/", khdtdata.Idkhdt.ToString());

                        }
                    }

                    Client.Client.Instance.Delete("api/khoahoc/delete/", khoahoc.Idkhoahoc.ToString());

                  

                    this.tableLayoutPanel1.Controls.Remove(item);
                }
            }
        }
    }
}
