using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Button btDefault = new Button();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            btDefault.Text = "Ekle";
            btDefault.Size = new Size(100, 45);
            btDefault.Location = new Point(500, 370);
            btDefault.Click += BtDefault_Click;
            Controls.Add(btDefault);
            cmbDefaultAraba.Visible = false;
            lbDefaultAraba.Visible = false;


        }
        int i = 0;
        private void BtDefault_Click(object sender, EventArgs e)
        {
            i += 1;
            if (i % 2 == 1)
            {
                cmbDefaultAraba.Visible = true;
                lbDefaultAraba.Visible = true;
                btDefault.Text = "Çıkar";
            }
            if (i % 2 == 0)
            {
                cmbDefaultAraba.Visible = false;
                lbDefaultAraba.Visible = false;
                btDefault.Text = "Ekle";

            }
        }

        private void ckbPerformans_Click(object sender, EventArgs e)
        {
            ckbCevre.Checked = false;
            ckbFiyat.Checked = false;
            ckbDefault.Checked = false;
            //if (ckbPerformans.Checked == false)
            //{
            //    cbDefault_Click(sender, e);
            //}


            this.tableLayoutPanel1.Controls.Add(this.lbMercedes, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbBMW, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbAudi, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbHonda, 0, 3);

            this.tableLayoutPanel1.Controls.Add(this.cmbMercedes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbBMW, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbAudi, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbHonda, 1, 3);


        }

        private void ckbCevre_Click(object sender, EventArgs e)
        {
            ckbPerformans.Checked = false;
            ckbFiyat.Checked = false;
            ckbDefault.Checked = false;


            this.tableLayoutPanel1.Controls.Add(this.lbMercedes, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbAudi, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbBMW, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbHonda, 0, 3);

            this.tableLayoutPanel1.Controls.Add(this.cmbMercedes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbAudi, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbBMW, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbHonda, 1, 3);
        }

        private void ckbFiyat_Click(object sender, EventArgs e)
        {

            ckbPerformans.Checked = false;
            ckbCevre.Checked = false;
            ckbDefault.Checked = false;
            this.tableLayoutPanel1.Controls.Add(this.lbHonda, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbAudi, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbBMW, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbMercedes, 0, 3);
         
            this.tableLayoutPanel1.Controls.Add(this.cmbHonda, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbAudi, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbBMW, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbMercedes, 1, 3);
          
        


        }

      
        private void cbDefault_Click(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.Controls.Add(this.lbMercedes, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbAudi, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbBMW, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbHonda, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbMercedes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbAudi, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbBMW, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbHonda, 1, 3);

            ckbPerformans.Checked = false;
            ckbCevre.Checked = false;
            ckbFiyat.Checked = false;
        }
    }
}
