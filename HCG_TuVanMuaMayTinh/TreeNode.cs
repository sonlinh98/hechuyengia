using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCG_TuVanMuaMayTinh
{
   public class TreeNode
    {
        Attribute attributes;
        TreeNode[] childs;
        int n;
        int numberLabel;

        public Attribute Attributes
        {
            get { return attributes; }
            set { attributes = value; }
        }

        public TreeNode[] Childs
        {
            get { return childs; }
            set { childs = value; }
        }

        public int NumberLabel
        {
            get { return numberLabel; }
            set { numberLabel = value; }
        }

        public TreeNode(Attribute Attributes)
        {
            this.Attributes = Attributes;
            this.Childs = new TreeNode[Attributes.Value.Count];
            n = 0;
            for (int i = 0; i < Attributes.Value.Count; i++)
            {
                Childs[i] = null;
            }
            if (Attributes.Value.Count == 0)
                NumberLabel = 1;
            else
                NumberLabel = 0;
        }

        public void AddNode(TreeNode Child)
        {
            if (n < Childs.Length)
            {
                Childs[n] = Child;
                NumberLabel = NumberLabel + Child.NumberLabel;
            }
            n++;
        }

    }
}
