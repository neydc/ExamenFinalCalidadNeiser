using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calidad_NeiserFinal.Models
{
    public class ValorCarta
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }

        public ValorCarta(int id, int cantidad)
        {
            Id = id;
            Cantidad = cantidad;
        }
    }
}
