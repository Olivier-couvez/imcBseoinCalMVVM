using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImcPoidsMVVM.Models
{
    class CalculIMCPoids
    {
        private Sujet MonModele;

        #region Propriétés

        
        #endregion

        public CalculIMCPoids(Sujet sujetEtudie)
            {
                        MonModele = sujetEtudie;
            }

        #region Méthodes
        public void CalculeIMC()
        {
            decimal imcC;
            decimal taille;

            taille = Convert.ToDecimal(MonModele.Taillecm / 100.0);
            taille = taille * taille;
            imcC = decimal.Divide(MonModele.Poids, taille);
            MonModele.Imc = decimal.Round(imcC, 2);
        }

        public void PoidsIdealH()
        {

            decimal PoidsLH = (MonModele.Taillecm - 100) - ((MonModele.Taillecm - 150) / 4);
            decimal PoidsDH = 50 + (decimal)(2.3 * ((MonModele.Taillecm / 2.54) - 60));
            MonModele.PoidsIdeal = decimal.Round((PoidsDH + PoidsLH) / 2, 1);

            // calcul besoin calorie

            decimal besoinMifflin = (10 * MonModele.Poids) + (6.25M * MonModele.Taillecm) - (5 * MonModele.Age) + 5;
            decimal besoinHarris = (13.397M * MonModele.Poids) + (4.799M * MonModele.Taillecm) - (5.677M * MonModele.Age) + 88.362M;
            MonModele.BesoinCalorie = ((besoinHarris + besoinMifflin) / 2) * MonModele.Coef;
        }

        public void PoidsIdealF()
        {

            decimal PoidsLF= (MonModele.Taillecm - 100) - ((10 * (MonModele.Taillecm - 150)) / 25);
            decimal PoidsDF= 45 + (decimal)(2.3 * ((MonModele.Taillecm / 2.54) - 60));
            MonModele.PoidsIdeal = decimal.Round((PoidsDF + PoidsLF) / 2, 1);

            // calcul besoin calorie

            decimal besoinMifflin = (10 * MonModele.Poids) + (6.25M * MonModele.Taillecm) - (5 * MonModele.Age) - 161;
            decimal besoinHarris = (9.24M * MonModele.Poids) + (3.098M * MonModele.Taillecm) - (4.330M * MonModele.Age) + 447.593M;
            MonModele.BesoinCalorie = ((besoinHarris + besoinMifflin) / 2) * MonModele.Coef;
        }

        public void Categorie()
        {
            if (MonModele.Imc < 16)
                MonModele.Categorie = "Maigreur Sévère";
            if ((MonModele.Imc < 19) && (MonModele.Imc > 16))
                MonModele.Categorie = "Maigreur";
            if ((MonModele.Imc < 25) && (MonModele.Imc > 19))
                MonModele.Categorie = "Normal";
            if ((MonModele.Imc < 30) && (MonModele.Imc > 25))
                MonModele.Categorie = "Surcharge";
            if ((MonModele.Imc < 35) && (MonModele.Imc > 30))
                MonModele.Categorie = "Obésité";
            if ((MonModele.Imc <40 ) && (MonModele.Imc > 35))
                MonModele.Categorie = "Obésité Modérée";
            if ((MonModele.Imc > 40))
                MonModele.Categorie = "Obésité Morbide";


        }

        #endregion
    }
}
