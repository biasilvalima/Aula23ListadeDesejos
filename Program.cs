using System;
using System.Collections.Generic;

namespace Aula23ListasObejtos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();
            produtos.Add(new Produto( "Iphone", 4000f, "Rose", 12546 ));
            produtos.Add(new Produto( "Moto g", 1200f, "Vermelho", 17846 ));
            produtos.Add(new Produto( "Samsung", 2000f, "Preto", 75461 ));
            produtos.Add(new Produto( "Lenovo", 900, "Dourado", 41555 ));

            System.Console.WriteLine("Os celulares escolhidos foram esses: ");
            foreach(Produto p in produtos)
            {
                System.Console.WriteLine($"{p.Nome} - {p.Preco} - {p.Cor}");
            }

            System.Console.WriteLine();
            //Remove da lista
            produtos.RemoveAll( p => p.Nome == "Lenovo");

            //quando remove algo da lista sempre colocar o foreach em seguida pra aparecer a lista nova
            System.Console.WriteLine("E esses foram comprados: ");
            foreach(Produto p in produtos)
            {
                System.Console.WriteLine($"{p.Nome} - {p.Preco} - {p.Cor}");
            }

            System.Console.WriteLine();

            List<Cartao> cartao = new List<Cartao>();
            cartao.Add( new Cartao("Beatriz",107));
            cartao.Add( new Cartao("Jefferson",181));
            cartao.Add( new Cartao("Pedro",459));
            cartao.Add( new Cartao("Felipe",227));

            System.Console.WriteLine("Os cartões cadastrados estão abaixo com nome do titular e CVV ");
            foreach(Cartao c in cartao)
            {
                System.Console.WriteLine($"{c.NomeTitular} - {c.CVV}");
            }

            System.Console.WriteLine();

            cartao.RemoveAll( c => c.NomeTitular == "Pedro");

            foreach(Cartao c in cartao)
            {
                System.Console.WriteLine($"{c.NomeTitular} - {c.CVV}");
            }
  
        }
    }
}
