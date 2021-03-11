using System;

namespace TariffeLibrary
{
    public class Gestione
    {
        public static string CalcoloTariffe (int ore)
        {
            string risposta = "";
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

            if (tariffaA < tariffaB && tariffaA < tariffaC)
            {
                risposta = "Tariffa A";
            }
            else if (tariffaB < tariffaA && tariffaB < tariffaC)
            {
                risposta = "Tariffa B";
            }
            else
            {
                risposta = "Tariffa C";
            }

            return risposta;
        }
    }
}
