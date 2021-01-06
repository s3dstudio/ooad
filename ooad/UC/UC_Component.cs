﻿using System;
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
        public UC_Component()
        {
            InitializeComponent();
            
        }
        int i;
        LinkLabel[] linkLabel = new LinkLabel[5];
        ooad.GUI.Main m = new Main();
        
        private void UC_Component_Load(object sender, EventArgs e)
        {
            //dynamic funtion
            int count = 5;
            for (i = 0; i < count; i++)
            {
                linkLabel[i] = new LinkLabel();
                linkLabel[i].Text = $"LinkLabel {i.ToString()}";
                linkLabel[i].Name = "ll" + i.ToString();
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
