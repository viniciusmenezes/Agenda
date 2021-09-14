using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaApp.Models
{
    public class Contato
    {
        public int? Id { get; set; }
        
        [Required]
        [DisplayName("Nome")]
        [StringLength(80, ErrorMessage = "Máximo de 80 caracteres.")]
        public string Nome { get; set; }
        
        [Required]
        [DisplayName("E-mail")]
        public string Email { get; set; }
        
        [Required]
        [DisplayName("Telefone")]
        [StringLength(11, ErrorMessage = "Máximo de 11 caracteres.")]
        public string Telefone { get; set; }
    }
}
