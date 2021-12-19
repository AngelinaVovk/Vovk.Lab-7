using System;
namespace Vovk.Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст на русском");
            string w = Convert.ToString(Console.ReadLine());
            Console.WriteLine(w.Replace("А", "*"));
        }
    }
}