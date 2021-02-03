using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreHierarquica
{
    public class Node
    {
        public Node() { }
        public Node(Char item)
        {
            this.Item = item;
        }

        public char Item { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public bool Equals(Node obj)
        {
            return this.Item == obj.Item;
        }

        public string RetornaResultado() 
        {
            var retorno = $"[{this.Item}";

            if (this.Left != null)
            {
                retorno += $"{this.Left.RetornaResultado()}";
            }
            if (this.Right != null)
            {
                retorno += $"{this.Right.RetornaResultado()}";
            }
            retorno += $"]";


            return retorno;
        }

        public Node LocalizarNode(char search) 
        {
            Node result = null;

            if (this.Item == search)
            {
                return this;
            }
            
            if (this.Left != null)
            {
                result = this.Left.LocalizarNode(search);
            }

            if (result != null)
            {
                return result;
            }

            if (this.Right != null)
            {
                result = this.Right.LocalizarNode(search);
            }

            return result;
        }

        public void AddNode(Node filho) 
        {
            if (filho == null)
            {
                return;
            }

            if (this.Left == null)
            {
                this.Left = filho;
            }
            else if (this.Right == null)
            {
                if (filho.Item.CompareTo(this.Left.Item) < 0)
                {
                    this.Right = this.Left;
                    this.Left = filho;
                }
                else 
                {
                    this.Right = filho;                
                }
            }
            else 
            {
                throw new E1Exception();
            }
        }

        public Node LocalizaPai(Node search) 
        {
            Node nodeFound = null;
            if (this.Left != null)
            {
                if (this.Left.Item == search.Item)
                {
                    return this;
                }
                else 
                {
                    nodeFound = this.Left.LocalizaPai(search);
                }
            }

            if (nodeFound != null)
            {
                return nodeFound;
            }

            if (this.Right != null)
            {
                if (this.Right.Item == search.Item)
                {
                    return this;
                }
                else 
                {
                    nodeFound = this.Right.LocalizaPai(search);
                }
            }

            if (nodeFound != null)
            {
                return nodeFound;
            }
            else 
            {
                return null;
            }
        }
    }
}
