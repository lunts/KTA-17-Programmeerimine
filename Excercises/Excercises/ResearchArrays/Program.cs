using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Google and try to understand what are arrays
            //2. Create small illustrative example
            //3. Do NOT copy & paste, use learnt concepts to create your own
            //4. Create pull request
            //5. Share with friends

            // Specify the data source.
            int[] scores = new int[] { 97, 92, 81, 60 };

            // Define the query expression.
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            // Execute the query.
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }
        }
    }
}
