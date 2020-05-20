using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProductivityFeatures
{
    class Features
    {

        public void MultiCaret()
        {
            Console.WriteLine("dotnet Bot!");
            Console.WriteLine("Allison!");
            Console.WriteLine("Kendra!");
        }

        #region intellicode
        public string IntelliCode()
        {
            string a = "";

            // var b = a.

            // char[] c = a.

            var d = a.ToLower();
            var e = a.ToLower();
            //var f = a.

            return a;
        }



        #endregion

        #region Refactoring Features

        public void FixSpacing()
        {
        }


        public void FixMyType()  //code cleanup
        {
            var myint = 0;
            var mystring = "Hello, world!";
            var myfloat = 0.2;
            var mybool = true;
            Console.WriteLine(myint.ToString(), mystring, myfloat, mybool);


        }

        // Click in the if statements and type (Ctrl + .) to invert them.
        public void InvertIfElse()
        {
            var tru = true;
            //Bool expressions
            if (tru)
            {
                Console.WriteLine("Truth!");
            }
            else
            {
                Console.WriteLine("Falsehood!");
            }

            // Comparisons
            if (1 > 2)
            {
                Console.WriteLine("Change places!");
            }
            else
            {
                Console.WriteLine("Okay!");
            }

            // Multiple conditions
            if (0 == 0 && true || true)
            {
                Console.WriteLine("AlwaysTrue");
            }
            else
            {
                Console.WriteLine("Unreachable");
            }
        }
        // Place your cursor in the for loop statement.
        // Use (Ctrl + .) to convert it to a foreach loop.
        // Use (Ctrl + .) to convert it back into a for loop.
        public void ForLoopToForEach()
        {
            List<int> intList = new List<int>() { 1, 2, 3 };

            for (int i = 0; i < intList.Count; i++)
            {
                int num = intList[i];
                Console.WriteLine(intList[num]);
            }
        }

        // Place you cursor in the linq query of shortGreeting.
        // Type (Shift + Alt + plus symbol) to select only the linq query.
        // Type (Ctrl + .) to convert the linq query into a foreach loop.
        public void LinqToForEach()
        {
            var greetings = new List<string>() { "hi", "yo", "hello", "howdy" };

            var shortGreeting =
                from greet in greetings
                where greet.Length < 3
                select greet;
        }

        // Use Go to Enclosing Block to jump to the top of the block your cursor is in.
        // Click inside the curly brace below and type (Shift + Alt + [) 
        // to jump to the top of the class.


        // Don't forget you can now navigate to files that you've recently 
        // viewed with Go To All. Type (Ctrl + t) to bring up the search box.
        // Type (r) to view your recent files. Navigate back to Program.cs via the drop down.


        // Place cursor in foreach keyword and type (Ctrl + .)
        // Select 'Convert to Linq' to convert to a query
        public void ForeachLoopToLinqQuery()
        {
            var greetings = new List<string>()
                { "hi", "yo", "hello", "howdy" };

            IEnumerable<string> enumerable()
            {
                foreach (var greet in greetings)
                {
                    if (greet.Length < 3)
                    {
                        yield return greet;
                    }
                }

                yield break;
            }

            var shortGreeting = enumerable();
        }

        // Place cursor in foreach keyword and type (Ctrl + .)
        // Select 'Convert to Linq(call form)' to convert to a method
        public void ForeachLoopToLinqMethod()
        {
            var greetings = new List<string>()
                { "hi", "yo", "hello", "howdy" };

            IEnumerable<string> enumerable()
            {
                foreach (var greet in greetings)
                {
                    if (greet.Length < 3)
                    {
                        yield return greet;
                    }
                }

                yield break;
            }

            var shortGreeting = enumerable();
        }
        public void WrapIndentAlignParameters(int a, int b, int c, int d, string e, string f, string g, string h, DateTime i, DateTime j, DateTime k)
        { }


    }

    #endregion
}

