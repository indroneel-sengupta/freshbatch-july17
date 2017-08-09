using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class Vowel
    {
        public void CheckVowel()
        {
            Console.WriteLine("Please Enter the Alphabet");
            char v = Convert.ToChar(Console.ReadLine());

            switch (v)
            {
                case 'a':
                case 'A':
                case 'e':
                case 'E':
                case 'i':
                case 'I':
                case 'o':
                case 'O':
                case 'u':
                case 'U':
                    Console.WriteLine("The Alphabet is a Vowel : "+v);
                    break;
                default:
                    Console.WriteLine("The Alphabet is a Consonent : " + v);
                    break;

            }
        }
    }
}
