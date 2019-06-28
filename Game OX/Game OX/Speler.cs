// <copyright file="Speler.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;

namespace HenE.Abdul.Game_OX
{
    /// <summary>
    /// Hier staat een abstract class met Gets en sets prop.
    /// </summary>
    public abstract class Speler
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Speler"/> class.</summary>
        /// <param name="naam">De naam van de speler.</param>
        public Speler(string naam)
        {
            this.Naam = naam;
        }

        /// <summary>
        /// Gets or sets de naam van de spelers.
        /// </summary>
        public string Naam { get; set; }

        /// <summary>
        ///
        /// </summary>
        public int Punten { get; private set; }

        public Teken TeGebruikenTeken { get; set; }

        public void Zet(Bord bord)
        {
            short indexOpHetBord = 0;

            // is de zet valid?
            do
            {
                indexOpHetBord = this.BepaalZet(bord);
            }
            while (!bord.IsValidZet(indexOpHetBord));

            bord.DoeZet(this, indexOpHetBord);
        }

        /// <summary>
        /// functie om te bepalen welke set de gebruiker wil doen.
        /// </summary>
        /// <param name="bord">het bord waarmee gespeeld wordt. </param>
        /// <returns>de index van het vakje op het bord. </returns>
        public abstract short BepaalZet(Bord bord);

        /// <summary>
        ///
        /// </summary>
        /// <param name="bord"></param>
        public void BeeindigBord(Bord bord)
        {
            // ben ik winnaar?
            // ja geef me dan een punt
            this.Punten++;
        }
    }
}
