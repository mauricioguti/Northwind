using Microsoft.Reporting.WinForms;

namespace Northwind
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Sp_RptClientesVariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NorthwindDataSet = new Northwind.NorthwindDataSet();
            this.rbnom = new System.Windows.Forms.RadioButton();
            this.rbpais = new System.Windows.Forms.RadioButton();
            this.rbciu = new System.Windows.Forms.RadioButton();
            this.txtcad = new System.Windows.Forms.TextBox();
            this.cmdejecuta = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Sp_RptClientesVariosTableAdapter = new Northwind.NorthwindDataSetTableAdapters.Sp_RptClientesVariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_RptClientesVariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NorthwindDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Sp_RptClientesVariosBindingSource
            // 
            this.Sp_RptClientesVariosBindingSource.DataMember = "Sp_RptClientesVarios";
            this.Sp_RptClientesVariosBindingSource.DataSource = this.NorthwindDataSet;
            // 
            // NorthwindDataSet
            // 
            this.NorthwindDataSet.DataSetName = "NorthwindDataSet";
            this.NorthwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rbnom
            // 
            this.rbnom.AutoSize = true;
            this.rbnom.Location = new System.Drawing.Point(65, 69);
            this.rbnom.Name = "rbnom";
            this.rbnom.Size = new System.Drawing.Size(100, 17);
            this.rbnom.TabIndex = 0;
            this.rbnom.TabStop = true;
            this.rbnom.Text = "Nombre Cliente:";
            this.rbnom.UseVisualStyleBackColor = true;
            this.rbnom.CheckedChanged += new System.EventHandler(this.rbnom_CheckedChanged);
            // 
            // rbpais
            // 
            this.rbpais.AutoSize = true;
            this.rbpais.Location = new System.Drawing.Point(184, 69);
            this.rbpais.Name = "rbpais";
            this.rbpais.Size = new System.Drawing.Size(48, 17);
            this.rbpais.TabIndex = 1;
            this.rbpais.TabStop = true;
            this.rbpais.Text = "Pais:";
            this.rbpais.UseVisualStyleBackColor = true;
            this.rbpais.CheckedChanged += new System.EventHandler(this.rbpais_CheckedChanged);
            // 
            // rbciu
            // 
            this.rbciu.AutoSize = true;
            this.rbciu.Location = new System.Drawing.Point(291, 69);
            this.rbciu.Name = "rbciu";
            this.rbciu.Size = new System.Drawing.Size(58, 17);
            this.rbciu.TabIndex = 1;
            this.rbciu.TabStop = true;
            this.rbciu.Text = "Cuidad";
            this.rbciu.UseVisualStyleBackColor = true;
            this.rbciu.CheckedChanged += new System.EventHandler(this.rbciu_CheckedChanged);
            // 
            // txtcad
            // 
            this.txtcad.Location = new System.Drawing.Point(517, 69);
            this.txtcad.Name = "txtcad";
            this.txtcad.Size = new System.Drawing.Size(262, 20);
            this.txtcad.TabIndex = 2;
            // 
            // cmdejecuta
            // 
            this.cmdejecuta.Location = new System.Drawing.Point(436, 69);
            this.cmdejecuta.Name = "cmdejecuta";
            this.cmdejecuta.Size = new System.Drawing.Size(75, 23);
            this.cmdejecuta.TabIndex = 3;
            this.cmdejecuta.Text = "Mostrar";
            this.cmdejecuta.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Sp_RptClientesVariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Northwind.frm_RptClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 109);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 329);
            this.reportViewer1.TabIndex = 4;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Sp_RptClientesVariosTableAdapter
            // 
            this.Sp_RptClientesVariosTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.cmdejecuta);
            this.Controls.Add(this.txtcad);
            this.Controls.Add(this.rbciu);
            this.Controls.Add(this.rbpais);
            this.Controls.Add(this.rbnom);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sp_RptClientesVariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NorthwindDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.RadioButton rbnom;
        private System.Windows.Forms.RadioButton rbpais;
        private System.Windows.Forms.RadioButton rbciu;
        private System.Windows.Forms.TextBox txtcad;
        private System.Windows.Forms.Button cmdejecuta;
        private System.Windows.Forms.BindingSource Sp_RptClientesVariosBindingSource;
        private NorthwindDataSet NorthwindDataSet;
        private NorthwindDataSetTableAdapters.Sp_RptClientesVariosTableAdapter Sp_RptClientesVariosTableAdapter;
        public ReportViewer reportViewer1;
    }
}