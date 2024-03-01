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
    public class Venta
    {
        //variables de las tablas VENTA

        //id de la tabla VENTA
        public int idVenta { get; set; }
        public int idCliente { get; set; }
        public int TotalProducto { get; set; }
        public decimal MontoTotal { get; set; }
        public string Contacto { get; set; }
        public string idDistrito { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string idTransaccion { get; set; }

        //referencia a los detalle_venta haciendo una lista 
        public List<DetalleVenta> oDetalleVenta { get; set; }
    }
}
