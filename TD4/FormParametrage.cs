namespace TD4
{
    public partial class FormParametrage : Form
    {
        internal Partie PartieEnCours = new Partie();
        public FormParametrage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            byte[,] taille;

            if (rdoTaille6x7.Checked == true)
                taille = new byte[6,7];
            else if (rdoTaille7x8.Checked == true)
                taille = new byte[7, 8];
            else if(rdoTaille8x9.Checked == true)
                taille = new byte[8, 9];
            else
                taille = new byte[9, 10];

            PartieEnCours.modifierPartie(rdoAdvJoueur.Checked, taille);
            FormJeu frmJeu = new FormJeu();
            frmJeu.Show(this);
            this.Hide();

        }
    }
}