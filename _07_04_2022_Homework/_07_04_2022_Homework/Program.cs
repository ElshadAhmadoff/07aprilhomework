using _07_04_2022_Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_04_2022_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<char> letters = new MyList<char>();
            letters.AddItem('a');
            letters.AddItem('b'); 
            letters.AddItem('c');
            letters.AddItem('d');
            letters.AddItem('f');
            letters.AddItem('g');
            for (int i = 0; i < letters._count; i++) Console.Write($"{letters[i]} ");
            Console.ReadLine();
        }
    }
}