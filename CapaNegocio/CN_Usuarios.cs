using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//haciendo referencia a las capas creadas
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{   //aqui se aplica todas las reglas de negocios para el crud
    public class CN_Usuarios
    {
        //ya se accede a la lista de la clase CD_Usuarios
        private CD_Usuarios objCapaDato = new CD_Usuarios();

       //un metodo que devuelva la lista de CD_Usuarios
       public List<Usuario> Listar()
        {
            //se retorna
            return objCapaDato.Listar();
        }
    }
}
