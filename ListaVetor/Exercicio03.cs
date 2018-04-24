using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVetor
{
    class Exercicio03
    {
        public Exercicio03()
        {
            string[] nome = new string[7];
            double[] preco = new double[7];

            Console.Write("\nNome1: ");
            nome[0] = Console.ReadLine();
            Console.Write("\nPreço1: ");
            preco[0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nNome2: ");
            nome[1] = Console.ReadLine();
            Console.Write("\nPreço2: ");
            preco[1] = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nNome3: ");
            nome[2] = Console.ReadLine();
            Console.Write("\nPreço3: ");
            preco[2] = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nNome4: ");
            nome[3] = Console.ReadLine();
            Console.Write("\nPreço4: ");
            preco[3] = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nNome5: ");
            nome[4] = Console.ReadLine();
            Console.Write("\nPreço5: ");
            preco[4] = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nNome6: ");
            nome[5] = Console.ReadLine();
            Console.Write("\nPreço6: ");
            preco[5] = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nNome7: ");
            nome[6] = Console.ReadLine();
            Console.Write("\nPreço7: ");
            preco[6] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Nome e preço do produto1: " + nome[0] + ", " + preco[0]);
            Console.WriteLine("Nome e preço do produto: " + nome[1] + ", " + preco[1]);
            Console.WriteLine("Nome e preço do produto: " + nome[2] + ", " + preco[2]);
            Console.WriteLine("Nome e preço do produto: " + nome[3] + ", " + preco[3]);
            Console.WriteLine("Nome e preço do produto: " + nome[4] + ", " + preco[4]);
            Console.WriteLine("Nome e preço do produto: " + nome[5] + ", " + preco[5]);
            Console.WriteLine("Nome e preço do produto: " + nome[6] + ", " + preco[6]);


            



        }
    }
}
