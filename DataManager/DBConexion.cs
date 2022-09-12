using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace DataManager
{
    public class DBConexion
    {   
        protected MySqlConnection _CONEXION = new MySqlConnection();
        String CadenaConexion;

        protected Boolean Conectar(String _server, String _Port, String _Database, String _Uid, String _Pwd)
        {
            CadenaConexion = "Server="+_server+";Port="+_Port+";Database="+_Database+";Uid="+_Uid+";Pwd="+_Pwd+";";
            Boolean Conectado = false;
            try
            {
                _CONEXION.ConnectionString = CadenaConexion;
                _CONEXION.Open();
                Conectado = true;
            }
            catch (Exception)
            {
                Conectado = false;
            }
            return Conectado;
        }
        protected void Desconectar()
        {
            try
            {
                if(_CONEXION.State==System.Data.ConnectionState.Open)
                {
                    _CONEXION.Close();
                }
            }
            catch (Exception)
            {

            }
        }

    }
}
