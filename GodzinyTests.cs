using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodzinyTests
{
    [TestClass]
    public class GodzinyTests
    {
        [TestMethod]
        [TestCase(7899, 2.1941666666666668)]
        public void SekundyNaGodziny(double liczba, double oczekiwana)
        {
            KonwerterCzasu.Form1 frm = new KonwerterCzasu.Form1();
            double prawdziwaWartosc = frm.SekundyNaGodziny(liczba);
            NUnit.Framework.Assert.AreEqual(oczekiwana, prawdziwaWartosc);
        }

        [TestMethod]
        [TestCase(2, 0.033333333333333333)]
        public void MinutyNaGodziny(double liczba, double oczekiwana)
        {
            KonwerterCzasu.Form1 frm = new KonwerterCzasu.Form1();
            double prawdziwaWartosc = frm.MinutyNaGodziny(liczba);
            NUnit.Framework.Assert.AreEqual(oczekiwana, prawdziwaWartosc);
        }

        [TestMethod]
        [TestCase(2, 2)]
        public void GodzinyNaGodziny(double liczba, double oczekiwana)
        {
            KonwerterCzasu.Form1 frm = new KonwerterCzasu.Form1();
            double prawdziwaWartosc = frm.GodzinyNaGodziny(liczba);
            NUnit.Framework.Assert.AreEqual(oczekiwana, prawdziwaWartosc);
        }

        [TestMethod]
        [TestCase(2, 48)]
        public void DniNaGodziny(double liczba, double oczekiwana)
        {
            KonwerterCzasu.Form1 frm = new KonwerterCzasu.Form1();
            double prawdziwaWartosc = frm.DniNaGodziny(liczba);
            NUnit.Framework.Assert.AreEqual(oczekiwana, prawdziwaWartosc);
        }

        [TestMethod]
        [TestCase(2, 336)]
        public void TygodnieNaGodziny(double liczba, double oczekiwana)
        {
            KonwerterCzasu.Form1 frm = new KonwerterCzasu.Form1();
            double prawdziwaWartosc = frm.TygodnieNaGodziny(liczba);
            NUnit.Framework.Assert.AreEqual(oczekiwana, prawdziwaWartosc);
        }

        [TestMethod]
        [TestCase(2, 1461)]
        public void MiesaceNaGodziny(double liczba, double oczekiwana)
        {
            KonwerterCzasu.Form1 frm = new KonwerterCzasu.Form1();
            double prawdziwaWartosc = frm.MiesiaceNaGodziny(liczba);
            NUnit.Framework.Assert.AreEqual(oczekiwana, prawdziwaWartosc);
        }

        [TestMethod]
        [TestCase(2,17532)]
        public void LataNaGodziny(double liczba, double oczekiwana)
        {
            KonwerterCzasu.Form1 frm = new KonwerterCzasu.Form1();
            double prawdziwaWartosc = frm.LataNaGodziny(liczba);
            NUnit.Framework.Assert.AreEqual(oczekiwana, prawdziwaWartosc);
        }
    }
}
