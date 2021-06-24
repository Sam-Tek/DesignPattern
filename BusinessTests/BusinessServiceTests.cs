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
            BusinessService businessService = new BusinessService(new MockStorage());

            List<Employe> employes = businessService.GetEmployes();

            Assert.AreEqual(employes.Count, 2);
        }
    }
}