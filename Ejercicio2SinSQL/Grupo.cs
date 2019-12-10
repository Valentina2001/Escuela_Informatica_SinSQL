using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2SinSQL
{
    public class Grupo
    {
        public int Num_grupo { get; set; }
        public string Nombre_grupo { get; set; }
        public int Num_componente { get; set; }
    }
}