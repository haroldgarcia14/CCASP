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
    public class DetalleVenta
    {
        //variables de la tabla DETALLE_VENTA

        //id de la tabla
        public int idDetalleVenta { get; set; }
        public int idVenta { get; set; }
        public Producto oProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        public string idTransaccion { get; set; }
    }
}
