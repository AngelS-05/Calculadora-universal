using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_universal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Calculadora Universal");
            Console.WriteLine("---------------------");

            double Gramo, Kilogramo, Miligramo, Tonelada, Libra, Onza;
            bool Aranque = true;
            int menu, menu2;
            float T, A, L, B;
            int menu1, menu3,menu4;

            while (Aranque)
            {
                Console.WriteLine("1. Calculadora Basica");
                Console.WriteLine("2. Area y Perimetro");
                Console.WriteLine("3. Peso y masa");
                Console.WriteLine("4. Salir");
                if (!int.TryParse(Console.ReadLine(), out menu1))
                {
                    Console.WriteLine("Opción inválida. Por favor, ingrese un número.");
                    continue;
                }
                switch (menu1)
                {

                //Calculadora Basica//

                    case 1:
                        Console.WriteLine("Calculadora Basica");
                        double N1;
                        double N2;
                        Console.WriteLine("Ingresar primer dato");
                        if (!double.TryParse(Console.ReadLine(),out N1))
                        {
                            Console.WriteLine("\"Opción inválida. Por favor, ingrese un número.\"");
                            continue;
                        }
                        Console.WriteLine("Ingresar el segundo dato");
                        if (!double.TryParse(Console.ReadLine(), out N2))
                        {
                            Console.WriteLine("\"Opción inválida. Por favor, ingrese un número.\"");
                            continue;
                        }
                        Console.WriteLine("Selccionar Operacion: +, -, *, /");
                        char OP;
                        OP = char.Parse(Console.ReadLine());
                            switch (OP)
                            {
                                case '+':
                                    double R5 = N1+N2;
                                    Console.WriteLine("El resultado de la suma es:"+R5);
                                    Console.ReadKey();
                                    Console.Clear();
                                break;
                                case '-': 
                                    double R2 = N1 - N2;
                                    Console.WriteLine("El resultado de la resta es:" + R2);
                                
                                    Console.ReadKey();
                                    Console.Clear();
                                break;
                                case '*': 
                                    double R1 = N1*N2;
                                    Console.WriteLine("El resultado de la multiplicacion es:"+R1);
                                    Console.ReadKey();
                                    Console.Clear();
                                break;
                                case '/': 
                                    double R3 = N1/N2;
                                    Console.WriteLine("El resultado de la division es:"+ R3);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                default:
                                Console.WriteLine("Opcion no valida");
                                Console.ReadKey();
                                Console.Clear();
                                    break;
                            }
                        break;

                //Area y Perimetro//

                    case 2:
                        Console.WriteLine("Calculadora Area y perimetro");
                        Console.WriteLine("1. Área");
                        Console.WriteLine("2. Perímetro");
                        Console.WriteLine("3. Salir");
                        if (!int.TryParse(Console.ReadLine(), out menu))
                        {
                            Console.WriteLine("Opción inválida. Por favor, ingrese un número.");
                            continue; // Volver al inicio del bucle
                        }

                        switch (menu)
                        {
                            case 1:
                                Console.WriteLine("1. Cuadrado");
                                Console.WriteLine("2. Rectángulo");
                                Console.WriteLine("3. Triángulo");
                                Console.WriteLine("4. Círculo");
                                if (!int.TryParse(Console.ReadLine(), out menu2))
                                {
                                    Console.WriteLine("Opción inválida. Por favor, ingrese un número.");
                                    continue;
                                }

                                switch (menu2)
                                {
                                    case 1:
                                        Console.Write("Ingrese el lado del cuadrado: ");
                                        L = float.Parse(Console.ReadLine());
                                        Console.WriteLine("El área del cuadrado es: " + (L * L));
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 2:
                                        Console.Write("Ingrese la base del rectángulo: ");
                                        B = float.Parse(Console.ReadLine());
                                        Console.Write("Ingrese la altura del rectángulo: ");
                                        A = float.Parse(Console.ReadLine());
                                        Console.WriteLine("El área del rectángulo es: " + (B * A));
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 3:
                                        Console.Write("Ingrese la base del triángulo: ");
                                        B = float.Parse(Console.ReadLine());
                                        Console.Write("Ingrese la altura del triángulo: ");
                                        A = float.Parse(Console.ReadLine());
                                        Console.WriteLine("El área del triángulo es: " + (B * A) / 2);
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 4:
                                        Console.Write("Ingrese el radio del círculo: ");
                                        T = float.Parse(Console.ReadLine());
                                        Console.WriteLine("El área del círculo es: " + (3.1416 * T * T));
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    default:
                                        Console.WriteLine("Opción inválida.");
                                        break;
                                }
                                break;

                            case 2:
                                Console.WriteLine("1. Cuadrado");
                                Console.WriteLine("2. Rectángulo");
                                Console.WriteLine("3. Triángulo");
                                Console.WriteLine("4. Círculo");
                                if (!int.TryParse(Console.ReadLine(), out menu2))
                                {
                                    Console.WriteLine("Opción inválida. Por favor, ingrese un número.");
                                    continue;
                                }

                                switch (menu2)
                                {
                                    case 1:
                                        Console.Write("Ingrese el lado del cuadrado: ");
                                        L = float.Parse(Console.ReadLine());
                                        Console.WriteLine("El perímetro del cuadrado es: " + (4 * L));
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 2:
                                        Console.Write("Ingrese la base del rectángulo: ");
                                        B = float.Parse(Console.ReadLine());
                                        Console.Write("Ingrese la altura del rectángulo: ");
                                        A = float.Parse(Console.ReadLine());
                                        Console.WriteLine("El perímetro del rectángulo es: " + (2 * (B + A)));
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 3:
                                        Console.Write("Ingrese la base del triángulo: ");
                                        B = float.Parse(Console.ReadLine());
                                        Console.Write("Ingrese la altura del triángulo: ");
                                        A = float.Parse(Console.ReadLine());
                                        Console.Write("Ingrese el lado del triángulo: ");
                                        L = float.Parse(Console.ReadLine());
                                        Console.WriteLine("El perímetro del triángulo es: " + (B + A + L));
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 4:
                                        Console.Write("Ingrese el radio del círculo: ");
                                        T = float.Parse(Console.ReadLine());
                                        Console.WriteLine("El perímetro del círculo es: " + (2 * 3.1416 * T));
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    default:
                                        Console.WriteLine("Opción inválida.");
                                        break;
                                }
                                 break;
                        }
                        break ;

                    //Peso y Masa//

                    case 3:
                            Console.WriteLine("Calculadora de Peso y Masa");
                            Console.WriteLine("Seleccionar Uniadad de Medida del dato");
                            Console.WriteLine("1. Miligramos");
                            Console.WriteLine("2. Gramos");
                            Console.WriteLine("3. Onzas");
                            Console.WriteLine("4. Libras");
                            Console.WriteLine("5. Kilogramos");
                            Console.WriteLine("6. Tonelada");
                        if (!int.TryParse(Console.ReadLine(), out menu3))
                        {
                            Console.WriteLine("\"Opción inválida. Por favor, ingrese un número.\"");
                            continue;
                        }
                        switch (menu3)
                        {
                            case 1:
                                Console.WriteLine("Ingrese los miligramos a convertir");
                                if (!double.TryParse(Console.ReadLine(),out Miligramo))
                                {
                                    Console.WriteLine("\"Opción inválida. Por favor, ingrese un número.\"");
                                    continue;
                                }
                                Console.WriteLine("Unidad de medida a convertir");
                                Console.WriteLine("1. Gramos");
                                Console.WriteLine("2. Onzas");
                                Console.WriteLine("3. Libras");
                                Console.WriteLine("4. Kilogramos");
                                Console.WriteLine("5. Tonelada");
                                if (!int.TryParse(Console.ReadLine(), out menu4))
                                {
                                    Console.WriteLine("\"Opción inválida. Por favor, ingrese un número.\"");
                                    continue;
                                }
                                switch (menu4)
                                {
                                    case 1:
                                        Console.WriteLine(Miligramo/1000+" g");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 2:
                                        Console.WriteLine(Miligramo/28349.5+ " oz");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 3: 
                                        Console.WriteLine(Miligramo/453592.37+ " lb");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 4:  
                                        Console.WriteLine(Miligramo/1000000 + " kg");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 5:
                                        Console.WriteLine(Miligramo / 1000000000000 + " t");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    default:
                                        Console.WriteLine("Opcion no valida");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                }
                                break;
                            case 2:
                                Console.WriteLine("Ingrese los gramos a convertir");
                                if (!double.TryParse(Console.ReadLine(), out Gramo))
                                {
                                    Console.WriteLine("\"Opción inválida. Por favor, ingrese un número.\"");
                                    continue;
                                }
                                Console.WriteLine("Unidad de medida a convertir");
                                Console.WriteLine("1. Miligramos");
                                Console.WriteLine("2. Onzas");
                                Console.WriteLine("3. Libras");
                                Console.WriteLine("4. Kilogramos");
                                Console.WriteLine("5. Tonelada");
                                if (!int.TryParse(Console.ReadLine(), out menu4))
                                {
                                    Console.WriteLine("\"Opción inválida. Por favor, ingrese un número.\"");
                                    continue;
                                }
                                switch (menu4)
                                {
                                    case 1:
                                        Console.WriteLine(Gramo * 1000 + " mg");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 2:
                                        Console.WriteLine(Gramo / 0.03527396 + " oz");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 3:
                                        Console.WriteLine(Gramo / 0.00220462 + " lb");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 4:
                                        Console.WriteLine(Gramo / 1000 + " kg");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 5:
                                        Console.WriteLine(Gramo / 1000000 + " t");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    default:
                                        Console.WriteLine("Opcion no valida");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                }
                                break;
                            case 3:
                                Console.WriteLine("Ingrese las onzas a convertir");
                                if (!double.TryParse(Console.ReadLine(), out Onza))
                                {
                                    Console.WriteLine("\"Opción inválida. Por favor, ingrese un número.\"");
                                    continue;
                                }
                                Console.WriteLine("Unidad de medida a convertir");
                                Console.WriteLine("1. Miligramos");
                                Console.WriteLine("2. Gramos");
                                Console.WriteLine("3. Libras");
                                Console.WriteLine("4. Kilogramos");
                                Console.WriteLine("5. Tonelada");
                                if (!int.TryParse(Console.ReadLine(), out menu4))
                                {
                                    Console.WriteLine("\"Opción inválida. Por favor, ingrese un número.\"");
                                    continue;
                                }
                                switch (menu4)
                                {
                                    case 1:
                                        Console.WriteLine(Onza * 28349.5 + " mg");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 2:
                                        Console.WriteLine(Onza * 28.3495 + " g");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 3:
                                        Console.WriteLine(Onza / 16 + " lb");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 4:
                                        Console.WriteLine(Onza / 35274000 + " kg");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 5:
                                        Console.WriteLine(Onza / 35274000 + " t");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    default:
                                        Console.WriteLine("Opcion no valida");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                }
                                break;
                            case 4:
                                Console.WriteLine("Ingrese las libras a convertir");
                                if (!double.TryParse(Console.ReadLine(), out Libra))
                                {
                                    Console.WriteLine("\"Opción inválida. Por favor, ingrese un número.\"");
                                    continue;
                                }
                                Console.WriteLine("Unidad de medida a convertir");
                                Console.WriteLine("1. Miligramos");
                                Console.WriteLine("2. Gramos");
                                Console.WriteLine("3. onzas");
                                Console.WriteLine("4. Kilogramos");
                                Console.WriteLine("5. Tonelada");
                                if (!int.TryParse(Console.ReadLine(), out menu4))
                                {
                                    Console.WriteLine("\"Opción inválida. Por favor, ingrese un número.\"");
                                    continue;
                                }
                                switch (menu4)
                                {
                                    case 1:
                                        Console.WriteLine(Libra * 453592.37 + " mg");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 2:
                                        Console.WriteLine(Libra * 453.592 + " g");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 3:
                                        Console.WriteLine(Libra * 16 + " oz");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 4:
                                        Console.WriteLine(Libra / 2.20462 + " kg");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 5:
                                        Console.WriteLine(Libra / 2204.62 + " t");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    default:
                                        Console.WriteLine("Opcion no valida");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                }
                                break;
                            case 5:
                                Console.WriteLine("Ingrese los Kilogramos a convertir");
                                if (!double.TryParse(Console.ReadLine(), out Kilogramo))
                                {
                                    Console.WriteLine("\"Opción inválida. Por favor, ingrese un número.\"");
                                    continue;
                                }
                                Console.WriteLine("Unidad de medida a convertir");
                                Console.WriteLine("1. Miligramos");
                                Console.WriteLine("2. Gramos");
                                Console.WriteLine("3. onzas");
                                Console.WriteLine("4. Libras");
                                Console.WriteLine("5. Tonelada");
                                if (!int.TryParse(Console.ReadLine(), out menu4))
                                {
                                    Console.WriteLine("\"Opción inválida. Por favor, ingrese un número.\"");
                                    continue;
                                }
                                switch (menu4)
                                {
                                    case 1:
                                        Console.WriteLine(Kilogramo * 1000000 + " mg");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 2:
                                        Console.WriteLine(Kilogramo * 1000 + " g");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 3:
                                        Console.WriteLine(Kilogramo * 35.274 + " oz");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 4:
                                        Console.WriteLine(Kilogramo * 2.20462 + " lb");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 5:
                                        Console.WriteLine(Kilogramo / 1000 + " t");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    default:
                                        Console.WriteLine("Opcion no valida");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                }
                                break;
                            case 6:
                                Console.WriteLine("Ingrese las Toneladas a convertir");
                                if (!double.TryParse(Console.ReadLine(), out Tonelada))
                                {
                                    Console.WriteLine("\"Opción inválida. Por favor, ingrese un número.\"");
                                    continue;
                                }
                                Console.WriteLine("Unidad de medida a convertir");
                                Console.WriteLine("1. Miligramos");
                                Console.WriteLine("2. Gramos");
                                Console.WriteLine("3. onzas");
                                Console.WriteLine("4. Libras");
                                Console.WriteLine("5. Kilogramos");
                                if (!int.TryParse(Console.ReadLine(), out menu4))
                                {
                                    Console.WriteLine("\"Opción inválida. Por favor, ingrese un número.\"");
                                    continue;
                                }
                                switch (menu4)
                                {
                                    case 1:
                                        Console.WriteLine(Tonelada * 1000000000000 + " mg");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 2:
                                        Console.WriteLine(Tonelada * 1000000 + " g");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 3:
                                        Console.WriteLine(Tonelada * 35274000 + " oz");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 4:
                                        Console.WriteLine(Tonelada * 2204.62 + " lb");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 5:
                                        Console.WriteLine(Tonelada * 1000 + " kg");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    default:
                                        Console.WriteLine("Opcion no valida");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                }
                                break;
                        }
                        break;
                    case 4:
                        Aranque = false;
                        break;
                }
            }
        }
    }
}
