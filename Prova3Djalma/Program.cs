using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3Djalma
{
    class Program
    {
        static void Main(string[] args)
        {
            //NOME: Rita de Cassia Franca Faria          RA: 6322054

            //3 – Criar um programa para calcular e mostrar a área de 3 figuras geométricas diferentes, não vale quadrado e nem retângulo.
            //Observação: as figuras são de escolha livre, dá um Google se não lembrar como faz o cálculo de alguma delas.
            //Requisitos: Deve ser apresentada uma lista para o usuário com o nome das 3 figuras que ele pode escolher para calcular
            //.Deve - se utilizar Switch Case.

;

                Console.WriteLine("Dentre as três figuras, escolha uma para ser calculada a àrea \n \n \t 1 Triângulo: 2 Losango : 3 Trapézio");

            int numero = Convert.ToInt32(Console.ReadLine());
            string figura = null;


             switch (numero)
            {
                case 1: figura = "Triângulo"; break;
                case 2: figura = "Losango"; break;
                case 3: figura = "Trapézio"; break; 

            }

            if (figura == "Triângulo")
            {
                Console.WriteLine("Digite quanto vale a Base:");
                double baset = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite quanto vale a Altura:");
                double altura = Convert.ToDouble(Console.ReadLine());

                double area = (baset * altura) / 2;

                Console.WriteLine($"A área do {figura} é de {area} cm2");

            }
             else if (figura == "Losango")
            {
                Console.WriteLine("Digite o valor da Diagonal maior:");
                double diagmaior = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor da Diagonal menor:");
                double diaglmenor = Convert.ToDouble(Console.ReadLine());

                double area = (diagmaior * diaglmenor) / 2;

                Console.WriteLine($"A área do {figura} é de {area} cm2");

            }

            if (figura == "Trapézio")
            {
                Console.WriteLine("Digite o valor da Base maior:");
                double basemaior = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor da Base maior:");
                double basemenor = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor da Altura:");
                double altura = Convert.ToDouble(Console.ReadLine());

                double area = ((basemaior + basemenor) * altura) /2;
                Console.WriteLine($"A área do {figura} é de {area} cm2");
            }

            Console.WriteLine("\n\t\t Vamos outra vez, porem com outra figura?\n\n Dentre as três figuras, escolha uma para ser calculada a àrea \n \n \t 1 Triângulo: 2 Losango : 3 Trapézio\n");

            switch (numero)
            {
                case 1: figura = "Triângulo"; break;
                case 2: figura = "Losango"; break;
                case 3: figura = "Trapézio"; break;

            }

            if (figura == "Triângulo")
            {
                Console.WriteLine("Digite quanto vale a Base:");
                double baset = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite quanto vale a Altura:");
                double altura = Convert.ToDouble(Console.ReadLine());

                double area = (baset * altura) / 2;

                Console.WriteLine($"A área do {figura} é de {area} cm2");

            }
            else if (figura == "Losango")
            {
                Console.WriteLine("Digite o valor da Diagonal maior:");
                double diagmaior = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor da Diagonal menor:");
                double diaglmenor = Convert.ToDouble(Console.ReadLine());

                double area = (diagmaior * diaglmenor) / 2;

                Console.WriteLine($"A área do {figura} é de {area} cm2");

            }

            if (figura == "Trapézio")
            {
                Console.WriteLine("Digite o valor da Base maior:");
                double basemaior = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor da Base maior:");
                double basemenor = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor da Altura:");
                double altura = Convert.ToDouble(Console.ReadLine());

                double area = ((basemaior + basemenor) * altura) / 2;
                Console.WriteLine($"A área do {figura} é de {area} cm2");
            }





            Console.ReadKey();

        }
    }
}
