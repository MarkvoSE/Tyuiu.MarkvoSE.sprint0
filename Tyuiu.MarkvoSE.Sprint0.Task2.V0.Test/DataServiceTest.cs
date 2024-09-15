using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MarkvoSE.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MarkvoSE.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassageValid()
        {

            var name = "Савелий";
            var res = DataService.GetMassage(name);


            Assert.AreEqual("Привет, Савелий", res);
        }
    }
}
