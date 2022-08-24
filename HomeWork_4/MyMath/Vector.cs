using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4.MyMath
{
    internal struct Vector
    {
        double x;
        double y;
        double z;

        public Vector(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void VectorInfo()
        {
            Console.WriteLine($"X coordinate: {x}\n" +
                              $"Y coordinate: {y}\n" +
                              $"Z coordinate: {z}");
        }
        public static Vector Addition(Vector vector1, Vector vector2)
        {
            Vector vector = new();

            vector.x = vector1.x + vector2.x;
            vector.y = vector1.y + vector2.y;
            vector.z = vector1.z + vector2.z;

            return vector;
        }
        public static Vector Subtraction(Vector vector1, Vector vector2)
        {
            Vector vector = new();

            vector.x = vector1.x - vector2.x;
            vector.y = vector1.y - vector2.y;
            vector.z = vector1.z - vector2.z;

            return vector;
        }
        public static Vector MultiplyByNum(Vector vector1, int num)
        {
            Vector vector = new();

            vector.x = num * vector1.x;
            vector.y = num * vector1.y;
            vector.z = num * vector1.z;

            return vector;
        }
        public static Vector DivideByNum(Vector vector1, int num)
        {
            Vector vector = new();

            vector.x = vector1.x / num;
            vector.y = vector1.y / num;
            vector.z = vector1.z / num;

            return vector;
        }

        //Альтернативный вариант с использованием out

        //public static void Addition(Vector vector1, Vector vector2, out Vector vector3)
        //{
        //    vector3.x = vector1.x + vector2.x;
        //    vector3.y = vector1.y + vector2.y;
        //    vector3.z = vector1.z + vector2.z;
        //}

    }
}
