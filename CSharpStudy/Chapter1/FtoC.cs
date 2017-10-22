using System;
namespace CSharpStudy
{
    public class FtoC
    {
        static void Main(){
            double f;
            double c;

            f = 59.0;
            c = 5.0 / 9.0 * (f - 32.0);

            Console.Write(f + " degrees Fahrenheit is ");
            Console.Write(c + " degrees Celsius.");
        }
    }
}
