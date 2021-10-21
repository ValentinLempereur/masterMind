using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class Program
    {
        //un commentaire meme si c'est n'importe quoi
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
            Afficher(compa);
            Console.ReadLine();



        }
        static void Afficher(int[] table) {
            for (int i = 0; i < 4; i++) {
                Console.Write(table[i]);       
            }
        }

        static void Comparaison(string combiUti, out int[] compa) 
        {
            compa = new int[4];
            for (int i = 0; i <= 3; i++) 
            {
                compa[i] = combiUti[i];
            }
            //Afficher(compa);
        }
    }
}
