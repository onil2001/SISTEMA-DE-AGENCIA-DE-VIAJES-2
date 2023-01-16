using C_Presentacion.DataSet;

namespace C_Presentacion.Reporte
{
    partial class ReporteCli
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
            this.odontologo1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tutoVaiLoginDataSet = new C_Presentacion.DataSet.TutoVaiLoginDataSet();
            this.sp_buscar_odontologoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spbuscarodontologoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odontologoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odontologoTableAdapter = new C_Presentacion.DataSet.TutoVaiLoginDataSetTableAdapters.odontologoTableAdapter();
            this.sp_buscar_odontologoTableAdapter = new C_Presentacion.DataSet.TutoVaiLoginDataSetTableAdapters.sp_buscar_odontologoTableAdapter();
            this.odontologo1TableAdapter = new C_Presentacion.DataSet.TutoVaiLoginDataSetTableAdapters.odontologo1TableAdapter();
            this.odontologo1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.odontologo1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutoVaiLoginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_buscar_odontologoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spbuscarodontologoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odontologoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odontologo1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // odontologo1BindingSource
            // 
            this.odontologo1BindingSource.DataMember = "odontologo1";
            this.odontologo1BindingSource.DataSource = this.tutoVaiLoginDataSet;
            // 
            // tutoVaiLoginDataSet
            // 
            this.tutoVaiLoginDataSet.DataSetName = "TutoVaiLoginDataSet";
            this.tutoVaiLoginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_buscar_odontologoBindingSource
            // 
            this.sp_buscar_odontologoBindingSource.DataMember = "sp_buscar_odontologo";
            this.sp_buscar_odontologoBindingSource.DataSource = this.tutoVaiLoginDataSet;
            // 
            // spbuscarodontologoBindingSource
            // 
            this.spbuscarodontologoBindingSource.DataMember = "sp_buscar_odontologo";
            this.spbuscarodontologoBindingSource.DataSource = this.tutoVaiLoginDataSet;
            // 
            // odontologoBindingSource
            // 
            this.odontologoBindingSource.DataMember = "odontologo";
            this.odontologoBindingSource.DataSource = this.tutoVaiLoginDataSet;
            // 
            // odontologoTableAdapter
            // 
            this.odontologoTableAdapter.ClearBeforeFill = true;
            // 
            // sp_buscar_odontologoTableAdapter
            // 
            this.sp_buscar_odontologoTableAdapter.ClearBeforeFill = true;
            // 
            // odontologo1TableAdapter
            // 
            this.odontologo1TableAdapter.ClearBeforeFill = true;
            // 
            // odontologo1BindingSource1
            // 
            this.odontologo1BindingSource1.DataMember = "odontologo1";
            this.odontologo1BindingSource1.DataSource = this.tutoVaiLoginDataSet;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.odontologo1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "C_Presentacion.Reporte.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 122);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1076, 447);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.odontologoBindingSource;
            this.comboBox1.DisplayMember = "codigo";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(114, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Código";
            // 
            // ReporteCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 593);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteCli";
            this.Text = "ReporteCli";
            this.Load += new System.EventHandler(this.ReporteCli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.odontologo1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutoVaiLoginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_buscar_odontologoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spbuscarodontologoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odontologoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odontologo1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TutoVaiLoginDataSet tutoVaiLoginDataSet;
        private System.Windows.Forms.BindingSource odontologoBindingSource;
        private DataSet.TutoVaiLoginDataSetTableAdapters.odontologoTableAdapter odontologoTableAdapter;
        private System.Windows.Forms.BindingSource spbuscarodontologoBindingSource;
        private DataSet.TutoVaiLoginDataSetTableAdapters.sp_buscar_odontologoTableAdapter sp_buscar_odontologoTableAdapter;
        private System.Windows.Forms.BindingSource sp_buscar_odontologoBindingSource;
        private System.Windows.Forms.BindingSource odontologo1BindingSource;
        private DataSet.TutoVaiLoginDataSetTableAdapters.odontologo1TableAdapter odontologo1TableAdapter;
        private System.Windows.Forms.BindingSource odontologo1BindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}