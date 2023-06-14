public class Partie
{
    //propriétés
    private Joueur[] _joueurs = new Joueur[1]; //joueurs de la partie
    private bool _typeAdv; // false si adversaire est IA - true si adversaire est Joueur 
    private byte[,] _tailleGrille; //taille de la grille (2D)
    double _gagne; // 1 = rouge gagne / -1 = jaune gagne / 0 = match nul
    int larg;
    int haut;

    //constructeur
    public Partie()
    {
        // Stockage infos par défaut partie
        _tailleGrille = new byte[6,7];
        _typeAdv = true;
    }

    // getters et setters

    public byte[,] TailleGrille
    {
        get
        {
            return _tailleGrille;
        }
    }

    public string nomJ1
    {
        get
        {
            return _joueurs[0].nom;
        }
    }

    public string nomJ2
    {
        get
        {
            return _joueurs[1].nom;
        }
    }

    //méthodes

    public void modifierPartie(bool JoueurVSJoueur, byte[,] TailleGrille)
    {
        // Stockage infos partie
        _typeAdv = JoueurVSJoueur;
        _tailleGrille = TailleGrille;
        int NbCoups = 0;

        // Création des joueurs et de la 1ère manche
        _joueurs[0] = new Joueur(_joueurs[0].nom);
        _joueurs[1] = new Joueur(_joueurs[1].nom);

        while (NbCoups < 6 * 7)
        {
            Place(TailleGrille,6,7);
        }
        Termine();
    }

    public void Place(byte[,] GrilleJeu, int haut, int larg)
    {
        //Colonne : numéro de colonne dans laquelle l'insertion sera faite
        //Place : passe à true quand le pion est placé
        int colonne, pion_y, pion_x;
        bool place = false;

        //Demande d'entrée de la colonne et réinitialisation de place
        Console.WriteLine("Entrer une colonne");
        colonne = Convert.ToInt32(Console.ReadLine());

        //Vérification si l'input est dans les limites
        while (colonne < 1 || colonne > larg)
        {
            Console.WriteLine($"Numéro de colonne doit être compris entre 1 et {larg}");
            colonne = Convert.ToInt32(Console.ReadLine());
        }

        //Tant qu'une case vide est disponible, descendre dans le tableau (puis insérer le pion)
        while (place == false)
        {
            for (int i = 0; i < haut; i++)
            {
                if (i == haut - 1 || GrilleJeu[i + 1, colonne - 1] != 0)
                {
                    GrilleJeu[i, colonne - 1] = 1;
                    place = true;
                    pion_y = i;
                    pion_x = colonne - 1;
                    Resultat(GrilleJeu, pion_y, pion_x, haut, larg);
                }
            }
        }
    }
    public void Termine()
    {
        if (_gagne == 1)
        {
            Console.WriteLine($"{_joueurs[0]} a gagné");
        }

        if (_gagne == 0)
        {
            Console.WriteLine("Match Nul");
        }

        if (_gagne == -1)
        {
            Console.WriteLine($"{_joueurs[1]} a gagné");
        }
    }

    public void Resultat(byte[,] Grille, int y, int x, int haut, int larg)
    {
        //Variable qui détermine le nombre de pions qui doivent être alignés pour gagner
        const int align = 4;
        int gagne = 0, i;
        bool verif = true;

        //Vérification sur la ligne au dessus du pion placé
        //(Il est inutile de vérifier directement au dessus du pion car ça ne sera jamais une case remplie)
        if (y - align > 0 && y - align < haut)
        {
            //En haut à gauche
            for (i = 1; i < align; i++)
            {
                if (x - i > 0 && x - i < larg && Grille[y - i, x - i] != 1)
                    verif = false;
            }

            if (verif == true)
                gagne++;
            verif = true;

            //En haut à droite
            for (i = 1; i < align; i++)
            {
                if (x + i > 0 && x + i < larg && Grille[y - i, x + i] != 1)
                    verif = false;
            }

            if (verif == true)
                gagne++;
            verif = true;

        }

        //Vérification sur la même ligne que le pion placé
        if (y - align > 0 && y - align < haut)
        {
            //À gauche
            for (i = 1; i < align; i++)
            {
                if (x - i > 0 && x - i < larg && Grille[y, x - i] != 1)
                    verif = false;
            }

            if (verif == true)
                gagne++;
            verif = true;

            //À droite
            for (i = 1; i < align; i++)
            {
                if (x + i > 0 && x + i < larg && Grille[y, x + i] != 1)
                    verif = false;
            }

            if (verif == true)
                gagne++;
            verif = true;

        }

        //Vérification sur la ligne en dessous du pion placé
        if (y + align > 0 && y + align < haut)
        {
            //En dessous
            for (i = 1; i < align; i++)
            {
                if (x > 0 && x < larg && Grille[y + i, x] != 1)
                    verif = false;
            }

            if (verif == true)
                gagne++;
            verif = true;

            //En dessous à gauche
            for (i = 1; i < align; i++)
            {
                if (x - i > 0 && x - i < larg && Grille[y + i, x - i] != 1)
                    verif = false;
            }

            if (verif == true)
                gagne++;
            verif = true;

            //En dessous à droite
            for (i = 1; i < align; i++)
            {
                if (x + i > 0 && x + i < larg && Grille[y + i, x + i] != 1)
                    verif = false;
            }

            if (verif == true)
                gagne++;
            verif = true;

        }

        //Si l'utilisateur a rempli la condition de victoire, on l'affiche en précisant dans combien de directions il a gagné
        if (gagne > 0)
        {
            Console.WriteLine($"Gagné dans {gagne} directions !");
        }
    }


}