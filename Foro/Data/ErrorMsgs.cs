using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Foro.Data
{
    public static class ErrorMsgs
    {
        public const string Requerido = "La propiedad{0} es requerido";
        public const string LimiteString = "La propiedad{0} debe tener un minimo de {2} caracteres y un maximo de {1} ";

        public const string NumberRequired = "La propiedad{0} debe tener un minimo de {1} número y un maximo de {2} ";
    }
}
