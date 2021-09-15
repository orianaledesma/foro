using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Foro.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foro.Models
{
    public class Entrada
    {
        public int Id { get; set; }
        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [StringLength(50, MinimumLength = 2, ErrorMessage = ErrorMsgs.LimiteString)]
        public string Titulo { get; set; }
        public DateTime FechaAlta { get; set; } = DateTime.Now ;
        public Categoria Categoria { get; set; }
        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public int CategoriaId { get; set; }
        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public int MiembroId { get; set; }
        public Miembro Miembro { get; set; }
        public List<Pregunta> Preguntas { get; set; }
        public bool Privada { get; set; } 
        public List<EntradaMiembro> MiembroHabilitados {get ; set ;}

       
    }
}
