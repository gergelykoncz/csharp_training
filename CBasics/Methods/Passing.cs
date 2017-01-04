using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBasics.Methods
{
    class Passing
    {
        void Increment(int value)
        {
            value++;
            //value is 101 here
        }

        void IncrementRef(ref int value)
        {
            value++;
            //value is 101 here
        }

        void OptionalParams(int x, int y, string message = "The result is: ")
        {
            int result = x + y;
            Console.WriteLine(message + result);
        }

        void Body()
        {
            int x = 100;
            Increment(x); //x is still 100
            IncrementRef(ref x); //x is 101 now
            OptionalParams(1, 1);
            OptionalParams(1, 1, "Hello: ");
        }
    }
}
