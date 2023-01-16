using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Negocio;
using System.Windows.Forms;

namespace C_Presentacion.FormulariosProyecto.Cliente
{
    public partial class ConsultarCliente : Form
    {
        //Creamos un objeto y un atributo de la clase Cliente_class (Capa lógica de negocios)
        Cliente_class cl = new Cliente_class();
        private Cliente_class cliente;

        //Creamos los getter y setter del atributo contacto creado, esto con la finalidad de almacenar los datos del DataGridView 
        //y poder pasarlos hacia el formulario anterior (EditarCliente)
        public Cliente_class ClienteSel
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public ConsultarCliente()
        {
            InitializeComponent();

        }



        //Método necesario para enviar el nombre de la table hacia la capa lógica de negocios
        //(posteriormente se enviará hacia la capa lógica de negocios y base de datos), esto con la finalidad de traer la data almacenada hacia el datagridview.
        private void cargar_Datos()
        {
            DTRegO.DataSource = cl.CargarDatos("Cliente");
        }

        //En el botón de consultar se receptarán los datos ingresados en los filtros, esto para su posterior envío hacia las demás capas.
        //(Se enviará el nombre de la tabla hacia la capa lógica de negocios,
        //Posteriormente, se enviará dicha sentencia hacia la capa de acceso de datos, dentro de la cual se realizará la transacción hacia la base de datos)
        private void BtnConsul_Click(object sender, EventArgs e)
        {
            //Se agrega al final el signo de porcentaje para cumplir la condición de la sentencia "like", ya que, mientras el apellido es obligario, el nombre será opcional.
            DTRegO.DataSource = cl.consultarApellidoyNombre(txtApellido.Text.Trim(), txtNombre.Text.Trim() + "%");

        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            //Ál clickear en el botón, se efectuará el método para cargar los datos al datagridview
            cargar_Datos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //Cerrará la ventana y regresará al usuario hacia la interfaz anterior
            this.Close();
        }

        //Evento Load, necesario para cargar la data y adicionalmente darles un tamaño a las celdas
        private void ConsultarCliente_Load(object sender, EventArgs e)
        {
            cargar_Datos();

            DTRegO.Columns[0].Width = 35;
            DTRegO.Columns[1].Width = 100;
            DTRegO.Columns[2].Width = 100;
            DTRegO.Columns[3].Width = 80;
            DTRegO.Columns[4].Width = 80;
            DTRegO.Columns[5].Width = 200;
            DTRegO.Columns[6].Width = 300;
        }

        //Evento necesario para seleccionar un determinado cliente
        //El usuario dará doble click sobre un cliente y dicha acción llevará la data hacia la interfaz anterior (editar datos).
        private void DTRegO_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int filasel = -1;
            ClienteSel = new Cliente_class();
            //Se iguala "filasel" con la fila del elemento del datagridview para seleccionar el índice exacto de la celda
            //ya que, las filas se comienzan a contar desde 0, por lo cual, si se igualara a 0 se contará desde la primera fila.
            filasel = DTRegO.CurrentRow.Index;
            ClienteSel.Codigos = Convert.ToInt32(DTRegO.Rows[filasel].Cells[0].Value);
            ClienteSel.Apellidos = Convert.ToString(DTRegO.Rows[filasel].Cells[1].Value);
            ClienteSel.Nombres = Convert.ToString(DTRegO.Rows[filasel].Cells[2].Value);
            ClienteSel.Cedula = Convert.ToString(DTRegO.Rows[filasel].Cells[3].Value);
            ClienteSel.Numero_Telefono = Convert.ToInt32(DTRegO.Rows[filasel].Cells[4].Value);
            ClienteSel.Correo_Electronico = Convert.ToString(DTRegO.Rows[filasel].Cells[5].Value);
            ClienteSel.Direccion = Convert.ToString(DTRegO.Rows[filasel].Cells[6].Value);
            this.Hide();
        }
    }
}
