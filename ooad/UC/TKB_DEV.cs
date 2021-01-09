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

namespace ooad.UC
{
    public partial class TKB_DEV : DevExpress.XtraEditors.XtraUserControl
    {
        public TKB_DEV()
        {
            InitializeComponent();
            siticoneDataGridView1.AutoGenerateColumns = false;
            foreach (DataGridViewColumn col in siticoneDataGridView1.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            while(siticoneDataGridView1.Rows.Count<9)
            {
                siticoneDataGridView1.Rows.Add();
            }
            siticoneDataGridView1[1, 1].Value = "1";
            siticoneDataGridView1[1, 2].Value = "1";
            siticoneDataGridView1[1, 3].Value = "1";
            siticoneDataGridView1[1, 4].Value = "2";
            IsTheSameCellValue(1, 2);
            if(IsTheSameCellValue(1,2))
            {
                this.BackColor = Color.Red;
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
