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
    public partial class HP : UserControl
    {
        List<DTO.DKHP> _dkhpdata;
        int _sotinchi = 0;
        int i, key, j, keydelete;
        public HP()
        {
            InitializeComponent();
            uC_DKHP1.Hide();
            uC_MNL1.Hide();

            cbbHocky.Items.Add("");
            cbbHocky.Items.Add("1");
            cbbHocky.Items.Add("2");
            cbbHocky.Items.Add("3");

            var time = DateTime.Now;
            cbbNamHoc.Items.Add("");
            for (int i = 2000; i <= time.Year; i++)
            {
                cbbNamHoc.Items.Add(i.ToString());
            }

        }
        public void LoadData()
        {
            _sotinchi = 0;

            var jsonString = Client.Client.Instance.Get("api/hocphan/dkhp/getdata/" + Client.User.Instance.iduser);
            _dkhpdata = DTO.DKHP.FromJson(jsonString);

            siticoneDataGridView1.DataSource = _dkhpdata;

            foreach(var item in _dkhpdata)
            {
                _sotinchi += (int)item.Sotinchi;
            }
            tbSotinchi.Text = _sotinchi.ToString();
        }
        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            uC_MNL1.SetDKHP(uC_DKHP1);
            uC_MNL1.Show();
            uC_MNL1.BringToFront();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            uC_DKHP1.SetHP(this);
            uC_DKHP1.Show();
            uC_DKHP1.BringToFront();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < siticoneDataGridView1.Rows.Count; i++)
            {
                bool check = Convert.ToBoolean(siticoneDataGridView1.Rows[i].Cells["Check"].Value?.ToString());

                if (check)
                {
                    string id = siticoneDataGridView1.Rows[i].Cells["Idtkbnhomlop"].Value?.ToString();



                    DTO.DKHP query = _dkhpdata.FirstOrDefault(t => Convert.ToString(t.Idtkbnhomlop) == id);

                    var jsonString2 = Client.Client.Instance.Get("api/dkhpdata/get");
                    List<DTO.DKHPData> dkhpdata1 = DTO.DKHPData.FromJson(jsonString2);

                    for (j = 0; j < dkhpdata1.Count(); j++)
                    {
                        if (dkhpdata1[j].Idtkbnhomlop == query.Idtkbnhomlop)
                        {
                            keydelete = j;
                        }
                    }


                    Client.Client.Instance.Delete("api/dkhpdata/delete/", dkhpdata1[keydelete].Iddkhp.ToString());

                    //  Console.WriteLine("id = {0} ,idsv  = {1} ,idtkbnhomlop  ={2} \n", dkhpdata1[keydelete].Iddkhp, dkhpdata1[keydelete].Idsv, dkhpdata1[keydelete].Idtkbnhomlop);




                }

            }

            LoadData();
        }

        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cbbHocky_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<DTO.DKHP> data = new List<DTO.DKHP>();
            _sotinchi = 0;
            foreach (var item in _dkhpdata)
            {
                if (item.Hocky == cbbHocky.Text && item.Thoigianmo.Year.ToString() == cbbNamHoc.Text)
                {
                    _sotinchi += (int)item.Sotinchi;
                    data.Add(item);
                }
            }

            if (cbbHocky.Text == "" && cbbNamHoc.Text == "")
            {
                siticoneDataGridView1.DataSource = _dkhpdata;
                foreach (var item in _dkhpdata)
                {
                    _sotinchi += (int)item.Sotinchi;
                }
                tbSotinchi.Text = _sotinchi.ToString();
                return;
            }

            tbSotinchi.Text = _sotinchi.ToString();
            siticoneDataGridView1.DataSource = data;

        }

        private void cbbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            List<DTO.DKHP> data = new List<DTO.DKHP>();
            _sotinchi = 0;
            foreach (var item in _dkhpdata)
            {
                if (item.Hocky == cbbHocky.Text && item.Thoigianmo.Year.ToString() == cbbNamHoc.Text)
                {
                    _sotinchi += (int)item.Sotinchi;
                    data.Add(item);
                }
            }

            if (cbbHocky.Text == "" && cbbNamHoc.Text == "")
            {
                siticoneDataGridView1.DataSource = _dkhpdata;
                foreach (var item in _dkhpdata)
                {
                    _sotinchi += (int)item.Sotinchi;
                }
                tbSotinchi.Text = _sotinchi.ToString();
                return;
            }

            tbSotinchi.Text = _sotinchi.ToString();
            siticoneDataGridView1.DataSource = data;
        }

        

       
    }
}
