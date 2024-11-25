using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFinderQu
{
    public class WordFinder
    {
        readonly int rows;
        readonly int columns;
        public char[,] MySoup { get;}
        string[] words;



        public WordFinder(IEnumerable<string> matrix)
        {
            rows = matrix.Count();
            columns = matrix.First().Length;
            MySoup = ConvertToCharMatrix(matrix);
        }
        public IEnumerable<string> Find(IEnumerable<string> wordstream)
        {
            List<string> mostRepeatWord = [];
            words = wordstream.ToArray();
            Array.Sort(words);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    for (int dr = 0; dr <= 1; dr++)
                    {
                        for (int dc = 1; dc >= 0; dc--)
                        {
                            if ((dc != 0 || dr != 0) && (dc != 1 || dr != 1))
                            {
                                foreach (var wordResult in MoveInMatrix(r, c, dr, dc))
                                {
                                    mostRepeatWord.Add(wordResult);
                                }
                            }
                        }

                    }
                }
            }

            return mostRepeatWord.GroupBy(x => x).OrderByDescending(g => g.Count()).Take(10).
                SelectMany(y => y.Distinct()).ToList();
        }


        /// <summary>
        /// Move in the matrix finding a prefix a stop if don't find any coincidence into the words to find Matrix then continue with the next position
        /// </summary>
        /// <param name="rowBase">row base to start with the search</param>
        /// <param name="columnBase">column base to start with the search</param>
        /// <param name="rowMov">Row to move in horizontal (1,0)</param>
        /// <param name="colMov">Column to move in vertical (0,1)</param>
        /// <returns>IEnumerable<string> words found into the soup matrix</returns>
        IEnumerable<string> MoveInMatrix(int rowBase, int columnBase, int rowMov, int colMov)
        {
            string move = string.Empty;
            int result = 0;
            move += MySoup[rowBase, columnBase];

            for (int i = rowBase + rowMov, j = columnBase + colMov;
            i >= 0 && j >= 0 && i < rows && j < columns; i += rowMov, j += colMov)
            {
                move += MySoup[i, j];

                result = prefix(move);
                var word = words[result].ToUpper();

                if (!word.StartsWith(move))
                {
                    break;
                }
                else if (word.Equals(move))
                {
                    yield return word;
                }
            }
        }

        int prefix(string x)
        {
            int inf = 0;
            int sup = words.Length - 1;

            while (inf < sup)
            {
                int med = (inf + sup) / 2;
                if (words[med].ToUpper().CompareTo(x) < 0)
                {
                    inf = med + 1;
                }
                else
                {
                    sup = med;
                }
            }

            return inf;
        }

        char[,] ConvertToCharMatrix(IEnumerable<string> matrix)
        {
            var result = new char[rows, columns];
            var array = matrix.ToArray();

            for (int i = 0; i < rows; i++)
            {
                var line = array[i].ToUpper();

                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = line[j];
                }
            }

            return result;
        }

    }
}
