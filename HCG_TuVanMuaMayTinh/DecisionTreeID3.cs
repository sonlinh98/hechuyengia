using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCG_TuVanMuaMayTinh
{
    class DecisionTreeID3
    {
        List<List<string>> Examples;
        List<Attribute> Attributes;
        TreeNode _tree;
        int _depth;
        string _solution;

        internal TreeNode Tree
        {
            get { return _tree; }
            set { _tree = value; }
        }

        public int Depth
        {
            get { return _depth; }
            set { _depth = value; }
        }

        public string Solution
        {
            get { return _solution; }
            set { _solution = value; }
        }

        public DecisionTreeID3(List<List<string>> Examples, List<Attribute> Attributes)
        {
            this.Examples = Examples;
            this.Attributes = Attributes;
            this.Tree = null;
            Depth = 0;
        }

        // tính entroypy
        private double GetEntropy(int Positives, int Negatives)
        {
            if (Positives == 0)
                return 0;
            if (Negatives == 0)
                return 0;
            double Entropy;
            int total = Negatives + Positives;
            double RatePositves = (double)Positives / total;
            double RateNegatives = (double)Negatives / total;
            Entropy = -RatePositves * Math.Log(RatePositves, 2) - RateNegatives * Math.Log(RateNegatives, 2);
            return Entropy;
        }

        // tính Gain(bestat,A);
        private double Gain(List<List<string>> Examples, Attribute A, string bestat)
        {
            double result;
            int CountPositives = 0;
            int[] CountPositivesA = new int[A.Value.Count];
            int[] CountNegativeA = new int[A.Value.Count];
            int Col = Attributes.IndexOf(A);
            for (int i = 0; i < A.Value.Count; i++)
            {
                CountPositivesA[i] = 0;
                CountNegativeA[i] = 0;
            }
            for (int i = 0; i < Examples.Count; i++)
            {
                int j = A.Value.IndexOf(Examples[i][Col].ToString());
                if (Examples[i][Examples[0].Count - 1] == "có")
                {
                    CountPositives++;
                    CountPositivesA[j]++;
                }
                else
                {
                    CountNegativeA[j]++;
                }
            }
            result = GetEntropy(CountPositives, Examples.Count - CountPositives);
            for (int i = 0; i < A.Value.Count; i++)
            {
                double RateValue = (double)(CountPositivesA[i] + CountNegativeA[i]) / Examples.Count;
                result = result - RateValue * GetEntropy(CountPositivesA[i], CountNegativeA[i]);
            }

            Solution = Solution + "\n * Gain(" + bestat + "," + A.Name + ") = " + result.ToString();
            return result;
        }

        // giải thuật ID3
        private TreeNode ID3(List<List<string>> Examples, List<Attribute> Attribute, string bestat)
        {
            Solution = Solution + "---------------------------------    Xét " + bestat + "     -------------------------------";
            if (CheckAllPositive(Examples))
            {
                Solution += "\n Tất cả các mẫu đều khẳng định => Trả về nút gốc với nhãn Có";
                return new TreeNode(new Attribute("Có"));
            }
            if (CheckAllNegative(Examples))
            {
                Solution += "\n Tất cả các mẫu đều phủ định => Trả về nút gốc với nhãn Không";
                return new TreeNode(new Attribute("Không"));
            }
            if (Attribute.Count == 0)
            {
                Solution += "\n Các thuộc tính rỗng => Trả về nút gốc có giá trị phổ biến nhất ";
                return new TreeNode(new Attribute(GetMostCommonValue(Examples)));
            }
            Attribute BestAttribute = GetBestAttribute(Examples, Attribute, bestat);

            int LocationBA = Attributes.IndexOf(BestAttribute);

            TreeNode Root = new TreeNode(BestAttribute);
            for (int i = 0; i < BestAttribute.Value.Count; i++)
            {
                List<List<string>> Examplesvi = new List<List<string>>();
                for (int j = 0; j < Examples.Count; j++)
                {
                    if (Examples[j][LocationBA].ToString() == BestAttribute.Value[i].ToString())
                        Examplesvi.Add(Examples[j]);
                }
                if (Examplesvi.Count == 0)
                {
                    Solution += "\n Các thuộc tính rỗng => Trả về nút gốc có giá trị phổ biến nhất ";
                    return new TreeNode(new Attribute(GetMostCommonValue(Examplesvi)));
                }
                else
                {
                    Solution += "\n";
                    Attribute.Remove(BestAttribute);
                    Root.AddNode(ID3(Examplesvi, Attribute, BestAttribute.Value[i]));
                }
            }
            return Root;
        }

        // lấy thuật tính có Gain cao nhất
        private Attribute GetBestAttribute(List<List<string>> Examples, List<Attribute> Attributes, string bestat)
        {
            double MaxGain = Gain(Examples, Attributes[0], bestat);
            int Max = 0;
            for (int i = 1; i < Attributes.Count; i++)
            {
                double GainCurrent = Gain(Examples, Attributes[i], bestat);
                if (MaxGain < GainCurrent)
                {
                    MaxGain = GainCurrent;
                    Max = i;
                }
            }
            Solution = Solution + "\n\t=> Ta chọn đặc tính tốt nhất là : " + Attributes[Max].Name;
            return Attributes[Max];
        }


        // lấy giá trị phổ biến nhất của tập đích
        private string GetMostCommonValue(List<List<string>> Examples)
        {
            int CountPositive = 0;
            for (int i = 0; i < Examples.Count; i++)
            {
                if (Examples[i][Examples[0].Count - 1] == "có")
                    CountPositive++;
            }
            int CountNegative = Examples.Count - CountPositive;
            string Label;
            if (CountPositive > CountNegative)
                Label = "Có";
            else
                Label = "Không";
            Solution = Solution + " là " + Label;
            return Label;
        }

        // kiểm tra xem tất cả tập có phải là positive không
        private bool CheckAllPositive(List<List<string>> Examples)
        {
            for (int i = 0; i < Examples.Count; i++)
            {
                if (Examples[i][Examples[0].Count - 1].ToString() == "không")
                    return false;
            }
            return true;
        }

        // kiểm tra xem tất cả tập có phải là Negative không
        private bool CheckAllNegative(List<List<string>> Examples)
        {
            for (int i = 0; i < Examples.Count; i++)
            {
                if (Examples[i][Examples[0].Count - 1] == "có")
                    return false;
            }
            return true;
        }

        // xây dựng cây
        public void GetTree()
        {
            Solution = "";
            List<Attribute> at = new List<Attribute>();
            for (int i = 0; i < Attributes.Count; i++)
            {
                at.Add(Attributes[i]);
            }
            Tree = ID3(Examples, at, "S");
            Depth = GetDepth(Tree);
        }

        // lấy độ sâu của cây
        private int GetDepth(TreeNode tree)
        {
            int depth;
            if (tree.Childs.Length == 0)
                return 1;
            else
            {
                depth = GetDepth(tree.Childs[0]);
                for (int i = 1; i < tree.Childs.Length; i++)
                {
                    int depthchild = GetDepth(tree.Childs[i]);
                    if (depth < depthchild)
                        depth = depthchild;
                }
                depth++;
            }
            return depth;
        }
    }
}
