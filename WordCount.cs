using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace async_programming
{
    internal class WordCount
    {
        public async Task<Dictionary<string, int>> CountWordsAsync(string filePath)
        {

            string[] lines = await File.ReadAllLinesAsync(filePath);


            return await Task.Run(() =>
            {
                return lines
                    .SelectMany(line => line.Split(new char[] { ' ', '.', ',', '?', '!', '"' }, StringSplitOptions.RemoveEmptyEntries))
                    .Select(word => word.ToLower())
                    .Where(word => word.Any(char.IsLetter))
                    .GroupBy(word => word)
                    .OrderByDescending(group => group.Count())
                    .Take(10)
                    .ToDictionary(group => group.Key, group => group.Count());
            });
        }
    }
}



