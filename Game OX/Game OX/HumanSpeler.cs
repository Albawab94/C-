// <copyright file="HumanSpeler.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;

namespace HenE.Abdul.Game_OX
{
    public class HumanSpeler : Speler
    {
        public HumanSpeler(string naam) : base(naam)
        {
        }

        /// <summary>
        /// vraag aan de speler welke zet hij wil doen.
        /// </summary>
        /// <param name="bord">het bord waarp gespeeld wordt</param>
        /// <returns>index van het veld op het bord</returns>
        public override short BepaalZet(Bord bord)
        {
            // vraag aan de gebruiker wat hij/zij wil doen?
            Console.WriteLine("Welke zet wil je doen ?");
            short spelerKeuze = 0;
            List<short> vrijeVelden = bord.VrijVelden();

            do
            {
                Console.Write("Kies een nummer ");

                foreach (short vrijVeld in vrijeVelden)
                {
                    Console.Write(vrijVeld.ToString() + ", ");
                }

                Console.WriteLine();
                string splelerKiest = Console.ReadLine();
                if (short.TryParse(splelerKiest, out spelerKeuze))
                {
                    spelerKeuze = short.Parse(splelerKiest);
                }
                else
                {
                    while (!short.TryParse(splelerKiest, out spelerKeuze))
                    {
                        Console.WriteLine("U hebt geen nummer ingevoerd");
                        splelerKiest = Console.ReadLine();
                        short.TryParse(splelerKiest, out spelerKeuze);
                    }
                }
            }
            while (vrijeVelden.IndexOf(spelerKeuze) < 0);
            int GebruikerNummer = spelerKeuze;
            return (short)GebruikerNummer;
        }
    }
}
