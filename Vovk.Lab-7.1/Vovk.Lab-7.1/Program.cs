using System;
namespace Vovk.Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string a = Convert.ToString(Console.ReadLine());
            //Возвращает строковый массив, содержащий подстроки данного экземпляра
            String[] w = a.Split(" ");
            string firstWord = w[0];
            string secondWord = w[1];
            w[0] = secondWord;
            w[1] = firstWord;
            //Сцепляет элементы указанного массива или элементы коллекции, помещая между ними заданный разделитель
            string c = string.Join(" ", w);
            Console.WriteLine(c);
        }
    }
}
            
                
       




