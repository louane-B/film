using System;
using System.Collections.Generic;

namespace BibliothequeFilm
{
    public class Film
    {
        private string titre;
        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }

        private string langue;
        public string Langue
        {
            get { return langue; }
            set { langue = value; }
        }

        private int anneeSortie;
        public int AnneeSortie
        {
            get { return anneeSortie; }
            set { anneeSortie = value; }
        }

        private int dureeEnMinutes;
        public int DureeEnMinutes
        {
            get { return dureeEnMinutes; }
            set { dureeEnMinutes = value; }
        }

        private int evaluation;
        public int Evaluation
        {
            get { return evaluation; }
            set { evaluation = value; }
        }

        private Categorie categorie;
        public String GetNomCategorie()
        {
            return categorie.Nom;
        }

        public String GetCoteCategorie()
        {
            return categorie.Nom;
        }

        public void SetCategorie(string nom, string cote)
        {
            categorie = new Categorie(nom, cote);
        }

        private List<Acteur> listeActeur;

        public Film()
        {
            Titre = "";
            Langue = "";
            AnneeSortie = 1900;
            DureeEnMinutes = 0;
            Evaluation = 0;
            categorie = new Categorie();
            listeActeur = new List<Acteur>();
        }

        public Film(string titre, string langue, int anneeSortie, int dureeEnMinutes, int evaluation, string nomCategorie, string coteCategorie)
        {
            Titre = titre;
            Langue = langue;
            AnneeSortie = anneeSortie;
            DureeEnMinutes = dureeEnMinutes;
            Evaluation = evaluation;
            SetCategorie(nomCategorie, coteCategorie);
            listeActeur = new List<Acteur>();
        }

        public int GetNombreActeur()
        {
            return listeActeur.Count;
        }

        public Acteur GetActeur(Acteur unActeur)
        {
            foreach (Acteur acteur in listeActeur)   
                if (acteur.Equals(unActeur))
                    return acteur;
            return null;
        }

        private bool IsActeurPresent(Acteur unActeur)
        {
            return !(GetActeur(unActeur) == null);
        }

        public bool AjouterActeur(Acteur unActeur)
        {
            if (!IsActeurPresent(unActeur))
            {
                listeActeur.Add(unActeur);
                return (IsActeurPresent(unActeur));
            }
            return false;
        }

        public bool EnleverActeur(Acteur unActeur)
        {
            if (IsActeurPresent(unActeur))
            {
                listeActeur.Remove(unActeur);
                return !(IsActeurPresent(unActeur));
            }
            return false;
        }

        public bool ViderActeur()
        {
            listeActeur.Clear();
            return IsAucunActeur();
        }

        public bool IsAucunActeur()
        {
            return listeActeur.Count == 0;
        }

        public double CalculerBudget()
        {
            double Budget = 0;
            foreach (Acteur acteur in listeActeur)   
            {
                Budget = Budget + acteur.SalaireParFilm;
            }
            return Budget;
        }

        public int CalculerAgeMoyenActeur()
        {
            int SommeAge = 0;
            foreach (Acteur acteur in listeActeur)   
            {
                SommeAge = SommeAge + acteur.GetAge();
            }
            return SommeAge / GetNombreActeur();
        }

        public int CalculerExperienceActeur()
        {
            int SommeExperience = 0;
            foreach (Acteur acteur in listeActeur)   
            {
                SommeExperience = SommeExperience + acteur.GetAnneeExperience();
            }
            return SommeExperience;
        }

        public int CalculerExperienceMoyenActeur()
        {
            return CalculerExperienceActeur() / GetNombreActeur();
        }

        public bool AfficherActeurs()
        {
            foreach (Acteur acteur in listeActeur)   
            {
                Console.WriteLine(acteur.Nom + "," + acteur.Prenom);
            }
            return true;
        }

        public override string ToString()
        {
            return "La film " + Titre + " est en " + Langue + ", dure " 
                + DureeEnMinutes + " minute(s), est sortie en " + AnneeSortie
                + " et a reçu l'évaluation " + Evaluation + "/10.";
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || (!(obj is Film)))
                return false;

            return ((Titre.Equals((obj as Film).Titre))
                    &&
                   (AnneeSortie.Equals((obj as Film).AnneeSortie)));
        }

        public override int GetHashCode()
        {
            return (Titre.Length) + (2 * AnneeSortie);
        }
    }
}
