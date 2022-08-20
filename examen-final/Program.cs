using System;
using System.Collections.Generic;
using System.Linq;

namespace examenfinal
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MainClass clase = new MainClass();
            int op1 = 1;

            do
            {
                Console.WriteLine("¿Que quieres hacer?");
                Console.WriteLine("1. Prmoedio de 5 números");
                Console.WriteLine("2. Calcular el area de un triangulo");
                Console.WriteLine("3. Nombres infinitos");
                Console.WriteLine("4. Imprimir una secuancia");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        float average = clase.getAverage();
                        Console.WriteLine("El promedio es: " +  average);
                        break;
                    case 2:
                        Console.WriteLine("Dame la medida de la base");
                        float we = float.Parse(Console.ReadLine());
                        Console.WriteLine("Dame la medida de la altura");
                        float he = float.Parse(Console.ReadLine());
                        float area = clase.getArea(weight: we, height: he);
                        Console.WriteLine("El area es: " + area);
                        break;
                    case 3:
                        clase.infiniteNames();
                        break;
                    case 4:
                        Console.WriteLine("¿De cuanto en cuanto quieres contar hasta el 100?");
                        int n = int.Parse(Console.ReadLine());
                        clase.printSecuence(n);
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        break;
                }

                Console.WriteLine("¿Quieres hacer otra cosa? ");
                Console.WriteLine("1. Si");
                Console.WriteLine("2. No, terminar programa");
                op1 = int.Parse(Console.ReadLine());
                Console.Clear();

            } while (op1 == 1);
        }

        private float getAverage()
        {
            List<float> nums = new List<float>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingresa el número: " + i);
                nums.Add(float.Parse(Console.ReadLine()));
            }
            float average = nums.Count > 0 ? nums.Average() : 0.0f;
            return average;
        }

        private float getArea(float weight, float height)
        {
            float area = (weight * height)/ 2;
            return area;
        }

        private void infiniteNames()
        {
            string name;
            List<string> names = new List<string>();
            while (true)
            {
                Console.WriteLine("Escribe un nombre");
                name = Console.ReadLine();

                if(string.IsNullOrEmpty(name))
                {
                    names.Sort();
                    Console.WriteLine(string.Join(", ", names));
                    break;
                } else
                {
                    names.Add(name);
                }
            }
        }

        private void printSecuence(int n)
        {
            for (int i = 0; i <= 100; i += n)
            {
                Console.WriteLine(i);
            }
        }
    }
}
