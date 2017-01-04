using System;

namespace CBasics.DataTypes
{
    class UsingNew
    {
        void InitUsingNew()
        {
            //You can use the new operator to invoke the default constructor
            bool b = new bool(); //b is false
            int i = new int(); //i is 0
            decimal d = new decimal(); //d is 0.00
            char c = new char(); //c is ''
            DateTime date = new DateTime(); //date is 1/1/0001 12:00:00 AM
        }
    }
}
