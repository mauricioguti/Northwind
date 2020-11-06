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
    public partial class Padre : Form
    {
        public Padre()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f1 = new Form2(); 
            f1.MdiParent = this;
            f1.Show();
        }
    }
}
