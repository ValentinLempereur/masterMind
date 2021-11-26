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
        static void Color(out int[] table, out int[] clone1)
        {
            clone1 = new int[4];
            table = new int[4];
            Random nbr = new Random();
            for (int i = 0; i < 4; i++)
            {           
                table[i] = nbr.Next(1, 7);
            }
            for (int j = 0; j < 4; j++)
            {
                clone1[j] = table[j];
            }
        }
        static void Main(string[] args)
        {
            string reponse = "Vous avez pas trouvez la bonne combinaison, veuillez réessayer";
            string win = "non";
            int[] table;
            int[] compa;
            int white = 0;
            int[] clone1;
            Color(out table, out clone1);
            Afficher(table);
            Console.WriteLine();
            if (win == "non")
            {
                for (int B = 1; B < 13; B++)
                {
                    if (B == 1)
                    {
                        Console.WriteLine("Entrer une combinaison");
                        string combiUti = Console.ReadLine();
                        Comparaison(combiUti, out compa);
                    }
                    else
                    {
                        Console.WriteLine("Entrer une nouvelle combinaison");
                        string combiUti = Console.ReadLine();
                        Comparaison(combiUti, out compa);
                    }
                        Clone(clone1, out table);
                        Red(table, compa, out int red);
                        if (red != 4)
                        {
                            White(table, compa, out white);
                        }
                        else
                        {
                            win = "oui";
                            reponse = "Vous avez gagnez !!";
                            B = 13;
                        }


                        Console.WriteLine("------------------------------------");
                        Console.WriteLine($"Nombre de pions rouge : {red}");
                        Console.WriteLine($"Nombre de pions blanc : {white}");
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine(reponse);
                        if (win == "non") 
                        {
                        Console.WriteLine($"Il vous reste {12 - B} tentative(s)");
                        }
                        Console.WriteLine("Appuyer sur ENTER pour passer à la suite");
                        Console.WriteLine("------------------------------------");
                        Console.ReadLine();
                }
            }



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

        //clone du tableau
        static void Clone(int[] clone1, out int[] table) 
        {
            table = new int[4];
            for (int j = 0; j <= 3; j++)
            {
                table[j] = clone1[j];
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
                    table[i] = -1;
                    compa[i] = -2;
                    red++; 
                }
            }
        }

        //recherche de pions blanc 

        static void White(int[] table, int[] compa, out int white)
        {
            white = 0;

            {
                for (int i = 0; i <= 3; i++)
                {
                    for (int f = 0; f <= 3; f++)
                    {
                        if (compa[i] == table[f])
                        {
                            compa[i] = -3;
                            white++;

                        }
                    }
                }
            }
        }

    }
}
