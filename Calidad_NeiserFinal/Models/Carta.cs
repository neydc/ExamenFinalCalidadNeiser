﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calidad_NeiserFinal.Models
{
    public class Carta
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string tipoCarta { get; set; }

        public int IdUsuario { get; set; }
    }
}
