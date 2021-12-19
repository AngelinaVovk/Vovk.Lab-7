using System;
namespace Vovk.Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string a = Convert.ToString(Console.ReadLine());
            String[] w = a.Split(" ");
            string firstWord = w[0];
            string secondWord = w[1];
            w[0] = secondWord;
            w[1] = firstWord;
            string c = string.Join(" ", w);
            Console.WriteLine(c);
        }
    }
}
            
                
       




