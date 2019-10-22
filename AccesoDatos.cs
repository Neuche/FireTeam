using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FireTeam
{
    class AccesoDatos
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;
        DataTable dt;
        string cadenaConexion;

        public SqlDataReader Lector
        {
            get { return lector; }
            set { lector = value; }
        }
        public SqlConnection Conexion
        {
            get { return conexion; }
            set { conexion = value; }
        }
        public string CadenaConexion
        {
            get { return cadenaConexion;}
            set { cadenaConexion = value; }
        }

        public AccesoDatos(string cadenaConexion)
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            lector = null;
            dt = new DataTable();
            this.cadenaConexion = cadenaConexion;
        }

        public void Conectar()
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        public void Desconectar()
        {
            conexion.Close();
            conexion.Dispose();
        }

        public DataTable ConsultarTabla (String tabla)
        {
            this.dt = new DataTable();
            this.Conectar();
            this.comando.CommandText = "SELECT * FROM " + tabla;
            this.dt.Load(comando.ExecuteReader());
            this.Desconectar();
            return this.dt;
        }

        public void LeerTabla (String tabla)
        {
            Conectar();
            comando.CommandText = "SELECT * FROM " + tabla;
            lector = comando.ExecuteReader();
        }

        public void Actualizar (string consultaSql)
        {
            Conectar();
            comando.CommandText = consultaSql;
            comando.ExecuteNonQuery() ;
            Desconectar();
        }
    }
}
