using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVetor
{
    class Exercicio04
    {
        public Exercicio04()
        {
            double[] nota = new double[4];

            Console.Write("\nDisciplina: ");
            string disciplina = Console.ReadLine();

            Console.Write("\nNota1: ");
            nota[0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nNota2: ");
            nota[1] = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nNota3: ");
            nota[2] = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nNota4: ");
            nota[3] = Convert.ToDouble(Console.ReadLine());

            double media = (nota[0] + nota[1] + nota[2] + nota[3]) / 4;

            Console.WriteLine("\nMédia: " + media);


        }
    }
}
