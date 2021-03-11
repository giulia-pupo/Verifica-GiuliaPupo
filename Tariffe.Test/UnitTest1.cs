using Microsoft.VisualStudio.TestTools.UnitTesting;
using TariffeLibrary;

namespace Tariffe.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TariffaConveniente1()
        {
            int ore = 36;
            string risultato_aspettato = "Tariffa A";
            string risultato_rispettivo = Gestione.CalcoloTariffe(ore);
            Assert.AreEqual(risultato_aspettato, risultato_rispettivo);
        }
        [TestMethod]
        public void TariffaConveniente2()
        {
            int ore = 25;
            string risultato_aspettato = "Tariffa B";
            string risultato_rispettivo = Gestione.CalcoloTariffe(ore);
            Assert.AreEqual(risultato_aspettato, risultato_rispettivo);
        }
        [TestMethod]
        public void TariffaConveniente3()
        {
            int ore = 2;
            string risultato_aspettato = "Tariffa C";
            string risultato_rispettivo = Gestione.CalcoloTariffe(ore);
            Assert.AreEqual(risultato_aspettato, risultato_rispettivo);
        }
    }
}
