using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Polus.Task1
{
    class Program
    {

        static void Main(string[] args)
        {
            IRepository repository = new FileRepository();

            //Для работы программы необходимо указать директорию с файлами
            string directory = Directory.GetCurrentDirectory();

            int minLengthOfWord = 6;

            Dictionary<string, string[]> inputDataDictionary = repository.GetData(directory, minLengthOfWord);
            Console.WriteLine(Thread.CurrentThread.IsAlive);
            Thread.Sleep(500);


            var popularWords = new FindMostPopularWords(inputDataDictionary);
            int quantityWords = 10;

            Dictionary<string, string[]> mostPoplulatWordsByFile = popularWords.GetMostPopularWordsByFile(quantityWords);
            string[] mostPoplulatWords = popularWords.GetMostPopularWords(quantityWords);
            ShowMostPopularWordsByFileOnConsole(mostPoplulatWordsByFile);

            Console.WriteLine($"{quantityWords} наиболее популярных слов во всех файлах:");
            ShowMostPopularWordsOnConsole(mostPoplulatWords);

            Console.ReadLine();
        }


        private static void ShowMostPopularWordsOnConsole(string[] words)
        {
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        private static void ShowMostPopularWordsByFileOnConsole(Dictionary<string, string[]> words)
        {
            foreach (var item in words)
            {
                Console.WriteLine(item.Key);
                ShowMostPopularWordsOnConsole(item.Value);
            }
        }


    }
}
