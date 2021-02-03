using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreHierarquica
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Node('A');
            var b = new Node('B');
            var c = new Node('C');
            var d = new Node('D');
            var e = new Node('E');
            var f = new Node('F');
            var g = new Node('G');
            var h = new Node('H');

            a.Left = b;
            a.Right = c;
            b.Left = d;
            b.Right = g;
            c.Left = e;
            c.Right = h;
            e.Right = f;


            Console.WriteLine(a.RetornaResultado());

            var teste1 = new List<List<Char>>()
            {
                new List<Char>(){'A','B'},
                new List<Char>(){'A','C'},
                new List<Char>(){'B','G'},
                new List<Char>(){'C','H'},
                new List<Char>(){'E','F'},
                new List<Char>(){'B','D'},
                new List<Char>(){'C','E'},
            };

            var retornoUm = MetodoTransformarArrayEmArvore.TransformarArrayEmArvore(teste1);

            Console.WriteLine(retornoUm);
            Console.ReadLine();
        }
    }
}
