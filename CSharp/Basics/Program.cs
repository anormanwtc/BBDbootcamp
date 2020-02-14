#define TEST_COND //as set by Conditional Used.ello will only run if this is set

using System;
using Hello;
using System.Collections.Generic;
using System.Linq;
using Attributes;

namespace CSharp
{
    [Author("Alistair", version = 8)]
    class Program
    {
        static void Main(string[] args)
        {
            // ReadnWrite.RnR();
            Animal a1 = new Animal();
            a1.Name = "Pixel";
            Console.WriteLine(a1.Moves());
        }
            public static void Oldtests() {
            new TaskExpl().AccessTheWebAsync();
            Console.WriteLine("Hello World!");
            //ello has been set to conditional("TEST_COND") in its file so will only appear with the line 1 #define TEST_COND
            Used.ello();
            // Console.ReadKey(); //commented out cause annoying but useful enough as info

            //1 - can intitialize then set the variable like this
            Animal a1 = new Animal();
            a1.Name = "Pixel";
            a1.Name = "Pixelrenamed";
            Console.WriteLine(a1.Moves());
            //2 - or this is called an object initializer
            Animal a2 = new Animal() {Name = "Scuzzy"};
            a2.Name = "hello";
            Console.WriteLine(a2.Moves());

            Delegates del = new Delegates();
            del.usingDelegates();
            //Anonymous types: var, read only but dont need definitions etc
            var v = new { Amount = 108, Message = "Hello" };
            Console.WriteLine(v.Amount + v.Message); 
 
            //multi params method just shoved in class Animal for testing

            paramsTest par = new paramsTest();
            par.ParamsMethod(); //prints out 0
            par.ParamsMethod("a", "b"); //prints out 2
            par.ParamsMethod("x", "y", "z"); //prints out 3
            Console.WriteLine("end of variable params test");

            IEnumerable<int> sqrNums = paramsTest.SquareNumbers(0,10);
            foreach(var number in sqrNums)
                Console.Write(number + " ");
            Console.WriteLine("All sqrNums of 0-9");

            //LINQ queries, requires using System.Linq;
            //LINQ queries only happen when the results are called for.
            //To prevent that happening multiple times we set the result into a list with .ToList();
            var numbersQuery =
                (from number in sqrNums
                where number < 40 && number > 3
                select number).ToList(); //LINQ query would be called here for the ToList()
                                        //This skips the below calls by using the saved result
            
            Console.WriteLine($"Total: {numbersQuery.Count()}"); //LINQ query would be called here
            foreach(var number in numbersQuery) //LINQ query would be called here
                Console.Write(number + " ");
            Console.WriteLine("All of previous x < 40 && x > 3");
        }

        
    }
}

/* public: 
Accessed by any other code in the same assembly or another assembly that references it.
// private: 
Accessed only by code in the same class or struct.
// protected: 
Accessed only by code in the same class, or in a class that is derived from that class.
// internal: 
Accessed by any code in the same assembly, but not from another assembly.
// protected internal: 
Accessed by any code in the assembly in which it is declared, or from within a derived class in another assembly.
private protected: 
Accessed only within its declaring assembly, by code in the same class or in a type that is derived from that class.
*/