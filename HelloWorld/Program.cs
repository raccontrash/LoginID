using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // VERSIONAMENTO?
            const string versaoPrograma = "Versão 1.0.4";
            Console.Write(versaoPrograma);
            Console.WriteLine("\n\n");


            // DECLARANDO IDIOMAS DISPONIVEIS
            int english = 1;
            int portugues = 2;
            int espanhol = 3;

            // PRIMEIRO PROGRAMA EM C# :)
            var meuTexto = "HelloWorld - Olá Mundo - Hola Mundo";
            Console.WriteLine("Hello World!");
            Console.WriteLine(meuTexto);

            // OPÇÕES DE IDIOMA
            Console.WriteLine("\n 1. Inglês");
            Console.WriteLine("\n 2. Português");
            Console.WriteLine("\n 3. Espanhol");

            /*
                if (Console.ReadLine() == english)
            {
                Console.WriteLine("o idioma escolhido foi: ");
            }
                else
            {
                Console.WriteLine("teste dois");
            }
            */

            // ESCOLHA DE IDIOMAS
            string idioma = "";
            Console.WriteLine("\nDigite o número correspondente para definir o idioma: ");
            idioma = Console.ReadLine();
         /* Console.WriteLine("O idioma escolhido foi: ");
            Console.WriteLine(idioma);
         */

            Console.ReadLine();
        }
    }
}