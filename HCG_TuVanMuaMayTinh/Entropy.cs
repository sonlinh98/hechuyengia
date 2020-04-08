using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCG_TuVanMuaMayTinh
{
    internal class Entropy
    {
        private int yesCount;

        public int YesCount
        {
            get { return yesCount; }
            set { yesCount = value; }
        }

        private int noCount;

        public int NoCount
        {
            get { return noCount; }
            set { noCount = value; }
        }

        private int totalCount;

        public int TotalCount
        {
            get { return totalCount; }
            set { totalCount = value; }
        }

        private string labelNode;

        public string LabelNode
        {
            get { return labelNode; }
            set { labelNode = value; }
        }
        private double layEntropy;

        public double LayEntropy
        {
            get { return layEntropy; }
            set { layEntropy = value; }
        }

        Entropy()
        {

        }
        public Entropy(string la, int y, int n)
        {
            this.LabelNode = la;
            this.YesCount = y;
            this.NoCount = n;
            this.TotalCount = YesCount + NoCount;
            this.LayEntropy = GetEntropy();
        }
        public Entropy(int y, int n)
        {
            this.YesCount = y;
            this.NoCount = n;
            this.TotalCount = YesCount + NoCount;
            this.LayEntropy = GetEntropy();
        }
        public double GetEntropy()
        {
            this.TotalCount = YesCount + NoCount;
            if (yesCount == 0 || noCount == 0)
            {
                return 0;
            }
            double RatePositves = (double)YesCount / TotalCount;
            double RateNegatives = (double)NoCount / TotalCount;
            return -RatePositves * Math.Log(RatePositves, 2) - RateNegatives * Math.Log(RateNegatives, 2);
        }
        public override string ToString()
        {
            return "[LabelNode: " + LabelNode +
                    ", GetEntropy: " + GetEntropy() +
                    ", YesCount: " + YesCount +
                    ", NoCount: " + NoCount +
                    ", TotalCount: " + TotalCount +
                    ", TotalCount: " + TotalCount + "]";

        }
    }
}
