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
    public class Carrito
    {
        //variables de la tabla CARRITO

        //id de la tabla
        public int Id { get; set; }
        public Cliente oCliente { get; set; } //hace referencia a la tabla Cliente
        public Producto oProducto { get; set; } //hace referencia a la tabla Producto
        public int Cantidad { get; set; }
    }
}
