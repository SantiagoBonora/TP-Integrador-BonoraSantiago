using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        

        // GENERIC HOST 6)
        Host.CreateDefaultBuilder(args)
        .ConfigureServices(services =>
        {
            
            services.AddHostedService<Logg>();
        })
        .Build()
        .RunAsync();
        


        // Cree una clase con métodos donde utilice los operadores de asignación compuesta +=,
        //  ++, &, ||, ?. Adicionalmente agregue un caso donde dado el número -7 (base 10) en 32
        //bits donde desplace el bit mas significativo realizando un desplazamiento aritmético, y
        //calcule el resultado final en base 10.


        int bin = -7;
        Console.WriteLine(Convert.ToString(bin>>>1, toBase:2).PadLeft(32,'0'));
        Console.WriteLine(Convert.ToString(bin>>>1, toBase:10));
        Console.WriteLine(bin>>>1);





        
        Console.Title = "Calculadora";
        string resp = "";
        Calculadora calculadora = new Calculadora();
        AreaPerimetro areaPerimetro = new AreaPerimetro();
        ConversorTemperatura conversorTemperatura = new ConversorTemperatura();
        ConversorUnidades conversorUnidades = new ConversorUnidades();
        ConversorMoneda conversorMoneda = new ConversorMoneda();
        Restaurant resto1 = new Restaurant();
        ProductosResto prod1 = new ProductosResto(1,"Hot Dog", 2);
        ProductosResto prod2 = new ProductosResto(2,"French fries", 1);
        ProductosResto prod3 = new ProductosResto(3,"Soda", 0.85);
        resto1.addProduct(prod1);
        resto1.addProduct(prod2);
        resto1.addProduct(prod3);



        double valor1 = 0;
        double valor2 = 0;
        double R = 0;
        do
        {

            Console.WriteLine("Presione el simbolo y luego enter para realizar la operacion:");
            Console.WriteLine("+ para sumar");
            Console.WriteLine("- para restar");
            Console.WriteLine("* para multiplicar");
            Console.WriteLine("/ para dividir");
            Console.WriteLine("p para potencia");
            Console.WriteLine("% para modulo");
            Console.WriteLine("m para promedio");
            Console.WriteLine("t para area de triangulo");
            Console.WriteLine("c para perimetro de circulo");
            Console.WriteLine("f conversor temperatura celsius a Fahrenheit");
            Console.WriteLine("u conversor temperatura centimetros a pulgadas");
            Console.WriteLine("d conversor pesosArg a Dolares");
            Console.WriteLine("r calcular cuenta restaurant");
            Console.Write("Eliga Una Opcion: ");
            resp = Console.ReadLine();
            string eleccion = Convert.ToString(resp);

            switch (eleccion)
            {
                case "+":
                    Console.WriteLine("Ingrese los numeros");
                    Console.Write("Valor1: ");
                    valor1 = int.Parse(Console.ReadLine());
                    Console.Write("Valor2: ");
                    valor2 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("El resultado de la suma es:");

                    R = calculadora.Suma(valor1, valor2);
                    Console.WriteLine("{0} + {1} = {2}", valor1, valor2, R);
                    break;
                case "-":
                    Console.WriteLine("Ingrese los numeros");
                    Console.Write("Valor1: ");
                    valor1 = int.Parse(Console.ReadLine());
                    Console.Write("Valor2: ");
                    valor2 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("El resultado de la resta es:");
                    R = calculadora.Resta(valor1, valor2);
                    Console.WriteLine("{0} - {1} = {2}", valor1, valor2, R);
                    break;
                case "*":
                    Console.WriteLine("Ingrese los numeros");
                    Console.Write("Valor1: ");
                    valor1 = int.Parse(Console.ReadLine());
                    Console.Write("Valor2: ");
                    valor2 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("El resultado de la multiplicacion es:");
                    R = calculadora.Multiplicacion(valor1, valor2);
                    Console.WriteLine("{0} * {1} = {2}", valor1, valor2, R);
                    break;
                case "/":
                    Console.WriteLine("Ingrese los numeros");
                    Console.Write("Valor1: ");
                    valor1 = int.Parse(Console.ReadLine());
                    Console.Write("Valor2: ");
                    valor2 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (valor2 != 0)
                    {
                        Console.WriteLine("El resultado de la division es:");
                        R = calculadora.Division(valor1, valor2);
                        Console.WriteLine("{0} / {1} = {2}", valor1, valor2, R);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("No se puede divir por 0");
                        break;
                    }
                case "p":
                    Console.WriteLine("Ingrese los numeros");
                    Console.Write("Valor1: ");
                    valor1 = int.Parse(Console.ReadLine());
                    Console.Write("Valor2: ");
                    valor2 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("El resultado de la potenciación es:");
                    R = calculadora.Potencia(valor1, valor2);
                    Console.WriteLine("{0} ^ {1} = {2}", valor1, valor2, R);
                    break;
                case "%":
                    Console.WriteLine("Ingrese los numeros");
                    Console.Write("Valor1: ");
                    valor1 = int.Parse(Console.ReadLine());
                    Console.Write("Valor2: ");
                    valor2 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("El resultado del modulo es:");
                    R = calculadora.Modulo(valor1, valor2);
                    Console.WriteLine("{0} % {1} = {2}", valor1, valor2, R);
                    break;
                case "m":
                    Console.WriteLine("El resultado del promedio es:");
                    R = calculadora.Promedio();
                    Console.WriteLine("El promedio es {0}",R);
                    break;
                case "t":
                    Console.WriteLine("Ingrese los numeros");
                    Console.Write("Base: ");
                    valor1 = int.Parse(Console.ReadLine());
                    Console.Write("Altura: ");
                    valor2 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("El resultado del área del triangulo es:");
                    R = areaPerimetro.AreaTriangulo(valor1, valor2);
                    Console.WriteLine("{0} * {1} / 2 = {2}", valor1, valor2, R);
                    break;
                case "c":
                    Console.WriteLine("Ingrese radio del circulo");
                    Console.Write("Radio: ");
                    valor1 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("El resultado del perimetro del circulo es:");
                    R = areaPerimetro.PerimetroCirculo(valor1);
                    Console.WriteLine("{0}", R);
                    break;
                case "f":
                    Console.WriteLine("Ingrese los numeros");
                    Console.Write("Grados en Celsius: ");
                    valor1 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("El resultado de la conversion es:");
                    R = conversorTemperatura.CelsiusToFahrenheit(valor1);
                    Console.WriteLine("{0}° Fahrenheit", R);
                    break;
                case "u":
                    Console.WriteLine("Ingrese los centimetros a convertir");
                    Console.Write("Cms: ");
                    valor1 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("El resultado de la conversion es:");
                    R = conversorUnidades.CentimetrosToPulgadas(valor1);
                    Console.WriteLine("{0} Pulgadas", R);
                    break;
                case "d":
                    Console.WriteLine("Ingrese los pesosArg a convertir y cotizacion del dolar");
                    Console.Write("PesosArg: ");
                    valor1 = int.Parse(Console.ReadLine());
                    Console.Write("Cotizacion del dolar: ");
                    valor2 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("El resultado de la conversion es:");
                    R = conversorMoneda.PesosArgToDolar(valor1, valor2);
                    Console.WriteLine("{0} Dolares", R);
                    break;
                case "r":
                    R = resto1.CalcularCuenta();
                    Console.WriteLine("Su cuenta es de ${0} ", R);
                    break;
            }
            Console.Write("¿Desea Continuar? s/n: ");
            resp = Console.ReadLine();
        }
        while (resp == "s" || resp == "s");
    }

    //
}

