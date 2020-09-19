using System;

namespace cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            String frase;
            Console.Write("digite uma frase:");
            frase = Console.ReadLine();
            Console.Write("");
            Console.WriteLine($"{frase.Replace("r" , "l").Replace("R" , "L")}");
              //<---fim(digite)--->\\

              //<---inicio(sair)--->\\
            Console.Write("agora presssione esnter para finalisar:");
            Console.ReadKey();
            
              
            

        }
    }
}
