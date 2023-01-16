using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Negocio;

namespace C_Presentacion.FormulariosProyecto.Inventario
{
    public partial class RegistrarAerolineas : Form
    {
        // Se crea un nuevo objeto E_Aerolinea y uno de N_Aerolinea
        E_Aerolinea objent = new E_Aerolinea();

	// Creación de una nueva instancia de N_Aerolinea
        N_Aerolinea objneg = new N_Aerolinea();

	//Creación de una nueva instancia de Validaciones
        Validaciones Validacion = new Validaciones();
        public RegistrarAerolineas()
        {
            InitializeComponent();
        }
	    //Método para mostrar un mensaje de error
        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        // Método para registrar aerolíneas
        void RegistrarAreolinea(String accion)
        {
            // Comprobación de los campos de nombre y siglas que no están vacíos
            if  (!Validacion.NoVacio(txtNombreAerolinea.Text,"Nombre de Aerolínea", ShowErrorMessage) || !Validacion.SoloLetras(txtNombreAerolinea.Text, ShowErrorMessage) ||
                !Validacion.NoVacio(txtSiglasAerolinea.Text,"Sigla de aerolínea" ,ShowErrorMessage) || !Validacion.SoloLetras(txtSiglasAerolinea.Text, ShowErrorMessage))
                {
                return;
            }
            objent.codigoAerolinea = txtCodigoAerolinea.Text;
            objent.nombreAerolinea = txtNombreAerolinea.Text;
            objent.siglasAerolinea = txtSiglasAerolinea.Text;

            // Llamar al método N_Registrar_Aerolinea de la clase N_Aerolinea y asignar el resultado a la variable Registrar_Aerolinea
            objent.accion = accion;
            String Registrar_Aerolinea = objneg.N_Registrar_Aerolinea(objent);
            MessageBox.Show(Registrar_Aerolinea, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

	//Método para buscar aerolínea por el campo nombre.
        void BuscarAerolinea()
        {

           
                objent.nombreAerolinea = txtBuscarAeroli.Text;
                // Se crea un nuevo DataTable y luego lo llena con los datos de las aerolineas
                DataTable dt = new DataTable();
                //txtBuscarAeroli
                dt = objneg.N_Buscar_Aerolineas(objent);
                dgvAerolineas.DataSource = dt;

        }

	//Método para agregar la aerolínea a la base de datos
        void agregarAerolinea()
        {

            // Se Muestra un mensaje de confirmación para registrar la aerolínea
            if (MessageBox.Show("¿Deseas registrar a " + txtNombreAerolinea.Text + "?", "Mensaje",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                // Se llama al método RegistrarAreolinea con el valor "1" cuando se haga clic en el botón "Agregar aerolínea"
                RegistrarAreolinea("1");
                limpiar();
                BuscarAerolinea();
            }


        }

	//Método para cargar los datos en la tabla
        void CargarAerolineas()
        {
            // Obtiene la fila seleccionada en el DataGridView
            int fila = dgvAerolineas.CurrentCell.RowIndex;
            // Asigna los valores de la fila seleccionada a los TextBox
            txtCodigoAerolinea.Text = dgvAerolineas[0, fila].Value.ToString();
            txtNombreAerolinea.Text = dgvAerolineas[1, fila].Value.ToString();
            txtSiglasAerolinea.Text = dgvAerolineas[2, fila].Value.ToString();

        }

	//Método para limpiar las cajas de texto al registrar las aerolíneas
        private void limpiar()
        {
            txtNombreAerolinea.Clear();
            txtSiglasAerolinea.Clear();
        }


        private void RegistrarAerolineas_Load(object sender, EventArgs e)
        {
            //Se Asigna como fuente de datos para el DataGridView el resultado del método N_Listar_Aerolinea de la clase N_Aerolinea
            dgvAerolineas.DataSource = objneg.N_Listar_Aerolinea();
        }

        // Se llama al método RegistrarAreolinea con el valor "1" cuando se haga clic en el botón "Agregar aerolínea"
        private void btnAgregarAerolinea_Click(object sender, EventArgs e)
        {
            agregarAerolinea();
        }



        private void btnMostrarAeolinea_Click(object sender, EventArgs e)
        {
	        //Se llama al método de buscar por un filtro opcional	
            BuscarAerolinea();
        }

        private void btnActualizarAerolinea_Click(object sender, EventArgs e)
        {
            // Llama al método ingresar con la acción "2" para actualizar los datos de la aerolinea
            RegistrarAreolinea("2");
            limpiar();
            BuscarAerolinea();
        }

        private void seleccionarFilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
	        // Llama al método CargarAerolineas al hacer clic en la opción actualizar del menú contextual
            //CargarAerolineas();
        }



        private void dgvAerolineas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Llama al método CargarAerolineas al hacer clic en la opción actualizar
            CargarAerolineas();
        }

        private void dgvAerolineas_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Se define una variable de ToolTip
            ToolTip toolTip = new ToolTip();
            //Se establece que si el puntero está en una determinada celda, entonces se le presente al usuario un mensaje 
            //que le indique que debe dar doble click para pasar los datos del datagridview hacia los textbox
            if (e.RowIndex > -1)
            {
                toolTip.SetToolTip(this.dgvAerolineas, "Presione doble click para llenar el formulario de edición");
                //Se establece un tiempo de delay tras aparecer el mensaje, esto con la finalidad de evitar multiples mensajes en la pantalla
                toolTip.AutoPopDelay = 1000;
                //toolTip.ReshowDelay = 500;
            }
        }

        private void dgvAerolineas_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            //Se establece que si el puntero sale de una determinada celda, entonces se cambie el color de fondo y del control en sí.
            if (e.RowIndex > -1)
            {
                dgvAerolineas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                dgvAerolineas.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void dgvAerolineas_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Se establece que si el puntero se encuentra en una determinada celda, entonces se cambie el color de fondo y del control en sí.
            if (e.RowIndex > -1)
            {
                dgvAerolineas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
                dgvAerolineas.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
        }
    }
    
}
