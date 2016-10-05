using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class Program
    {
        static void saluer() //type: ne renvoie rien -> void
        {
            String msg;
            String nom;
            string affiche;
            msg = "Veuillez saisir votre nom";
            Console.WriteLine(msg);
            nom = Console.ReadLine();
            affiche = "Bonjour " + nom;
            Console.WriteLine(affiche);
        }

        static float SaisirFloat(string prompt)
        {
            string reponse;
            float nombre;
            Console.WriteLine(prompt);
            reponse = Console.ReadLine();
            nombre = float.Parse(reponse);
            return nombre;

        }

        static void Additionner()
        {

            float somme;
            float nmbra;
            float nmbrb;
            string affichea;
            string afficheb;
            string reponsea;
            string reponseb;



            affichea = "Veuillez saisir le 1er nombre de votre addition :  ";
            nmbra = SaisirFloat(affichea);
            /* Console.WriteLine(affichea);
             reponsea = Console.ReadLine();
             nmbra = float.Parse(reponsea);*/

            afficheb = "Veuillez saisir le 2nd nombre de votre addition : ";
            nmbrb = SaisirFloat(afficheb);
            /* Console.WriteLine(afficheb);
             reponseb = Console.ReadLine();
             nmbrb = float.Parse(reponseb);*/


            somme = nmbra + nmbrb;
            Console.WriteLine("La somme vaut : " + somme.ToString());
        }

        static void Soustraire()
        {
            float soustraire;
            float nmbr1;
            float nmbr2;
            string affiche1;
            string affiche2;
            string reponse1;
            string reponse2;

            affiche1 = "Veuillez saisir le 1er nombre de votre soustration : ";
            Console.WriteLine(affiche1);
            reponse1 = Console.ReadLine();
            nmbr1 = float.Parse(reponse1);

            affiche2 = "Veuillez saisir le 2nd nombre de votre soustration : ";
            Console.WriteLine(affiche2);
            reponse2 = Console.ReadLine();
            nmbr2 = float.Parse(reponse2);

           soustraire = nmbr1 - nmbr2;
            Console.WriteLine("La soustraction vaut : " + soustraire);





        }
        static void Main(string[] args)
        {
            /* Pour faire fonctionner la fonction saluer juste noter Saluer();*/
            Additionner();
            Soustraire();


        }
    }
}
