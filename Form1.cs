using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Northwind
{
    public partial class Form1 : Form
    {
        void cargartabla()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_listaproductos", varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            da.Dispose();
        }
        void rellenacombo()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listacategorias", varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbcategoria.DataSource = dt;
            cmbcategoria.DisplayMember = "categoryname";
            cmbcategoria.ValueMember = "categoryid";
            da.Dispose();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rellenacombo();
            cargartabla();
        }
    }
}
