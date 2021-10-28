using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class Program
    {
        //nombre aléatoire
        static void Color(out int[] table)
        {           
            table = new int[4];
            Random nbr = new Random();
            for (int i = 0; i < 4; i++)
            {           
                table[i] = nbr.Next(1, 7);
            }
        }
        static void Main(string[] args)
        {
            int[] table;
            int[] compa;
            Color(out table);
            Afficher(table);
            Console.WriteLine();
            Console.WriteLine("entrer une combinaison");
            string combiUti = Console.ReadLine();
            Comparaison(combiUti, out compa);




            Red(table, compa, out int red);
            Console.WriteLine($"nombre de pions rouge{red}");
            Console.ReadLine();



        }
        //afficher la table
        static void Afficher(int[] table) {
            for (int i = 0; i < 4; i++) {
                Console.Write(table[i]);       
            }
        }

        //mettre le string en tableau
        static void Comparaison(string combiUti, out int[] compa) 
        {
            compa = new int[4];
            for (int i = 0; i <= 3; i++) 
            {
                compa[i] = int.Parse(combiUti[i].ToString());
            }
        }

        //recherche de pions rouges 
        static void Red(int[] table, int[] compa, out int red) 
        {
            red = 0;
            for (int i = 0; i <= 3; i++) 
            {
                if(compa[i] == table[i])
                {
                    red++; 
                }
            }
        }

        //recherche de pions blanc 

        static void White(int[] table, int[] compa, out int white) 
        {
            white = 0;
            for (int i = 0; i <= 3; i++) 
            {
                for (int f = 0; f <= 3; i++) 
                {
                    if (compa[i] == table[f]) 
                    {
                        white++;
                    }
                }
            }
        }

    }
}
