using System;
namespace Vovk.Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            string w = Convert.ToString(Console.ReadLine());
            char[] slova = { ' ' };
            string[] a = w.Split(slova);
            int b = a.Length;
            string firstword = a[0];
            string secondword = a[1];
            for (int i = 0; i < b; i++)
            {
                if (a[i] == firstword)
                {
                    a[i] = secondword;
                    continue;
                }
                if (a[i] == secondword)
                    a[i] = firstword;
            }
            string c = String.Join(" ", a);
            Console.WriteLine(c);
        }
    }
}






