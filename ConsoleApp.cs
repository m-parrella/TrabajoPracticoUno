using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

namespace ConsoleApp
{
    public class ConsoleApp
    {

        enum DiasSemana
        {
            Domingo = 1,
            Lunes,
            Martes,
            Miercoles,
            Jueves,
            Viernes,
            Sabado
        };

        enum color { Blanco = 0, Azul, Negro };

        static void Main(string[] args)
        {
            /*
             * Trabajo Practico Nro 1
             * Generalidades
             * Grupo 3
             */
            var ConsoleApp = new ConsoleApp();

            Console.WriteLine("Trabajo Práctico Nro. 1 | Grupo 3 | 2023");

            Console.WriteLine("\n- Generalidades");

            Console.WriteLine("\n1) Crear una función que devuelva la suma de dos números recibidos por parámetros");
            double sum = ConsoleApp.SumarNumeros(10, 5);
            Console.WriteLine($" - La suma de 10 y 5 es [{sum}]");

            Console.WriteLine("\n2) Crear una función que reciba una cadena de 8 caracteres y retorne en el mismo parámetro la cadena cortada de izquierda a derecha en 4 caracteres");
            string stringIn = "12345678";
            string stringOut = DividirCadena(stringIn);
            Console.WriteLine($" - La cadena [{stringIn}] cortada de izquierda a derecha es [{stringOut}]");

            Console.WriteLine("\n3) Crear una función que devuelva la fecha y hora actual");
            string fecha = ObtenerFecha();
            Console.WriteLine($" - La fecha actual es [{fecha}]");

            Console.WriteLine("\n- Enumeraciones");

            Console.WriteLine("\n1) Crear una enumeración con los días de la semana, comenzando por Domingo con valor 1.");
            int dia = EnumerarDias();
            Console.WriteLine($" - El jueves es el día [{dia}]");

            Console.WriteLine("\n- Conversiones");

            Console.WriteLine("\n1) Realizar la conversión de true, false, 1 y 0 utilizando los métodos Convert., bool.Parse y bool.TryParse. Explique cómo responde en cada caso cada uno de los métodos indicados");
            Convertir();

            Console.WriteLine("\n2) Explique que sucede en los siguientes intentos de casteos de datos.");
            Castear();

            Console.WriteLine("\n3) Escriba una sentencia switch utilizando una enumeración con 3 colores (blanco, azul y negro) y para cada caso indicar un mensaje de cual es el color informado.");
            SentenciaSwitch();

            Console.WriteLine("\n4) Si se tiene una variable entera a, realice una sentencia if para evaluar si la variable a es mayor a 10. Si es verdad, mostrar un mensaje indicando que el valor es mayor a 10");
            Console.WriteLine("5) Al ejercicio del punto 4), agregar la sentencia de else y, en ella, indicar un mensaje de error.");
            Console.WriteLine(" - Valor: 30");
            if (SentenciaIf(30))
            {
                Console.WriteLine(" - El valor ingresado es mayor a 10");
            }
            else
            {
                Console.WriteLine(" - El valor ingresado no es mayor a 10");
            }

            /*
              * 6) ¿Cuál es la diferencia entre la sentencia for y foreach? ¿Cuándo se debe utilizar cada una de ellas?
              * La instrucción for ejecuta una instrucción o un bloque de instrucciones mientras una expresión booleana especificada se evalúa como true.
              * La instrucción foreach ejecuta una instrucción o un bloque de instrucciones para cada elemento de una instancia del tipo que implementa la 
              * interfaz System.Collections.IEnumerable o System.Collections.Generic.IEnumerable<T>
              */

            Console.WriteLine("\n7) Defina una variable a que en cada ciclo de una sentencia while incremente su valor en 5. Cuando la variable a exceda el valor de 50, el ciclo while debe finalizar.");
            List<int> resultado = SentenciaWhile(3);
            Console.WriteLine($" - Resultado para el valor [3]: {String.Join(",", resultado)}");

            Console.ReadKey();

        }

        public static double SumarNumeros(double a, double b)
        {
            // 1) Crear una función que devuelva la suma de dos números recibidos por parámetros
            double resultado = a + b;
            return resultado;
        }

        public static string DividirCadena(string s)
        {
            // 2) Crear una función que reciba una cadena de 8 caracteres y retorne en el mismo parámetro la cadena cortada de izquierda a derecha en 4 caracteres.
            int length = s.Length;
            int partsCount = (int)Math.Ceiling((double)length / 4);
            string[] parts = new string[partsCount];
            for (int i = 0; i < partsCount; i++)
            {
                int startIndex = Math.Max(length - (i + 1) * 4, 0);
                int partLength = Math.Min(4, length - startIndex);
                parts[i] = s.Substring(startIndex, partLength);
            }
            return string.Concat(parts[0], parts[1]);
        }

        public static string ObtenerFecha()
        {
            // 3) Crear una función que devuelva la fecha y hora actual
            return DateTime.Now.ToString();
        }

        public static int EnumerarDias()
        {
            /*
             * - Enumeraciones
             * 1) Crear una enumeración con los días de la semana, comenzando por Domingo con valor 1.
             * 2) Agregar a la enumeración la posibilidad de Imprimir un Texto por cada día de la semana (?)
             */
            return (int)DiasSemana.Jueves;
        }

        static void Convertir()
        {
            /* 
             * - Conversiones
             * 1) Realizar la conversión de true, false, 1 y 0 utilizando los métodos Convert., bool.Parse y bool.TryParse. 
             * Explique cómo responde en cada caso cada uno de los métodos indicados.
             */
            Console.WriteLine($" - La conversión de Bool [true] a Int es [{Convert.ToInt32(true).ToString()}] usando el método Convert.ToInt32()");
            Console.WriteLine($" - La conversión de Bool [false] a Int es [{Convert.ToInt32(false).ToString()}] usando el método Convert.ToInt32()");
            Console.WriteLine($" - La conversión de Int [1] a Bool es [{Convert.ToBoolean(1).ToString()}] usando el método Convert.ToBoolean()");
            Console.WriteLine($" - La conversión de Int [0] a Bool es [{Convert.ToBoolean(0).ToString()}] usando el método Convert.ToBoolean()");
            Console.WriteLine($" - La conversión del String [true] a Bool es [{bool.Parse("true").ToString()}] usando el método bool.Parse()");
            Console.WriteLine($" - La conversión del String [false] a Bool es [{bool.Parse("false").ToString()}] usando el método bool.Parse()");
            Console.WriteLine($" - El resultado del metodo bool.TryParse para [true] es [{Boolean.TryParse("true", out bool r1).ToString()}]");
            Console.WriteLine($" - El resultado del metodo bool.TryParse para [false] es [{Boolean.TryParse("false", out bool r2).ToString()}]");
            Console.WriteLine($" - El resultado del metodo bool.TryParse para [random] es [{Boolean.TryParse("random", out bool r3).ToString()}]");
        }

        static void Castear()
        {
            // 2) Explique que sucede en los siguientes intentos de casteos de datos.
            /*
             * a) int a = (int)344.4
             * En esta operación La parte decimal del valor 344.4 se truncará, lo que significa que se eliminará la parte decimal y se tomará solo la parte entera.
             * El resultado será 344 como un valor de tipo int.");
             */
            int a = (int)344.4;
            Console.WriteLine($"  a) int a = (int)344.4 -> a = {a}");
            /*
             * b) decimal b = 10
             * El valor entero 10 se asigna directamente a la variable b. C# permite esta asignación implícita porque 10 es compatible con el tipo de dato decimal.
             */
            decimal b = 10;
            Console.WriteLine($"  b) decimal b = 10 -> a = {b}");
            /*
             * c) int a=443444; short b = (short)a;
             * Un short es un tipo de dato de 16 bits, mientras que un int es un tipo de dato de 32 bits.
             * Esto significa que un short puede almacenar un rango más limitado de valores en comparación con un int.
             * Si el valor en a es mayor o menor que el rango válido para un short (-32,768 a 32,767), la conversión producirá un resultado truncado o truncado.
             */
            int c = 443444;
            short d = (short)c;
            Console.WriteLine($"  c) int a=443444; short b = (short)a -> a = {d}");
        }

        static void SentenciaSwitch()
        {
            /* 
             * 3) Escriba una sentencia switch utilizando una enumeración con 3 colores (blanco, azul y negro)
             * y para cada caso indicar un mensaje de cual es el color informado.
             */
            color Color;
            string eleccion = "Azul";
            bool sucess = Enum.TryParse<color>(eleccion, out Color);

            switch (Color)
            {
                case color.Blanco:
                    Console.WriteLine(" - El color elegido es Blanco");
                    break;
                case color.Azul:
                    Console.WriteLine(" - El color elegido es Azul");
                    break;
                case color.Negro:
                    Console.WriteLine(" - El color elegido es Negro");
                    break;
                default:
                    Console.WriteLine(" - El color elegido es Incorrecto");
                    break;
            }
        }

        public static bool SentenciaIf(int var)
        {
            /*
             * 4) Si se tiene una variable entera a, realice una sentencia if para evaluar si la variable a es mayor a 10.
             * Si es verdad, mostrar un mensaje indicando que el valor es mayor a 10. 
             * 5) Al ejercicio del punto 4), agregar la sentencia de else y, en ella, indicar un mensaje de error.
             */
            if (var > 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<int> SentenciaWhile(int a)
        {
            /*
             * 7) Defina una variable a que en cada ciclo de una sentencia while incremente su valor en 5.
             * Cuando la variable a exceda el valor de 50, el ciclo while debe finalizar.
             */
            int i = a;
            List<int> resultado = new List<int>();
            while (i <= 50)
            {
                resultado.Add(i);
                i += 5;
            }
            return resultado;

        }

    }

}