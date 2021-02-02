using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaTest;

namespace TestErrati
{
    [TestClass]
    public class OperazioneTest
    {


        [TestMethod]
        public void TestCalcoloMisterioso()
        {
            int n = 5;
            long valore_aspettato = 240;
            long resp = Gestione.CalcoloMisterioso(n);
            Assert.AreEqual(valore_aspettato, resp);
        }

        [TestMethod]
        public void TestCalcoloMisterioso2()
        {
            int n = -100;
            long valore_aspettato = -3;
            long resp = Gestione.CalcoloMisterioso2(n);
            Assert.AreEqual(valore_aspettato, resp);
        }

        [TestMethod]
        public void TestMisurazioneMisteriosa()
        {
            double[] valori = new double[] { 4, 6, 7, -9.1 };
            double valore_aspettato = 3;
            double min = Gestione.MisurazioneMisteriosa(valori);
            Assert.AreEqual(valore_aspettato, min);
        }

        [TestMethod]
        public void TestCalcoloMisterioso3()
        {
            int n = -130;
            long valore_aspettato = -3;
            long resp = Gestione.CalcoloMisterioso2(n);
            Assert.AreEqual(valore_aspettato, resp);
        }

        [TestMethod]
        public void TestMisurazioneMisteriosa1()
        {
            double[] valori = new double[] { 4, -6.5, 7, 9.1 };
            double valore_aspettato = 1;
            double min = Gestione.MisurazioneMisteriosa(valori);
            Assert.AreEqual(valore_aspettato, min);
        }

    }
}
