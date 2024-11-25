using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFinderQu
{
    public class ValidateMatrix
    {

        public readonly int MaxRows = 64;
        public readonly int MaxColumns = 64;

        public ValidateMatrix(int maxRows, int maxColumns)
        {
            MaxRows = maxRows;   
            MaxColumns = maxColumns;
        }

        /// <summary>
        /// Validate if the matrix is a rectangle and don't exceed the rules
        /// </summary>
        /// <param name="values">Array to validate</param>
        /// <returns>bool if the matrix is a valid to search words</returns>
        public bool isValid(IEnumerable<string> values)
        {
            return values.Any() && values.Count() <= MaxRows && values.First().Length <= MaxColumns && values.Skip(1).All(v => values.First().Length.Equals(v.Length));
        }
    }
}
