using Calidad_NeiserFinal.Repository;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Calidad_NeiserFinal.Models;
using Microsoft.AspNetCore.Mvc;

namespace Pruebas
{
    
    class JuegoPokerController
    {
        private CartaRepository @object;

        public JuegoPokerController(CartaRepository @object)
        {
            this.@object = @object;
        }

        [Test]
        public void TestCrearBarajas()
        {
            List<Carta> barajaPrueba = new List<Carta>();
            Carta carta1 = new Carta();
            carta1.Id = 1;
            carta1.IdUsuario = 1;
            carta1.tipoCarta = "Trebol";
            carta1.Numero = 1;

            Carta carta2 = new Carta();
            carta1.Id = 1;
            carta1.IdUsuario = 2;
            carta1.tipoCarta = "Diamante";
            carta1.Numero = 4;


            Carta carta3 = new Carta();
            carta3.Id = 3;
            carta3.IdUsuario = 3;
            carta3.tipoCarta = "Trebol";
            carta3.Numero = 3;

            Carta carta4 = new Carta();
            carta1.Id = 1;
            carta1.IdUsuario = 4;
            carta1.tipoCarta = "Pica";
            carta1.Numero = 4;

            Carta carta5 = new Carta();
            carta1.Id = 1;
            carta1.IdUsuario = 2;
            carta1.tipoCarta = "Corazón";
            carta1.Numero = 4;

            barajaPrueba.Add(carta1);
            barajaPrueba.Add(carta2);
            barajaPrueba.Add(carta3);
            barajaPrueba.Add(carta4);
            barajaPrueba.Add(carta5);

            var pokerMock = new Mock<CartaRepository>();
            pokerMock.Setup(o => o.Puntaje(barajaPrueba));

            var pokController = new JuegoPokerController(pokerMock.Object);
            var val = pokController;

            Assert.IsInstanceOf<List>(val); // lista de barajas
         
        }

        [Test]
        public void TestTipoCarta()
        {
            List<string> tipoDeCarta = new List<string>();
            tipoDeCarta.Add("Corazon");
            tipoDeCarta.Add("Diamante");
            tipoDeCarta.Add("Espada");
            tipoDeCarta.Add("Flores");

            var pokerMock = new Mock<CartaRepository>();
            pokerMock.Setup(o => o.TipoCarta());

            var pokController = new JuegoPokerController(pokerMock.Object);
            var val = pokController;   //envia una lista 

            Assert.IsInstanceOf<List>(val); // lista de tipos de carta

        }


        [Test]
        public void UsuarioUnoGano() {
            var userMock = new Mock<ICartaService>();

           // userMock.Setup(a=>a.CrearBaraja);
        }

        [Test]
        public void UsuarioDosGano()
        {

        }
        [Test]
        public void UsuarioTresGano()
        {

        }
        [Test]
        public void UsuarioCuatroGano()
        {

        }
        [Test]
        public void UsuarioCincoGano()
        {

        }

        [Test]
        public void UsuarioUnoYDosEmpate()
        {

        }

        [Test]
        public void UsuariosTripleEmpate()
        {

        }

        [Test]
        public void UsuariosCuadrupleEmpate()
        {

        }

        [Test]
        public void UsuariosCincoEmpate()
        {

        }
    }
}
