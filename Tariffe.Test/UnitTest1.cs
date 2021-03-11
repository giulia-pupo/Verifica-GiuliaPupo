using Microsoft.VisualStudio.TestTools.UnitTesting;
using TariffeLibrary;

namespace Tariffe.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TariffaConveniente()
        {
            int ore = 2;
            string risultato_aspettato = "Tariffa C";
            string risultato_rispettivo = Gestione.CalcoloTariffe(ore);
            Assert.AreEqual(risultato_aspettato, risultato_rispettivo);
        }
    }
}
