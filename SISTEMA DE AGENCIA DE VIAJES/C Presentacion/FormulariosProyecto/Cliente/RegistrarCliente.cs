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
using System.Text.RegularExpressions;

namespace C_Presentacion.FormulariosProyecto.Cliente
{
    public partial class RegistrarCliente : Form
    {
        //Se crea un objeto de la clase Cliente_class (Capa lógica de negocios)
        Cliente_class c = new Cliente_class();
        Cliente_class ClienteSel = new Cliente_class();
        List<Object> cliente_list;
        List<Object> lst_cliente;
        List<Object> cliente;
        Validaciones v = new Validaciones();
        public RegistrarCliente()
        {
            InitializeComponent();
            txtCodigo.Text = c.Generar_codigo("Cliente");
            cargar_Datos();
            cliente_list = c.busquedaCliente();
        }

        //Método para cargar los datos hacia el datagridview
        private void cargar_Datos()
        {
            dgvCliente.DataSource = c.CargarDatos("Cliente");

            dgvCliente.Columns[0].Width = 100;
            dgvCliente.Columns[1].Width = 200;
            dgvCliente.Columns[2].Width = 200;
            dgvCliente.Columns[3].Width = 200;
            dgvCliente.Columns[4].Width = 200;
            dgvCliente.Columns[5].Width = 300;
            dgvCliente.Columns[6].Width = 400;
        }

        //sentencia para denotar sentencias que generen error  
        ErrorProvider error = new ErrorProvider();

        //Método que devolverá un mensaje de error al ingresar cadenas erróneas
        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Método para validar el correo
        public static bool validarCorreo(string correo)
        {
            return correo != null && Regex.IsMatch(correo,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        //Método para limpiar las cajas de texto
        private void limpiar()
        {
            txtCodigo.Text = c.Generar_codigo("Cliente");
            txtApellido.Clear();
            txtNombre.Clear();
            txtCedula.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();

        }

        //Evento para guardar y validar los datos ingresados en los textbox
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Se llamará a los métodos de validación creados en la capa lógica de negocios y se les pasará los respectivos parámetros de validación
            //hacia cada caja de texto. Posteriormente, se establecerá que marquen dicho mensaje de error en caso de incumplimiento.

            //Validación necesaria para el ingreso de datos (notNull) y de letras.
            if(!v.IsOnlyLettersAndNotEmpty(txtApellido.Text, ShowErrorMessage) || !v.IsOnlyLettersAndNotEmpty(txtNombre.Text, ShowErrorMessage))
            {
                return;
            }
            //Validación necesaria para el ingreso de datos (notNull) y de numeros.
            if (!v.IsOnlyNumbersAndNotEmpty(txtCedula.Text, ShowErrorMessage) || !v.IsOnlyNumbersAndNotEmpty(txtTelefono.Text, ShowErrorMessage))
            {
                return;
            }
            //Validación necesaria para el ingreso de datos (notNull)
            if (!v.NotEmpty(txtCorreo.Text, ShowErrorMessage) || !v.NotEmpty(txtDireccion.Text, ShowErrorMessage))
            {
                return;
            }

            //Se creará una variable string que se igualará hacia una lista de clientes, la cual obtendrá los valores de cada
            //textbox y los pasará hacia la capa lógica de negocios mediante el método "registrar"
            String msj = "";
            try
            {
                c.Codigos = Convert.ToInt32(txtCodigo.Text.Trim());
                c.Apellidos = txtApellido.Text.Trim();
                c.Nombres = txtNombre.Text.Trim();
                c.Cedula = txtCedula.Text.Trim();
                c.Numero_Telefono = Convert.ToInt32(txtTelefono.Text.Trim());
                c.Correo_Electronico = txtCorreo.Text.Trim();
                c.Direccion = txtDireccion.Text.Trim();
                msj = c.registrar();
                MessageBox.Show(msj);
                limpiar();
            }
            //Se denotan posibles excepiones y se envía mensaje
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Se actualiza el datagridview tras presionar el boton de ingresar
            cargar_Datos();

        }
        //Se establece que al presionar el botón de cancelar, se cierre el formulario actual.
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Evento necesario para validar un formato adecuado de correo electrónico
        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!RegistrarCliente.validarCorreo(txtCorreo.Text))
            {
                error.SetError(txtCorreo, "Error, formato de correo no válido");
            }
            else
            {
                error.Clear();
            }
        }

        //Evento necesario para almacenar modificaciones en los textbox y enviarlas hacia una lista de clientes a la capa lógica de negocios.
        //Posteriormente, en la capa lógica de negocios dicha lista será enviada hacia la capa de acceso de datos para finalmente enviar 
        //la sentencia de consulta hacia la base de datos.
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Se realizan nuevamente las respectivas validaciones
            if (!v.IsOnlyLettersAndNotEmpty(txtApellido.Text, ShowErrorMessage) || !v.IsOnlyLettersAndNotEmpty(txtNombre.Text, ShowErrorMessage))
            {
                return;
            }
            if (!v.IsOnlyLettersAndNotEmpty(txtCedula.Text, ShowErrorMessage) || !v.IsOnlyNumbersAndNotEmpty(txtTelefono.Text, ShowErrorMessage))
            {
                return;
            }

            if (!v.NotEmpty(txtCorreo.Text, ShowErrorMessage) || !v.NotEmpty(txtDireccion.Text, ShowErrorMessage))
            {
                return;
            }

            String msj = "";
            try
            {
                //El valor de las cajas de texto se almacenará en la lista de clientes, esto de manera individual en cada atributo(mediante el setter)
                //y luego se enviarán dichos datos hacia la capa lógica de negocios mediante el método "Modificar"-
                c.Codigos = Convert.ToInt32(txtCodigo.Text.Trim());
                c.Apellidos = txtApellido.Text.Trim();
                c.Nombres = txtNombre.Text.Trim();
                c.Cedula = txtCedula.Text.Trim();
                c.Numero_Telefono = Convert.ToInt32(txtTelefono.Text.Trim());
                c.Correo_Electronico = txtCorreo.Text.Trim();
                c.Direccion = txtDireccion.Text.Trim();
                msj = c.Modificar(c.Codigos, c.Apellidos, c.Nombres, c.Cedula, c.Numero_Telefono, c.Correo_Electronico, c.Direccion);
                MessageBox.Show(msj);
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cargar_Datos();
        }

        //Evento del datagridview que permitirá llenar las cajas de texto con los datos seleccionados en las celdas. Dicha acción se denotará al dar doble click
        private void dgvCliente_DoubleClick(object sender, EventArgs e)
        {
            int filasel = -1;
            ClienteSel = new Cliente_class();
            //Se iguala "filasel" con la fila del elemento del datagridview para seleccionar el índice exacto de la celda
            //ya que, las filas se comienzan a contar desde 0, por lo cual, si se igualara a 0 se contará desde la primera fila.
            filasel = dgvCliente.CurrentRow.Index;
            ClienteSel.Codigos = Convert.ToInt32(dgvCliente.Rows[filasel].Cells[0].Value);
            ClienteSel.Apellidos = Convert.ToString(dgvCliente.Rows[filasel].Cells[1].Value);
            ClienteSel.Nombres = Convert.ToString(dgvCliente.Rows[filasel].Cells[2].Value);
            ClienteSel.Cedula = Convert.ToString(dgvCliente.Rows[filasel].Cells[3].Value);
            ClienteSel.Numero_Telefono = Convert.ToInt32(dgvCliente.Rows[filasel].Cells[4].Value);
            ClienteSel.Correo_Electronico = Convert.ToString(dgvCliente.Rows[filasel].Cells[5].Value);
            ClienteSel.Direccion = Convert.ToString(dgvCliente.Rows[filasel].Cells[6].Value);
            //
            if (ClienteSel != null)
            {
                //Llenamos los txt con los datos del cliente seleccionado
                txtCodigo.Text = ClienteSel.Codigos.ToString();
                txtApellido.Text = ClienteSel.Apellidos.ToString();
                txtNombre.Text = ClienteSel.Nombres.ToString();
                txtCedula.Text = ClienteSel.Cedula.ToString();
                txtTelefono.Text = ClienteSel.Numero_Telefono.ToString();
                txtCorreo.Text = ClienteSel.Correo_Electronico.ToString();
                txtDireccion.Text = ClienteSel.Direccion.ToString();
            }
        }

        //Evento necesario para establecer la consulta
        private void BtnConsul_Click(object sender, EventArgs e)
        {
            //Se establece que mientras el código no sea vacio se cumpla la condición
            if (!txtCodigoBusqueda.Text.Equals(""))
            {
                //se creará una variable de tipo string llamada codigo y se le pasará el valor del codigo escrito por el usuario
                //posterioirmante, se llamará al método de "Buscar_cliente" y se le pasará dicho código como parámetro
                string codigo = txtCodigoBusqueda.Text.Trim();
                Buscar_Cliente(codigo);
                cargar_Datos();
            }
            else
            {
                //Se devuleve mensaje en caso de que no se haya ingresado un código
                MessageBox.Show("Error, no se ha ingresado un código");
            }
        }

        //Método necesario para buscar al cliente por el parámetro de código
        public void Buscar_Cliente(string codigo)
        {
            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            //Se establece que la variable local abstraerá los datos de la lista de clientes
            foreach (var cliente in cliente_list)
            {
                //Se obtiene el valor de cliente
                System.Type type = cliente.GetType();

                //Se obtiene el valor del código y se define una sentencia en la que se igualará con el parámetro de código
                //(parámetro que será llenado por el usuario en el evento anterior)
                string Codigo = (string)type.GetProperty("codigo").GetValue(cliente);
                if (codigo.Equals(Codigo))
                {
                    //Se guarda cada valor de la lista de objetos en variables locales
                    String apellidos = (String)type.GetProperty("apellido").GetValue(cliente);
                    String nombres = (String)type.GetProperty("nombre").GetValue(cliente);
                    String cedula = (String)type.GetProperty("cedula").GetValue(cliente);
                    string numero_telefono = (string)type.GetProperty("numero_telefono").GetValue(cliente);
                    String correo_electronico = (String)type.GetProperty("correo_electronico").GetValue(cliente);
                    String direccion = (String)type.GetProperty("direccion").GetValue(cliente);

                    //Se llenan los textbox con los valores almacenados en cada variable
                    txtCodigo.Text = Codigo.ToString();
                    txtApellido.Text = apellidos;
                    txtNombre.Text = nombres;
                    txtCedula.Text = cedula;
                    txtTelefono.Text = numero_telefono.ToString();
                    txtCorreo.Text = correo_electronico;
                    txtDireccion.Text = direccion;
                }
                //else
                  //  MessageBox.Show("Cliente no encontrado");
                  
            }

        }
        //Evento del datagridview que permite ver el control del mismo cuando el puntero se mueve atravez de las celdas.
        private void dgvCliente_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Se establece que si el puntero se encuentra en una determinada celda, entonces se cambie el color de fondo y del control en sí.
            if(e.RowIndex > -1)
            {
                dgvCliente.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
                dgvCliente.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
        }
        //Evento del datagridview que permite ver el control del mismo cuando el puntero salga de una respectiva celda.
        private void dgvCliente_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            //Se establece que si el puntero sale de una determinada celda, entonces se cambie el color de fondo y del control en sí.
            if (e.RowIndex > -1)
            {
                dgvCliente.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                dgvCliente.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        //Evento que se produce cuando el puntero del mouse entra en una determinada celda
        private void dgvCliente_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Se define una variable de ToolTip
            ToolTip toolTip = new ToolTip();
            //Se establece que si el puntero está en una determinada celda, entonces se le presente al usuario un mensaje 
            //que le indique que debe dar doble click para pasar los datos del datagridview hacia los textbox
            if (e.RowIndex > -1)
            {
                toolTip.SetToolTip(this.dgvCliente, "Presione doble click para llenar el formulario de edición");
                //Se establece un tiempo de delay tras aparecer el mensaje, esto con la finalidad de evitar multiples mensajes en la pantalla
                toolTip.AutoPopDelay = 1000;
                //toolTip.ReshowDelay = 500;
            }
        }
    }
}