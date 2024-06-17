using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherOrderFunction
{
    class HigherOrderFunctionExample
    {
        static void Main()
        {

            Func<int, int, int> operation = Add; /*Func<int, int, int> operation = (x, y) => x + y;*/
            int result = ApplyOperation(operation, 3, 5);
            Console.WriteLine($"Result of applying Add(3, 5): {result}"); 
        }
        static int ApplyOperation(Func<int, int, int> operation, int x, int y)
        {
            return operation(x, y);
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
