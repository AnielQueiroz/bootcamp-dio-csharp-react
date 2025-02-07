using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp_DIO.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine(x * y);
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine(x / y);
        }

        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine(pot);
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"seno de {angulo} = {Math.Round(seno, 4)}");
        }
        
        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"coseno de {angulo} = {Math.Round(coseno, 4)}");
        }
        
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"tangente de {angulo} = {Math.Round(tangente, 4)}");
        }
    }
}