using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVetor
{
    class Exercicio05
    {
        public Exercicio05()
        {
            double[] peso = new double[5];

            Console.Write("\nPeso1: ");
            peso[0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nPeso2: ");
            peso[1] = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nPeso3: ");
            peso[2] = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nPeso4: ");
            peso[3] = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nPeso5: ");
            peso[4] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            double soma = (peso[0] + peso[1]  + peso[2] + peso[3] + peso[4]);

            double media = (peso[0] + peso[1] + peso[2] + peso[3] + peso[4]) / 5;

            Console.WriteLine("Soma: " + soma + " kg");
            Console.WriteLine("Média: " + media);



        }
    }
}
