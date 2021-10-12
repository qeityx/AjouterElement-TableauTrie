using System;

namespace AjouterElement_TableauTrie
{
    class Program
    {
        static void Main(string[] args)
        {

            int temp;
            int i;
            int number;
            int dim;
            
            Console.WriteLine("Entrez la dimension du tableau");
            dim = int.Parse(Console.ReadLine());
            int[] T = new int[dim + 1];
            Console.WriteLine("Donner les nombres que vous voulez entrez par ordre");
            
            for (i=0;i<dim;i++)
            {
                T[i]= int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Entrez un nombre");
            number = int.Parse(Console.ReadLine());
            // cas decroissant
            if (T[0] > T[1])
                
            {
                T[dim] = number;
                for (i = dim; i > 0; i--)
                {
                    
                        if (T[i - 1] < T[i])
                        {
                            temp = T[i];
                            T[i] = T[i - 1];
                            T[i - 1] = temp;
                        }
                    
                }
            }
            // cas croissant
            else if (T[1]> T[0])
            {
                T[dim] = number;
                for (i = dim; i > 0; i--)
                {

                    if (T[i - 1] > T[i])
                    {
                        temp = T[i];
                        T[i] = T[i - 1];
                        T[i - 1] = temp;
                    }

                }

            }
            for (i=0;i<dim+1;i++)
            {
                Console.WriteLine(T[i]);
            }
            
        }
    }
}
