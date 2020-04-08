using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCG_TuVanMuaMayTinh
{
    public class Attribute
    {
        List<string> valuez;
        string name;
        string label;

        public List<string> Value
        {
            get { return valuez; }
            set { valuez = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Label
        {
            get { return label; }
            set { label = value; }
        }

        public Attribute()
        {
            this.Name = "";
            this.Label = "";
            this.Value = new List<string>();
        }

        public Attribute(List<string> Value, string Name)
        {
            this.Value = Value;
            this.Name = Name;
            this.Label = "";
        }

        public Attribute(string Label)
        {
            this.Label = Label;
            this.Name = string.Empty;
            Value = new List<string>();
        }

        public void AddValue(string Value)
        {
            if (!valuez.Contains(Value))
                valuez.Add(Value);
        }
    }
}
