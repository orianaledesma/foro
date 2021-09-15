using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Foro.Models
{
    public class EntradaMiembro
    {

        public Entrada Entrada { get; set; }

        [Key, ForeignKey("Entrada")]
        public int EntradaId { get; set; }
        public Miembro Miembro { get; set; }

        [Key, ForeignKey("Miembro")]
        public int MiembroId { get; set; }




    }
}
