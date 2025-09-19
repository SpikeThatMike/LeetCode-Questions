using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Questions
{
    public class TextJustification
    {
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            List<string> result = [];
            StringBuilder currentLine = new();

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                bool isLastLine = (i + 1 == words.Length);
                
                if (currentLine.Length + word.Length > maxWidth)
                {

                    string line = currentLine.ToString().TrimEnd();
                    int spacesToAdd = maxWidth - line.Length;
                    int countOfSpaces = line.Count(c => c == ' ');

                    if (countOfSpaces == 0)
                    {
                        line = line.PadRight(maxWidth);
                    }
                    else
                    {
                        var spacesBetweenWords = spacesToAdd / countOfSpaces;
                        var extraSpaces = spacesToAdd % countOfSpaces;
                        int lineLength = line.Length;

                        List<int> posInserted = [];
                        
                        for (int x = lineLength - 1; x != 0; x--)
                        {
                            if (line[x] != ' ') continue;

                            line = line.Insert(x, new string(' ', spacesBetweenWords));

                            posInserted.Add(x);

                            for (int y = 0; y < posInserted.Count; y++)
                            {
                                posInserted[y] += 1;
                            }
                        }

                        for (int x = 0; x < extraSpaces; x++)
                        {
                            line = line.Insert(posInserted.LastOrDefault(), new string(' ', 1));
                            posInserted.RemoveAt(posInserted.Count - 1);
                        }
                    }

                    result.Add(line);
                    currentLine.Clear();
                    currentLine.Append(word + " ");

                    if (isLastLine)
                    {
                        line = currentLine.ToString().TrimEnd();
                        line = line.PadRight(maxWidth);
                        result.Add(line);
                    }
                }
                else
                {
                    currentLine.Append(word + " ");

                    if (isLastLine)
                    {
                        string line = currentLine.ToString().TrimEnd();
                        line = line.PadRight(maxWidth);
                        result.Add(line);
                    }
                }
            }

            return result;
        }
    }
}
