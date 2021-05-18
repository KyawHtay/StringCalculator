using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            StringCalculator cal = new StringCalculator();
            int result=cal.Add("//;\n1;-2");
        }
    }
}
