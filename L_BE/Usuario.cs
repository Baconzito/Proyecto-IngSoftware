using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_BE
{
    public class Usuario
    {
        private int Id;
        public string Nombre {  get; set; }
        private string Contraseña { get; set; }

        public Usuario(int id, string nombre, string contraseña) 
        { 
            Id = id;
            Nombre = nombre;
            Contraseña = contraseña;
        }

    }
}
