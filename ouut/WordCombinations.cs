using System;
using System.Linq;

//ouut (Object Under Unit Test)
namespace ouut
{
    public class WordCombinations 
    {
        public String[] findWords(params string[] args)
        {
                if (args.Count() == 0)
                {
                    return new String[] { "" };
                }
                else
                {
                    String[] oldWords = findWords(args.Skip(1).ToArray());
                    String[] newWords = oldWords.Where(word => word == "" || word.Split(new String[] { " " }, 
                        StringSplitOptions.RemoveEmptyEntries)[0] == args[1])
                            .Select(word => (args[0] + " " + word).Trim()).ToArray();

                    return oldWords.Union(newWords).ToArray();
                }
        }
    }
}