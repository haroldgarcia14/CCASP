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
    public class Categoria
    {
        //campos de la tabla Categoria

        //id de la tabla categoria
        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }
        
        //se hace referencia a activo o inactivo
        public bool Activo { get; set; }
    }
}
