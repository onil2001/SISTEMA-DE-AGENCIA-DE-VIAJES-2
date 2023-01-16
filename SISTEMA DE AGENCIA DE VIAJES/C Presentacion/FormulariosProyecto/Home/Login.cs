using System;
using C_Presentacion.FormulariosProyecto.Inventario;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Capa_Negocio;
using Capa_Entidad;



namespace C_Presentacion.Home
{
    public partial class Login : Form
    {

        E_users objeuser = new E_users();
        N_users objnuser = new N_users();
        PantallaPrincipal frm1 = new PantallaPrincipal();
        public static string usuario_nombre;
        public static string area;
        public Login()
        {
            InitializeComponent();
        }


        void p_logueo()
        {
           // PantallaPrincipal login = new PantallaPrincipal();
            //login.ShowDialog();
            
            DataTable dt = new DataTable();
            objeuser.usuario = textBox1.Text;
            objeuser.clave = textBox2.Text;

            dt = objnuser.N_user(objeuser);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido " + dt.Rows[0][1].ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario_nombre = dt.Rows[0][1].ToString();
                area = dt.Rows[0][0].ToString();

                frm1.ShowDialog();

                Login login = new Login();
                login.ShowDialog();

                if (login.DialogResult == DialogResult.OK)
                    Application.Run(new PantallaPrincipal());

                textBox1.Clear();
                textBox2.Clear();


            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }







        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            p_logueo();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
