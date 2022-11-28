using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Арифметическая прогрессия");
            ArithProgression arith = new ArithProgression();
            arith.setStar(10);
            arith.setStep(2);
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine("Сброс значений");
            arith.reset();
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine("Геометрическая прогрессия");
            GeomProgression geom = new GeomProgression();
            geom.setStar(5);
            geom.setStep(3);
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine("Сброс значений");
            geom.reset();
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.ReadKey();
        }
    }
}
