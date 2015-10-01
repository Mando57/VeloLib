using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeloLib
{
    public class VeloElectrique : Velo
    {
        private int puissanceMoteur;
        private int tensionMoteur;
        private double capaciteBatterie;
        private double capaciteRestante;
        /**
         * Constructeur par défaut de la classe VeloElectrique
         */
        public VeloElectrique():base()
        {
            this.puissanceMoteur = 250;
            this.tensionMoteur = 36;
            this.capaciteBatterie = 10;
            this.capaciteRestante = 10;
        }
        /**
         * Constructeur paramétré de la classe VeloElectrique
         * @param puissanceMoteur
         * @param tensionMoteur
         * @param capaciteBatterie
         * @param capaciteRestante
         * @param tailleCadre
         * @param couleur
         * @param pignon
         * @param poids 
         */
        public VeloElectrique(int puissanceMoteur, int tensionMoteur, double capaciteBatterie, double capaciteRestante, String tailleCadre, String couleur, int pignon, double poids) : base(tailleCadre, couleur, pignon, poids)
        {    
            this.puissanceMoteur = puissanceMoteur;
            this.tensionMoteur = tensionMoteur;
            this.capaciteBatterie = capaciteBatterie;
            this.capaciteRestante = capaciteRestante;
        }

        /**
         * Recharge la capacité de la batterie
         */
        public void chargerBatterie()
        {
            capaciteRestante = capaciteBatterie;
        }
        /**
         * Indique la consommation en ampère du moteur en Ampère
         * @return 
         */
        public double consommationMoteurA()
        {
            return puissanceMoteur / tensionMoteur;
        }
        /**
         * Indique le temps d'utilisation possible du vélo électrique avec une batterie pleine
         * @return 
         */
        public double tempsUtilisation()
        {
            return capaciteBatterie / consommationMoteurA();
        }
        /**
         * Indique l'autonomie totale en km possible avec la batterie pleine
         * @param vitesse
         * @return 
         */
        public double autonomieTotaleKm(int vitesse)
        {
            return tempsUtilisation() * vitesse;
        }
        /**
         * Indique la consommation moyenne en Watt du vélo électrique à la vitesse indiquée en paramètre
         * @param vitesse
         * @return 
         */
        public double consommationMoyenneW(int vitesse)
        {
            return puissanceMoteur * tempsUtilisation() / autonomieTotaleKm(vitesse);
        }
        /**
         * Diminue la capacité restante de la batterie s'il est possible de parcourir la distance passée en paramètre
         * @param vitesse
         * @param distance 
         */
        public void rouler(int vitesse, double distance)
        {
            double intensiteConsommee = consommationMoyenneW(vitesse) / tensionMoteur * distance;
            Console.WriteLine("Consommation de " + intensiteConsommee + "A");
            if (intensiteConsommee < capaciteRestante)
                capaciteRestante -= intensiteConsommee;
            else
                Console.WriteLine("Plus assez de batterie restante pour faire " + distance + "km");
        }
        /**
         * Indique l'autonomie en km possible à la vitesse indiquée
         * @param vitesse
         * @return 
         */
        public double autonomieKm(int vitesse)
        {
            return capaciteRestante / consommationMoteurA() * vitesse;
        }
        /**
         * Améliore la capacité de la batterie du vélo électrique
         */
        public void upgrader()
        {
            base.upgrader();
            capaciteBatterie *= 1.2;
        }
        /**
         * Indique le nombre de trajets qu'il est possible de réaliser avec l'autonomie restante
         * @param distance
         * @param vitesse
         * @return 
         */
        public int nbTrajets(double distance, int vitesse)
        {
            return (int)(autonomieKm(vitesse) / distance);
        }
    }
}
