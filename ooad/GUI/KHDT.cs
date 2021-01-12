using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ooad.GUI
{
    public partial class KHDT : MaterialForm
    {
        public KHDT()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);
            dataGridView1.AutoGenerateColumns = false;
            //foreach (DataGridViewColumn col in dataGridView1.Columns)
            //{
            //    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //    col.HeaderCell.Style.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            //}
            //while (dataGridView1.Rows.Count < 9)
            //{
            //    dataGridView1.Rows.Add();
            //}
            //dataGridView1[1, 1].Value = "1";
            //dataGridView1[1, 2].Value = "1";
            //IsTheSameCellValue(1, 2);
        }
        public bool IsTheSameCellValue(in int column, in int row)
        {
            DataGridViewCell cell1 = dataGridView1[column, row];
            DataGridViewCell cell2 = dataGridView1[column, row - 1];
            if (cell1.Value == null || cell2.Value == null)
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            //if (e.RowIndex < 1 || e.ColumnIndex < 0)
            //    return;
            //if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            //{
            //    e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            //}
            //else
            //{
            //    e.AdvancedBorderStyle.Top = dataGridView1.AdvancedCellBorderStyle.Top;
            //}
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (e.RowIndex == 0)
            //    return;
            //if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            //{
            //    e.Value = "";
            //    e.FormattingApplied = true;
            //}
        }

        private void KHDT_Load(object sender, EventArgs e)
        {

        }

        public void LoadData(string id)
        {
            var jsonString = Client.Client.Instance.Get("api/chitietkhdt/getct/" + id);
            List<DTO.CHITIETKEHOACH> khdt = DTO.CHITIETKEHOACH.FromJson(jsonString);

            var bindingList = new BindingList<DTO.CHITIETKEHOACH>(khdt);
            var source = new BindingSource(bindingList, null);

            if (khdt.Count > 0)
            {
                label1.Text += "\t" + khdt[0].Idkhdt.ToString();
                label2.Text += "\t" + khdt[0].Idhdt.ToString();
                label3.Text += "\t" + khdt[0].Tenkhdt;
            }

            dataGridView1.DataSource = source;
        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
