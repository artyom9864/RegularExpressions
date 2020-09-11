using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Регулярные_выражения
{
    class Program
    {
        static readonly Random rndGen = new Random();

        static void Main(string[] args)
        {

            Regex regex = new Regex(@"\w[@]+\w[#]{2}\d{3}\w+[a]{3}\w+");
            var chars = "@aBCDEFGH0123456789##";
            string stroka = null;
            var random = new Random();
            int p = 0;

            for (; ; )
            {
                stroka = "";
                for (int i = 0; i < 20; i++)
                {

                    stroka += chars[random.Next(chars.Length)];
                }
                Console.WriteLine("Рандомная строка: " + stroka);
                MatchCollection matches = regex.Matches(stroka);

                p++;                 
                if (matches.Count > 0)                    
                {
                    foreach (Match lol in matches)
                        Console.WriteLine("Индекс: " + lol.Index);
                    break; 
                }
                else
                {
                    Console.WriteLine("Нет совпадений");

                }
                Console.WriteLine("Результат" + p);
            }
                
              

         
        }
    }
}
