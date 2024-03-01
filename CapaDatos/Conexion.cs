/*****************************************************************
**                 Author: Harold Garcia                        ** 
**      C# - ASP.NET / ADO.NET => .NET FRAMEWORK 4.8            **
*****************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//se agrega esta libreria en el proyecto de la capa datos
//para poder usarla se va al menu de agregar/referencia/System.Configuration
using System.Configuration;

namespace CapaDatos
{   //clase para hacer conexion a sql
    public class Conexion
    {
        //se almacena la configuracion de la conexion con una cadena
        public static string cn = ConfigurationManager.ConnectionStrings["cadena"].ToString();
    }
}
