using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polus.Task1
{
    public class FindMostPopularWords
    {
        private readonly Dictionary<string, string[]> _dictionary;

        public FindMostPopularWords(Dictionary<string, string[]> dictionary)
        {
            _dictionary = dictionary;
        }

        /// <summary>
        /// Вернуть Словарь наиболее популярных слов по каждому элементу исходного словаря
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public Dictionary<string, string[]> GetMostPopularWordsByFile(int quantity)
        {
            Dictionary<string, string[]> result = new Dictionary<string, string[]>();

            foreach (var item in _dictionary)
            {
                string[] mostPopularWords = null;

                Parallel.Invoke(() => mostPopularWords = FindMostPopularWordsCommon(item.Value, quantity));

                StringBuilder bookStats = new StringBuilder($"{quantity} наиболее часто встречающихся слов в файле {item.Key} :\n");
                foreach (string word in mostPopularWords)
                {
                    bookStats.AppendLine(word);
                }
                result.Add($"{quantity} наиболее часто встречающихся слов в файле {item.Key}:", mostPopularWords);

            }
            return result;
        }
        /// <summary>
        /// Вернуть массив наиболее популярных слов во всем словаре
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public string[] GetMostPopularWords(int quantity)
        {
            string[] mostPopularWords = null;
            List<string> wordsList = new List<string>();

            foreach (var item in _dictionary)
            {
                wordsList.AddRange(item.Value);
            }
            Parallel.Invoke(() => mostPopularWords = FindMostPopularWordsCommon(wordsList.ToArray(), quantity));

            return mostPopularWords;
        }

        /// <summary>
        /// Выбрать топ наиболее популярных слов
        /// </summary>
        /// <param name="words">Массив слов</param>
        /// <param name="quantity">Топ</param>
        /// <returns></returns>
        private string[] FindMostPopularWordsCommon(string[] words, int quantity)
        {
            return words
                .AsParallel()
                .GroupBy(w => w)
                .OrderByDescending(w => w.Count())
                .Select(w => w.Key)
                .Take(quantity)
                .ToArray();
        }
    }
}
