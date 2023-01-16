
using C_Presentacion.FormulariosProyecto.Cliente;
using C_Presentacion.FormulariosProyecto.Reservas;
using C_Presentacion.FormulariosProyecto.Inventario;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C_Presentacion;
// Esta es la clase principal para la pantalla principal de la aplicación.
// Contiene funciones para personalizar la apariencia de la pantalla, mostrar y ocultar menús y submenús, abrir y cerrar formularios hijos, y manejar eventos de mouse para cambiar la apariencia de los botones.
namespace C_Presentacion.Home
{
    public partial class PantallaPrincipal : Form
    {
        private IconButton currentbtn;
        private Panel LeftBorderBtn;
        private Form FormularioActivo = null;

        private struct RGBCOLORS
        {
            public static Color azulbajo = Color.FromArgb(24, 161, 251);
        }

        public PantallaPrincipal()
        {
            InitializeComponent();
            customdesign();
            // Creación de un panel para el borde izquierdo de los botones de navegación
            LeftBorderBtn = new Panel();
            panelOpciones.Controls.Add(LeftBorderBtn);
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            //admin
            // Al cargar la pantalla, se hacen visibles los botones para el usuario con permisos de administrador
            this.BtnNorm.Visible = true;
            this.BtnClientes.Visible = true;
            this.BtnInventario.Visible = true;
            this.BtnReservas.Visible = true;
            


        }

        // Método para personalizar el diseño de la pantalla
        private void customdesign()
        {
            this.OpcReservas.Visible = false;
            this.OpcClientes.Visible = false;
            this.OpcInventario.Visible = false;

        }

        // Se muestran los submenús al iniciar la aplicación
        private void hidesubmenu()
        {
            if (OpcReservas.Visible)
            {
                OpcReservas.Visible = false;
            }
            if (OpcClientes.Visible)
            {
                OpcClientes.Visible = false;
            }
            if (OpcInventario.Visible)
            {
                OpcInventario.Visible = false;
            }

        }

        // Método para ocultar los submenús
        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void ActivarBoton(object senderBtn, Color color)
        {

        }

        // Método para desactivar el botón seleccionado actualmente
        private void desactivarBoton()
        {
            if (currentbtn != null)
            {
                currentbtn.BackColor = Color.FromArgb(11, 53, 103);
                currentbtn.ForeColor = Color.White;
                currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                currentbtn.IconColor = Color.White;
                currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentbtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void abrirhijoform(Form FrmHijo)
        {
            //Si existe formulairo abierto lo cerramos
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            //almacenamos el form abierto agregamos estilos y mostramos
            FormularioActivo = FrmHijo;
            FrmHijo.TopLevel = false;
            FrmHijo.FormBorderStyle = FormBorderStyle.None;
            FrmHijo.Dock = DockStyle.Fill;
            PanelForms.Controls.Add(FrmHijo);
            PanelForms.Tag = FrmHijo;
            FrmHijo.BringToFront();
            FrmHijo.Show();
        }


        private void BtnSalir_MouseMove(object sender, MouseEventArgs e)
        {
            this.BtnSalir.IconColor = Color.RoyalBlue;
            this.BtnSalir.ForeColor = Color.RoyalBlue;
        }

        private void BtnSalir_MouseLeave(object sender, EventArgs e)
        {
            this.BtnSalir.IconColor = Color.White;
            this.BtnSalir.ForeColor = Color.White;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void BtnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMax.Visible = false;
            BtnNorm.Visible = true;
        }

        private void Btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnNorm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnMax.Visible = true;
            BtnNorm.Visible = false;
        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        //BtnNuevCli abrirhijoform(new RegistrarCliente());
        private void BtnNuevCli_Click_1(object sender, EventArgs e)
        {
            abrirhijoform(new RegistrarCliente());
        }



        private void BtnReservas_Click(object sender, EventArgs e)
        {
            showsubmenu(OpcReservas);
            //ActivarBoton(sender, RGBCOLORS.);
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            showsubmenu(OpcClientes);
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            showsubmenu(OpcInventario);
        }



        private void Factura_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnNuevoDesT_Click(object sender, EventArgs e)
        {
            abrirhijoform(new NuevoDestino());
        }

        private void BtnNuevRes_Click(object sender, EventArgs e)
        {
            abrirhijoform(new RegistrarReserva());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            abrirhijoform(new RegistrarAerolineas());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoCli_Click(object sender, EventArgs e)
        {
            abrirhijoform(new RegistrarCliente());
        }

        private void BtnEditCli_Click(object sender, EventArgs e)
        {
           
        }
    }
}
