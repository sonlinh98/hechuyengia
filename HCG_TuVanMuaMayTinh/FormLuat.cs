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
    public partial class FormLuat : Form
    {
        KetNoiSQL ketNoi = new KetNoiSQL();
        string table = "luat";
        string Age, Sex, Income, Configuration, Manufacturers, OS, Buy;

        private void FormLuat_Load(object sender, EventArgs e)
        {
            //txtKQ.Text = "hhh";
        }

        int numberColumns = 0;
        public FormLuat()
        {
           
            loadData();
        }
        public FormLuat(List<Luat> dsLuat)
        {
             InitializeComponent();
            ketNoi.truyVanSQL("delete from " + table);

            string sql = "insert into " + table + " values(@a,@s,@i,@c,@m,@o,@b)";
            for (int i = 0; i < dsLuat.Count; i++)
            {
                ketNoi.thucThiSQL(sql, dsLuat[i]);
            }

            loadData();

            for (int i = 0; i < dsLuat.Count; i++)
            {
                string kq = "Luật "+(i+1)+": Nếu ";

                int j = 0;
                string []listDieuKien = new string[10];
                if (!dsLuat[i].Age.Equals(""))
                {
                    listDieuKien[j] = "Age = "+dsLuat[i].Age;
                    j++;
                }
                if (!dsLuat[i].Sex.Equals(""))
                {
                    listDieuKien[j] = "Sex = "+dsLuat[i].Sex;
                    j++;
                }
                if (!dsLuat[i].Income.Equals(""))
                {
                    listDieuKien[j] = "Income = "+dsLuat[i].Income;
                    j++;
                }
                if (!dsLuat[i].Configuration.Equals(""))
                {
                    listDieuKien[j] = "Configuration = "+dsLuat[i].Configuration;
                    j++;
                }
                if (!dsLuat[i].Manufacturers.Equals(""))
                {
                    listDieuKien[j] = "Manufacturers = "+dsLuat[i].Manufacturers;
                    j++;
                }
                if (!dsLuat[i].OS.Equals(""))
                {
                    listDieuKien[j] = "OS = "+dsLuat[i].OS;
                    j++;
                }

                string dk = listDieuKien[0];
                for (int k = 1; k < j - 1; k++)
                {
                    dk += " And " + listDieuKien[k];
                }
                dk += " And " +listDieuKien[j - 1];

                kq += dk + " Buy = " + dsLuat[i].Buy + ";\r\r\n\n";

                txtKQ.AppendText(kq);
            }
        }
        public void loadData()
        {
            //try
            //{
            //    dataGridView1.DataSource = ketNoi.layDLTuBang(table);
            //    numberColumns = dataGridView1.Columns.Count;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    this.Enabled = false;
            //    HuongDanCauHinhCSDL f = new HuongDanCauHinhCSDL();
            //    f.TopMost = true;
            //    f.Show();
            //}
        }

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int index = dataGridView1.SelectedCells[0].RowIndex;
            //DataGridViewRow row = dataGridView1.Rows[index];
            //this.Age = row.Cells[1].Value.ToString();
            //this.Sex = row.Cells[2].Value.ToString();
            //this.Income = row.Cells[3].Value.ToString();
            //this.Configuration = row.Cells[4].Value.ToString();
            //this.Manufacturers = row.Cells[5].Value.ToString();
            //this.OS = row.Cells[6].Value.ToString();
            //this.Buy = row.Cells[7].Value.ToString();

            //string kq = "Nếu ";
            //for (int i = 1; i <numberColumns-1; i++)
            //{
            //    string value = row.Cells[i].Value.ToString();
            //    if(!value.Equals("")){
            //        kq += dataGridView1.Columns[i].HeaderText+" = " +value+", ";
            //    }
            //}
            //txtKQ.Text = kq + " thì Buy = " + Buy;
            //    txtKQ.AppendText("\r\nhello");

        }

    }
}
