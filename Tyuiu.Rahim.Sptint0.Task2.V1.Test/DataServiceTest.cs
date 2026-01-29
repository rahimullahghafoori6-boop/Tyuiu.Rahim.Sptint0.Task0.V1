using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.Rahim.Sprint0.Task2.V1.Lib;

namespace Tyuiu.Rahim.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChekGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Rahimullajgafori";
            var res = DataService.GetMessage(name);

            //Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет, a", res);
        }
    }
}
