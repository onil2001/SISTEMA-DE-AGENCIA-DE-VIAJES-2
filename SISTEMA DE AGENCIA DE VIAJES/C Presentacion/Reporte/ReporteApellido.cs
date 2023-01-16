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
    public partial class ReporteApellido : Form
    {
        public ReporteApellido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReporteCli repor = new ReporteCli();
            repor.apellido = textBox1.Text;
            repor.nombre = textBox2.Text;
            repor.Show();
        }
    }
}
