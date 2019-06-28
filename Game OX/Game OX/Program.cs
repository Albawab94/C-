// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using HenE.Abdul.Game_OX;
using System;

namespace Game_OX
{
    class Program
    {
        static void Main(string[] args)
        {
            Spel spel = new Spel();
            //// STap 1 eerste speler toevoegen
            // // vraag aan de gebruiker of hij een human of computer speler wilt toevoegen
            Console.WriteLine("Hoi, Leuk dat je komt spelen, wil je me je naam vertellen?");

            string naamVanDeHuidigeGebruiker = Console.ReadLine();

            Console.WriteLine("Hoi, {0}", naamVanDeHuidigeGebruiker);

            // controleer of er al een speler met die naam in het spel aanwezig is
            while (spel.FindSpelerByNaam(naamVanDeHuidigeGebruiker) != null)
            {
                Console.WriteLine("Deze naam is al in gebruik. Geef aan andere naam op");
                naamVanDeHuidigeGebruiker = Console.ReadLine();
            }

            ConsoleKeyInfo ingegevenTeken;
            Console.WriteLine("Welke teken wil je spelen,  O of X? ");
            ingegevenTeken = Console.ReadKey();

            string naamVanDeTweedeSpeler = string.Empty;
            do
            {
                if (ingegevenTeken.Key == ConsoleKey.O || ingegevenTeken.Key == ConsoleKey.X)
                {
                    switch (ingegevenTeken.Key)
                    {
                        case ConsoleKey.O:
                            spel.AddHumanSpeler(naamVanDeHuidigeGebruiker, Teken.O);
                            break;
                        case ConsoleKey.X:
                            spel.AddHumanSpeler(naamVanDeHuidigeGebruiker, Teken.X);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Je keuze is niet correct .Welke teken wil je spelen,  O of X? ");
                    ingegevenTeken = Console.ReadKey();
                }
            }
            while (ingegevenTeken.Key != ConsoleKey.O && ingegevenTeken.Key != ConsoleKey.X);
            Console.WriteLine();

            // hier nog de vraag of hij tegen de compueter of opersoon wilt spelen
            Console.WriteLine("Wil je tegen de computer spelen , J of N ? ");
            string tegenWieGaSpelen = "";
            tegenWieGaSpelen = Console.ReadLine().ToLower();
            while ((tegenWieGaSpelen != "j") && (tegenWieGaSpelen != "n"))
            {
                Console.WriteLine("Graag type J of N");
                tegenWieGaSpelen = Console.ReadLine().ToLower();
            }

            if (tegenWieGaSpelen == "j")
            {
                switch (ingegevenTeken.Key)
                {
                    case ConsoleKey.X:
                        spel.AddComputerSpeler("Speler", Teken.O);
                        break;
                    case ConsoleKey.O:
                        spel.AddComputerSpeler("Speler", Teken.X);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Voeg de naam van de andre speler toe ?");
                naamVanDeTweedeSpeler = Console.ReadLine();
                while (spel.FindSpelerByNaam(naamVanDeTweedeSpeler) != null)
                {
                    Console.WriteLine("Deze naam is al gebruiken. Voeg even een andere naam toe");
                    naamVanDeTweedeSpeler = Console.ReadLine();
                }

                switch (ingegevenTeken.Key)
                {
                    case ConsoleKey.X:
                        spel.AddHumanSpeler(naamVanDeTweedeSpeler, Teken.O);
                        break;
                    case ConsoleKey.O:
                        spel.AddHumanSpeler(naamVanDeTweedeSpeler, Teken.X);
                        break;
                    default:
                        break;
                }
            }

            // vraag om de dimension van het bord
            short dimensionDeBord = 0;

            do
            {
                Console.WriteLine("Wat is de dimension van het bord ? \" Geef een nummer tussen 2 en 9 \"");
                string readDimension = Console.ReadLine();
                if (short.TryParse(readDimension, out dimensionDeBord))
                {
                    dimensionDeBord = short.Parse(readDimension);
                }
                else
                {
                    Console.WriteLine("U hebt geen nummer ingevoerd");
                }
            }
            while (dimensionDeBord < 2 || dimensionDeBord > 9);

            // start de ronde
            // toon hier welke spelers er zijn, wie heeft welk teken en wie begint
            Bord bord = spel.Start(dimensionDeBord);

            // foreach (Speler speler in spel.)
            Console.ReadKey();
        }
    }
}
