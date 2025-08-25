using BibliothequeFilm2025.Models;

namespace BibliothequeFilm2025.Controleurs
{
    public class BibliothequeFilmControleur()
    {
        public void AjouterActeur(string nom, string prenom, int anneeNaissance, int anneeDebutCinema, int nombreFilmParticipe, double salaireParFilm)
        {
            monfilm.AjouterActeur(new Acteur(nom, prenom, anneeNaissance, anneeDebutCinema, nombreFilmParticipe, salaireParFilm));
        }
    }
}