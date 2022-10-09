using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //структура
            Console.WriteLine("Структура: ");
            MyStruct struct1 = new MyStruct { Name = "Саша", Length = 178, Array = new int[] { 6, 1, 7, 0 } };
            MyStruct struct2 = struct1;
            struct1.Name = "Юля";
            struct1.Length = 170;
            struct1.Array[1] = 500;
            Console.WriteLine(struct2.Name + " " + struct2.Length + " " + struct2.Array[1]);
            //класс
            Console.WriteLine("Класс: ");
            MyClass class1 = new MyClass { Name = "Саша", Length = 178, Array = new int[] { 6, 1, 7, 0 } };
            MyClass class2 = class1;
            class1.Name = "Юля";
            class1.Length = 170;
            class1.Array[1] = 500;
            Console.WriteLine(class2.Name + " " + class2.Length + " " + class2.Array[1]);
        }

        struct MyStruct
        {
            public string Name;
            public int Length;
            public int[] Array;
        }

        class MyClass
        {
            public string Name;
            public int Length;
            public int[] Array;
        }


    }
}
