using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCG_TuVanMuaMayTinh
{
     class Gain
    {
        private string labelNode;

        public string LabelNode
        {
            get { return labelNode; }
            set { labelNode = value; }
        }

        private List<Entropy> dsEntropy;

        public List<Entropy> DSEntropyS
        {
            get { return dsEntropy; }
            set { dsEntropy = value; }
        }

        private Entropy entropyS;

        public Entropy EntropyS
        {
            get { return entropyS; }
            set { entropyS = value; }
        }
        public double layGain { get; set; }


        public Gain()
        {
            dsEntropy = new List<Entropy>();

        }
        public Gain(string l, List<Entropy> ds, Entropy s)
        {
            this.dsEntropy = new List<Entropy>();
            this.LabelNode = l;
            this.dsEntropy = ds;
            this.entropyS = s;
            layGain = GetGain();
        }
        public double GetGain()
        {
            double result = entropyS.GetEntropy();
            for (int i = 0; i < dsEntropy.Count; i++)
            {
                result -= (double)dsEntropy[i].TotalCount / entropyS.TotalCount * dsEntropy[i].GetEntropy();
            }
            return result;
        }
        public override string ToString()
        {
            return "Label: " + LabelNode +
                    ", GetGain: " + GetGain()+
                    ", entropyS: " + entropyS.ToString() ;
        }
    }

}
