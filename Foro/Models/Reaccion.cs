using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Foro.Data;

namespace Foro.Models
{
    public class Reaccion
     {
        public DateTime Fecha { get; set; } = DateTime.Now;
        public int Id { get; set; }

        public bool MeGusta { get; set; } 
        public Respuesta Respuesta { get; set; }
        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public int RespuestaId { get; set; }
        public Miembro Miembro { get; set; }
        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public int MiembroId { get; set; }



    }
}
