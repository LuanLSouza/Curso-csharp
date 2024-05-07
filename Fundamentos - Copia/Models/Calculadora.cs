using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x+y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x-y}");
        }

        public void Mutiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x*y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x/y}");
        }

        public void Potencia(int x, int y)
        {
            double potencia = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {potencia}");
        } 

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double retorno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(retorno, 4)}");
        }

        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double retorno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo} = {Math.Round(retorno, 4)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double retorno = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo} = {Math.Round(retorno, 4)}");
        }           

        public void RaizQuadrada(double x)
        {
            double retorno = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {Math.Round(retorno, 4)}");
        }       

    }
}