// <copyright file="Actie.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;

namespace HenE.Abdul.Game_OX
{
    class Actie
    {
        private IList<Speler> _spelers = new List<Speler>();

        /// <summary>
        /// Als de spel begint spelen dan start deze mehtod.
        /// </summary>
        /// <param name="speler">De naam van de speler.</param>
        /// <param name="dimensionVanDeBord">Hoe veel kolomen en rijen.</param>
        public void StartDeSpel(string speler, int dimensionVanDeBord, Teken teken)
        {
            // De speler voer .
            Console.WriteLine(speler + " Voer het kolomnummer toe dat u wilt invoeren ?");
            int spelerKolomNummer;
            string spelerKolom = Console.ReadLine();
            while (!int.TryParse(spelerKolom, out spelerKolomNummer) || (spelerKolomNummer > dimensionVanDeBord || spelerKolomNummer < 1))
            {
                Console.WriteLine("Je mag alleen nummer invoeren of geef graag een nummer tussen 0 en " + dimensionVanDeBord);
                spelerKolom = Console.ReadLine();
            }

            Console.WriteLine(speler + " Voer het rijnummer toe dat u wilt invoeren ?");
            int spelerRijNummer;
            string spelerRij = Console.ReadLine();
            while (!int.TryParse(spelerRij, out spelerRijNummer) || (spelerRijNummer > dimensionVanDeBord || spelerRijNummer < 1))
            {
                Console.WriteLine("Je mag alleen nummer invoeren of geef graag een nummer tussen 1 en " + dimensionVanDeBord);
                spelerRij = Console.ReadLine();
            }

            this.AddItemToArray(dimensionVanDeBord, spelerKolomNummer, spelerRijNummer, teken);

            Console.WriteLine(speler);
        }

        public void AddItemToArray(int dimension, int spelerKolom, int spelerRij, Teken teken)
        {
           Teken[,] kolomsEnRijen = new Teken[dimension, dimension];

           int spelerKolomInArray = spelerKolom - 1;
           int spelerRijInArray = spelerRij - 1;

           Console.WriteLine(kolomsEnRijen[spelerKolomInArray, spelerRijInArray]);
           switch (kolomsEnRijen[spelerKolomInArray, spelerRijInArray])
            {
                case Teken.O:
                    Console.WriteLine("Can't");
                    break;
                case Teken.X:
                    Console.WriteLine("Can't");
                    break;
                default:

                    kolomsEnRijen[spelerKolomInArray, spelerRijInArray] = teken;
                    break;
            }

           Console.WriteLine(kolomsEnRijen[spelerKolomInArray, spelerRijInArray]);
        }
    }
}
