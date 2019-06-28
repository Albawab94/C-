// <copyright file="spel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;

namespace HenE.Abdul.Game_OX
{
    /// <summary>
    ///
    /// </summary>
    public class Spel
    {
        private IList<Speler> _spelers = new List<Speler>();
        private Bord _huidigeBord;

        public Teken[] GetMogelijkeTekens
        {
            get
            {
                // welke tekens zijn nog aanwezig?
                if (this._spelers.Count > 0)
                {
                    // welk teken heeft de speler al in gebruik, dan mag het andere teken gebruitk worden;
                    // todo
                    return new Teken[] { Teken.O, Teken.X };
                }

                return new Teken[] { Teken.O, Teken.X };
            }
        }

        /// <summary>
        /// Dit start het spel.
        /// </summary>
        /// <param name="dimension">Het formaat van het bord.</param>
        /// <returns>Het getekende bord.</returns>
        public Bord Start(short dimension)
        {
            // maak een bord, met de jusite dimension
            // hoe bepaal je wie mag beginnen?
            this._huidigeBord = new Bord(dimension, this);
            Teken teken = new Teken();

            // wie begint?
            this._huidigeBord.TekenBord();

            Speler huidigeSpeler = _spelers[0];

            while (!this._huidigeBord.IsBordFinished())
            {
                List<short> vrij = _huidigeBord.VrijVelden();

                // teken het bord
                // vraag aan speler 1 wat hij wil doen
                Console.Write(huidigeSpeler.Naam + " : Kies maar een nummer ");
                foreach (short v in vrij)
                {
                    Console.Write(v.ToString() + ", ");
                }
                Console.WriteLine();
                huidigeSpeler.Zet(this._huidigeBord);
                this._huidigeBord.TekenBord();
                if (this._huidigeBord.HeeftTekenGewonnen(huidigeSpeler.TeGebruikenTeken) )
                {
                    Console.WriteLine(huidigeSpeler.Naam + " : Hoera je bent gewonnen !!!!");
                    this._huidigeBord.ResetBord();
                }

                huidigeSpeler = this.TegenSpeler(huidigeSpeler);
            }

            Console.WriteLine("Het boord is vol !!!");

            return this._huidigeBord;
        }

        public Speler TegenSpeler(Speler huidigeSpeler)
        {
            foreach (Speler speler in this._spelers)
            {
                if (speler != huidigeSpeler)
                {
                    return speler;
                }
            }

            return null;
        }

        /// <summary>
        /// Deze method geef een nieuwe speler als de speler niet al bestaat.
        /// </summary>
        /// <param name="naam">De naam van de human speler</param>
        /// <param name="teken">welek teken gaat de spelr gebruiken.</param>
        /// <returns>Deze method geeft een neuwie speler terug.</returns>
        public Speler AddHumanSpeler(string naam, Teken teken)
        {
            // bestaat deze speler al?
            if (this.FindSpelerByNaam(naam) != null)
            {
                throw new Exception("Speler bestaat al");
            }

            Speler speler = new HumanSpeler(naam);
            speler.TeGebruikenTeken = teken;
            this._spelers.Add(speler);

            return speler;
        }

        public Speler AddComputerSpeler(string naam, Teken teken)
        {
            Speler computerSpeler = new ComputerSpeler(naam);
            computerSpeler.TeGebruikenTeken = teken;
            this._spelers.Add(computerSpeler);

            return computerSpeler;
        }

        /// <summary>
        /// Deze method zoekt of de naam van de niuwe speler al bastaat.
        /// </summary>
        /// <param name="naam">De naam van de speler.</param>
        /// <returns>De niuwe speler.</returns>

        public Speler FindSpelerByNaam(string naam)
        {
            foreach (Speler speler in this._spelers)
            {
                if (speler.Naam == naam)
                {
                    return speler;
                }
            }

            return null;
        }
    }
}