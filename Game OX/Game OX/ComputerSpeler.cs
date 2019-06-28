
using System;
using System.Collections.Generic;

namespace HenE.Abdul.Game_OX
{
    public class ComputerSpeler : Speler
    {
        public ComputerSpeler(string name) : base(name)
        {
        }

        /// <summary>
        /// bepaal een vrij vak en kies dat.
        /// Kun je winnen? bepalen.
        /// </summary>
        /// <param name="bord">het bord waarp gespeeld wordt. </param>
        /// <returns>index van het veld op het bord. </returns>
        public override short BepaalZet(Bord bord)
        {
            // todo
            // welke vakjes zijn nog leeg?
            // vragen aan bord om aan te geven wat leeg is
            // loop door de lege velden.
            List<short> vrijeVelden = bord.VrijVelden();

            foreach (short index in vrijeVelden)
            {
                bord.DoeZet(this, index);

                // als ik mijn teken daar invul, win ik dan.
                // of wint de tegenstander dan?
                if (bord.HeeftTekenGewonnen(this.TeGebruikenTeken))
                {
                    bord.ResetVeld(index);
                    return index;
                }
                else
                {
                    // ik heb niet gewonnen, reset het veld en laat de tegespeler de zet doen
                    Speler tegenSpeler = bord.TegenSpeler(this);

                    bord.DoeZet(tegenSpeler, index);
                    if (bord.HeeftTekenGewonnen(tegenSpeler.TeGebruikenTeken))
                    {
                        // tegenstander heeft gewonnen
                        bord.ResetVeld(index);
                        return index;
                    }
                }

                // altijd weer het bord resetten
                bord.ResetVeld(index);
            }

            // als ik hier kom,
            return vrijeVelden[0];

            // is er een volgende zet
             // ja, probeer die dan
             // nee,
             //  loop dan weer door de mogelijke zetten heen
               // nee, is er dan een volgende
                  // ja, kijk daar dan mee
                  // nee
                  // dan kies ik de eerste uit de mogelijke zetten

            // kan ik winnen?
            // ja, dan dat vakje kiezen
            // nee
            // kan de tegenstander winnen?
            // ja
            // dan dat vakje kiezen
            // anders kies de eerste
            Random random = new Random();
            int bepaalHetBord = bord.Dimension * bord.Dimension;
            int result = random.Next(0, bepaalHetBord);

            short i = (short)result;
            return i;
        }
    }
}
