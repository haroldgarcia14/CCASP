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

    public class Producto
    {
        //variables de la tabla PRODUCTO

        //id de la tabla PRODUCTO
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca oMarca { get; set; } //hace referencia a la tabla Marca
        public Categoria oCategoria { get; set; } //hace referencia a la tabla Categoria
        public decimal Precio { get; set; }
        public int Stock {  get; set; }
        public string RutaImagen { get; set; }
        public string NombreImagen { get; set;}
        public bool Activo { get; set; }
    }
}
