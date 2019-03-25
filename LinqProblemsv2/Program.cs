using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Problems
{
    //public class WordList
    //{
    //    List<string> words = new List<string>() { "the", "bike", "it", "tenth", "mathematics" };
    //}

    class Program
    {
        static void Main(string[] args)
        {
            // List<string> words = new List<string>() { "the", "bike", "it", "tenth", "mathematics" };
            var words = new List<string>() { "the", "bike", "it", "tenth", "mathematics" };

            var resultList = words.FindAll(delegate (string s) { return s.Contains("th"); });

            foreach (var word in resultList)
            {
                //resultList.ForEach(s => Console.Writeline(s);
                Console.WriteLine(word);
            }
            Console.ReadLine();



        }
    }


}
