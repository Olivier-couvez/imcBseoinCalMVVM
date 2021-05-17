﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImcPoidsMVVM.Models
{
    public class Sujet
    {
        #region attributs
        private bool sexe; //true -> Female , false -> Male
        private int taillecm;
        private decimal imc; // indice de masse corporelle
        private decimal poids; // poids calculé selon la formule de Lorentz
        private decimal poidsIdeal; // poids calculé selon la formule de Devine
        private string categorie;
        private int age;
        private decimal coef;
        private decimal besoinCalorie;
        #endregion

        #region proprietes

        public int Taillecm { get => taillecm; set => taillecm = value; }
        public bool Sexe { get => sexe; set => sexe = value; }
        public decimal Imc { get => imc; set => imc = value; }
        public decimal Poids { get => poids; set => poids = value; }
        public decimal PoidsIdeal { get => poidsIdeal; set => poidsIdeal = value; }
        public string Categorie { get => categorie; set => categorie = value; }
        public int Age { get => age; set => age = value; }
        public decimal Coef { get => coef; set => coef = value; }
        public decimal BesoinCalorie { get => besoinCalorie; set => besoinCalorie = value; }

        #endregion


        #region methodes
        public Sujet()
        {
            Taillecm = int.MinValue;
            Imc = decimal.MinValue;
            Poids = decimal.MinValue;
            PoidsIdeal = decimal.MinValue;
            categorie = string.Empty;
            age = int.MinValue;
            coef = decimal.MinValue;
            besoinCalorie = decimal.MinValue;
        }


        #endregion
    }
}
