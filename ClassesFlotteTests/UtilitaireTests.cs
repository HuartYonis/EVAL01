using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassesFlotte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesFlotte.Tests
{
    [TestClass()]
    public class UtilitaireTests
    {
        [TestMethod()]
        public void ChargeUtileTest()
        {

            Vehicule veh = new Vehicule("AA-123-BB", "Essence", 8);
            Utilitaire util = new Utilitaire(15000,3000,50);
            
            Assert.AreEqual(12000, util.ChargeUtile());
        }

        [TestMethod()]
        public void PrevoirEntretienTest()
        {
            // TODO
        }
    }
}