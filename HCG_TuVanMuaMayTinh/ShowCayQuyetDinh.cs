using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCG_TuVanMuaMayTinh
{
    public partial class ShowCayQuyetDinh : Form
    {
        List<Attribute> Attributes = new List<Attribute>();
        DecisionTreeID3 DTID3;
        List<List<string>> Examples = new List<List<string>>();
        KetNoiSQL ketnoi = new KetNoiSQL();

        public ShowCayQuyetDinh()
        {
            InitializeComponent();
        }

        private void ShowCayQuyetDinh_Load(object sender, EventArgs e)
        {

            // load dữ liệu huấn luyện
            Examples.Clear();
            string sql = "Select Age, Sex, Income, Configuration, Manufacturers, Os, Buy  from DuLieu";
            DataTable D = ketnoi.truyVanSQL(sql);

            foreach (DataRow row in D.Rows)
            {

                List<string> example = new List<string>();
                foreach (DataColumn item in D.Columns)
                {
                    string name = row[item].ToString();
                    example.Add(name);
                }


                Examples.Add(example);
            }


            List<Attribute> at = new List<Attribute>();

            Attribute age = new Attribute(new List<string> {"youth", "senior", "middle-aged" }, "Age");
            at.Add(age);
            Attribute sex = new Attribute(new List<string> { "male", "female" }, "Sex");
            at.Add(sex);
            Attribute income = new Attribute(new List<string> { "high", "low", "medium" }, "Income");
            at.Add(income);
            Attribute config = new Attribute(new List<string> { "high", "low", "medium" }, "Configuration");
            at.Add(config);
            Attribute manu = new Attribute(new List<string> { "SONY", "DELL", "APPLE", "SAMSUNG", "HP", "ASUS" }, "Manufacturers");
            at.Add(manu);
            Attribute os = new Attribute(new List<string> { "Windows", "Mac OS", "Linux" }, "Os");
            at.Add(os);


            // tạo cây quyết định
            DTID3 = new DecisionTreeID3(Examples, at);

            DTID3.GetTree();

            Height = DTID3.Depth * 200;
            Width = DTID3.Tree.NumberLabel * 100;

            pbxpaint.Invalidate();
        }
    }
}
