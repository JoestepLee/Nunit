using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Triangle
    {
        public double a, b, c;

        public int IsIsoTriangle(double a, double b, double c)//Kiểm tra có phải tam giác cân
        {
            int result = 0;
            if (a == b || b == c || c == a)
            {
                result = 1;
            }
            return result;
        }
        public int IsRightTriangle(double a, double b, double c)//Kiểm tra có phải tam giác vuông
        {
            int result = 0;
            if (a * a + b * b == c * c || c * c + b * b == a * a || a * a + a * a == b * b)
            {
                result = 1;
            }
            return result;
        }

        public int IsEquiTriangle(double a, double b, double c)//Kiểm tra có phải là tam giác điều
        {
            int result = 0;
            if (a == b && b == c && c == a)
            {
                result = 1;
            }
            return result;
        }

        public int IsIsoRightTriangle(double a, double b, double c)//Kiểm tra có phải là tam giác vuông cân
        {
            int result = 0;
            if (IsRightTriangle(a, b, c) == 1 && IsIsoTriangle(a, b, c) == 1)
            {
                result = 1;
            }
            return result;
        }

        public int IsTriangle(double a, double b, double c)//Kiểm tra tam giác
        {
            int result = 0;
            if (a + b > c && b + c > a && a + c > b)
            {
                result = 1;
            }
            return result;
        }

        public int TypeTriangle(double a, double b, double c)
        {
            int result = 0;
            if (IsTriangle(a, b, c) == 1)
            {
                result = 1;
                if (IsIsoRightTriangle(a, b, c) == 1)
                    result = 2;
                if (IsEquiTriangle(a, b, c) == 1)
                    result = 3;
                if (IsIsoTriangle(a, b, c) == 1)
                    result = 4;
                if (IsRightTriangle(a, b, c) == 1)
                    result = 5;
            }

            return result;
        }
    }
}
