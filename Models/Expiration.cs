using System;
using System.ComponentModel.DataAnnotations;

namespace ValidarCPR.Entities
{
    public class Expiration
    {
        [Required(ErrorMessage = "Campo obrigátorio.")]
        [Range(1, 99, ErrorMessage = "Fator de Redução entre 1 e 99")]
        public int DecreaseFactor { get; set; }

        [Required(ErrorMessage = "Campo obrigátorio.")]
        [Range(1, 360, ErrorMessage = "Máxima Validade entre 1 e 360.")]
        public int ExpirationDays { get; set; }

        [Required(ErrorMessage = "Campo obrigátorio.")]
        [DataType(DataType.Date)]
        public DateTime DateNow { get; set; }
        
        [Required(ErrorMessage = "Campo obrigátorio.")]
        [DataType(DataType.Date)]
        public DateTime ExpirationDate { get; set; }
    }
}
