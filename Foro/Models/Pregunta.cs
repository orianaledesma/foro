using Foro.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Foro.Models
{
    public class Pregunta
    {
        public int Id { get; set; }
        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [StringLength(200, MinimumLength =2,ErrorMessage = ErrorMsgs.LimiteString)]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public int EntradaId { get; set; }
        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public Entrada Entrada { get; set; }
        public List<Respuesta> Respuestas { get; set; }
        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public int MiembroId { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public DateTime Fecha { get; set; } = DateTime.Now;
       
        public Boolean Activa { get; set; }


    }
}
