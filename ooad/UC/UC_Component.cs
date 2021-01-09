using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ooad.GUI;

namespace ooad.UC
{
    public partial class UC_Component : UserControl
    {
        private long _namkhoahoc;
        public UC_Component(long namkhoahoc)
        {
            _namkhoahoc = namkhoahoc;
            InitializeComponent();
            
        }
        public UC_Component()
        {
            InitializeComponent();

        }
        int i;
        LinkLabel[] linkLabel = new LinkLabel[1000];
        ooad.GUI.Main m = new Main();
        
        private void UC_Component_Load(object sender, EventArgs e)
        {

            string jsonString = Client.Client.Instance.Get("api/KHDT/getfromyear/" + _namkhoahoc );
            var listKHDT = DTO.KHDT.FromJson(jsonString);

            siticoneLabel2.Text = "CTĐT Khoá " + this._namkhoahoc.ToString();

            //dynamic funtion
            int count = listKHDT.Count();
            for (i = 0; i < count; i++)
            {
              
                linkLabel[i] = new LinkLabel();
                linkLabel[i].Text = listKHDT[i].Tenkhdt;
                linkLabel[i].Name = "ll" + i.ToString();
                linkLabel[i].AutoSize = true;
                linkLabel[i].Location = new Point(17, 90 + (20 * i));
                linkLabel[i].LinkColor = Color.White;
                this.Height = 150 + (20 * i);
                ////áp dụng lambda funtion để handle linklabel
               
                linkLabel[i].Click += new EventHandler(delegate (object s, EventArgs args)
                {
                    //(((LinkLabel)s).Name+" Clicked"); //lưu ý handle như dòng này
                    m.tempM = ((LinkLabel)s).Text;
                });
                linkLabel[i].Click += m.khdt_load;
                this.metroListView1.Controls.Add(linkLabel[i]);

            }
        }
        //private void khdt_load(object sender, EventArgs args)
        //{
          
        //}
    }
}
