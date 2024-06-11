using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Как можно было еще решить эту задачу?
class Program
{
    static void Main(string[] args)
    {
        string text = File.ReadAllText(args[0]);
        string noPunctuationText = new string(text.ToLower().Where(c => !char.IsPunctuation(c)).ToArray());
        char[] delimiters = new char[] { ' ', '\r', '\n' };
        string[] strings = noPunctuationText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string,int> wordFrequency = new Dictionary<string,int>();
        HashSet<string> uniqueWords = new HashSet<string>(strings);
        foreach (string s in strings)
        {
            if (wordFrequency.ContainsKey(s))
            {
                wordFrequency[s]++;
            }
            else
            {
                wordFrequency[s] = 1;
            }
        }
        Console.WriteLine("10 самых частых слов в книге:");
        foreach (var word in wordFrequency.OrderByDescending(x => x.Value).Take(10))
        {
            Console.WriteLine($"{word.Key} - {word.Value} раз(а)");
        }
        Console.WriteLine($"Количество уникальных слов: {uniqueWords.Count}");
    }
}