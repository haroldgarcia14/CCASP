/*****************************************************************
**                 Author: Harold Garcia                        ** 
**      C# - ASP.NET / ADO.NET => .NET FRAMEWORK 4.8            **
*****************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Marca
    {
        //se agregan las variables de la tabla MARCA

        //Id de la tabla marca
        public int IdMarca { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
    }
}
