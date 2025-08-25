using System;

namespace BibliothequeFilm
{
    public class Acteur
    {
        private string nom;
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        private string prenom;
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        private int anneeNaissance;
        public int AnneeNaissance
        {
            get { return anneeNaissance; }
            set
            {
                if ((value >= 1900) && (value <= DateTime.Now.Year))
                    anneeNaissance = value; 
            }
        }

        private int anneeDebutCinema;
        public int AnneeDebutCinema
        {
            get { return anneeDebutCinema; }
            set 
            {
                if ((value > AnneeNaissance + 3) && (value <= DateTime.Now.Year))
                    anneeDebutCinema = value; 
            }
        }

        private int nombreFilmParticipe;
        public int NombreFilmParticipe
        {
            get { return nombreFilmParticipe; }
            set 
            { 
                if(value >= 0)
                    nombreFilmParticipe = value; 
            }
        }

        private double salaireParFilm;
        public double SalaireParFilm
        {
            get { return salaireParFilm; }
            set 
            { 
                if(value >= 0)
                    salaireParFilm = value; 
            }
        }

        public Acteur()
        {
            Nom = "";
            Prenom = "";
            AnneeNaissance = 1900;
            AnneeDebutCinema = 1920;
            NombreFilmParticipe = 0;
            SalaireParFilm = 0;
        }

        public Acteur(string nom, string prenom, int anneeNaissance, int anneeDebutCinema, int nombreFilmParticipe, double salaireParFilm)
        {
            Nom = nom;
            Prenom = prenom;
            AnneeNaissance = anneeNaissance;
            AnneeDebutCinema = anneeDebutCinema;
            NombreFilmParticipe = nombreFilmParticipe;
            SalaireParFilm = salaireParFilm;
        }

        public int GetAge()
        {
            return DateTime.Now.Year - AnneeNaissance;
        }

        public int GetAgeEn(int uneAnnee)
        {
            return uneAnnee - AnneeNaissance;
        }

        public int GetAnneeExperience()
        {
            return DateTime.Now.Year - AnneeDebutCinema;
        }

        public int GetNombreFilmParAnnee()
        {
            return NombreFilmParticipe / GetAnneeExperience();
        }

        public double GetSalaireAnnuel()
        {
            return GetNombreFilmParAnnee() * salaireParFilm;
        }

        public double GetSalaireTotal()
        {
            return NombreFilmParticipe * SalaireParFilm;
        }
        
		public override string ToString()
		{
            return "L'acteur se nomme " + Nom + " , " + Prenom + ". Il est né en " 
                + AnneeNaissance + " et il a débuté au cinéma en " + AnneeDebutCinema
                + ". Son salaire par film est de " + SalaireParFilm + "$ et il a participé à "
                + NombreFilmParticipe + " film(s).";
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || (!(obj is Acteur)))
                return false;

            return ((Nom.Equals((obj as Acteur).Nom))
                     &&
                   (Prenom.Equals((obj as Acteur).Prenom))
                     &&
                   (AnneeNaissance.Equals((obj as Acteur).AnneeNaissance))
                     &&
                   (AnneeDebutCinema.Equals((obj as Acteur).AnneeDebutCinema)));
        }

        public override int GetHashCode()
        {
            return (Nom.Length) + (2 * Prenom.Length) + (3 * AnneeNaissance) + (4 * AnneeDebutCinema); 
        }
    }
}
