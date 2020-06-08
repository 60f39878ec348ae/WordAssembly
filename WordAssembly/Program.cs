using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WordAssembly;

namespace WordAssembly
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input.Length < 2 || input.Length > 7)
                return;

            var words = WordAssembly.Properties.Resources.words.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            var list = new List<string>(words);


            Console.WriteLine("Possible words:");
            for (int i = 2; i <= input.Length; i++)
            {
                Console.Title = i.ToString();
                var test = CreateString(input, i);
                foreach (var text in test)
                {
                    if (list.Contains(text))
                    {
                        Console.WriteLine(text);
                    }


                }
            }

            


            Console.ReadKey(true);

        }

        static List<string> CreateString(string chars, int answerlenght)
        {
            List<string> result = new List<string>();
            switch (answerlenght)
            {
                case 2:
                    for (int y = 0; y < chars.Length; y++)
                    {
                        for (int x = 0; x < chars.Length; x++)
                        {
                            if (x == y)
                                continue;
                            var res = string.Concat(chars[x], chars[y]);
                            result.Add(res);
                        }
                    }

                    break;
                case 3:
                    for (int z = 0; z < chars.Length; z++)
                    {
                        for (int y = 0; y < chars.Length; y++)
                        {
                            for (int x = 0; x < chars.Length; x++)
                            {
                                if (x == y || x == z || y == z)
                                    continue;

                                var res = string.Concat(chars[x], chars[y], chars[z]);
                                result.Add(res);
                            }
                        }
                    }
                    break;
                case 4:
                    for (int a = 0; a < chars.Length; a++)
                    {
                        for (int z = 0; z < chars.Length; z++)
                        {
                            for (int y = 0; y < chars.Length; y++)
                            {
                                for (int x = 0; x < chars.Length; x++)
                                {
                                    if (x == y || x == z || y == z || y == a || z == a || x == a)
                                        continue;

                                    var res = string.Concat(chars[x], chars[y], chars[z], chars[a]);
                                    result.Add(res);
                                }
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
            return result;

        }
    }
}
