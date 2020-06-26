using System;

namespace Atividade3_PrimeiroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
          heroi Klebinho = new heroi();
          Klebinho.nome = "Klebinho";
          Klebinho.equipamento = "Escopeta";

        Console.WriteLine(Klebinho.nome);
        Console.WriteLine(Klebinho.Defender());
        Console.WriteLine(Klebinho.Atacar(807.5f, 50.2f));

        }
    }
}
