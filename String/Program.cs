using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку используя только русские буквы");
            string str = Console.ReadLine().ToLower();
            
            char[] A = { 'я', 'е', 'ё', 'у', 'ы', 'а', 'и', 'о', 'ю', 'э' };
            char[] B = {'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ'};

            string[] words = str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> uniqueWords = new List<string>();

            foreach (string word in words)
            {
                if (!uniqueWords.Contains(word) && A.Contains(word[0]))
                {
                    uniqueWords.Add(word);
                }
            }
            
            foreach (string word in words)
            {
                if (!uniqueWords.Contains(word) && B.Contains(word[0]))
                {
                    uniqueWords.Add(word);
                }          
            }

            string output = string.Join(" ", uniqueWords);

            Console.WriteLine(output);

            Console.ReadLine();
        }
    }
}
