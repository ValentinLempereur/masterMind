﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class Program
    {
        static void Color(out int[] table)
        {
            table = new int[4];
            for (int i = 0; i < 4; i++)
            {

                Random nbr = new Random();
                table[i] = nbr.Next(1, 7);
            }
        }
        static void Main(string[] args)
        {
            int[] table;
            Color(out table);
            Afficher(table);
            Console.ReadLine();
        }
        static void Afficher(int[] table) {
            for (int i = 0; i < 4; i++) {
                Console.Write(table[i]);       
            }
        }
    }
}