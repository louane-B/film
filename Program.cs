using System;

namespace BibliothequeFilm
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez entrer le nom du Film...");

            Film film1 = new Film(Console.ReadLine(), "Anglais", 2008, 152, 9, "Action", "16+");
            Console.WriteLine(film1);

            Acteur acteur1 = new Acteur("Bale", "Christian", 1974, 1986, 48, 1000000);
            film1.AjouterActeur(acteur1);
            Acteur acteur2 = new Acteur("Ledger", "Heath", 1979, 1992, 23, 500000);
            film1.AjouterActeur(acteur2);
            Acteur acteur3 = new Acteur("Eckhart", "Aaron", 1968, 1992, 38, 700000);
            film1.AjouterActeur(acteur3);

            Console.WriteLine("");
            Console.WriteLine("Liste des acteurs...");
            Console.WriteLine("");

            film1.AfficherActeurs();

            Console.WriteLine("");
            Console.WriteLine("Informations sur le film...");
            Console.WriteLine("");

            Console.WriteLine("Le film a " + film1.GetNombreActeur() + " acteur(s).");
            Console.WriteLine("Le film a coûté " + film1.CalculerBudget() + "$ en budget d'acteur(s).");
            Console.WriteLine("La moyenne d'âge des acteurs du film est de " + film1.CalculerAgeMoyenActeur() + " an(s).");

            Console.ReadKey();
        }
    }
}
