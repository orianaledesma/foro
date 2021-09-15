       using Foro.Data;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foro.Models
{
    public class Miembro : Usuario
    {
        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [Range(1,int.MaxValue, ErrorMessage = ErrorMsgs.NumberRequired)]
        public int Telefono { get; set; }
        public List <Entrada> Entradas { get; set; }
        public List <Pregunta> Preguntas { get; set; }
        public List <Respuesta> Respuestas { get; set; }
        public List<Reaccion> PreguntasYRespuestasQueMeGustan{ get; set; }
        public List<EntradaMiembro> EntradasHabilitados { get; set; }
    }
}
