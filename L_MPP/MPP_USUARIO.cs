using L_DA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L_BE;
using System.Collections;

namespace L_MPP
{
    public class MPP_USUARIO
    {
        public MPP_USUARIO() { oCnx = new Conexion();}
        Conexion oCnx;
        public bool Agregar(Usuario oUsuario)
        {
            Hashtable ht = new Hashtable();
            ht.Add("@Nombre", oUsuario.Nombre);
            ht.Add("@Contraseña", oUsuario.Contraseña);
            return oCnx.Guardar("Agregar",ht);
        }
        public bool Borrar(Usuario oUsuario)
        {
            Hashtable ht = new Hashtable();
            ht.Add("@Id", oUsuario.Id);
            return oCnx.Guardar("Borrar", ht);
        }
        public bool Modificar(Usuario oUsuario)
        {
            Hashtable ht = new Hashtable();
            ht.Add("@Id", oUsuario.Id);
            ht.Add("@Nombre", oUsuario.Nombre);
            ht.Add("@Contraseña", oUsuario.Contraseña);
            return oCnx.Guardar("Modificar", ht);
        }
        public DataTable Leer()
        {
            return oCnx.Leer("Leer");
        }
    }
}
