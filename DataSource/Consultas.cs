using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataSource
{
    public static class Consultas
    {
        public static DataTable INICIO_SESION(String pUsuario, String pClave)
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT 
            a.IDUsuario, a.Usuario, a.Clave, a.IDEmpleado, 
            b.Nombres,b.Apellidos, 
            CONCAT(b.Nombres,' ',b.Apellidos) Empleado,
            b.Genero ,a.IDRol, c.Rol  
            FROM usuarios a, empleados b, roles c 
            WHERE a.IDEmpleado=b.IDEmpleado 
            AND c.IDRol=a.IDRol 
            AND a.Usuario='" + pUsuario + @"' 
            AND a.Clave=MD5(SHA1('" + pClave + "'));";

            //String Consulta = @"select IdUsuario, Usuario, clave from Usuarios where Usuario = '"+pUsuario+@"' 
            //    and clave = md5('"+pClave+"');";

            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable IniciarSesionCliente(String pUsuario, String pClave)
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT 
            a.IDUsuario, a.Usuario, a.Clave, a.IDEmpleado, 
            b.Nombres,b.Apellidos, 
            CONCAT(b.Nombres,' ',b.Apellidos) Cliente,
            b.Direccion ,a.IDRol, c.Rol  
            FROM Usuarios_Cliente a, Clientes b, roles c 
            WHERE a.IDEmpleado = b.IdCliente 
            AND c.IDRol=a.IDRol 
            AND a.Usuario='" + pUsuario + @"' 
            AND a.Clave=MD5(SHA1('" + pClave + "'));";


            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable IniciarSesionTecnico(String pUsuario, String pClave)
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT 
            a.IDUsuario, a.Usuario, a.Clave, a.IDEmpleado, 
            b.Nombres,b.Apellidos, 
            CONCAT(b.Nombres,' ',b.Apellidos) Cliente,
            b.DUI,b.NIT,b.Telefono, b.Direccion ,a.IDRol, c.Rol  
            FROM Usuarios_Tecnico a, Tecnicos b, roles c 
            WHERE a.IDEmpleado = b.IdTecnico 
            AND c.IDRol=a.IDRol 
            AND a.Usuario='" + pUsuario + @"' 
            AND a.Clave=MD5(SHA1('" + pClave + "'));";


            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable TODOS_LOS_USUARIOS()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT 
            a.IDUsuario, a.Usuario, a.IDEmpleado, a.IDRol,
            b.Nombres, b.Apellidos, b.Genero,
            c.Rol  
            FROM usuarios a, empleados b, roles c 
            WHERE a.IDEmpleado=b.IDEmpleado 
            AND a.IDRol=c.IDRol ORDER BY Apellidos;";
            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable TODOS_LOS_USUARIOS_CLIENTE()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT 
            a.IDUsuario, a.Usuario, a.IDEmpleado, a.IDRol,
            b.Nombres, b.Apellidos, b.Genero,
            c.Rol  
            FROM usuarios_Cliente a, Clientes b, roles c 
            WHERE a.IDEmpleado=b.IDCliente 
            AND a.IDRol=c.IDRol ORDER BY Apellidos;";
            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable TODOS_LOS_USUARIOS_TECNICO()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @" SELECT 
            a.IDUsuario, a.Usuario, a.IDEmpleado, a.IDRol,
            b.Nombres, b.Apellidos, b.Genero,
            c.Rol  
            FROM usuarios_Tecnico a, Tecnicos b, roles c 
            WHERE a.IDEmpleado=b.IDTecnico 
            AND a.IDRol=c.IDRol ORDER BY Apellidos;";
            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable TODOS_LOS_ROLES()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT IDRol, Rol FROM roles ORDER BY Rol;";
            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable PERMISOS(String pIDRol)
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"select a.IdOpcion, b.Opcion from Permisos a, Opciones b where
                                a.IdOpcion = b.IdOpcion and a.IdRol = " + pIDRol + ";";
            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable TODOS_LOS_EMPLEADOS()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT IDEmpleado, Nombres, Apellidos, Genero 
            FROM empleados order by Apellidos, Nombres;";
            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable TODOS_LOS_CLIENTES()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT IDCliente, Nombres, Apellidos, Direccion, Genero  
            FROM Clientes order by Apellidos, Nombres;";
            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable TODOS_LOS_TECNICOS()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT IDTecnico, Nombres, Apellidos, DUI, NIT, Telefono, Direccion, Genero  
            FROM Tecnicos order by Apellidos, Nombres;";
            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable TODOS_LOS_EQUIPOS()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT IDEquipo, Equipo, Detalles  
            FROM Equipos order by Equipo;";
            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable Logs1()
        {
            DataTable Resultado = new DataTable();
            String Consulta = "SELECT *FROM Logs_1 order by fecha;";
            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable Logs_por_usuario(String _user)
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT *FROM Logs_1 where user='"+_user+"';";
            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable TODAS_LAS_INCIDENCIAS()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"Select a.IdIncidencia, a.Descripcion, a.Fecha_Apertura, a.Diagnostico, a.Tipo, a.Estado, a.Criticidad, 
                                a.IdEmpleado, 
                                (select concat(Nombres,' ',Apellidos) from Empleados where IDEmpleado = a.IDEmpleado) as Empleados,
                                a.IdTecnico, 
                                (select concat(Nombres,' ',Apellidos) from Tecnicos where IDTecnico = a.IDTecnico) as Tecnicos
                                ,a.IdCliente,
                                (select concat(Nombres,' ',Apellidos) from Clientes where IDCliente = a.IDCliente) as Clientes
                                ,a.IdEquipo,
                                (select Equipo from Equipos where IDEquipo = a.IDEquipo)as Equipos
                                ,a.Fecha_Cierre, Solucion from Incidencias a;"; 

            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable TODAS_LAS_INCIDENCIAS_POR_CLIENTE(String id)
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"Select a.IdIncidencia, a.Descripcion, a.Fecha_Apertura, a.Diagnostico, a.Tipo, a.Estado, a.Criticidad, 
                                a.IdEmpleado, (select concat(Nombres,' ',Apellidos) from Empleados where IDEmpleado = a.IDEmpleado) as Empleados,
                                a.IdTecnico, 
                                (select concat(Nombres,' ',Apellidos) from Tecnicos where IDTecnico = a.IDTecnico) as Tecnicos
                                ,a.IdCliente,
                                (select concat(Nombres,' ',Apellidos) from Clientes where IDCliente = a.IDCliente) as Clientes
                                ,a.IdEquipo,
                                (select Equipo from Equipos where IDEquipo = a.IDEquipo)as Equipos
                                ,a.Fecha_Cierre, Solucion from Incidencias a where a.IDCliente = "+id+";";

            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }


        public static DataTable TODAS_LAS_INCIDENCIAS_POR_TECNICO(String id)
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"Select a.IdIncidencia, a.Descripcion, a.Fecha_Apertura, a.Diagnostico, a.Tipo, a.Estado, a.Criticidad, 
                                a.IdEmpleado, 
                                (select concat(Nombres,' ',Apellidos) from Empleados where IDEmpleado = a.IDEmpleado) as Empleados,
                                a.IdTecnico, 
                                (select concat(Nombres,' ',Apellidos) from Tecnicos where IDTecnico = a.IDTecnico) as Tecnicos
                                ,a.IdCliente,
                                (select concat(Nombres,' ',Apellidos) from Clientes where IDCliente = a.IDCliente) as Clientes
                                ,a.IdEquipo,
                                (select Equipo from Equipos where IDEquipo = a.IDEquipo)as Equipos
                                ,a.Fecha_Cierre, Solucion from Incidencias a where a.IDTecnico = " + id + ";";

            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable TODAS_LAS_INCIDENCIAS_POR_EMPLEADO(String id)
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"Select a.IdIncidencia, a.Descripcion, a.Fecha_Apertura, a.Diagnostico, a.Tipo, a.Estado, a.Criticidad, 
                                a.IdEmpleado, 
                                (select concat(Nombres,' ',Apellidos) from Empleados where IDEmpleado = a.IDEmpleado) as Empleados,
                                a.IdTecnico, 
                                (select concat(Nombres,' ',Apellidos) from Tecnicos where IDTecnico = a.IDTecnico) as Tecnicos
                                ,a.IdCliente,
                                (select concat(Nombres,' ',Apellidos) from Clientes where IDCliente = a.IDCliente) as Clientes
                                ,a.IdEquipo,
                                (select Equipo from Equipos where IDEquipo = a.IDEquipo)as Equipos
                                ,a.Fecha_Cierre, Solucion from Incidencias a where a.IDEmpleado = " + id + ";";

            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }


        public static DataTable PERMISOS_DE_UN_ROL(String pIDRol)
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT IDOPCION , OPCION,
                    IFNULL((SELECT IDPERMISO FROM PERMISOS Z WHERE Z.IDROL = " + pIDRol + @" AND Z.IDOPCION=A.IDOPCION),0) IDPERMISO,
                    (SELECT COUNT(IDPERMISO)FROM PERMISOS Z WHERE Z.IDROL = " + pIDRol + @" AND Z.IDOPCION = A.IDOPCION) ASIGNADO
                    FROM OPCIONES A;";
            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }


        public static DataTable TODAS_LAS_OPCIONES()
        {
            DataTable Resultado = new DataTable();
            String Consulta = "select *from opciones;";

            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable TODOS_LOS_ROLES2()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT IDRol, Rol FROM roles ORDER BY idrol;";
            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable REPORTE_EMPLEADOS()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT IDEmpleado, Nombres, Apellidos, Genero 
            FROM empleados;";
            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }
        
        public static DataTable REPORTE_GENERAL_INCIDENCIAS()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"Select a.IdIncidencia, a.Fecha_Apertura, a.Tipo, a.Estado, a.Criticidad,
                                a.IdEmpleado,
                                (select Nombres from Empleados where IDEmpleado = a.IDEmpleado) as Empleado,
                                a.IdTecnico,
                                (select Nombres from Tecnicos where IDTecnico = a.IDTecnico) as Tecnico,
                                a.IdCliente,
                                (select Nombres from Clientes where IDCliente = a.IDCliente) as Cliente,
                                a.IdEquipo,
                                (select Equipo from Equipos where IDEquipo = a.IDEquipo)as Equipo
                                ,a.Fecha_Cierre from Incidencias a;";
            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable REPORTE_GENERAL_INCIDENCIAS2()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"Select a.IdIncidencia, a.Fecha_Apertura, a.Tipo, a.Estado, a.Criticidad,
                                a.IdEmpleado,
                                (select concat(Nombres,' ',Apellidos) from Empleados where IDEmpleado = a.IDEmpleado) as Empleado,
                                a.IdTecnico,
                                (select concat(Nombres,' ',Apellidos) from Tecnicos where IDTecnico = a.IDTecnico) as Tecnico,
                                a.IdCliente,
                                (select concat(Nombres,' ',Apellidos) from Clientes where IDCliente = a.IDCliente) as Cliente,
                                a.IdEquipo,
                                (select Equipo from Equipos where IDEquipo = a.IDEquipo)as Equipo
                                ,a.Fecha_Cierre from Incidencias a;";
            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable REPORTE_GENERAL_INCIDENCIAS_POR_FECHA_Y_ESTADO(String fInicio, String fFinal, String Estado)
        {
            DataTable Resultado = new DataTable();
            String Consulta = "";

            if (Estado != "Todos")
            {
                Consulta = @"Select a.IdIncidencia, a.Fecha_Apertura, a.Tipo, a.Estado, a.Criticidad,
                            a.IdEmpleado,
                            (select concat(Nombres,' ',Apellidos) from Empleados where IDEmpleado = a.IDEmpleado) as Empleado,
                            a.IdTecnico,
                            (select concat(Nombres,' ',Apellidos) from Tecnicos where IDTecnico = a.IDTecnico) as Tecnico,
                            a.IdCliente,
                            (select concat(Nombres,' ',Apellidos) from Clientes where IDCliente = a.IDCliente) as Cliente,
                            a.IdEquipo,
                            (select Equipo from Equipos where IDEquipo = a.IDEquipo)as Equipo
                            ,a.Fecha_Cierre from Incidencias a 
                            where a.Fecha_Apertura BETWEEN '" + fInicio + "' AND '" + fFinal + "' AND Estado = '" + Estado + "';";
            }
            else
            {
                Consulta = @"Select a.IdIncidencia, a.Fecha_Apertura, a.Tipo, a.Estado, a.Criticidad,
                            a.IdEmpleado,
                            (select concat(Nombres,' ',Apellidos) from Empleados where IDEmpleado = a.IDEmpleado) as Empleado,
                            a.IdTecnico,
                            (select concat(Nombres,' ',Apellidos) from Tecnicos where IDTecnico = a.IDTecnico) as Tecnico,
                            a.IdCliente,
                            (select concat(Nombres,' ',Apellidos) from Clientes where IDCliente = a.IDCliente) as Cliente,
                            a.IdEquipo,
                            (select Equipo from Equipos where IDEquipo = a.IDEquipo)as Equipo
                            ,a.Fecha_Cierre from Incidencias a 
                            where a.Fecha_Apertura BETWEEN '" + fInicio + "' AND '" + fFinal + "';";
            }

            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }
        
        public static DataTable BuscarUsuario(String Usuario)
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT Usuario FROM Usuarios where Usuario = '" + Usuario + "';";
            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable BuscarUsuarioCliente(String Usuario)
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT Usuario FROM Usuarios_Cliente where Usuario = '" + Usuario + "';";
            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable BuscarUsuarioTecnico(String Usuario)
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT Usuario FROM Usuarios_Tecnico where Usuario = '" + Usuario + "';";
            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }
    }
}
