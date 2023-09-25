using ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ConsoleAppTests
{
    [TestClass]
    public class ConsoleAppTests
    {
        [TestMethod]
        public void TestSumarNumeros()
        {
            double inputA = 10;
            double inputB = 5;
            double expected = 15;
            double result = ConsoleApp.ConsoleApp.SumarNumeros(inputA, inputB);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestDividirCadena()
        {
            string input = "12345678";
            string expected = "56781234";
            string result = ConsoleApp.ConsoleApp.DividirCadena(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestEnumerarDias()
        {
            int expected = 5;
            int result = ConsoleApp.ConsoleApp.EnumerarDias();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSentenciaIf()
        {
            int value = 35;
            Assert.IsTrue(ConsoleApp.ConsoleApp.SentenciaIf(value));
        }

        [TestMethod]
        public void TestSentenciaWhile()
        {
            int start = 35;
            List<int> result = ConsoleApp.ConsoleApp.SentenciaWhile(start);
            List<int> expected = new List<int> { 35, 40, 45, 50 };
            CollectionAssert.AreEqual(expected, result);
        }
    }
}