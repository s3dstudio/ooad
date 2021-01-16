using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooad.UC
{
    public partial class UC_DKHP : UserControl
    {
        List<DTO.DKHP> _listDkhp;
        UC.HP _hp;
        public UC_DKHP()
        {
            InitializeComponent();

            siticoneDataGridView1.AllowUserToAddRows = false;

            LoadData();

        }
        public void LoadData()
        {
            var jsonString = Client.Client.Instance.Get("api/hocphan/dkhp/get");
            _listDkhp = DTO.DKHP.FromJson(jsonString);

            siticoneDataGridView1.DataSource = _listDkhp;
        }
        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();
        }

        long dem =0 ;
        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            var jsonString = Client.Client.Instance.Get("api/hocphan/dkhp/getdata/" + Client.User.Instance.iduser);
            List<DTO.DKHP> dkhpdata = DTO.DKHP.FromJson(jsonString);
            
            for(int i =0; i < dkhpdata.Count(); i++)
            {
                dem += dkhpdata[i].Sotinchi;
            }

            for (int i = 0; i < siticoneDataGridView1.Rows.Count; i++)
            {
                bool check = Convert.ToBoolean(siticoneDataGridView1.Rows[i].Cells["check"].Value?.ToString());

                if (check)
                {
                   string dem1 = siticoneDataGridView1.Rows[i].Cells["sotinchiDataGridViewTextBoxColumn"].Value.ToString();
                    dem += long.Parse(dem1);
                }
            }

            if( dem > 24) {
                MessageBox.Show("vượt quá 24 tín chỉ");
                dem = 0;
            
            }
                else
            {
                for (int i = 0; i < siticoneDataGridView1.Rows.Count; i++)
                {
                    bool check = Convert.ToBoolean(siticoneDataGridView1.Rows[i].Cells["check"].Value?.ToString());

                    if (check)
                    {
                        string id = siticoneDataGridView1.Rows[i].Cells["Idnhomlop"].Value?.ToString();

                        DTO.DKHPData dkhp = new DTO.DKHPData();

                        DTO.DKHP query = _listDkhp.FirstOrDefault(t => Convert.ToString(t.Idnhomlop) == id);

                        var bytes = Guid.NewGuid().ToByteArray();
                        Array.Resize(ref bytes, 2);
                        var bigInt = new BigInteger(bytes);
                        if (bigInt < 0)
                            bigInt = -bigInt;

                        dkhp.Iddkhp = long.Parse(bigInt.ToString());
                        dkhp.Idsv = Client.User.Instance.iduser;
                        dkhp.Idtkbnhomlop = query.Idtkbnhomlop;


                        Client.Client.Instance.Post("api/dkhpdata/post", dkhp);
                        //Console.WriteLine("iddkp = {0}, idtkbnl = {1} \n", dkhp.Iddkhp,dkhp.Idtkbnhomlop);

                        dem = 0;
                    }
                }
            }
           

            _hp.LoadData();

            this.Hide();
            this.SendToBack();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void SetHP(UC.HP hp) { _hp = hp; }
    }
}
