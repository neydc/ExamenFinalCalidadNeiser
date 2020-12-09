using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calidad_NeiserFinal.Models;

namespace Calidad_NeiserFinal.Repository
{
    public interface IUsuarioService
    {
        public List<User> Jugadores(List<string> nombres);

    }
    public class UserRepository: IUsuarioService
    {
        public List<User> Jugadores(List<string> nombres)
        {
            List<User> jugadores = new List<User>();
            int contador = 0;
            for (int i = 1; i < 6; i++)
            {
                User Nuevojugardor = new User();
                Nuevojugardor.Id = i;
                Nuevojugardor.Nombre = nombres[contador];

                jugadores.Add(Nuevojugardor);

                contador++;
            }

            foreach (var a in jugadores)
            {
                Console.WriteLine(a.Id + a.Nombre + a.Puntaje);
            }

            return jugadores;
        }
    }
}
