using System;
using System.Windows;

namespace Juste_prix
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Déclaration du compteur (en dehors des méthodes pour qu'il ne se réinitialise pas à 0 à chaque clic)
        int attempt = 0;

        //Déclaration de numberToFind (en dehors des méthodes pour qu'il soit accessible dans toutes les méthodes)
        //Déclaration de random pour générer le nombre aléatoire

        private Random random = new Random();
        private int numberToFind = 0;

        public MainWindow()
        {
            InitializeComponent();
            //Attribution du nomberToFind aléatoire compris entre 1 et 50 (+1 exclus)
            numberToFind = random.Next(1, 50) + 1;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int number;
            if(int.TryParse(Input.Text,out number))
            {
                attempt++;
                if (number > numberToFind)
                {
                    Info.Text = "c'est moins !";
                }
                else if (number < numberToFind)
                {
                    Info.Text = "c'est plus !";
                }
                else
                {
                    Info.Text = $"Bravo ! vous avez trouvé en {attempt} essais";
                }
            }
            else
            {
                Info.Text = "erreur saisir un nombre";
            }
            //try
            //{
            //    int userNombresEssais = int.Parse(Input.Text);
            //    if (userNombresEssais > 0 && userNombresEssais < 51) //vérification que le nombre est bien entre 1 et 50
            //    {
            //        counter++; //incémentation du compteur d'essais
            //        if (userNombresEssais > numberToFind) //si l'entrée de l'utilisateur est supérieur au nombre....
            //        {
            //            //MessageBox.Show("C'est moins !", "Le nombre juste !"); //pour que sa s'affiche dans une autre fenetre
            //            Info.Text = "C'est moins !";//pour que je l'affiche directement sur ma page dans la Textbox
            //        }
            //        else if (userNombresEssais < numberToFind) //sinon l'entrée de l'utilisateur est inférieur au nombre....
            //        {
            //            //MessageBox.Show("C'est plus !", "Le nombre juste !");
            //            Info.Text = "C'est plus !";
            //        }
            //        else //sinon c'est gagné avec affichage du nombre de tentatives!
            //        {
            //            //MessageBox.Show($"Vous avez gagné en {counter} essais !", "Le nombre juste !");
            //            Info.Text = $"Bravo, vous avez gagné en {counter} essais!";
            //        }

            //        UpdateTry();
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Erreur de saisie détectée", "Erreur");//pour affiché message d'erreur si c'est pas des chiffres
            //}
            //void UpdateTry()
            //{
            //    NombreEssais.Text = ($"Vous étes à {counter} essais !"); //au début de la page d'accueil j'ai mis "nombres d'essais à: 0"
            //}

        }

    }
}