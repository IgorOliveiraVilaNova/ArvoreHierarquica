using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreHierarquica
{
    public class MetodoTransformarArrayEmArvore
    {
        public static string TransformarArrayEmArvore(List<List<Char>> lista)
        {
            var listaEspera = new List<Node>();

            if (lista == null || !lista.Any())
            {
                throw new E4Exception();
            }

            Node root = null;
            foreach (var item in lista)
            {
                if (item == null || !item.Any() || item.Count > 2)
                {
                    throw new E4Exception();
                }

                var pai = new Node(item[0]);
                var filho = new Node(item[1]);

                if (root != null && root.LocalizaPai(filho) != null)
                {
                    throw new E3Exception();
                }

                if (listaEspera.Any())
                {
                    var listaRemover = new List<Node>();
                    foreach (var nodeEspera in listaEspera)
                    {
                        if (filho.Equals(nodeEspera))
                        {
                            filho.AddNode(nodeEspera.Left);
                            filho.AddNode(nodeEspera.Right);
                        }
                    }

                    if (listaRemover.Any())
                    {
                        foreach (var remover in listaRemover)
                        {
                            listaEspera.Remove(remover);
                        }
                    }
                }

                if (root != null)
                {
                    if (root.Equals(filho))
                    {
                        pai.Left = root;
                        root = pai;
                        continue;
                    }
                    else 
                    {
                        var node = root.LocalizarNode(pai.Item);
                        if (node == null)
                        {
                            pai.Left = filho;
                            listaEspera.Add(pai);
                            continue;
                        }
                        else 
                        {
                            node.AddNode(filho);
                            continue;
                        }
                    }
                }
                else
                {
                    pai.Left = filho;
                    root = pai;
                    continue;
                }

            }

            return root.RetornaResultado();
        }


    }
}
