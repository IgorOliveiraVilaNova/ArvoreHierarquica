using System;
using System.Collections.Generic;
using ArvoreHierarquica;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteUnitario
{
    [TestClass]
    public class Testes
    {
        [TestMethod]
        public void Exemplo1() 
        {
            var lista = new List<List<Char>>()
            {
                new List<Char>(){'A','B'},
                new List<Char>(){'A','C'},
                new List<Char>(){'B','G'},
                new List<Char>(){'C','H'},
                new List<Char>(){'E','F'},
                new List<Char>(){'B','D'},
                new List<Char>(){'C','E'},
            };

            var result = MetodoTransformarArrayEmArvore.TransformarArrayEmArvore(lista);

            Assert.AreEqual("[A[B[D][G]][C[E[F]][H]]]", result);
        }

        [TestMethod]
        public void Exemplo2() 
        {
            var lista = new List<List<Char>>()
            {
                new List<Char>(){'B','D'},
                new List<Char>(){'D','E'},
                new List<Char>(){'A','B'},
                new List<Char>(){'C','F'},
                new List<Char>(){'E','G'},
                new List<Char>(){'A','C'},
            };
            var result = MetodoTransformarArrayEmArvore.TransformarArrayEmArvore(lista);

            Assert.AreEqual("[A[B[D[E[G]]]][C[F]]]", result);
        }

        [TestMethod]
        [ExpectedException(typeof(E3Exception))]
        public void Exemplo3() 
        {
            var lista = new List<List<Char>>()
            {
                new List<Char>() { 'A', 'B' },
                new List<Char>() { 'A', 'C' },
                new List<Char>() { 'B', 'D' },
                new List<Char>() { 'D', 'C' },
            };

            var result = MetodoTransformarArrayEmArvore.TransformarArrayEmArvore(lista);            
        }

    }
}
