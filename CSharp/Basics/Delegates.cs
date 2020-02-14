using System;

namespace CSharp
{
    public class Delegates
    {
        public delegate void Calculate(int x, int y);
        public static void Add(int x, int y) => Console.WriteLine(x + y); 
        public static void Multiply(int x, int y) => Console.WriteLine(x * y);
        public static void Invalid(int x, int y) => Console.WriteLine("Error");
        public static Calculate chooseMethod(char symbol) {
            if (symbol == '+')
                return Add;
            else if (symbol == '*')
                return Multiply;
            else
                return Invalid;
        }
        public void usingDelegates() {
            Calculate method = chooseMethod('+');   //if we passed a variable instead of +/* we could still use method
                                                    //without knowing which was inputted etc

            Delegates test = new Delegates();

            Console.Write("3 + 4 = ");
            method(3, 4);
            Console.Write(" vs ");
            Console.Write("3 + 4 = ");
            Delegates.Add(3,4);

            method = chooseMethod('*');
            Console.Write("3 x 4 = ");
            method(3, 4);
            
            method = chooseMethod('#');
            Console.Write("3 # 4 = ");
            method(3, 4);
        }
    }
}