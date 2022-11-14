using static System.Console;
using static System;
using System.Linq;

namespace livroSharp
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            WriteLine("------Funções de Texto------");
            string empresa = " Microsoft Corporation";
            WriteLine("TRIM - retira os espaços em branco antes e após a exexpressão");
            writeLine($"Nome sem espaços:{empresa.Trim()}");
        }
    }
}