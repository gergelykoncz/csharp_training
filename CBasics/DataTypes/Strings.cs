using System;

namespace CBasics.DataTypes
{
    class Strings
    {
        void StringMembers()
        {
            //Every string has a Length property
            string bob = "Bob"; //bob.Length === 3
            //You can compare two strings using the Compare method
            string jane = "Jane";
            string.Compare(bob, jane);
            /*There are three return values:
             * -1: The first string is sorted first
             * 0: The two strings are equally sorted
             * 1: The second string is sorted first
             */
             //You can pass various settings into overloads of this method
             //So that you can make comparison ignore case, ignore culture, etc.
            string.Compare(bob, jane, StringComparison.OrdinalIgnoreCase);

            //The Contains method tells you if the string contains a substring
            bob.Contains("bo"); //true

            //The Split method is used to break a string into an array
            "a,b,c,d,e".Split(','); //["a", "b", "c", "d", "e"]

            //String can be concatenated using the + operator
            string result = "res" + "ult"; //"result"

            //Use the ToUpper and ToLower methods respectively for casing
            string upper = "lower".ToUpper(); //"LOWER"

            //Note that strings are immutable:
            upper.ToLower(); //returns a NEW string, the string held in upper won't change

            //The string escape character is \
            string welcome = "Hello I'm \"bob\"";

            //There's another option called verbatim strings
            string verbatim = @"Hello I'm ""bob""";

            //String is a reference type, but equality comparison is overridden
            bool x = "bob" == "bob"; //true
            //However, prefer the Equals method
            "bob".Equals("bob", StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
