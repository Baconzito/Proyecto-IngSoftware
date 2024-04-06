using L_DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_MPP
{
    public class MPP_USUARIO
    {
        MPP_USUARIO() { oCnx = new Conexion();}
        Conexion oCnx;
        public bool Agregar()
        {
            return true;
        }
        public bool Borrar()
        {
            return true;
        }
        public bool Modificar()
        {
            return true;
        }
    }
}
