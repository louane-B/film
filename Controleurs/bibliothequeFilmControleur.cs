using BibliothequeFilm2025.Models;

namespace BibliothequeFilm2025.Controleurs
{
    private film monfilm;
    public class BibliothequeFilmControleur()
    {
        public void AjouterActeur(string nom, string prenom, int anneeNaissance, int anneeDebutCinema, int nombreFilmParticipe, double salaireParFilm)
        {
            monfilm.AjouterActeur(new Acteur(nom, prenom, anneeNaissance, anneeDebutCinema, nombreFilmParticipe, salaireParFilm));
        }

        public string GetListeActeurs()
        {
            return monfilm.GetListeActeurs();
        }

        public int GetNombreActeur()
        {
            return monfilm.GetNombreActeur();
        }

        public double GetBudgetFilm()
        {
            return monfilm.CalculerBudget();
        }

        public int GetMoyenneAgeActeur()
        {
            return monfilm.CalculerAgeMoyenActeur();
        }
    }
}