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
    }
}
