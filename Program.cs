using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pen pen1 = new Pen ("Белый",250);
            Pen pen2 = new Pen();
            Console.WriteLine(pen1.color + ", " + pen1.cost);
            Console.WriteLine(pen2.color + ", " + pen2.cost);
            Rectangle rect1 = new Rectangle(5,77);
            Console.WriteLine(rect1.Square());
            Rectangle rect2 = new Rectangle(5);
            Console.WriteLine(rect2.Square( ));
            Rectangle rect3 = new Rectangle();
            Console.WriteLine(rect3.Square());
        }
    }
    
    class Pen
    {
        public string color;
        public int cost;
        public Pen()
        {
            color = "Чёрный";
            cost = 100;
        }
        public Pen(string penColor, int penCost)
        {
            color = penColor;
            cost = penCost;
        }
    }

    class Rectangle
    {
        public int a;
        public int b;
        
        public int Square() => a * b;
        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public Rectangle(int side)
        {
            a = side;
            b = side;
        }

        public Rectangle()
        {
            a = 6;
            b = 4;
        }
    }
}
