using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2SinSQL
{
    public class Alumno
    {

        [Key]
        public int Num_Matricula { get; set; }
        public int Dni { get; set; }
        public string Nombre { get; set; }
    }
}
