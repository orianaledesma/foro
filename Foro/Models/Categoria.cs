using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Foro.Data;


namespace Foro.Models
{
    public class Categoria
    {   
        public int Id { get; set; }
        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [StringLength(50, MinimumLength =1,ErrorMessage = ErrorMsgs.LimiteString)]
        public string Nombre { get; set; }
        public List <Entrada> Entradas { get; set; }

    }
}
