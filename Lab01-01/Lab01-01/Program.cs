using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[3] Resta");
                Console.WriteLine("[4] Multiplicación");
                Console.WriteLine("[5] División");
                Console.WriteLine("[6] Primeros 10 primos");
                Console.WriteLine("[7] F° a C°");
                Console.WriteLine("[8] C° a F°");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta entre {0} y {1} es {2}", c, d, Resta(c, d));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicación entre {0} y {1} es {2}", e, f, Multiplicacion(e, f));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Ingrese el primer número");
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int h = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La division entre {0} y {1} es {2}", g, h, Division(g, h));
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Calculando...");
                        Primos();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Ingrese los grados Celcius");
                        int i = Convert.ToInt32(Console.ReadLine());
                        FaC(i);
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Ingrese los grados Farenheint");
                        int j = Convert.ToInt32(Console.ReadLine());
                        CaF(j);
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));

        }
        //Función para calcular la suma de 2 números enteros
        static int Suma(int a, int b)
        {
            return a + b;
        }
        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }
        //Calcular resta de 2 números
        static int Resta(int a, int b)
        {
            return a - b;
        }
        //Calcular multiplicación de 2 números
        static int Multiplicacion(int a, int b)
        {
            return a * b;
        }
        //Calcular división de 2 números usando manejo de errores
        static string Division(int a, int b)
        {
            try
            {
                return (a / b).ToString();
            }
            catch (Exception) {
                Console.WriteLine("No se puede dividir entre 0");
            }
            return "Indefinido";
        }
        //Calcular los primeros 10 números primos
        static int Primos()
        {
            int i;
            int cont = 0; //un contador, el cual si es mayor a dos indica que el numero no es primo
            for (i = 2; i <= 30; i++)
            {  //apertura del for1
                for (int j = 1; j <= i; j++)
                {   //apertura for2

                    if (i % j == 0)
                    {
                        cont = cont + 1;
                    }
                }
                if (cont <= 2)
                { //si variable cont es mayor a dos, el numero es divisible en mas de dos numero osea no es primo
                    Console.WriteLine(i);
                } //cierre for2
                cont = 0; //igualamos a cero para hacer otra evaluacion con otro numero


            }//cierre del for1
            return i;
        }
        //Convertir Farenheint a Celcius
        static void FaC(int a)
        {
            Console.WriteLine( (5 * (a - 32)) / 9);
        }
        //Convertir Celcius a Farenheint
        static void CaF(int a)
        {
            Console.WriteLine(((9 * a) / 5) + 32);
        }
    }
}
