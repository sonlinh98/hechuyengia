using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCG_TuVanMuaMayTinh
{
    public class Luat
    {
        private int stt;

        public int STT
        {
            get { return stt; }
            set { stt = value; }
        }

        public string Age { get; set; }
        public string Sex { get; set; }
        public string Income { get; set; }
        public string Configuration { get; set; }
        public string Manufacturers { get; set; }
        public string OS { get; set; }
        public string Buy { get; set; }
        public Luat(string a, string s, string i, string c, string m, string o, string b)
        {
            this.Age = a;
            this.Sex = s;
            this.Income = i;
            this.Configuration = c;
            this.Manufacturers = m;
            this.OS = o;
            this.Buy = b;
        }
        public Luat()
        {
            this.Age = "";
            this.Sex = "";
            this.Income = "";
            this.Configuration = "";
            this.Manufacturers = "";
            this.OS = "";
            this.Buy = "";
        }
        public Luat(int st)
        {
            this.stt = st;
            this.Age = "";
            this.Sex = "";
            this.Income = "";
            this.Configuration = "";
            this.Manufacturers = "";
            this.OS = "";
            this.Buy = "";
        }
        public Luat(int st, string a, string s, string i, string c, string m, string o, string b)
        {
            this.STT = st;
            this.Age = a;
            this.Sex = s;
            this.Income = i;
            this.Configuration = c;
            this.Manufacturers = m;
            this.OS = o;
            this.Buy = b;
        }
        public override string ToString()
        {
            return "stt: " + STT + ", age: " + Age + ", sex: " + Sex + ", Income: " + Income +
                "\nCon: " + Configuration + ",man: " + Manufacturers + ", os: " + OS + ", buy: " + Buy;
        }
    }
}
