﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2SinSQL
{
    public class Grupo
    {
        [Key]
        public int Num_grupo { get; set; }
        public string Nombre_grupo { get; set; }
        public int Num_componente { get; set; }
    }
}