using L_BE;
using L_MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_BLL
{
    public class BLL_USUARIO
    {
        public BLL_USUARIO() { Mpp_Usuario = new MPP_USUARIO(); }
        MPP_USUARIO Mpp_Usuario;
        public bool Agregar(Usuario oUsuario)
        {
            return Mpp_Usuario.Agregar(oUsuario);
        }
        public bool Borrar(Usuario oUsuario)
        {
            return Mpp_Usuario.Modificar(oUsuario);
        }
        public bool Modificar(Usuario oUsuario) 
        {
            return Mpp_Usuario.Modificar(oUsuario);
        }
    }
}
