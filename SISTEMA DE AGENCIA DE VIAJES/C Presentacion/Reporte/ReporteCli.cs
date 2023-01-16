using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Presentacion.Reporte
{
    public partial class ReporteCli : Form
    {
        public ReporteCli()
        {
            InitializeComponent();
        }
        public string apellido { get; set; }
        public string nombre { get; set; }

        private void ReporteCli_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tutoVaiLoginDataSet.sp_buscar_odontologo' Puede moverla o quitarla según sea necesario.
            this.sp_buscar_odontologoTableAdapter.Fill(this.tutoVaiLoginDataSet.sp_buscar_odontologo,apellido,nombre);
            // TODO: esta línea de código carga datos en la tabla 'tutoVaiLoginDataSet.odontologo' Puede moverla o quitarla según sea necesario.
            this.odontologoTableAdapter.Fill(this.tutoVaiLoginDataSet.odontologo);

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  ReporteCli repor = new ReporteCli();
            //repor.apellido = textBox1.Text;
            //repor.nombre = textBox2.Text;
            //this.sp_buscar_odontologoTableAdapter.Fill(this.tutoVaiLoginDataSet.sp_buscar_odontologo, textBox1.Text, textBox2.Text);

            // this.reportViewer1.RefreshReport();


            this.odontologo1TableAdapter.Fill(this.tutoVaiLoginDataSet.odontologo1, comboBox1.SelectedValue.ToString());

            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.odontologo1TableAdapter.Fill(this.tutoVaiLoginDataSet.odontologo1, comboBox1.SelectedValue.ToString());

            this.reportViewer1.RefreshReport();
        }
    }
}
