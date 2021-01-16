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
    public partial class KQHT : UserControl   
    {
        private double dtb= 0 ,tong = 0.0;
        private long SumTinChi = 0;
        List<DTO.CHITIETKQHT> _listchitietkqht ;
      
        public KQHT()
        {
            InitializeComponent();

            LoadData();


        }

        public void LoadData()
        {
            var jsonString = Client.Client.Instance.Get("api/ketquahoctap/getbyusername/" + Client.User.Instance.userName);
            _listchitietkqht = DTO.CHITIETKQHT.FromJson(jsonString);

            siticoneDataGridView1.DataSource = _listchitietkqht;

            int count = _listchitietkqht.Count();
            for (i = 0; i < count; i++)
            {
                tong += _listchitietkqht[i].Ketqua;
                SumTinChi += _listchitietkqht[i].Sotinchi;

            }
            dtb = Math.Round((tong / count), 1);

            siticoneTextBox1.Text = dtb.ToString();
            siticoneTextBox2.Text = SumTinChi.ToString();
            tong = 0;
            dtb = 0;
            SumTinChi = 0;
        }

        private void lollipopButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < siticoneDataGridView1.Rows.Count; i++)
            {
                bool check = Convert.ToBoolean(siticoneDataGridView1.Rows[i].Cells["Check"].Value?.ToString());

                if (check)
                {
                    string id = siticoneDataGridView1.Rows[i].Cells["idketquahoctapDataGridViewTextBoxColumn"].Value?.ToString();

                   

                    DTO.CHITIETKQHT query = _listchitietkqht.FirstOrDefault(t => Convert.ToString(t.Idketquahoctap) == id);

                

                 //   Console.WriteLine("qua trinh ={0} ,id  ={1} ,thuc hanh ={3}, ket qua ={2}, thi ={4} \n", query.Quatrinh, query.Idketquahoctap, query.Ketqua, query.Thuchanh, query.Thi);



                    Client.Client.Instance.Put("api/ketquahoctap/edit", query);
                    
                   
                }
                
            }

            LoadData();
        }

        int i,j,key;

        
    }
    
}
