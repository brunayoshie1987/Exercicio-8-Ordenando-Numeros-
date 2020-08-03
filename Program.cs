using System;
using System.Collections.Generic;

namespace Exercicio_8__Ordenando_Numeros
{
    class Program
    {


        public int nrPosicoesArray = 10;

        public static void Main(string[] args)
        {

            static void Main(string[] args, int nrPosicoesArray)
            {
                var array = new int[nrPosicoesArray];
                var nrInteiros = 0;

                while (nrInteiros < nrPosicoesArray)
                {
                    Console.WriteLine("Informe um número inteiro");
                    var strNumero = Console.ReadLine();

                    var intNumero = 0;

                    if (int.TryParse(strNumero, out intNumero))
                    {
                        array[nrInteiros] = intNumero;

                        nrInteiros++;
                    }
                }

                ImprimirOrdemDecrescente(array, nrPosicoesArray);

                Console.ReadKey();
            }

            static void ImprimirOrdemDecrescente(int[] array, int nrPosicoesArray)
            {
                var newArray = new int[nrPosicoesArray];
                var nrInteiros = 0;
                var posicaoMenorNumero = 0;
                var listaPosicaoesJaVistas = new List<int>();

                while (nrInteiros < nrPosicoesArray)
                {
                    var menorNumero = 0;
                    var achouMenorNumero = false;

                    for (int x = 0; x < nrPosicoesArray; x++)
                    {
                        if (listaPosicaoesJaVistas.Contains(x))
                        {
                            continue;
                        }

                        var numeroTeste = array[x];

                        for (int i = 0; i < nrPosicoesArray; i++)
                        {
                            if (listaPosicaoesJaVistas.Contains(i))
                            {
                                continue;
                            }

                            var numeroComparar = array[i];

                            if (numeroTeste < numeroComparar || numeroTeste == numeroComparar)
                            {
                                achouMenorNumero = true;
                                menorNumero = numeroTeste;
                                posicaoMenorNumero = x;
                            }
                            else
                            {
                                achouMenorNumero = false;
                                break;
                            }
                        }

                        if (achouMenorNumero)
                        {
                            break;
                        }
                    }

                    if (achouMenorNumero)
                    {
                        listaPosicaoesJaVistas.Add(posicaoMenorNumero);
                        newArray[nrInteiros] = menorNumero;
                        nrInteiros++;
                    }
                }

                Console.WriteLine("------- ORDEM CRESCENTE -------");

                for (int i = 0; i < nrPosicoesArray; i++)
                {
                    Console.WriteLine(newArray[i]);
                }
            }
        }
    }
}

