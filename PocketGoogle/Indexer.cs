using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PocketGoogle;

public class Indexer : IIndexer
{
    //<Слово, <Номер документа, Список[порядковый индекс слова в документе]> >
    private Dictionary<string, Dictionary<int, List<int>>> _wordsIndex =
        new Dictionary<string, Dictionary<int, List<int>>>();

    private string[] GetWords(string input)
    {
        List<string> result = new List<string>();
        var matches = Regex.Matches(input, @"([\w]+|[\s.,!?:-])");
        foreach (Match match in matches)
        {
            if (!string.IsNullOrEmpty(match.Value))
                result.Add(match.Value);
        }

        return result.ToArray();
    }

    //Add. Этот метод должен индексировать все слова в документе.
    //Разделители слов: { ' ', '.', ',', '!', '?', ':', '-','\r','\n' };
    //Сложность – O(document.Length)
    public void Add(int id, string documentText)
    {
        var separators = new[] { " ", ".", ",", "!", "?", ":", "-", "\r", "\n" };
        string[] words = GetWords(documentText);
        for (int i = 0; i < words.Length; i++)
        {
            if (!separators.Contains(words[i]))
            {
                if (!_wordsIndex.ContainsKey(words[i]))
                {
                    _wordsIndex.Add(words[i], new Dictionary<int, List<int>>());
                    _wordsIndex[words[i]].Add(id, new List<int>());
                }

                if (!_wordsIndex[words[i]].ContainsKey(id))
                {
                    _wordsIndex[words[i]].Add(id, new List<int>());
                }

                _wordsIndex[words[i]][id].Add(i);
            }
        }
    }

    //Этот метод должен искать по слову все id документов, где оно встречается.
    //Сложность — O(result), где result — размер ответа на запрос
    public List<int> GetIds(string word)
    {
        return !_wordsIndex.ContainsKey(word) ? new List<int>() : _wordsIndex[word].Keys.ToList();
    }

    //Этот метод по слову и id документа должен искать все позиции, в которых слово начинается.
    //Сложность — O(result)
    public List<int> GetPositions(int id, string word)
    {
        return !_wordsIndex.ContainsKey(word) ? new List<int>() :
            !_wordsIndex[word].ContainsKey(id) ? new List<int>() : _wordsIndex[word][id];
    }

    //Этот метод должен удалять документ из индекса, после чего слова в нем искаться больше не должны.
    //Сложность — O(document.Length)
    public void Remove(int id)
    {
        foreach (var wordData in _wordsIndex)
        {
            _wordsIndex[wordData.Key].Remove(id);
        }
    }
}