using System;

namespace CBasics.DataTypes
{
    class Parsing
    {
        void ParseFromString()
        {
            int i = int.Parse("123");
            int i2;
            if(int.TryParse("123", out i2))
            {
                Console.Write("Yayy, i2 holds a number!");
            }
            else
            {
                Console.Write("Oh, could not parse the string!");
            }
        }
    }
}
