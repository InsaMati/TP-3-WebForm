using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AccesoADatos
    {
        public SqlDataReader Leer { get; set; }
        public SqlConnection Conexion { get; set; }
        public SqlCommand Comando { get; set; }

        public AccesoADatos()
        {
            Conexion = new SqlConnection("data source=DESKTOP-OC9KSLQ\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi");
            Comando = new SqlCommand();
            Comando.Connection = Conexion;
        }

        public void EjecutarLector()
        {
            try
            {
                Conexion.Open();
                Leer = Comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void SetearQuery(string SqlConsulta)
        {
            Comando.CommandType = System.Data.CommandType.Text;
            Comando.CommandText = SqlConsulta;
        }

        public void SetearSp(string SqlConsulta)
        {
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.CommandText = SqlConsulta;
        }

        public void AgregarParametroPorString(string nombre,string valor)
        {
            Comando.Parameters.AddWithValue(nombre, valor);
        }

        public void CerrarConexionDB()
        {
            Conexion.Close();
        }
    }
}
