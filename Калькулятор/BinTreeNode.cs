using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор
{
    /// <summary>
    // Описание вершины бинарного дерева, которая содержит:
    // - информационное поле - Info
    // - ссылку на левое поддерево - Left
    // - ссылку на правое поддерево - Right
    /// </summary>

    public class BinTreeNode
    {
        public BinTreeNode()
        {
            Info = "";
            Left = null;
            Right = null;
        }

        public BinTreeNode(string value)
        {
            Info = value;
            Left = null;
            Right = null;
        }

        public string Info { get; set; }
        public BinTreeNode Left { get; set; }
        public BinTreeNode Right { get; set; }
    }
}
