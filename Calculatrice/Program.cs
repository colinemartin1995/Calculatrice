﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class Program
    {



        static float SaisirFloat(string prompt)
        {
            string reponse;
            float nombre;
            Console.WriteLine(prompt);
            reponse = Console.ReadLine();
            nombre = float.Parse(reponse);
            return nombre;

        }


        static void Menu()
        {
            bool quitter;
           quitter = false;
            string aurevoir;

            while (quitter == false) { 
           
            string affichemenu;
            string choixmenu;
            affichemenu = " Bonjour, quelle opération souhaitez vous réaliser : + Additionner  - Soustraire  / Diviser * Multiplier  Q Pour quitter";
            Console.WriteLine(affichemenu);
            choixmenu = Console.ReadLine();
            
            if(choixmenu == "+")
            {
                Additionner();
            }

            if(choixmenu == "-")
            {
                Soustraire();
            }
            
            if(choixmenu == "/" )
            {
                Diviser();
            }

            if (choixmenu == "*")
            {
                Multiplier();
            }

            if (choixmenu == "Q")
                {
                    quitter = true;
                }
           }
            
            aurevoir = "Quitter - Au revoir !";
            Console.WriteLine(aurevoir);
        }


        static void Additionner()
        {

            float somme;
            float nmbra;
            float nmbrb;
            string affichea;
            string afficheb;
      



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
            //string reponse1;
           // string reponse2;

            affiche1 = "Veuillez saisir le 1er nombre de votre soustration : ";
            nmbr1 = SaisirFloat(affiche1);
           /* reponse1 = Console.ReadLine();
            nmbr1 = float.Parse(reponse1);*/

            affiche2 = "Veuillez saisir le 2nd nombre de votre soustration : ";
           nmbr2 = SaisirFloat(affiche2);
           /* reponse2 = Console.ReadLine();
            nmbr2 = float.Parse(reponse2);*/

           soustraire = nmbr1 - nmbr2;
            Console.WriteLine("La soustraction vaut : " + soustraire.ToString());





        }

        static void Multiplier()
        {
            float multiplier;
            float nmbr3;
            float nmbr4;
            string affichemultiplier1;
            string affichemultiplier2;
            //string reponse1;
            // string reponse2;

            affichemultiplier1 = "Veuillez saisir le 1er nombre : ";
            nmbr3 = SaisirFloat(affichemultiplier1);
         

            affichemultiplier2 = "Veuillez saisir le 2nd nombre : ";
            nmbr4 = SaisirFloat(affichemultiplier2);
         

            multiplier = nmbr3 * nmbr4;
            Console.WriteLine("La multiplication vaut : " + multiplier.ToString());





        }

        static void Diviser()
        {
            float diviser;
            float nmbrdiviser1;
            float nmbrdiviser2;
            string affichediviser1;
            string affichediviser2;

       
         
          
            affichediviser1 = "Veuillez saisir le 1er nombre : ";
            nmbrdiviser1 = SaisirFloat(affichediviser1);


            affichediviser2 = "Veuillez saisir le 2nd nombre : ";
            nmbrdiviser2= SaisirFloat(affichediviser2);

             while (nmbrdiviser2 == 0)
            {
                Console.WriteLine("Ne pas diviser par 0 !");

                affichediviser2 = "Veuillez saisir le 2nd nombre : ";
                nmbrdiviser2 = SaisirFloat(affichediviser2);
                    

            }

         
                diviser = nmbrdiviser1 / nmbrdiviser2;
                Console.WriteLine("La division vaut : " + diviser.ToString());

          


        }



        static void Main(string[] args)
        {
            /* Pour faire fonctionner la fonction saluer juste noter Saluer();*/
            //Additionner();
            // Soustraire();
            //Multiplier();
            //Diviser();

            Menu();

        }
    }
}
