using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Northwind
{
    public partial class Form2 : Form
    {
        int opci;
        public Form2()
        {
            InitializeComponent();
        }

        private void rbnom_CheckedChanged(object sender, EventArgs e)
        {
            opci = 0;
        }

        private void rbpais_CheckedChanged(object sender, EventArgs e)
        {
            opci = 1;
        }

        private void rbciu_CheckedChanged(object sender, EventArgs e)
        {
            opci = 2;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Sp_RptClientesVariosTableAdapter.Fill(this.NorthwindDataSet.Sp_RptClientesVarios, txtcad.Text, Convert.ToByte(opci));
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
