using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace CheckPoint_2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("ESCOGE EL EJERCICIO QUE QUIERES PROBAR, ENTRE EL 1 y 13");
            int numEj = int.Parse(Console.ReadLine());

            switch (numEj)
            {
                case 1:


                    Console.WriteLine(" Ejercicio 1 Tarea: " +
                     "\nPedir al usuario que ingrese su nombre y su edad, guardando ambos valores en variables." +
                     "\nMostrar un mensaje de bienvenida que contenga ambos valores.");


                    Console.WriteLine("\n\n¡¡ Bienvenido !! \nIngresa tu nombre: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("\nIngresa tu edad: ");
                    int edad = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nHola " + nombre + ", tu edad es " + edad + " años.");
                    break;














                case 2:

                    Console.WriteLine("Ejercicio 2 Tarea: " +
                    "\nPedir el ingreso de un número del 0 al 9 e imprimir el nombre en letras del mismo" +
                    "\nEjemplo: Ingresamos 2 y se nos responde con el mensaje DOS");


                    Console.WriteLine("\n\nIngresa un numero entre el 0 y el 9 \nEste número sera impreso por pantalla");
                    int num = int.Parse(Console.ReadLine());
                    

                    

                    
                    if ((num >= 0) && (num <= 9))
                    {
                       switch (num)
                       {
                           case 0:
                                Console.WriteLine("\nIngresaste el número {0} y se escribe CERO. ", num);
                                break;
                            case 1:
                                Console.WriteLine("\nIngresaste el número {0} y se escribe UNO. ", num);
                                break;

                            case 2:
                                Console.WriteLine("\nIngresaste el número {0} y se escribe DOS. ", num);
                                break;

                            case 3:
                                Console.WriteLine("\nIngresaste el número {0} y se escribe TRES. ", num);
                                break;

                            case 4:
                                Console.WriteLine("\nIngresaste el número {0} y se escribe CUATRO. ", num);
                                break;

                            case 5:
                                Console.WriteLine("\nIngresaste el número {0} y se escribe CINCO. ", num);
                                break;

                            case 6:
                                Console.WriteLine("\nIngresaste el número {0} y se escribe SEIS. ", num);
                                break;

                            case 7:
                                Console.WriteLine("\nIngresaste el número {0} y se escribe SIETE. ", num);
                                break;

                            case 8:
                                Console.WriteLine("\nIngresaste el número {0} y se escribe OCHO. ", num);
                                break;

                            case 9:
                                Console.WriteLine("\nIngresaste el número {0} y se escribe NUEVE. ", num);
                                break;

                        }
                    }
                    else
                    {
                        Console.WriteLine("\nIngresaste un numero invalido, reinicia el programa.");
                    }

                    break;











                case 3:



                    Console.WriteLine("Ejercicio 3 Tarea: " +
                    "\nPedir el ingreso de dos números por consola e imprimir el de menor valor primero y el de" +
                    "\nmayor valor despues, separados por una coma");



                    Console.WriteLine("\n\nA Continuacíon ingresa dos numeros, seran impresos por pantalla de menor a mayor.");
                    Console.WriteLine("\nIngrese el primer número: ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nIngrese el segundo número: ");
                    int num2 = int.Parse(Console.ReadLine());

                    if (num1 > num2)
                    {
                        Console.WriteLine("\nOrdenado de menor a mayor: " + num2 + ", " + num1);
                    }
                    else
                    {
                        Console.WriteLine("\nOrdenado de menor a mayor: " + num1 + ", " + num2);
                    }

                    break;










                case 4:



                    Console.WriteLine("Ejercicio 4  Tarea: " +
                    "\nEscribir un programa que pida el ingreso de un numero entero y que indiquere si se trata" +
                    "\nde un numero par o un numero impar. Utilizar el operador de módulo(%)");


                    Console.WriteLine("\n\nIngresa un numero entero: ");
                    int num3 = int.Parse(Console.ReadLine());

                    if (num3 % 2 == 0)
                    {
                        Console.WriteLine("\nEl numero ingresaso {0} es par.", num3);
                    }
                    else
                    {
                        Console.WriteLine("\nEl numero ingresado {0} es impar.", num3);
                    }

                    break;









                case 5:



                    Console.WriteLine("Ejercicio 5 Tarea: " +
                                      "\nCalcula la potencia dado una base y un exponente utilizando el búcle WHILE" +
                                      "\nCalcula la potencia dado una base y un exponente utilizando el búcle FOR");

                    Console.WriteLine("\n\nCalculando ponencia, ingresa la base ");
                    long num4 = long.Parse(Console.ReadLine());

                    Console.WriteLine("\nCalculando ponencia, ingresa el exponente ");
                    long num5 = long.Parse(Console.ReadLine());
                    long num6 = num5;

                    //Cata: el num 6 es el num 5
                    //RECORDEMOS que la potencia puede tener exponente negativo. que pasa entonces con x^-1 (por leyes de exponentes eso es igual a 1/x)???
                    //con exponente -1 no va a iterar ni una vez. 
                    // exponente positivo--> se multiplica tantas veces como el valor del exponente
                    //exponente negativo--> el valor se calcula asi: si n<0 entonces x^n = (1/x^(-n)


                    long resultado_pot = num4;
                    long resultado_pot2 = num4;
                    // Usando FOR:

                    for (int i = 1; i < num5; i++)
                    {
                        resultado_pot *= num4;
                    }
                    Console.WriteLine("La potencia de un número usando FOR \nCon base " + num4 + " y un exponante " + num5 + " es " + resultado_pot);

                    // Usando While

                    while (num6 > 1)
                    {
                        resultado_pot2 *= num4;
                        num6--;
                    }
                    Console.WriteLine("\nLa potencia de un número usando WHILE \nCon base " + num4 + " y un exponante " + num5 + " es " + resultado_pot);

                    break;














                case 6:



                    Console.WriteLine("Ejercicio 6 Tarea: " +
                                       "\nA partir de un array de elementos, buscar si un valor se encuentra dentro del mismo." +
                                       "\nEn caso que se encuentre, mostrar la posición en la cual fue encontrado. " +
                                       "\nDe lo contrario, mostrar - 1");

                    Console.WriteLine("\nTeniendo el siguiente array: \n\nedades = { 20, 15, 10, 12, 28, 35, 48, 7, 5, 6, 10, 11 } ");



                    //esta bien, la cosa es que en c# hay algo que se llama linq. 
                    //https://www.tutorialspoint.com/how-to-check-in-chash-whether-the-string-array-contains-a-particular-work-in-a-string-array
                    

                    int[] edades = { 20, 15, 10, 12, 28, 35, 48, 7, 5, 6, 10, 11 };
                    Console.WriteLine("\nIngresa el valor a ser buscado:");
                    int num_buscar = int.Parse(Console.ReadLine());


                    for (int i = 0; i < edades.Length; i++)

                    if (num_buscar == edades[i])  //1ra 
                    //if (edades.Contains(num_buscar)) // usando lo del link pero no logro con esta sacar la posicion 
                        Console.WriteLine("\nEN POSICION " + i + ": EL NÚMERO INGRESADO (" + num_buscar + ") FUE ENCONTADO !!" );
                    else
                        Console.WriteLine("\nEn Posicion " + i + ": El número ingresado no se encuentra, -1" );






                    break;







                case 7:

                    Console.WriteLine("Ejercicio 7 Tarea: " +
                                      "\nDeterminar que puntaje extra le corresponde a un jugador luego de pedirle que " +
                                      "\ningrese dicho valor. Los puntajes ingresados iran de 0 a 9." +
                                      "\n\n• Si el puntaje ingresado esta entre 1 y 3 inclusive, le suma 10 veces el puntaje ingresado" +
                                      "\n• Si el puntaje ingresado esta entre 7 y 9 inclusive, le suma 1000 veces el puntaje ingresado" +
                                      "\n• Para puntajes mayores a 9 ó 0, se emitirá un mensaje de error");



                    Console.WriteLine("\n\n\nIngresa tu puntaje:");
                    int puntaje = int.Parse(Console.ReadLine());
                    int n_Puntaje;
                    if ((puntaje > 9) && (puntaje < 0))
                    {
                        Console.WriteLine("\n\nEl puntaje ingresado es erroneo. ");
                    }
                    else if ((puntaje > 0) && (puntaje < 4))
                    {
                        n_Puntaje = puntaje * 10;
                        Console.WriteLine("\nEl puntaje extra del puntaje ingresado (" + puntaje + ") es: " + n_Puntaje);
                    }
                    else if ((puntaje > 6) && (puntaje < 10))
                    {
                        n_Puntaje = puntaje * 1000;
                        Console.WriteLine("\nEl puntaje extra del puntaje ingresado (" + puntaje + ") es: " + n_Puntaje);
                    }
                    else if ((puntaje > 3) && (puntaje < 7))
                    {
                        Console.WriteLine("\nEl puntaje ingresado (" + puntaje + ") no tiene puntaje extra.");
                    }



                    break;






                case 8:

                    Console.WriteLine("Ejercicio 8 Tarea:" +
                                      " \r\nPartiendo de un array de números declarado, ordenar el mismo y mostrar" +
                                      "\r\nel resultado del array ordenado");


                    Console.WriteLine("teniendo el siguiente Array:" +
                        "\n\n sinOrdenar = { 10, 18, 22, 65, 8, 0, 126, 8, 996, 7, 2, 5, 23, 75, 44, 29, 24 } \n\n");


                    int[] sinOrdenar = { 10, 18, 22, 65, 8, 0, 126, 8, 996, 7, 2, 5, 23, 75, 44, 29, 24 };
                    int[] ordenado = new int[17];
                    Array.Sort(sinOrdenar);

                    for (int i = 0; i < sinOrdenar.Length; i++)
                    {
                        ordenado[i] = sinOrdenar[i];
                        Console.WriteLine("Posición " + i + ": " + ordenado[i]);
                    }

                    Console.WriteLine("\n\n Array Ordenado = { " + (string.Join(", ", ordenado) + " }"));

                    break;













                case 9:

                    Console.WriteLine("• Ejercicio 9 Tarea: " +
                                      " \nPartiendo de un array de números declarado dentro del código, calcular el promedio " +
                                      " \ny mostrarlo por consola." +
                                      " \n\nRecodemos, la formula del promedio : (A1 + ...An) / n ");

                    Console.WriteLine("teniendo el siguiente Array:" +
                       "\n\n Array = { 10, 18, 22, 65, 8, 0, 126, 8, 996, 7, 2, 5, 23, 75, 44, 29, 24 } \n\n");

                    //existe en linq el .SUM

                    
                    int[] arrayPromedio = { 10, 18, 22, 65, 8, 0, 126, 8, 996, 7, 2, 5, 23, 75, 44, 29, 24 };
                    int suma = arrayPromedio.Sum(); // Corrijo con .Sum()

                    //for (int a = 0; a < arrayPromedio.Length; a++)
                    // {
                    //   suma += arrayPromedio[a];
                    //}
                    Console.WriteLine("La suma total es: " + suma);
                    Console.WriteLine("El promedio es: " + suma / arrayPromedio.Length);


                    break;










                case 10:
                    Console.WriteLine("Ejercicio 10Tarea" +
                                      "\r\nDeclarar un array tamaño 10 y completarlo con valores contiguos empezando por un " +
                                      " numero ingresado por consola." +
                                      "\r\nImprimir en pantalla el contenido del array por cada una de sus posiciones");


                    int[] array2 = new int[10]; //kah  // Asi estan en EDU IT, se inicializa y se declara el tamaño del Array, solo que lo hice en un solo renglon 
                    Console.WriteLine("\n\nIngrese valor agregar al Array");
                    ;
                    for (int i = 0; i < 10; i++)
                    {
                        int dato = int.Parse(Console.ReadLine());
                        array2[i] = dato;
                    }

                    Console.WriteLine("\n\n Array = { " + (string.Join(", ", array2) + " }"));



                    break;













                case 11:

                    Console.WriteLine("Ejercicio 11 Tarea:" +
                                      "\r\nPidiendo una palabra o frase por consola comprobar si la misma es un palíndromo o no. " +
                                      "\r\nInformar el resultado.\r\nEjemplo de palíndromo: Anita lava la tina - Se lee igual de izquiera a derecha y de derecha a izquierda\r\n");

                    Console.WriteLine("\nIngrese palabra o frase: ");
                    string palin = Console.ReadLine();
                    string palin2 =  "";
            
                    for (int i = palin.Length -1 ; i >= 0; i--)
                    {
                        palin2 += palin[i];
                    }
                      Console.WriteLine("\n\nLa frase o palabra invertida: " + palin2);



                    if ((palin.Replace(" ",String.Empty).ToLower()).Equals(palin2.Replace(" ", String.Empty).ToLower()))
                        Console.WriteLine("\n\n¡ La Palabra o frase ingresada es un palíndromo.! ");
                    else
                        Console.WriteLine("\n\nLa palabra o frase que ingresaste no es un palíndromo.\n\nSigue intentando.");

                



                    break;










                case 12:
                    Console.WriteLine("Ejercicio 12 Tarea:" +
                        "\n Dado un valor de temperatura por consola y elegida una opcion de conversión," +
                        "\n convertir el valor según corresponda. Las opciones de conversión seran:" +
                        "\r\n Grados Celsius a Grados Fahrenheit" +
                        "\r\n Grados Fahrenheit a Grados Celsius" +
                        "\r\n Grados Kelvin a Grados Celcius" + 
                        "\n" +
                        "\r\no Dado un valor de distancia por consola y elegida una opcion de conversión," +
                        "\r\nconvertir el valor según corresponda. Las opciones de conversión seran:" +
                        "\r\n Metros a Pies" +
                        "\r\n Kilometros a Millas" +
                        "\r\n Centimetros a Pulgadas");


                    Console.WriteLine("\n\nQUE DESEA CONVERTIR ?? \n\n1. PARA TEMPERATURA.\n\n2. PARA DISTANCIA");
                    int usuario = int.Parse(Console.ReadLine());

                    if (usuario == 1)
                    {
                        Console.WriteLine("\n\n\nIngrese la temperatura que desea convertir: ");
                        double tempU = double.Parse(Console.ReadLine());

                        Console.WriteLine("Escoja una opcion de conversion: " +
                                          "\n 1. Grados Celsius a Grados Fahrenheit." +
                                          "\n 2. Grados Fahrenheit a Grados Celsius " +
                                          "\n 3. Grados Kelvin a Grados Celcius");

                        int tipo_con = int.Parse(Console.ReadLine());


                        switch (tipo_con)
                        {
                            case 1:   // F = 1,8* C+32
                                double tempF = 1.8 * tempU + 32;
                                Console.Write("\nIngresaste " + tempU + "° celsius, que equivalen a " + tempF + "° Fahrenheit\n");
                                break;


                            case 2:  // C=( F- 32)/1,8
                                double tempC = (tempU - 32) / 1.8;
                                Console.Write("\nIngresaste " + tempU + "° Fahrenheit, que equivalen a " + tempC + "° celsius. \n");
                                break;


                            case 3: //La temperatura en grados Celsius (° C) es igual a la temperatura en Kelvin (K) menos 273.15:
                                double tempK = tempU - 273.15;
                                Console.Write("\nIngresaste " + tempU + "k (Kelvin), que equivalen a " + tempK + "° celsius. \n");
                                break;

                            default:
                                Console.WriteLine("\n\nERROR, INGRESO UN VALOR INVALIDO.");
                                break;
                        }
                    }
                    else if (usuario == 2)
                    {


                        Console.WriteLine("\n\n\nIngrese la distancia que desea convertir: ");
                        double distU = double.Parse(Console.ReadLine());


                        Console.WriteLine("Escoja una opcion de conversion: " +
                                          "\n 1. Metros a Pies." +
                                          "\n 2. Kilometros a Millas. " +
                                          "\n 3. Centimetros a Pulgadas. ");

                        int tipo_con2 = int.Parse(Console.ReadLine());

                        switch (tipo_con2)
                        {
                            case 1: //1 metro equivale a 3.28 pies 
                                double distP = distU * 3.28;
                                Console.WriteLine("\nIngresaste " + distU + "m que equivalen a " + distP + "ft (Pies) ");
                                break;

                            case 2: // 1 km equivale a 0.6214 millas
                                double distM = distU * 0.6214;
                                Console.WriteLine("\nIngresaste " + distU + "Km que equivalen a " + distM + "mi (Millas). ");
                                break;

                            case 3://1 cm es igual a 0,394 pulgadas
                                double distPu = distU * 0.39;
                                Console.WriteLine("\nIngresaste " + distU + " cm que equivalen a " + distPu + " (Pulgadas). ");
                                break;

                            default:
                                Console.WriteLine("\n\nERROR, INGRESO UN VALOR INVALIDO.");
                                break;

                        }
                    }
                    else
                        Console.WriteLine("\n\nERROR, INGRESO UN VALOR INVALIDO.");

                break;







                case 13:

                    Console.WriteLine("Ejercicio 13 Tarea:" +
                                      "\r\nDesarrolle una calculadora de interes para los clientes de un banco dado por linea de comando un capital inicial," +
                                      " taza anual(taza por periodo) y cantidad de años(cantidad de periodos)." +
                                      "\r\nLa formula a utilizar es: el capital acumulado del periodo anterior + (taza * el capital acumulado)." +
                                      "\r\nEjemplo:" +
                                      "\r\nPeriodos p = 4 | Taza i = 10 % | Capital inicial c = $1000" +
                                      "\r\np = 1 | capital acumulado = $1000 | interes = (capital acumulado * taza) $1000 * 0.1 = $100" +
                                      "\r\np = 2 | capital acumulado = $1100 | interes = (capital acumulado * taza) $1100 * 0.1 = $110" +
                                      "\r\np = 3 | capital acumulado = $1210 | interes = (capital acumulado * taza) $1210 * 0.1 = $121" +
                                      "\r\np = 4 | capital acumulado = $1331 | interes = (capital acumulado * taza) $1331 * 0.1 = $133" +
                                      "" +
                                      "\r\nIntereses acumulado a lo largo al final del 4 periodo $464" +
                                      "\r\nA tener en cuenta, el sistema tiene que ser a prueba de errores por lo tanto:" +
                                      "\r\nPara prevenir errores de los usuarios, no permite tazas negativas," +
                                      "\r\nemite un error cuando se ingresa un valor negativo." +
                                      "\r\nLos intereses no pueden sobrepasar un maximo del 50%. Emite un error por pantalla cuando se ingresa un valor que sobrepasa el 50% de interes." +
                                      "\r\nEl Capital no puede ser negativo, emite un error por pantalla cuando se ingresa un valor negativo." +
                                      "\r\nAl final emite un informe con los datos ingresados, el capital final y el interes generado.");


                    Console.WriteLine("\n\n\nBIENVENIDO, ESTA ES UNA CALCULADORA DE INTERESES.");
                    Console.WriteLine("\n Ingrese su capital inicial:");

                    long capIni = long.Parse(Console.ReadLine());
                    if(capIni < 0)
                    {
                        Console.WriteLine("\n\nERROR, INGRESO UN VALOR INVALIDO.");
                        break;
                    }

                    Console.WriteLine("\nIngrese su taza anual teniendo encuenta que: " +
                                      "\nTaza 10% ingresar 0,1" +
                                      "\nTaza 20% Ingresar 0,2" +
                                      "\nTaza 30% Ingresar 0.3");
                      
                    double taza = double.Parse(Console.ReadLine());
                    if (taza < 0)
                    {
                        Console.WriteLine("\n\nERROR, INGRESO UN VALOR INVALIDO.");
                        break;
                    }

                    Console.WriteLine("\n Ingrese su cantidad de años:");
                    int pe = int.Parse(Console.ReadLine());
                    if (pe < 0)
                    {
                        Console.WriteLine("\n\nERROR, INGRESO UN VALOR INVALIDO.");
                        break;
                    }

                    double capAcu = capIni;
                    double intTotal=0;

                    for (int i = 1; i <= pe; i++) //el capital acumulado del periodo anterior + (taza * el capital acumulado)
                    {
                        Console.WriteLine("Periodo " + i + " | capital acumulado = " + capAcu + " | interes = " + (taza * capAcu));
                        double interes = (taza * capAcu);
                        intTotal += interes; 
                            
                        capAcu = capAcu + (taza * capAcu);   
                    }
                    
                    if(intTotal > (capIni/2) )
                        Console.WriteLine("\n\nERROR, INGRESO INVALIDO, INTERES TOTAL (" +intTotal+") SUPERA EL 50% DEL VALOR INICIAL");
                    else
                    {
                        Console.WriteLine("\n\nCapital inicial = $" + capIni + "\nCapital final acumulado = $" + capAcu + "\nInteres total ganado = $" + intTotal);
                    }

                  break;
            }

















        }
    }
}
