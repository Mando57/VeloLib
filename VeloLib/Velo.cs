using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeloLib
{
    public class Velo
    {
        private String tailleCadre;
        private String couleur;
        private int pignon;
        private double poids;


        public Velo()
        {
            this.tailleCadre = "M";
            this.couleur = "bleu";
            this.pignon = 21;
            this.poids = 11.5;
        }

        public Velo(String tailleCadre, String couleur, int pignon, double poids)
        {
            this.tailleCadre = tailleCadre;
            this.couleur = couleur;
            this.pignon = pignon;
            this.poids = poids;
        }

        public String getTailleCadre()
        {
            return tailleCadre;
        }

        public String getCouleur()
        {
            return couleur;
        }

        public void setCouleur(String couleur)
        {
            this.couleur = couleur;
        }

        public int getPignon()
        {
            return pignon;
        }

        public void setPignon(int pignon)
        {
            this.pignon = pignon;
        }

        public double getPoids()
        {
            return poids;
        }

        public void setPoids(double poids)
        {
            this.poids = poids;
        }

        public void changerPignon(int pignon)
        {
            this.pignon = pignon;
        }
        public void repeindre(String couleur)
        {
            this.couleur = couleur;
        }
        public void repeindre()
        {
            this.couleur = "blanc";
        }
        public void upgrader()
        {
            this.couleur = "dégradé";
        }
    }
}
