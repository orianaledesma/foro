using Foro.Data;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foro.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [StringLength(200, MinimumLength =1,ErrorMessage = ErrorMsgs.LimiteString)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [StringLength(200, MinimumLength =1,ErrorMessage = ErrorMsgs.LimiteString)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [StringLength(80, MinimumLength =10,ErrorMessage = ErrorMsgs.LimiteString)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public DateTime FechaAlta { get; set; } = DateTime.Now ;

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [StringLength(30, MinimumLength =8,ErrorMessage = ErrorMsgs.LimiteString)]
        [DataType(DataType.Password)]
        [Display(Name="Contraseña")]
        public string Password { get; set; }

       
    }
}
