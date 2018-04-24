using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVetor
{
    class Exercicio01
    {
        public Exercicio01()
        {
            int[] numeros = new int[16];

            Console.Write("\nNúmero1: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNúmero2: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNúmero3: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNúmero4: ");
            int numero4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNúmero5: ");
            int numero5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNúmero6: ");
            int numero6 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNúmero7: ");
            int numero7 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNúmero8: ");
            int numero8 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNúmero9: ");
            int numero9 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\número10: ");
            int numero10 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNúmero11: ");
            int numero11 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNúmero12: ");
            int numero12 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNúmero13: ");
            int numero13 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNúmero14: ");
            int numero14 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNúmero15: ");
            int numero15 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNúmero16: ");
            int numero16 = Convert.ToInt32(Console.ReadLine());
            
            numeros[0] = numero1;
            numeros[1] = numero2;
            numeros[2] = numero3;
            numeros[3] = numero4;
            numeros[4] = numero5;
            numeros[5] = numero6;
            numeros[6] = numero6;
            numeros[7] = numero7;
            numeros[8] = numero8;
            numeros[9] = numero9;
            numeros[10] = numero10;
            numeros[11] = numero11;
            numeros[12] = numero12;
            numeros[13] =  numero13;
            numeros[14] = numero14;
            numeros[15] = numero15;

            int somaDosNumeros = numeros[0] + numeros[1] + numeros[2] + numeros[3] + numeros[4] + numeros[5] + numeros[6] + numeros[7] + numeros[8] + numeros[9] + numeros[10] + numeros[11] + numeros[12] + numeros[13] + numeros[14] + numeros[15];
            
            Console.WriteLine("Soma dos números: " + somaDosNumeros);



            
            

        }
    }
}
