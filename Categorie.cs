
namespace BibliothequeFilm
{
    public class Categorie
    {
        private string nom;
        public string Nom
        {
            get { return nom; }
            set { nom = value;}
        }

        private string cote;
        public string Cote
        {
            get { return cote; }
            set { cote = value; }
        }

        public Categorie()
        {
            Nom = "";
            Cote = "";
        }

        public Categorie(string nom, string cote)
        {
            Nom = nom;
            Cote = cote;
        }

        public override string ToString()
        {
            return "La catégorie se nomme " + Nom + " et la cote est " + Cote;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || (!(obj is Categorie)))
                return false;

            return (Nom.Equals((obj as Categorie).Nom));
        }

        public override int GetHashCode()
        {
            return (Nom.Length);
        }
    }
}
