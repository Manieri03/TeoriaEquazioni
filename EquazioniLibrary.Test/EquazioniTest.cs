using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class EquazioniTest
    {
        [TestMethod]
        public void Determined()
        {
            double a = 3;           
            bool rispostaasp = true;
            bool risposta = Equazioni.IsDetermined(a);
            Assert.AreEqual(rispostaasp, risposta);

        }
        [TestMethod]
        public void Determined1()
        {
            double a = 0;
            bool rispostaasp = false;
            bool risposta = Equazioni.IsDetermined(a);
            Assert.AreEqual(rispostaasp, risposta);

        }
        [TestMethod]
        public void Inconsisted()
        {
            double a = 3;
            bool rispostaasp = false;
            bool risposta = Equazioni.IsInconsisted(a);
            Assert.AreEqual(rispostaasp, risposta);

        }
        [TestMethod]
        public void Inconsisted1()
        {
            double a = 0;
            bool rispostaasp = true;
            bool risposta = Equazioni.IsInconsisted(a);
            Assert.AreEqual(rispostaasp, risposta);

        }
        [TestMethod]
        public void Degree2()
        {
            double a = 3;
            bool rispostaasp = true;
            bool risposta = Equazioni.IsDetermined(a);
            Assert.AreEqual(rispostaasp, risposta);
        }
        [TestMethod]
        public void Degree21()
        {
            double a = 0;
            bool rispostaasp = false;
            bool risposta = Equazioni.IsDetermined(a);
            Assert.AreEqual(rispostaasp, risposta);
        }
        [TestMethod]
        public void Delta()
        {
            double a = 2;
            double b = 7;
            double c = 3;
            int rispostaasp = 25;
            double risposta = Equazioni.Delta(a, b, c);
            Assert.AreEqual(rispostaasp, risposta);
        }
        [TestMethod]
        public void Delta1()
        {
            double a = 0;
            double b = 7;
            double c = 3;
            int rispostaasp = 49;
            double risposta = Equazioni.Delta(a, b, c);
            Assert.AreEqual(rispostaasp, risposta);
        }
        [TestMethod]
        public void Delta2()
        {
            double a = 3;
            double b = 0;
            double c = 4;
            int rispostaasp = -48;
            double risposta = Equazioni.Delta(a, b, c);
            Assert.AreEqual(rispostaasp, risposta);
        }
        [TestMethod]
        public void Delta3()
        {
            double a = 3;
            double b = 5;
            double c = 0;
            int rispostaasp = 25;
            double risposta = Equazioni.Delta(a, b, c);
            Assert.AreEqual(rispostaasp, risposta);
        }
        [TestMethod]
        public void EquationDegree()
        {
            double a = 0;
            double b = 0;
            string rispostaasp = "Indeterminato";
            string risposta = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(rispostaasp, risposta);
        }
        [TestMethod]
        public void EquationDegree1()
        {
            double a = 0;
            double b = 8;
            string rispostaasp = "Impossibile";
            string risposta = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(rispostaasp, risposta);
        }
        [TestMethod]
        public void EquationDegree2()
        {
            double a = 2;
            double b = 1;
            string rispostaasp ="-0,5";
            string risposta = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(rispostaasp, risposta);
        }
        
    }
}
