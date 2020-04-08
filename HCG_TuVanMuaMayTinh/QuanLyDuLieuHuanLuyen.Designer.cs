namespace HCG_TuVanMuaMayTinh
{
    partial class QuanLyDuLieuHuanLuyen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyDuLieuHuanLuyen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxAge = new System.Windows.Forms.ComboBox();
            this.comboBoxBuy = new System.Windows.Forms.ComboBox();
            this.comboBoxOS = new System.Windows.Forms.ComboBox();
            this.comboBoxManufactures = new System.Windows.Forms.ComboBox();
            this.comboBoxConfigular = new System.Windows.Forms.ComboBox();
            this.comboBoxIncome = new System.Windows.Forms.ComboBox();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxNhapDl = new System.Windows.Forms.GroupBox();
            this.groupBoxThaoTac = new System.Windows.Forms.GroupBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxNhapDl.SuspendLayout();
            this.groupBoxThaoTac.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sex";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(16, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Income";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(16, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Configuration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(16, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Manufacturers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(16, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "OS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(16, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Buy";
            // 
            // comboBoxAge
            // 
            this.comboBoxAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAge.FormattingEnabled = true;
            this.comboBoxAge.Items.AddRange(new object[] {
            "youth",
            "middle-aged",
            "senior"});
            this.comboBoxAge.Location = new System.Drawing.Point(190, 24);
            this.comboBoxAge.Name = "comboBoxAge";
            this.comboBoxAge.Size = new System.Drawing.Size(274, 28);
            this.comboBoxAge.TabIndex = 1;
            // 
            // comboBoxBuy
            // 
            this.comboBoxBuy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuy.FormattingEnabled = true;
            this.comboBoxBuy.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxBuy.Location = new System.Drawing.Point(190, 272);
            this.comboBoxBuy.Name = "comboBoxBuy";
            this.comboBoxBuy.Size = new System.Drawing.Size(274, 28);
            this.comboBoxBuy.TabIndex = 7;
            // 
            // comboBoxOS
            // 
            this.comboBoxOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOS.FormattingEnabled = true;
            this.comboBoxOS.Items.AddRange(new object[] {
            "Windows",
            "Linux",
            "Mac OS"});
            this.comboBoxOS.Location = new System.Drawing.Point(190, 238);
            this.comboBoxOS.Name = "comboBoxOS";
            this.comboBoxOS.Size = new System.Drawing.Size(274, 28);
            this.comboBoxOS.TabIndex = 6;
            // 
            // comboBoxManufactures
            // 
            this.comboBoxManufactures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManufactures.FormattingEnabled = true;
            this.comboBoxManufactures.Items.AddRange(new object[] {
            "APPLE",
            "ASUS",
            "DELL",
            "HP",
            "SAMSUNG",
            "SONY"});
            this.comboBoxManufactures.Location = new System.Drawing.Point(190, 197);
            this.comboBoxManufactures.Name = "comboBoxManufactures";
            this.comboBoxManufactures.Size = new System.Drawing.Size(274, 28);
            this.comboBoxManufactures.TabIndex = 5;
            // 
            // comboBoxConfigular
            // 
            this.comboBoxConfigular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConfigular.FormattingEnabled = true;
            this.comboBoxConfigular.Items.AddRange(new object[] {
            "low",
            "medium",
            "high"});
            this.comboBoxConfigular.Location = new System.Drawing.Point(190, 158);
            this.comboBoxConfigular.Name = "comboBoxConfigular";
            this.comboBoxConfigular.Size = new System.Drawing.Size(274, 28);
            this.comboBoxConfigular.TabIndex = 4;
            // 
            // comboBoxIncome
            // 
            this.comboBoxIncome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIncome.FormattingEnabled = true;
            this.comboBoxIncome.Items.AddRange(new object[] {
            "low",
            "medium",
            "high"});
            this.comboBoxIncome.Location = new System.Drawing.Point(190, 112);
            this.comboBoxIncome.Name = "comboBoxIncome";
            this.comboBoxIncome.Size = new System.Drawing.Size(274, 28);
            this.comboBoxIncome.TabIndex = 3;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "male",
            "female"});
            this.comboBoxSex.Location = new System.Drawing.Point(190, 68);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(274, 28);
            this.comboBoxSex.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 336);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(976, 322);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBoxNhapDl
            // 
            this.groupBoxNhapDl.Controls.Add(this.label1);
            this.groupBoxNhapDl.Controls.Add(this.label2);
            this.groupBoxNhapDl.Controls.Add(this.label3);
            this.groupBoxNhapDl.Controls.Add(this.label4);
            this.groupBoxNhapDl.Controls.Add(this.label5);
            this.groupBoxNhapDl.Controls.Add(this.label6);
            this.groupBoxNhapDl.Controls.Add(this.comboBoxSex);
            this.groupBoxNhapDl.Controls.Add(this.label7);
            this.groupBoxNhapDl.Controls.Add(this.comboBoxIncome);
            this.groupBoxNhapDl.Controls.Add(this.comboBoxAge);
            this.groupBoxNhapDl.Controls.Add(this.comboBoxConfigular);
            this.groupBoxNhapDl.Controls.Add(this.comboBoxBuy);
            this.groupBoxNhapDl.Controls.Add(this.comboBoxManufactures);
            this.groupBoxNhapDl.Controls.Add(this.comboBoxOS);
            this.groupBoxNhapDl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxNhapDl.ForeColor = System.Drawing.Color.Black;
            this.groupBoxNhapDl.Location = new System.Drawing.Point(131, 12);
            this.groupBoxNhapDl.Name = "groupBoxNhapDl";
            this.groupBoxNhapDl.Size = new System.Drawing.Size(492, 318);
            this.groupBoxNhapDl.TabIndex = 14;
            this.groupBoxNhapDl.TabStop = false;
            this.groupBoxNhapDl.Text = "Nhập dữ liệu";
            // 
            // groupBoxThaoTac
            // 
            this.groupBoxThaoTac.Controls.Add(this.btThem);
            this.groupBoxThaoTac.Controls.Add(this.btXoa);
            this.groupBoxThaoTac.Controls.Add(this.btThoat);
            this.groupBoxThaoTac.Controls.Add(this.btSua);
            this.groupBoxThaoTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxThaoTac.ForeColor = System.Drawing.Color.Black;
            this.groupBoxThaoTac.Location = new System.Drawing.Point(693, 12);
            this.groupBoxThaoTac.Name = "groupBoxThaoTac";
            this.groupBoxThaoTac.Size = new System.Drawing.Size(198, 318);
            this.groupBoxThaoTac.TabIndex = 15;
            this.groupBoxThaoTac.TabStop = false;
            this.groupBoxThaoTac.Text = "Thao tác";
            // 
            // btThem
            // 
            this.btThem.FlatAppearance.BorderSize = 0;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.ForeColor = System.Drawing.Color.Red;
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.Location = new System.Drawing.Point(46, 24);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(117, 54);
            this.btThem.TabIndex = 10;
            this.btThem.Tag = "8";
            this.btThem.Text = " ";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.FlatAppearance.BorderSize = 0;
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.ForeColor = System.Drawing.Color.Red;
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.Location = new System.Drawing.Point(46, 94);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(117, 54);
            this.btXoa.TabIndex = 11;
            this.btXoa.Tag = "9";
            this.btXoa.Text = " ";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThoat
            // 
            this.btThoat.FlatAppearance.BorderSize = 0;
            this.btThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThoat.ForeColor = System.Drawing.Color.Red;
            this.btThoat.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.Image")));
            this.btThoat.Location = new System.Drawing.Point(46, 246);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(117, 54);
            this.btThoat.TabIndex = 13;
            this.btThoat.Tag = "11";
            this.btThoat.Text = " ";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btSua
            // 
            this.btSua.FlatAppearance.BorderSize = 0;
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.ForeColor = System.Drawing.Color.Red;
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.Location = new System.Drawing.Point(46, 166);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(117, 54);
            this.btSua.TabIndex = 12;
            this.btSua.Tag = "10";
            this.btSua.Text = " ";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click_1);
            // 
            // QuanLyDuLieuHuanLuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 670);
            this.Controls.Add(this.groupBoxThaoTac);
            this.Controls.Add(this.groupBoxNhapDl);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuanLyDuLieuHuanLuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tập dữ liệu huấn luyện";
            this.Load += new System.EventHandler(this.FormNhapDL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxNhapDl.ResumeLayout(false);
            this.groupBoxNhapDl.PerformLayout();
            this.groupBoxThaoTac.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxAge;
        private System.Windows.Forms.ComboBox comboBoxBuy;
        private System.Windows.Forms.ComboBox comboBoxOS;
        private System.Windows.Forms.ComboBox comboBoxManufactures;
        private System.Windows.Forms.ComboBox comboBoxConfigular;
        private System.Windows.Forms.ComboBox comboBoxIncome;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.GroupBox groupBoxNhapDl;
        private System.Windows.Forms.GroupBox groupBoxThaoTac;
    }
}