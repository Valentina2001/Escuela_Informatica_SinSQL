using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2SinSQL
{
    public class Tribunal
    {
        [Key]
        public int Num { get; set; }
        public string Lugar_Examen { get; set; }
        public int Num_Componentes { get; set; }
    }
}
