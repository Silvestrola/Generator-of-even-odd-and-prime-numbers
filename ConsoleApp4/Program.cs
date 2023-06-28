// See https://aka.ms/new-console-template for more information

using System;
using System.Runtime.CompilerServices;

while (true)
{               
        int opcao, contador = 0;
        Console.Clear();
        Console.WriteLine("Digite uma opção, na qual terá como opção de visualizar a quantidades de um atributo de sua preferência\nem relação as seguintes opções:\n\n1)Número Par\n2)Número Ímpar\n3)Número Primo\n");
        Console.Write("\nOpção: ");
        while (!int.TryParse(Console.ReadLine(), out opcao))    
        {
            Console.Write("Opção inválida, informe uma opção válida: ");
        }

    switch(opcao)
    {
        case 1:
            int num1;
            Console.Write("\nSelecione um número limite: ");
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Número inválido, informe um número válido: ");
            }           
            Console.WriteLine("\nNúmeros Pares: ");
            for (int i = 2; i <= num1; i++)
            {
                if (i % 2 == 0) {

                    contador++;               
                    Console.WriteLine(i);
                }
            }
            Console.Write("Quantidade: " + contador + "\n");
            break;

        case 2:
            int num2;
            Console.Write("\nSelecione um número limite: ");
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Número inválido, informe um número válido: ");
            }
            Console.WriteLine("\nNúmeros Ímpares : ");
            for (int i = 1; i <= num2; i++)
            {
                if (i % 2 == 1){
                    contador++;
                    Console.WriteLine(i);
                }
            }
            Console.Write("Quantidade: " + contador + "\n");
            break;

        case 3:
            int num3;
            Console.Write("\nSelecione um número limite: ");
            while (!int.TryParse(Console.ReadLine(), out num3))
            {
                Console.Write("Número inválido, informe um número válido: ");
            }         
            Console.WriteLine("\nNúmeros Primos: ");
            Console.WriteLine(1);
            for (int n = 1; n <= num3; n++)
            {
                int cont = 0;
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {                   
                        cont++;
                    }
                }
                if (cont == 1)
                {
                    contador++;
                    Console.WriteLine(n);
                }
            }
            Console.WriteLine("Quantidade: " + (contador + 1));
            break;            
    }
    Console.WriteLine();
    Console.WriteLine("Aperte ENTER, caso queira fazer uma nova busca");
    Console.ReadLine();
}