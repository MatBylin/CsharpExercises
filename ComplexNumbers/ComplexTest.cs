using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    class ComplexNumber
    {
        protected double a, b;

        public ComplexNumber(double realPart, double imaginaryPart)
        {
            a = realPart;
            b = imaginaryPart;
        }


        public double GetReal()
        {
            return a;
        }


        public void SetReal(double a)
        {
            this.a = a;
        }


        public double GetImaginary()
        {
            return b;
        }


        public void SetImaginary(double b)
        {
            this.b = b;
        }


        public new string ToString()
        {
            return "(" + a + "," + b + ")";
        }


        public double GetMagnitude()
        {
            return Math.Sqrt((a * a) + (b * b));
        }


        public void Add(ComplexNumber c2)
        {
            a += c2.GetReal();
            b += c2.GetImaginary();
        }

    }

    class ComplexTest
    {
        static void Main()
        {


            ComplexNumber number = new ComplexNumber(5, 2);
            Console.WriteLine("Number is: " + number.ToString());

            number.SetImaginary(-3);
            Console.WriteLine("Number is: " + number.ToString());

            Console.Write("Magnitude is: ");
            Console.WriteLine(number.GetMagnitude());

            ComplexNumber number2 = new ComplexNumber(-1, 1);
            number.Add(number2);
            Console.Write("After adding: ");
            Console.WriteLine(number.ToString());


            Console.ReadLine();
        }
    }
    //class ComplexTest
    //{
    //    static void Main(string[] args)
    //    {
    //        ComplexNumber cn1 = new ComplexNumber(5, 2);
    //        Console.WriteLine("The number is: "+ cn1.ToString());

    //        cn1.B = -3;
    //        Console.WriteLine("The number is: " + cn1.ToString());

    //        Console.Write("Magnitude is: ");
    //        Console.WriteLine(cn1.GetMagnitude());

    //        ComplexNumber cn2 = new ComplexNumber(-1, 1);
    //        cn1.Add(cn2);

    //        Console.Write("After adding: ");
    //        Console.WriteLine(cn1.ToString());

    //        Console.Read();
    //    }
    //}

    //class ComplexNumber
    //{
    //    public int A { get; set; }
    //    public int B { get; set; }


    //    public ComplexNumber(int real, int imaginary)
    //    {
    //        A = real;
    //        B = imaginary;
    //    }

    //    public new string ToString()
    //    {
    //        return "(" + A + "," + B + ")";
    //    }

    //    public double GetMagnitude()
    //    {
    //        return Math.Sqrt((A*A) + (B*B));
    //    }

    //    public void Add(ComplexNumber cNumber)
    //    {
    //        this.A += cNumber.A;
    //        this.B += cNumber.B;

    //    }
    //}
}
