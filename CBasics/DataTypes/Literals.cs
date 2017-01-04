using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBasics.DataTypes
{
    class Literals
    {
        void ImplicitTypes()
        {
            /* In this example I'll use implicitly typed variables (var)
             * The compiler is able to infer the type of the stored variable.
             * Hover over the var keyword each line to see the variable type
             */

            //When you use integer literals, the compiler will assume you'd want ints.
            var intType = 0; //intType is an int
            //If you'd like to use a long, you'd need to suffix variables with l or L
            var longType = 0l; //longType is a long
            //The suffix case doesn't matter
            var bigLongType = 0L; //bigLongType is long too

            //When you use fractions, the compiler will assume you'd want doubles.
            var doubleType = 0.0; //doubleType is double
            //if you'd like to have a float, use f or F
            var floatType = 0.0f; //floatType is a float
            //For decimals, use m or M
            var decimalType = 0.0M; //decimalType is a decimal
        }
    }
}
