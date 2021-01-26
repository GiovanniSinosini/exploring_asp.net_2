using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica_Veterinaria_3.Models
{
    public class Cliente
    {
        [Key]
        public int Id_Cliente { get; set; }

        [Required]
        [Display(Name = "Nome do Cliente")]
        public string Nome { get; set; }
        
        public string Email { get; set; }
        public string Num_Telefone { get; set; }
        public string Endereco { get; set; }
        public Animal Animal { get; set; }

    }
}
