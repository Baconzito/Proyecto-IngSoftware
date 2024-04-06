using L_DA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace L_MPP
{
    public class MPP_USUARIO
    {
        public MPP_USUARIO() { oCnx = new Conexion();}
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
        public DataTable Leer()
        {
            return oCnx.Leer("");
        }
    }
}
