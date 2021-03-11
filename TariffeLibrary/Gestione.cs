using System;

namespace TariffeLibrary
{
    public class Gestione
    {
        public static string CalcoloTariffe (int ore)
        {
            int tariffaA;
            if (ore > 24)
            {
                tariffaA = 30;
            }
            else
            {
                tariffaA = 15;
            }

            int tariffaB = ore * 1;

            int calcolo = ore - 1;
            double tariffaC = calcolo * 1.20;

            in
        }
    }
}
