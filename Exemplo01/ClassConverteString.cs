using System;

namespace Exemplo01
{
    public class ClassConverteString
    {
        private string nome;
        private string mnome;

        public String entrada(){
            Console.Clear();
            Console.WriteLine("Digite um nome ou frase:\n");
            nome = Console.ReadLine();
            mnome = nome.ToUpper();
            return mnome;
        }
    }
}