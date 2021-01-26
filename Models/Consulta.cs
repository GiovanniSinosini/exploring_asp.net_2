using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica_Veterinaria_3.Models
{
    public class Consulta
    {
        [Key]
        public int Id_Consulta { get; set; }
        
        [Display(Name = "Data da Consulta")]
        public DateTime DataConsulta { get; set; }                
      
        [Required]
        [Display(Name = "Nome do Cliente")]
        public String Cliente { get; set; }

        [Required]
        [Display(Name = "Nome do Animal")]
        public String Nome_Animal { get; set; }

        [Required]
        [Display(Name = "Histórico do Animal")]
        public String  Historico_Animal { get; set; }

        [Required]
        [Display(Name = "Agendamento realizado por")]
        public string QuemAgendou { get; set; }

        [Required]
        [Display(Name = "Nome do Médico")]
        public string Medico { get; set; }

        [Display(Name = "Cliente compareceu?")]
        public bool PresencaCliente { get; set; }
    }
}
