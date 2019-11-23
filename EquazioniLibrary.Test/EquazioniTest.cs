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
    }
}
