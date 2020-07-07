using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQProblems
{
    public class Linq
    {
        //  Using LINQ, write a function that returns all words that contain the substring “th” from a list.
        //	List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", “mathematics” };

        public IEnumerable<string> IfContains(string str)
        {
            var words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var contains = words.Where(word => word.Contains(str)).Select(word => word);
            return contains;
        }

    }
}
