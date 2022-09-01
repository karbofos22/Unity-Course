using System;
using HomeWork_4.MyMath;


namespace HomeWork_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector vector1 = new(21, -6, 15);

            Vector vector2 = new(9, -2, 33);

            var vector3 = Vector.Addition(vector1, vector2);
            vector3.VectorInfo();

            Console.WriteLine();

            var vector4 = Vector.Subtraction(vector1, vector2);
            vector4.VectorInfo();

            Console.WriteLine();

            var vector5 = Vector.MultiplyByNum(vector1, -2);
            vector5.VectorInfo();

            Console.WriteLine();

            var vector6 = Vector.DivideByNum(vector2, 4);
            vector6.VectorInfo();
        }
    }
}
