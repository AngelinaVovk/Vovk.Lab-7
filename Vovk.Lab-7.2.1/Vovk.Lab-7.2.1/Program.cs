using System;
namespace Vovk.Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            string w = Convert.ToString(Console.ReadLine());
            char[] letter = {'*'};
            string[] a = w.Split(letter);
            int b = a.Length;
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine(w.Replace("А","*"));

            }
        }
    }
}
