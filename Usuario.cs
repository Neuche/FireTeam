using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireTeam
{
    class Usuarios
    {
        private string usuario;
        private string nombre;
        private string apellido;
        private string calle;
        private int numero;
        private DateTime fec_nac;
        private int tipoDoc;
        private string documento;
        private string telefono;
        private int valoracion;
        private bool sexo;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public DateTime Fec_Nac
        {
            get { return fec_nac; }
            set { fec_nac = value; }
        }
        public int TipoDoc
        {
            get { return tipoDoc; }
            set { tipoDoc = value; }
        }
        public string Documento
        {
            get { return documento; }
            set { documento = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public int Valoracion
        {
            get { return valoracion; }
            set { valoracion = value; }
        }

        public bool Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public Usuarios()
        {
            usuario = "";
            nombre = "";
            apellido = "";
            calle = "";
            numero = 0;
            fec_nac = DateTime.Today;
            tipoDoc = 0;
            documento = "";
            telefono = "";
            valoracion = 0;
            sexo = false;
        }
        public Usuarios(string usuario, string nombre, string apellido, string calle,int numero,int tipoDoc, DateTime fec_nac, string documento,string telefono, int valoracion, bool sexo)
        {
            this.usuario = usuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.calle = calle;
            this.numero = numero;
            this.tipoDoc = tipoDoc;
            this.fec_nac = fec_nac;
            this.documento = documento;
            this.telefono = telefono;
            this.valoracion = valoracion;
            this.sexo = sexo;
        }
    }
}
