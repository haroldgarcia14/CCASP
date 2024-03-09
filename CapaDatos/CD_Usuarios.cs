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

        //se creara un nuevo metodo para registrar a los nuevos usuarios
                            //se declaran los parametros de
                            //de tipo Usuario y uno de salida de string
        public int Registrar(Usuario obj, out string Mensaje)
        {
            int idautogenerado = 0; //lo que se recibira el id al registrar
            Mensaje = string.Empty; //mensaje vacio temporal

            try
            {
                //se hace la conexion
                using(SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {
                    //se llama el procedimiento almacenado
                    SqlCommand cmd = new SqlCommand("sp_RegistarUsuario", oconexion);
                    //se hace el llamado de los campos de la tabla Usuario
                    //y parametros del procedimiento almacenado
                    cmd.Parameters.AddWithValue("Nombres", obj.Nombres);
                    cmd.Parameters.AddWithValue("Apellidos",obj.Apellidos);
                    cmd.Parameters.AddWithValue("Correo", obj.Correo);
                    cmd.Parameters.AddWithValue("Clave", obj.Clave);
                    cmd.Parameters.AddWithValue("Activo", obj.Activo);

                    //parametros de salida
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    
                    //se indica el tipo de comando que se va a ejecutar
                    cmd.CommandType = CommandType.StoredProcedure;

                    //abriendo conexion
                    oconexion.Open();

                    //ejecutar el comando
                    cmd.ExecuteNonQuery();

                    //se retorna el parametro de salida
                    //que guarde el ultimo id que se ha registrado
                    idautogenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch(Exception ex)
            {
                idautogenerado = 0;
                Mensaje = ex.Message;
            }
            return idautogenerado;
        }

        //metodo para editar lo usuarios ya registrados
        public bool Editar(Usuario obj, out string Mensaje)
        {
            bool resultado = false;
            Mensaje = string.Empty;

            try
            {
                using(SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {
                    //se llama el procedimiento almacenado
                    SqlCommand cmd = new SqlCommand("sp_EditarUsuario", oconexion);

                    //se hace el llamado de los campos de la tabla Usuario
                    //y parametros del procedimiento almacenado
                    cmd.Parameters.AddWithValue("IdUsuario", obj.idUsuario);
                    cmd.Parameters.AddWithValue("Nombres", obj.Nombres);
                    cmd.Parameters.AddWithValue("Apellidos", obj.Apellidos);
                    cmd.Parameters.AddWithValue("Correo", obj.Correo);
                    cmd.Parameters.AddWithValue("Clave", obj.Clave);
                    cmd.Parameters.AddWithValue("Activo", obj.Activo);

                    //parametros de salida
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    //abriendo conexion
                    oconexion.Open();

                    //ejecutar el comando
                    cmd.ExecuteNonQuery();

                    //se retorna el parametro de salida
                    //que guarde el ultimo id que se ha registrado
                    resultado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch(Exception ex)
            {
                resultado = false;
                Mensaje = ex.Message;
            }
            return resultado;
        }
    }
}
