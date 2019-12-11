using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2SinSQL
{
    public class TFC
    {
        [Key]
        public int Num_orden { get; set; }
        public string Tema { get; set; }
        public string Fecha { get; set; }
    }
}
