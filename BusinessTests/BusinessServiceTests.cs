using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessTests;
using Entities;

namespace Business.Tests
{
    [TestClass()]
    public class BusinessServiceTests
    {
        [TestMethod()]
        public void GetEmployesTest()
        {
            // arrange
            BusinessService businessService = new BusinessService(new MockStorage());
            // act
            List<Employe> employes = businessService.GetEmployes();
            // assert
            Assert.AreEqual(employes.Count, 2);
        }
    }
}