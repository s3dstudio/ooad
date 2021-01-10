using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using ooad.DTO;

namespace ooad.UC
{
    public partial class TKB_DEV : DevExpress.XtraEditors.XtraUserControl
    {
        List<TKB> _listTKBData;
        public TKB_DEV()
        {
            InitializeComponent();
            siticoneDataGridView1.AutoGenerateColumns = false;
            foreach (DataGridViewColumn col in siticoneDataGridView1.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            while(siticoneDataGridView1.Rows.Count<10)
            {
                //int tiet = 1;
                
                siticoneDataGridView1.Rows.Add();
              // siticoneDataGridView1[1, tiet].Value = "Tiết " + tiet;

               // tiet++;
            }

            var jsonString = Client.Client.Instance.Get("api/TKB/get/1");
            _listTKBData = TKB.FromJson(jsonString);

            foreach(var item in _listTKBData)
            {
                for (int tiet = (int)item.Tietbatdau ; tiet <= item.Tietketthuc; tiet++)
                {
                    string value = item.Idnhomlop + Environment.NewLine + item.Tennhomlop + Environment.NewLine + item.Thoigianmo.ToString();

                    siticoneDataGridView1[(int)item.Thu, tiet].Value = value;
                    siticoneDataGridView1.Columns[(int)item.Thu].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                   // siticoneDataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    //if (IsTheSameCellValue((int)item.Thu, tiet + 1))
                    //{
                    //    this.BackColor = Color.Red;
                    //}
                }
            }

           
            
        }
        public bool IsTheSameCellValue(in int column,in int row)
        {
            DataGridViewCell cell1 = siticoneDataGridView1[column, row];
            DataGridViewCell cell2 = siticoneDataGridView1[column, row - 1];
            if (cell1.Value == null || cell2.Value == null)
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }


        private void siticoneDataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if (e.RowIndex < 1 || e.ColumnIndex < 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
            else
            {
                e.AdvancedBorderStyle.Top = siticoneDataGridView1.AdvancedCellBorderStyle.Top;
            }
        }

        private void siticoneDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.Value = "";
                e.FormattingApplied = true;
            }
        }
    }
}
