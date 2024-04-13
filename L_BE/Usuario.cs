using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_BE
{
    public class Usuario
    {
        [Key]
        [Required(ErrorMessage = "Campo Requerido")]
        public int Id;
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(16, ErrorMessage = "El nombre no puede ser mayor a 16 caracteres")]
        public string Nombre {  get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(64, ErrorMessage = "La contraseña no puede ser mayor a 64 caracteres")]
        public string Contraseña { get; set; }

        public Usuario(int id, string nombre, string contraseña) 
        { 
            Id = id;
            Nombre = nombre;
            Contraseña = contraseña;
        }

    }
}
