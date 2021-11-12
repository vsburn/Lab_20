using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_lab
{
    class Program
    {
        #region Задача
        /* В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
        * метод получает входным параметром переменную типа double;
        *метод возвращает значение типа double, которое является результатом вычисления.
        *
        *Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
        *длину окружности по формуле D = 2 * π* R;
        *площадь круга по формуле S = π* R²;
        *объем шара. Формула V = 4/3 * π * R³.
        *
        *Методы должны быть объявлены как статические.
        */
        #endregion
        delegate double MyDelegate(double value);
        static void Main(string[] args)
        {
            MyDelegate lengthCircle = LengthCircle;
            MyDelegate areaCircle = AreaCircle;
            MyDelegate volumeSphere = VolumeSphere;
            Console.Write("Введите радиус: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Выберите необходимое действие:\n1 Найти длину окружности\n2 Найти площадь круга\n3 Найти объём шара\n4 Выполнить всё\n1 / 2 / 3 / 4: ");
            int act = Convert.ToInt32(Console.ReadLine());
            switch (act)
            {
                case 1:
                    Console.WriteLine($"{lengthCircle(r):F2}");
                    break;
                case 2:
                    Console.WriteLine($"{areaCircle(r):F2}");
                    break;
                case 3:
                    Console.WriteLine($"{volumeSphere(r):F2}");
                    break;
                case 4:
                    Console.WriteLine($"Длина окружности {lengthCircle(r):F2}");
                    Console.WriteLine($"Площадь круга {areaCircle(r):F2}");
                    Console.WriteLine($"Объём шара {volumeSphere(r):F2}");
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
        static double LengthCircle(double r)
        {
            return 2 * Math.PI * r;
        }
        static double AreaCircle(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
        static double VolumeSphere(double r)
        {
            return (4 * Math.PI * Math.Pow(r, 3)) /3;
        }
    }
}
