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
        private long SumTinCchi =0;
        List<DTO.DKHP> dkhpdata;
        public HP()
        {
            InitializeComponent();
            uC_DKHP1.Hide();
            uC_MNL1.Hide();

            LoadData();



        }
        public void LoadData()
        {
            var jsonString = Client.Client.Instance.Get("api/hocphan/dkhp/getdata/" + Client.User.Instance.iduser);
             dkhpdata = DTO.DKHP.FromJson(jsonString);

            siticoneDataGridView1.DataSource = dkhpdata;

            for(int i =0; i< dkhpdata.Count(); i++)
            {
                SumTinCchi += dkhpdata[i].Sotinchi;
            }
            siticoneTextBox2.Text = SumTinCchi.ToString();

            SumTinCchi = 0;

            if(kiemTraTinChi() < 14)
            {
                siticoneTextBox1.Visible = true;
            }
            else
            {
                siticoneTextBox1.Visible = false;
            }
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

        private void lollipopButton1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < siticoneDataGridView1.Rows.Count; i++)
            {
                bool check = Convert.ToBoolean(siticoneDataGridView1.Rows[i].Cells["Check"].Value?.ToString());

                if (check)
                {
                    string id = siticoneDataGridView1.Rows[i].Cells["idtkbnhomlopDataGridViewTextBoxColumn"].Value?.ToString();



                    DTO.DKHP query = dkhpdata.FirstOrDefault(t => Convert.ToString(t.Idtkbnhomlop) == id);


                    var jsonString1 = Client.Client.Instance.Get("api/tkbnhomlop/get");
                    List<DTO.TKBNHOMLOP>  Tkbnhomlop = DTO.TKBNHOMLOP.FromJson(jsonString1);

                    for(i =0; i<Tkbnhomlop.Count();i++)
                    {
                        if(Tkbnhomlop[i].Idtkbnhomlop== query.Idtkbnhomlop) {
                            key = i;
                            Tkbnhomlop[i].Thu = query.Thu;
                            Tkbnhomlop[i].Tietbatdau = query.Tietbatdau;
                            Tkbnhomlop[i].Tietketthuc = query.Tietketthuc;
                          
                        }
                    }

            // Console.WriteLine("id ={0} ,thu  ={1} ,tiet bat dau ={2}, tiet ket thuc ={3} \n", Tkbnhomlop[key].Idtkbnhomlop, Tkbnhomlop[key].Thu, Tkbnhomlop[key].Tietbatdau, Tkbnhomlop[key].Tietketthuc);

                    Client.Client.Instance.Put("api/tkbnhomlop/edit", Tkbnhomlop[key]);

                    



                    //idnhomlop = nl.idnhomlop,
                    //          tenhocphan = hp.tenhocphan,
                    //          khoaquanly = k.tenkhoa,
                    //          sotinchi = hp.sotinchi,
                    //          giangvien = gv.tengv,
                    //          thu = tkbnl.thu,
                    //          tietbatdau = tkbnl.tietbatdau,
                    //          tietketthuc = tkbnl.tietketthuc,
                    //          idtkbnhomlop = tkbnl.idtkbnhomlop


                }

            }

            LoadData();
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < siticoneDataGridView1.Rows.Count; i++)
            {
                bool check = Convert.ToBoolean(siticoneDataGridView1.Rows[i].Cells["Check"].Value?.ToString());

                if (check)
                {
                    string id = siticoneDataGridView1.Rows[i].Cells["idtkbnhomlopDataGridViewTextBoxColumn"].Value?.ToString();



                    DTO.DKHP query = dkhpdata.FirstOrDefault(t => Convert.ToString(t.Idtkbnhomlop) == id);

                    var jsonString2 = Client.Client.Instance.Get("api/dkhpdata/get");
                    List<DTO.DKHPData> dkhpdata1 = DTO.DKHPData.FromJson(jsonString2);

                    for (j = 0; j < dkhpdata1.Count(); j++)
                    {
                        if(dkhpdata1[j].Idtkbnhomlop==query.Idtkbnhomlop)
                        {
                            keydelete = j;
                        }    
                    }


                    Client.Client.Instance.Delete("api/dkhpdata/delete/",dkhpdata1[keydelete].Iddkhp.ToString());

                  //  Console.WriteLine("id = {0} ,idsv  = {1} ,idtkbnhomlop  ={2} \n", dkhpdata1[keydelete].Iddkhp, dkhpdata1[keydelete].Idsv, dkhpdata1[keydelete].Idtkbnhomlop);




                }

            }

            LoadData();
        }
        int i ,key,j,keydelete;

        private void siticoneTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lollipopButton1_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private long kiemTraTinChi()
        {
            
            var jsonString = Client.Client.Instance.Get("api/hocphan/dkhp/getdata/" + Client.User.Instance.iduser);
            dkhpdata = DTO.DKHP.FromJson(jsonString);

            for (int i = 0; i < dkhpdata.Count(); i++)
            {
                SumTinChi1 += dkhpdata[i].Sotinchi;
            }

            return SumTinChi1;
           
        }

        long SumTinChi1 =0;
    }
    }

