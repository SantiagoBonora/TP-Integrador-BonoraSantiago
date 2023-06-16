public class Calculadora
{

    public double Suma(double v1, double v2)
    {
        return v1 + v2;
    }

    public double Resta(double v1, double v2)
    {
        return v1 - v2;
    }
    public double Division(double v1, double v2)
    {
        return v1 / v2;
    }
    public double Multiplicacion(double v1, double v2)
    {
        return v1 * v2;
    }
    public double Modulo(double v1, double v2)
    {
        return v1 % v2;
    }

    public double Potencia(double v1, double v2)
    {
        return Math.Pow(v1, v2);
    }

    public float Promedio()
    {
        int X = 0,N = 0;
        float num,suma= 0;
        Console.WriteLine("Ingrese la cantidad de numeros a promediar");
        N = int.Parse(Console.ReadLine());
        while (X < N)
        {  
            Console.Write("Ingrese valor: ");
            num = float.Parse(Console.ReadLine());
            suma = suma + num;
            X++;
        }
        
        return suma / N;
    }





}

