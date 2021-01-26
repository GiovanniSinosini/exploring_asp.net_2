using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica_Veterinaria_3.Models
{
    public class Animal
    {
        [Key]
        public int Id_Animal { get; set; }

        [Required]
        [Display(Name = "Nome do Animal")]
        public string Nome { get; set; }
        
        public DateTime Data_Nascimento { get; set; }
        public float Peso { get; set; }

        [Required]
        [Display(Name = "Histórico do Animal")]
        public string Historico { get; set; }






    }
}
