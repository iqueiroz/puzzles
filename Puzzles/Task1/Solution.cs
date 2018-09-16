namespace Puzzles.Task1
{
    using System;
    using System.Text.RegularExpressions;
    using System.Text;
    public class Solution
    {
        private Regex _notNumbersPattern = new Regex(@"[^0-9]");
        private const char Separator = '-';
        public string solution(string S)
        {

            var result = this._notNumbersPattern.Replace(S, string.Empty);
            if (result.Length < 3)
                return result;

            var number = new StringBuilder(result);

            switch(number.Length % 3)
            {
                case 0:
                    for (var i = number.Length - 3; i > 0; i -= 3)
                        number.Insert(i, Separator);
                    break;
                case 1:
                    number.Insert(number.Length - 2, Separator);
                    number.Insert(number.Length - 5, Separator);
                    for (var i = number.Length - 9; i > 0; i -= 3)
                        number.Insert(i, Separator);
                    break;
                case 2:
                    number.Insert(number.Length - 2, Separator);
                    for (var i = number.Length - 6; i > 0; i -= 3)
                        number.Insert(i, Separator);
                    break;
            }
            
            result = number.ToString();
            return result;
        }
    }
}
