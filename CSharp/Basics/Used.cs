using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Hello
{
    public static class Used //static classes can only be used, not made
    {
        [Conditional("TEST_COND")]
        public static void ello() => Console.WriteLine("Hello from Used!");
        //single line functions
    }
    
    public class paramsTest {
        public void ParamsMethod(params string[] list) => Console.WriteLine(list.Length);

        public static IEnumerable<int> SquareNumbers(int start, int finish)
        { //needs using System.Collections.Generic; cause the non generic doesnt take types
            for (var i = start; i < finish; i++)
            {
                yield return i*i;
            }
        }

    }
    public class Animal
    {
        private int age;
        //constructors
        public Animal() {}
        public Animal(int age) => this.age = age;

        //Without the get;set; you expose the exact reference, could this be exploitable?
        public string Name { get; set; } //shorthand creation of getters/setters for Name
        //public {get; set;} is basically identical to without it but its "easier to change later?"
        // You can change either like {private get; set {more code};}
        // You can also manually make the get and set methods

        //method
        public string Moves() => $"{Name} is moving";
        // {
        //     return($"{Name} is moving"); 
        // } //return doesnt work as a single line function cause stuff is auto returned?

    }

    //dont use partial classes if possible

    // public partial class Split {
    //     // partials can be used to continually add parts to a class for different people
    //     // or something like that
    //     private int hello = 5;
    // }
    // public partial class Split {
    //     private int there = 10;
    // }

}