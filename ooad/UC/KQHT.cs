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
        public KQHT()
        {
            InitializeComponent();

            var jsonString = Client.Client.Instance.Get("api/ketquahoctap/getbyusername/" + Client.User.Instance.userName);
            List<DTO.CHITIETKQHT> listChitiet = DTO.CHITIETKQHT.FromJson(jsonString);

            siticoneDataGridView1.DataSource = listChitiet;
        
        }
    }
}
