using System;
using static System.Console;

namespace ComplexNumbers
{
    // Created by Jake Magri
    
    // ComplexNumber class contains Operator overloads for calculatior of complex numbers.
    class ComplexNumber
    {

        // Private variables to represent real and imaginary parts of complex numbers.
        private double real;
        private double imaginary;


        // Constructor that initializes the ComplexNumber class with two doubles representing the real and imaginary objects.
        public ComplexNumber(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        // Operator overload for the addition of two ComplexNumber objects.
        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            double realPart = a.real + b.real;
            double imaginaryPart = a.imaginary + b.imaginary;
            return new ComplexNumber(realPart, imaginaryPart);
        }

        // Operator overload for the subtraction of two ComplexNumber objects.
        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            double realPart = a.real - b.real;
            double imaginaryPart = a.imaginary - b.imaginary;
            return new ComplexNumber(realPart, imaginaryPart);
        }

        // Operator overload for the multiplication of two ComplexNumber objects.
        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            double realPart = a.real * b.real - a.imaginary * b.imaginary;
            double imaginaryPart = a.real * b.imaginary + a.imaginary * b.real;
            return new ComplexNumber(realPart, imaginaryPart);
        }

        // Operator overload for the division of two ComplexNumber objects.
        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            double denominator = b.real * b.real + b.imaginary * b.imaginary;
            double realPart = (a.real * b.real + a.imaginary * b.imaginary) / denominator;
            double imaginaryPart = (a.imaginary * b.real - a.real * b.imaginary) / denominator;
            return new ComplexNumber(realPart, imaginaryPart);
        }

        // Override of the ToString method so ComplexNumber objects can be printed in the format "(real + imaginary i)" or "(real - imaginary i)" based on the if statement created using a ternary operator.
        public override string ToString()
        {
            string sign = (imaginary < 0) ? "-" : "+";
            return string.Format("({0} {1} {2}i)", real, sign, Math.Abs(imaginary));
        }
    }

    // ComplexTest class uses the Main method and provides inputs/outputs for the ComplexNumber class.
    class ComplexTest
    {
        static void Main(string[] args)
        {

            // Prompt the user to enter the real and imaginary parts of two ComplexNumber objects.
            Write("Enter the real part of complex number x: ");
            double xReal = double.Parse(ReadLine());

            Write("Enter the imaginary part of complex number x: ");
            double xImaginary = double.Parse(ReadLine());

            Write("Enter the real part of complex number y: ");
            double yReal = double.Parse(ReadLine());

            Write("Enter the imaginary part of complex number y: ");
            double yImaginary = double.Parse(ReadLine());

            // Create two ComplexNumber objects using the user input.
            ComplexNumber x = new ComplexNumber(xReal, xImaginary);
            ComplexNumber y = new ComplexNumber(yReal, yImaginary);


            // Return the results of adding, subtracting, multiplying, and dividing the two ComplexNumber objects using overloaded operators.
            WriteLine("{0} + {1} = {2}", x, y, x + y);
            WriteLine("{0} - {1} = {2}", x, y, x - y);
            WriteLine("{0} * {1} = {2}", x, y, x * y);
            WriteLine("{0} / {1} = {2}", x, y, x / y);
        }
    }
}


