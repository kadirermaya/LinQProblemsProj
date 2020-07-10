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

        //  Using LINQ, write a function that takes in a list of strings and returns a copy of the list without duplicates.
        //  List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };


        public IEnumerable<string> ListWithoutDuplicated(List<string> list)
        {
            var names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };
            var namesWithoutDuplicated = names.Distinct();
            return namesWithoutDuplicated;
        }

        //  Using LINQ, write a function that calculates the class grade average after dropping the lowest grade for each student.
        //  The function should take in a list of strings of grades (e.g., one string might be "90,100,82,89,55"), drops the lowest 
        //  grade from each string, averages the rest of the grades from that string, then averages the averages.
        //  List<string> classGrades = new List<string>()
        //  {
        //  "80,100,92,89,65",
        //  "93,81,78,84,69",
        //  "73,88,83,99,64",
        //  "98,100,66,74,55"
        //  };
        //  Expected output: 86.125

        


    }


}
