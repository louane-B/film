using System;

namespace BibliothequeFilm
{
    public class Program
    {
        static void Main(string[] args)
        {
            BibliothequeFilmControleur controleur = new BibliothequeFilmControleur();
            Console.WriteLine("Veuillez entrer le nom du Film...");

            controleur.Creerfile(console.Readline(), "Anglais", 2000, 152, 9, "Action");
            Console.WriteLine(controleur.GetfilmInfos());

            //Acteur acteur1 = new Acteur("Bale", "Christian", 1974, 1986, 48, 1000000);
            //film1.AjouterActeur(acteur1);
            controleur.AjouterActeur("Bale", "Christian", 1974, 1986, 48, 1000000);
            //Acteur acteur2 = new Acteur("Ledger", "Heath", 1979, 1992, 23, 500000);
            //film1.AjouterActeur(acteur2);
            controleur.AjouterActeur("Ledger", "Heath", 1979, 1992, 23, 500000);
            //Acteur acteur3 = new Acteur("Eckhart", "Aaron", 1968, 1992, 38, 700000);
            //film1.AjouterActeur(acteur3);
            controleur.AjouterActeur("Eckhart", "Aaron", 1968, 1992, 38, 700000);

            Console.WriteLine("");
            Console.WriteLine("Liste des acteurs...");
            Console.WriteLine("");

            Console.WriteLine(controleur.GetListeActeurs());

            Console.WriteLine("");
            Console.WriteLine("Informations sur le film...");
            Console.WriteLine("");

            Console.WriteLine("Le film a " + controleur.GetNombreActeur() + " acteur(s).");
            Console.WriteLine("Le film a coûté " + controleur.CalculerBudget() + "$ en budget d'acteur(s).");
            //Console.WriteLine("La moyenne d'âge des acteurs du film est de " + film1.CalculerAgeMoyenActeur() + " an(s).");

            Console.ReadKey();
        }
    }
}
