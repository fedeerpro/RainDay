using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Incidencia
    {
        String _IDIncidencia;
        String _Descripcion;
        String _Fecha_Apertura;
        String _Diagnostico;
        String _Tipo;
        String _Estado;
        String _Criticidad;
        String _IDEmpleado;
        String _IDTecnico;
        String _IDCliente;
        String _IDEquipo;
        String _Fecha_Cierre;
        String _Solucion;

        public string IDIncidencia
        {
            get
            {
                return _IDIncidencia;
            }

            set
            {
                _IDIncidencia = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }

            set
            {
                _Descripcion = value;
            }
        }

        public string Fecha_Apertura
        {
            get
            {
                return _Fecha_Apertura;
            }

            set
            {
                _Fecha_Apertura = value;
            }
        }

        public string Diagnostico
        {
            get
            {
                return _Diagnostico;
            }

            set
            {
                _Diagnostico = value;
            }
        }

        public string Tipo
        {
            get
            {
                return _Tipo;
            }

            set
            {
                _Tipo = value;
            }
        }

        public string Estado
        {
            get
            {
                return _Estado;
            }

            set
            {
                _Estado = value;
            }
        }

        public string Criticidad
        {
            get
            {
                return _Criticidad;
            }

            set
            {
                _Criticidad = value;
            }
        }

        public string IDEmpleado
        {
            get
            {
                return _IDEmpleado;
            }

            set
            {
                _IDEmpleado = value;
            }
        }

        public string IDTecnico
        {
            get
            {
                return _IDTecnico;
            }

            set
            {
                _IDTecnico = value;
            }
        }

        public string IDCliente
        {
            get
            {
                return _IDCliente;
            }

            set
            {
                _IDCliente = value;
            }
        }

        public string IDEquipo
        {
            get
            {
                return _IDEquipo;
            }

            set
            {
                _IDEquipo = value;
            }
        }

        public string Fecha_Cierre
        {
            get
            {
                return _Fecha_Cierre;
            }

            set
            {
                _Fecha_Cierre = value;
            }
        }

        public string Solucion
        {
            get
            {
                return _Solucion;
            }

            set
            {
                _Solucion = value;
            }
        }

        public Boolean Agregar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO Incidencias (Descripcion, Fecha_Apertura, Diagnostico, Tipo, Estado, Criticidad, IdEmpleado, IdTecnico, IdCliente, IdEquipo, Fecha_Cierre, Solucion) values(");
                Sentencia.Append("'" + this._Descripcion + "', ");
                Sentencia.Append("'" + this._Fecha_Apertura + "', ");
                Sentencia.Append("'" + this._Diagnostico + "', ");
                Sentencia.Append("'" + this._Tipo + "', ");
                Sentencia.Append("'" + this._Estado + "', ");
                Sentencia.Append("'" + this._Criticidad + "', ");
                Sentencia.Append("" + this._IDEmpleado + ", ");
                Sentencia.Append("" + this._IDTecnico + ", ");
                Sentencia.Append("" + this._IDCliente + ", ");
                Sentencia.Append("'" + this._IDEquipo + "', ");
                Sentencia.Append("" + this._Fecha_Cierre + ", ");
                Sentencia.Append("'" + this._Solucion + "');");

                if (operacion.Insertar(Sentencia.ToString()) > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }

        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("UPDATE Incidencias SET ");
                Sentencia.Append("Descripcion ='" + this._Descripcion + "', ");
                Sentencia.Append("Fecha_Apertura = '" + this._Fecha_Apertura + "', ");
                Sentencia.Append("Diagnostico = '" + this._Diagnostico + "', ");
                Sentencia.Append("Tipo = '" + this._Tipo + "', ");
                Sentencia.Append("Estado = '" + this._Estado + "', ");
                Sentencia.Append("Criticidad = '" + this._Criticidad + "', ");
                Sentencia.Append("IdEmpleado = " + this._IDEmpleado + ", ");
                Sentencia.Append("IdTecnico = " + this._IDTecnico + ", ");
                Sentencia.Append("IdCliente = " + this._IDCliente + ", ");
                Sentencia.Append("IdEquipo = '" + this._IDEquipo + "', ");
                Sentencia.Append("Fecha_Cierre = " + this._Fecha_Cierre + ", ");
                Sentencia.Append("Solucion = '" + this._Solucion + "' ");
                Sentencia.Append("WHERE IdIncidencia = " + this.IDIncidencia + ";");
                if (operacion.Insertar(Sentencia.ToString()) > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }

        public Boolean Eliminar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("DELETE FROM Incidencias ");
                Sentencia.Append("WHERE IdIncidencia = " + this.IDIncidencia + ";");
                if (operacion.Insertar(Sentencia.ToString()) > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }

        public DataTable BuscarEmpleado()
        {
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            DataTable TablaRes = new DataTable();
            try
            {

                Sentencia.Append("Select CONCAT(Nombres, ' ', Apellidos) Empleado from Empleados where IdEmpleado = "+this._IDEmpleado+"; ");

                TablaRes = operacion.Consultar(Sentencia.ToString());
                
            }
            catch (Exception)
            {
            }
            return TablaRes;
        }
        
        public DataTable BuscarCliente()
        {
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            DataTable TablaRes = new DataTable();
            try
            {

                Sentencia.Append("Select CONCAT(Nombres, ' ', Apellidos) Cliente from Clientes where IdCliente = " + this._IDCliente + "; ");

                TablaRes = operacion.Consultar(Sentencia.ToString());

            }
            catch (Exception)
            {
            }
            return TablaRes;
        }

        public DataTable BuscarTecnico()
        {
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            DataTable TablaRes = new DataTable();
            try
            {

                Sentencia.Append("Select CONCAT(Nombres, ' ', Apellidos) Tecnico from Tecnicos where IdTecnico = " + this._IDTecnico + "; ");

                TablaRes = operacion.Consultar(Sentencia.ToString());

            }
            catch (Exception)
            {
            }
            return TablaRes;
        }

        public DataTable BuscarEquipo()
        {
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            DataTable TablaRes = new DataTable();
            try
            {

                Sentencia.Append("Select Equipo from Equipos where IdEquipo = " + this._IDEquipo + "; ");

                TablaRes = operacion.Consultar(Sentencia.ToString());

            }
            catch (Exception)
            {
            }
            return TablaRes;
        }



    }
}
