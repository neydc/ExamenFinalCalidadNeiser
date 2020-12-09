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
            User jugador = new User();
            jugador.Id = 1;
            jugador.Nombre = "Neiser";
            jugador.Puntaje = 80;

            User jugador2 = new User();
            jugador2.Id = 1;
            jugador2.Nombre = "Pedro";
            jugador2.Puntaje = 30;
            var UserMock = new Mock<UserRepository>();
            
            var val = 500;   //envia una lista 
            Assert.IsInstanceOf<ViewResult>(val); //se espera viewresult

        }

        [Test]
        public void TestCartaAlta()
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
            var val = pokController; //Valor mas alto

            Assert.IsInstanceOf<int>(val); 
        }

      
        [Test]
        public void UsuarioCuatroGano()
        {
            User jugador3 = new User();
            jugador3.Id = 1;
            jugador3.Nombre = "Neiser";
            jugador3.Puntaje = 80;

            User jugador4 = new User();
            jugador4.Id = 1;
            jugador4.Nombre = "Pedro";
            jugador4.Puntaje = 30;
            var UserMock = new Mock<UserRepository>();

            var val = 500;   //envia una lista 
            Assert.IsInstanceOf<ViewResult>(val);
        }
        [Test]
        public void UsuarioCincoGano()
        {
            User jugador4 = new User();
            jugador4.Id = 1;
            jugador4.Nombre = "Neiser";
            jugador4.Puntaje = 80;

            User jugador5 = new User();
            jugador5.Id = 1;
            jugador5.Nombre = "Pedro";
            jugador5.Puntaje = 100;
            var UserMock = new Mock<UserRepository>();

            var val = 100;   //envia una lista 
            Assert.IsInstanceOf<int>(val);
        }

        [Test]
        public void UsuarioUnoYDosEmpate()
        {
            User jugador4 = new User();
            jugador4.Id = 1;
            jugador4.Nombre = "Neiser";
            jugador4.Puntaje = 100;

            User jugador5 = new User();
            jugador5.Id = 1;
            jugador5.Nombre = "Pedro";
            jugador5.Puntaje = 100;
            var UserMock = new Mock<UserRepository>();
            var val = 100;   //envia una lista 
            Assert.IsInstanceOf<int>(val);
        }

     
        [Test]
        public void UsuarioTresGano()
        {
            User jugador = new User();
            jugador.Id = 1;
            jugador.Nombre = "Neiser";
            jugador.Puntaje = 10;

            User jugador2 = new User();
            jugador2.Id = 1;
            jugador2.Nombre = "Pedro";
            jugador2.Puntaje = 30;

            User jugador3 = new User();
            jugador3.Id = 1;
            jugador3.Nombre = "Juan";
            jugador3.Puntaje = 50;
            var UserMock = new Mock<UserRepository>();
            var ValorMaximoPuntaje = jugador.Max(o => o.Puntaje);
            var val = pokController; //Valor mas alto

            Assert.IsInstanceOf<ValorMaximoPuntaje>(val);

        }

    }
}
