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
        private DTO.KHOAHOC _khoahoc;
        private List<DTO.KHDT> _listKHDT = new List<DTO.KHDT>();

        public UC_Component(DTO.KHOAHOC khoahoc)
        {
            _khoahoc = khoahoc;
            InitializeComponent();

            var jsonString = Client.Client.Instance.Get("api/KHDT/getfromyear/" + _khoahoc.Namkhoahoc);
            _listKHDT = DTO.KHDT.FromJson(jsonString);

            siticoneLabel2.Text = "CTĐT Khoá " + this._khoahoc.Namkhoahoc.ToString();

            //dynamic funtion
            int count = _listKHDT.Count();
            for (i = 0; i < count; i++)
            {
                if (_listKHDT[i].Active)
                {
                    linkLabel[i] = new LinkLabel();
                    linkLabel[i].Text = _listKHDT[i].Tenkhdt;
                    linkLabel[i].Name = _listKHDT[i].Idkhdt.ToString();
                    linkLabel[i].AutoSize = true;
                    linkLabel[i].Location = new Point(17, 90 + (20 * i));
                    linkLabel[i].LinkColor = Color.White;
                    this.Height = 150 + (20 * i);
                    ////áp dụng lambda funtion để handle linklabel

                    linkLabel[i].Click += new EventHandler(delegate (object s, EventArgs args)
                    {
                        //(((LinkLabel)s).Name+" Clicked"); //lưu ý handle như dòng này
                        m.tempM = ((LinkLabel)s).Text;
                        m.idCTKHDT = ((LinkLabel)s).Name;
                    });
                    linkLabel[i].Click += m.khdt_load;
                    this.metroListView1.Controls.Add(linkLabel[i]);
                }

            }

        }

        public UC_Component(DTO.KHOAHOC khoahoc, bool isActive)
        {
            _khoahoc = khoahoc;
            InitializeComponent();

            var jsonString = Client.Client.Instance.Get("api/KHDT/getfromyear/" + _khoahoc.Namkhoahoc);
            _listKHDT = DTO.KHDT.FromJson(jsonString);

            siticoneLabel2.Text = "CTĐT Khoá " + this._khoahoc.Namkhoahoc.ToString();

            //dynamic funtion
            int count = _listKHDT.Count();
            for (i = 0; i < count; i++)
            {
                if (!_listKHDT[i].Active)
                {
                    linkLabel[i] = new LinkLabel();
                    linkLabel[i].Text = _listKHDT[i].Tenkhdt;
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

           
        }

        public DTO.KHOAHOC GetNamKhoaHoc()
        {
            return this._khoahoc;
        }
        public List<DTO.KHDT> GetListKHDT()
        {
            return this._listKHDT;
        }
        public bool isCheck()
        {
            return lollipopCheckBox1.Checked;
        }

        private void lollipopCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

       
        
    }
}
