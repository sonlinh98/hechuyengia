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
    public partial class QuanLyDuLieuHuanLuyen : Form
    {
        KetNoiSQL ketNoi = new KetNoiSQL();
        string table = "dulieu";
        string Age, Sex, Income, Configuration, Manufacturers, OS, Buy;
        string TAge, TSex, TIncome, TConfiguration, TManufacturers, TOS, TBuy;
        int TSTT;
        int index = -1;

        private void btSua_Click_1(object sender, EventArgs e)
        {
            try
            {
                layDLTuGridView();
                string sql = "delete from " + table + " where stt=@stt";
                Luat l = new Luat(this.TSTT);
                ketNoi.xoaSuaTimKiemDL(sql, l);
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = ketNoi.layDLTuBang(table);
                index = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormNhapDL_Load(object sender, EventArgs e)
        {

        }

        DataGridViewRow row;

        public QuanLyDuLieuHuanLuyen()
        {
            InitializeComponent();
            this.ActiveControl = comboBoxAge;
            loadData();
        }
        public void loadData()
        {
            try
            {
                dataGridView1.DataSource = ketNoi.layDLTuBang(table);
                setSourceCombo(comboBoxAge, "age");
                setSourceCombo(comboBoxSex, "sex");
                setSourceCombo(comboBoxIncome, "income");
                setSourceCombo(comboBoxConfigular, "Configuration");
                setSourceCombo(comboBoxManufactures, "Manufacturers");
                setSourceCombo(comboBoxOS, "os");
                setSourceCombo(comboBoxBuy, "buy");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Enabled = false;
                HuongDanCauHinhCSDL f = new HuongDanCauHinhCSDL();
                f.TopMost = true;
                f.Show();
            }
        }


        //lấy DL từ combobox
        public void layDL()
        {
            this.Age = layDLCombo(comboBoxAge);
            this.Sex = layDLCombo(comboBoxSex);
            this.Income = layDLCombo(comboBoxIncome);
            this.Configuration = layDLCombo(comboBoxConfigular);
            this.Manufacturers = layDLCombo(comboBoxManufactures);
            this.OS = layDLCombo(comboBoxOS);
            this.Buy = layDLCombo(comboBoxBuy);
        }
        //Lấy Dl từ datagridview 
        public void layDLTuGridView()
        {
            try
            {
                this.TSTT = Int32.Parse(row.Cells[0].Value.ToString());
                this.TAge = row.Cells[1].Value.ToString();
                this.TSex = row.Cells[2].Value.ToString();
                this.TIncome = row.Cells[3].Value.ToString();
                this.TConfiguration = row.Cells[4].Value.ToString();
                this.TManufacturers = row.Cells[5].Value.ToString();
                this.TOS = row.Cells[6].Value.ToString();
                this.TBuy = row.Cells[7].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Chọn dòng dữ liệu cần thao tác!");
            }
        }

        string layDLCombo(ComboBox cb)
        {
            string result = "";
            try
            {
                result = cb.SelectedValue.ToString();
            }
            catch (Exception)
            {
                result = "";
            }
            return result;
        }

        public void setSourceCombo(ComboBox c, string colume)
        {
            c.DataSource = ketNoi.truyVanSQL("select distinct(" + colume + ") from dulieu");
            c.DisplayMember = colume;
            c.ValueMember = colume;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = dataGridView1.SelectedCells[0].RowIndex;
                row = dataGridView1.Rows[index];
                layDLTuGridView();
                comboBoxAge.SelectedValue = this.TAge;
                comboBoxSex.SelectedValue = this.TSex;
                comboBoxIncome.SelectedValue = this.TIncome;
                comboBoxConfigular.SelectedValue = this.TConfiguration;
                comboBoxManufactures.SelectedValue = this.TManufacturers;
                comboBoxOS.SelectedValue = this.TOS;
                comboBoxBuy.SelectedValue = this.TBuy;
                index = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            layDL();
            Luat l = new Luat(this.Age, this.Sex, this.Income, this.Configuration, this.Manufacturers, this.OS, this.Buy);
            string sql = "insert into " + table + " values(@a,@s,@i,@c,@m,@o,@b)";
            ketNoi.thucThiSQL(sql, l);
            MessageBox.Show("Thêm dữ liệu thành công", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadData();
        }


        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                layDLTuGridView();
                layDL();
                string sql = "update " + table + " set age=@a,sex=@s,Income=@i, Configuration = @c, Manufacturers=@m,OS=@o, buy= @b where stt=@stt ";
                Luat l = new Luat(this.TSTT, this.Age, this.Sex, this.Income, this.Configuration, this.Manufacturers, this.OS, this.Buy);
                ketNoi.xoaSuaTimKiemDL(sql, l);
                MessageBox.Show("Sửa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = ketNoi.layDLTuBang(table);
                index = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
