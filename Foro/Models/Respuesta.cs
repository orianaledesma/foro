using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Foro.Data;


namespace Foro.Models
{
    public class Respuesta
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public int PreguntaId { get; set; }
        public Pregunta Pregunta { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [StringLength(2000, MinimumLength = 2, ErrorMessage = ErrorMsgs.LimiteString)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public int MiembroId { get; set; }
        public Miembro Miembro { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public List<Reaccion> Reacciones { get; set; }

    }
}
