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
        public BLL_USUARIO() { Mpp_Usuario = new MPP_USUARIO; }
        MPP_USUARIO Mpp_Usuario;
        public bool Agregar()
        {
            return true;
        }
    }
}
