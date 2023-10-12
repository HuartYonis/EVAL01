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

            Vehicule veh = new Vehicule("AA-123-BB", "Essence", 500);
            Utilitaire util = new Utilitaire("AA-123-BB", "Essenc",500,15000,3000,50);
            
            Assert.AreEqual(12000, util.ChargeUtile());
        }

        [TestMethod()]
        public void PrevoirEntretienTest()
        {
            // Cas 2 : le dernier entretien date de moins de 1 ans
            Tourisme vt1 = new Tourisme("AA-125-BB", "Essence", 7, 4, new Modele("Fiat500", "Fiat", 15000));
            vt1.AjouterEntretien(new Entretien(new DateTime(2023, 07, 01), 14000, "RAS"));
            vt1.SetKmActuel(25000);
            Assert.AreEqual(false, vt1.PrevoirEntretien());

            // Cas 2 : le dernier entretien date de plus de 1 ans
            Tourisme vt2 = new Tourisme("AA-125-BB", "Essence", 7, 4, new Modele("Fiat500", "Fiat", 15000));
            vt2.AjouterEntretien(new Entretien(new DateTime(2020, 07, 01), 14000, "RAS"));
            vt2.SetKmActuel(25000);
            Assert.AreEqual(true, vt2.PrevoirEntretien());


        }
    }
}