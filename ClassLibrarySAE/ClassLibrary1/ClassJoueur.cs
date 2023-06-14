public class Joueur
{
    //propriétés
    private string _nom; // nom du joueur

    //constructeur
    public Joueur(string Nom)
    {
        // Création du joueur
        _nom = Nom;
    }

    // getters et setters
    public string nom
    {
        get
        {
            return _nom;
        }
    }
}