using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArea
{
    public class AreaDLL
    {
        public double Circle(double radius)
        {
            //Площадь круга
            double area = Math.Round(Math.PI * Math.Pow(radius, 2), 2);
            return area;
        }

        public Tuple<double, bool> Triangle (double a, double b, double c)
        {
            //Проверка на прямоугольный треугольник
            Boolean isRight = false;
            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) ||
                Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2) ||
                Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2))
                isRight = true;
            //Вычисление площади треугольника
            double p = (a + b + c) / 2;
            double area = Math.Round(Math.Sqrt(p*(p-a)*(p-b)*(p-c)), 2);
            //Возвращается площадь и результат проверки на прямоугольность
            return Tuple.Create(area, isRight);
        }
    }
}
