using System;

namespace MyProgram
{
    class Fraction
    {

        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public Fraction(int wholeNumber)
            : this(wholeNumber, 1)
        {
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            int lcd = LCD(a.denominator, b.denominator);
            int numerator = a.numerator * (lcd / a.denominator) + b.numerator * (lcd / b.denominator);
            return new Fraction(numerator, lcd);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            int lcd = LCD(a.denominator, b.denominator);
            int numerator = a.numerator * (lcd / a.denominator) - b.numerator * (lcd / b.denominator);
            return new Fraction(numerator, lcd);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            int numerator = a.numerator * b.numerator;
            int denominator = a.denominator * b.denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            int numerator = a.numerator * b.denominator;
            int denominator = a.denominator * b.numerator;
            return new Fraction(numerator, denominator);
        }

        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }

        private static int LCD(int a, int b)
        {
            return a * b / GCD(a, b);
        }

        public override string ToString()
        {
            if (denominator == 1)
            {
                return numerator.ToString();
            }
            return $"{numerator}/{denominator}";
        }
    }
}









namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть чисельник першого дробу: ");
            int numerator1 = int.Parse(Console.ReadLine());

            Console.Write("Введіть знаменник першого дробу: ");
            int denominator1 = int.Parse(Console.ReadLine());

            Fraction f1 = new Fraction(numerator1, denominator1);

            Console.Write("Введіть чисельник другого дробу: ");
            int numerator2 = int.Parse(Console.ReadLine());

            Console.Write("Введіть знаменник другого дробу: ");
            int denominator2 = int.Parse(Console.ReadLine());

            Fraction f2 = new Fraction(numerator2, denominator2);

            Console.WriteLine("f1 = " + f1);
            Console.WriteLine("f2 = " + f2);

            Fraction sum = f1 + f2;
            Fraction difference = f1 - f2;
            Fraction product = f1 * f2;
            Fraction quotient = f1 / f2;

            Console.WriteLine("f1 + f2 = " + sum);
            Console.WriteLine("f1 - f2 = " + difference);
            Console.WriteLine("f1 * f2 = " + product);
            Console.WriteLine("f1 / f2 = " + quotient);

            
        }
    }
}


