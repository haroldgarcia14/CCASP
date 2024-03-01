/*****************************************************************
**                 Author: Harold Garcia                        ** 
**      C# - ASP.NET / ADO.NET => .NET FRAMEWORK 4.8            **
*****************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//en la capa de Negocio tambien se va agregar como referencia a la capa de entidad y capa de datos

//la capa de CapaPresentacionAdmin
//y CapaPresentacionTienda tambien se agregara como referencia la capa de entidad y capa negocio


//agregando capa Entidad
using CapaEntidad;

//para la bd
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Usuarios
    {
        //devuelve una lista de la clase usuario
        //se agrega la referencia de la capa entidad donde esta usuario
        //se agrega con referencias en el proyecto de datos
        public List<Usuario> Listar()//tiene que retornar 
        {
            List<Usuario> lista = new List<Usuario>();//objeto

            try
            {
                //usando la variable que se creo en la clase Conexion.cs
                using(SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {
                    //variable guardando query
                    string query = "select IdUsuario,Nombres,Apellidos,Correo,Clave,Reestablecer,Activo from USUARIO";

                    //comando que permite ejecutar el query guardado 
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text; //asignado que tipo se ingresara(texto)

                    //abriendo conexion
                    oconexion.Open();

                    //para que pueda leer el resultado del select asignado 
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {   //se repetira N cantidad de registros que tenga
                        while (dr.Read())
                        {
                            //y se guardará en la variable Lista
                            lista.Add(
                                    new Usuario()
                                    {
                                        idUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                        Nombres = dr["Nombres"].ToString(),
                                        Apellidos = dr["Apellidos"].ToString(),
                                        Correo = dr["Correo"].ToString(),
                                        Clave = dr["Clave"].ToString(),
                                        Reestablecer = Convert.ToBoolean(dr["Reestablecer"]),
                                        Activo = Convert.ToBoolean(dr["Activo"])
                                    }
                                );
                        }
                    }
                }
            }
            catch
            {
                //una lista vacia
                lista = new List<Usuario>();
            }

            return lista;//retorno
        }
    }
}
