using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace FireTeam
{
    public partial class CrearCuenta : Form
    {
        AccesoDatos datos = new AccesoDatos("server = DESKTOP-O2KDBBS ; database=FireTeam ; integrated security = true");

        public CrearCuenta()
        {
            InitializeComponent();
        }

        private void btinicio_Click(object sender, EventArgs e)
        {
            Usuarios a = new Usuarios();
            a.Usuario = txtUser.Text;
            a.Nombre = txtNombre.Text;
            a.Apellido = txtApellido.Text;
            a.Calle = txtCalle.Text;
            a.Numero = Convert.ToInt32(txtNumero.Text);
            a.Fec_Nac = DtpickerFecha.Value;
            a.TipoDoc = Convert.ToInt32(cboTipoDoc.SelectedValue);
            a.Documento = txtDoc.Text;
            a.Telefono = txtTelefono.Text;
            if (ckbMasculino.Checked)
                a.Sexo = true;
            else
                a.Sexo = false;

            string consultaSql = "INSERT INTO Usuarios Values (' " +
                a.Usuario + "','" +
                a.Nombre + "',' " +
                a.Apellido + "','" +
                a.Calle + "','" +
                a.Numero + ",'" +
                a.Fec_Nac + "','" +
                a.TipoDoc + "',' " +
                a.Documento + "',' " +
                a.Telefono + "','" +
                a.Sexo + "', 1)";
            datos.Actualizar(consultaSql);
            Visible = false;
            InicioSesion1 i = new InicioSesion1();
            i.Show();
        }

        private void cargarCombo(ComboBox combo, string nombreTabla)
        {
            DataTable dt = new DataTable();
            dt = datos.ConsultarTabla(nombreTabla);
            combo.DataSource = dt;
            combo.ValueMember = dt.Columns[0].ColumnName;
            combo.DisplayMember = dt.Columns[1].ColumnName;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrearCuenta_Load(object sender, EventArgs e)
        {
            cargarCombo(cboTipoDoc, "Tipo_documentos");
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
            //WindowState = FormWindowState.Minimized;
        }

        private void Maxim_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maxim.Visible = false;
            restore.Visible = true;
        }
    }
}
