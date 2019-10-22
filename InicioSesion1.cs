using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireTeam
{
    public partial class InicioSesion1 : Form
    {
        public InicioSesion1()
        {
            InitializeComponent();
        }
        
 

        private void button1_Click(object sender, EventArgs e)
        {
            //Form Chat = new Form();
            //Chat.Show();
            
            Visible = false;
            Form interfaz = new Form1();
            interfaz.Show();
        }
        
        private void lbCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form CrearCuenta = new CrearCuenta();
            CrearCuenta.Show();
            Visible = false;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void InicioSesion1_Load(object sender, EventArgs e)
        {
            btEntrar.Visible = false;
            txtPassword.Visible = false;
            txtUsuario.Visible = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restore_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            restore.Visible = false;
            Maxim.Visible = true;
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maxim_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maxim.Visible = false;
            restore.Visible = true;
        }

        private void lbOlvidoContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form CrearCuenta = new CrearCuenta();
            CrearCuenta.Show();
            Visible = false;
        }

        private void btnSignUpNow_Click(object sender, EventArgs e)
        {
            btEntrar.Visible = true;
            btnSignUpNow.Visible = false;
            button1.Visible = false;
            txtPassword.Visible = true;
            txtUsuario.Visible = true;

        }
    }
}
