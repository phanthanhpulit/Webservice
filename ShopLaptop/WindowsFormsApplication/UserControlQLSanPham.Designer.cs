namespace WindowsFormsApplication
{
    partial class UserControlQLSanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gvSanPham = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maloai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VGA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.display = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wireless = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.battery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chitiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baohanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.active1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbactive = new System.Windows.Forms.ComboBox();
            this.Active = new System.Windows.Forms.Label();
            this.txtchitiet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLoaiSP = new System.Windows.Forms.ComboBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.btnLamlai = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtbattery = new System.Windows.Forms.TextBox();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.txtbaohanh = new System.Windows.Forms.TextBox();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.txtHDD = new System.Windows.Forms.TextBox();
            this.txtwireless = new System.Windows.Forms.TextBox();
            this.txtmanhinh = new System.Windows.Forms.TextBox();
            this.txtVGA = new System.Windows.Forms.TextBox();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.txthinh = new System.Windows.Forms.TextBox();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pbHinhAnh = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 373);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.gvSanPham);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 233);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1038, 140);
            this.panel5.TabIndex = 1;
            // 
            // gvSanPham
            // 
            this.gvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.masp,
            this.tensp,
            this.gia,
            this.hinh,
            this.maloai,
            this.CPU,
            this.RAM,
            this.HDD,
            this.VGA,
            this.display,
            this.wireless,
            this.battery,
            this.weight,
            this.chitiet,
            this.baohanh,
            this.active1});
            this.gvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvSanPham.Location = new System.Drawing.Point(0, 0);
            this.gvSanPham.MultiSelect = false;
            this.gvSanPham.Name = "gvSanPham";
            this.gvSanPham.ReadOnly = true;
            this.gvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSanPham.Size = new System.Drawing.Size(1036, 138);
            this.gvSanPham.TabIndex = 0;
            this.gvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSanPham_CellClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // masp
            // 
            this.masp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.masp.DataPropertyName = "masp";
            this.masp.HeaderText = "Mã sản phẩm";
            this.masp.Name = "masp";
            this.masp.ReadOnly = true;
            // 
            // tensp
            // 
            this.tensp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tensp.DataPropertyName = "tensp";
            this.tensp.HeaderText = "Tên sản phẩm";
            this.tensp.Name = "tensp";
            this.tensp.ReadOnly = true;
            // 
            // gia
            // 
            this.gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "Giá";
            this.gia.Name = "gia";
            this.gia.ReadOnly = true;
            // 
            // hinh
            // 
            this.hinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hinh.DataPropertyName = "hinh";
            this.hinh.HeaderText = "Hình";
            this.hinh.Name = "hinh";
            this.hinh.ReadOnly = true;
            // 
            // maloai
            // 
            this.maloai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maloai.DataPropertyName = "maloai";
            this.maloai.HeaderText = "Loại sản phẩm";
            this.maloai.Name = "maloai";
            this.maloai.ReadOnly = true;
            this.maloai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.maloai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CPU
            // 
            this.CPU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CPU.DataPropertyName = "CPU";
            this.CPU.HeaderText = "CPU";
            this.CPU.Name = "CPU";
            this.CPU.ReadOnly = true;
            // 
            // RAM
            // 
            this.RAM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RAM.DataPropertyName = "RAM";
            this.RAM.HeaderText = "RAM";
            this.RAM.Name = "RAM";
            this.RAM.ReadOnly = true;
            // 
            // HDD
            // 
            this.HDD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HDD.DataPropertyName = "HDD";
            this.HDD.HeaderText = "HDD";
            this.HDD.Name = "HDD";
            this.HDD.ReadOnly = true;
            // 
            // VGA
            // 
            this.VGA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VGA.DataPropertyName = "VGA";
            this.VGA.HeaderText = "VGA";
            this.VGA.Name = "VGA";
            this.VGA.ReadOnly = true;
            // 
            // display
            // 
            this.display.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.display.DataPropertyName = "display";
            this.display.HeaderText = "Màn hình";
            this.display.Name = "display";
            this.display.ReadOnly = true;
            // 
            // wireless
            // 
            this.wireless.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.wireless.DataPropertyName = "wireless";
            this.wireless.HeaderText = "Wireless";
            this.wireless.Name = "wireless";
            this.wireless.ReadOnly = true;
            // 
            // battery
            // 
            this.battery.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.battery.DataPropertyName = "battery";
            this.battery.HeaderText = "Pin";
            this.battery.Name = "battery";
            this.battery.ReadOnly = true;
            // 
            // weight
            // 
            this.weight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.weight.DataPropertyName = "weight";
            this.weight.HeaderText = "Trọng lượng";
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            // 
            // chitiet
            // 
            this.chitiet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chitiet.DataPropertyName = "chitiet";
            this.chitiet.HeaderText = "Chi tiết";
            this.chitiet.Name = "chitiet";
            this.chitiet.ReadOnly = true;
            // 
            // baohanh
            // 
            this.baohanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.baohanh.DataPropertyName = "baohanh";
            this.baohanh.HeaderText = "Bảo hành";
            this.baohanh.Name = "baohanh";
            this.baohanh.ReadOnly = true;
            // 
            // active1
            // 
            this.active1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.active1.DataPropertyName = "active";
            this.active1.HeaderText = "Active";
            this.active1.Name = "active1";
            this.active1.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 233);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pbHinhAnh);
            this.panel4.Controls.Add(this.cbactive);
            this.panel4.Controls.Add(this.Active);
            this.panel4.Controls.Add(this.txtchitiet);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.cbLoaiSP);
            this.panel4.Controls.Add(this.btnBrowser);
            this.panel4.Controls.Add(this.btnLamlai);
            this.panel4.Controls.Add(this.btnHuy);
            this.panel4.Controls.Add(this.btnLuu);
            this.panel4.Controls.Add(this.txtbattery);
            this.panel4.Controls.Add(this.txtweight);
            this.panel4.Controls.Add(this.txtbaohanh);
            this.panel4.Controls.Add(this.txtRAM);
            this.panel4.Controls.Add(this.txtHDD);
            this.panel4.Controls.Add(this.txtwireless);
            this.panel4.Controls.Add(this.txtmanhinh);
            this.panel4.Controls.Add(this.txtVGA);
            this.panel4.Controls.Add(this.txtmasp);
            this.panel4.Controls.Add(this.txttensp);
            this.panel4.Controls.Add(this.txtgia);
            this.panel4.Controls.Add(this.txthinh);
            this.panel4.Controls.Add(this.txtCPU);
            this.panel4.Controls.Add(this.txtID);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(200, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(836, 231);
            this.panel4.TabIndex = 1;
            // 
            // cbactive
            // 
            this.cbactive.FormattingEnabled = true;
            this.cbactive.Location = new System.Drawing.Point(616, 64);
            this.cbactive.Name = "cbactive";
            this.cbactive.Size = new System.Drawing.Size(187, 21);
            this.cbactive.TabIndex = 97;
            // 
            // Active
            // 
            this.Active.AutoSize = true;
            this.Active.Location = new System.Drawing.Point(557, 68);
            this.Active.Name = "Active";
            this.Active.Size = new System.Drawing.Size(37, 13);
            this.Active.TabIndex = 96;
            this.Active.Text = "Active";
            // 
            // txtchitiet
            // 
            this.txtchitiet.Location = new System.Drawing.Point(616, 38);
            this.txtchitiet.Name = "txtchitiet";
            this.txtchitiet.Size = new System.Drawing.Size(187, 20);
            this.txtchitiet.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 93;
            this.label4.Text = "Chi tiết";
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.FormattingEnabled = true;
            this.cbLoaiSP.Location = new System.Drawing.Point(97, 143);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Size = new System.Drawing.Size(187, 21);
            this.cbLoaiSP.TabIndex = 92;
            this.cbLoaiSP.Text = "Chọn loại sản phẩm";
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(247, 116);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(37, 21);
            this.btnBrowser.TabIndex = 91;
            this.btnBrowser.Text = "....";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // btnLamlai
            // 
            this.btnLamlai.Location = new System.Drawing.Point(676, 195);
            this.btnLamlai.Name = "btnLamlai";
            this.btnLamlai.Size = new System.Drawing.Size(75, 23);
            this.btnLamlai.TabIndex = 90;
            this.btnLamlai.Text = "Làm lại";
            this.btnLamlai.UseVisualStyleBackColor = true;
            this.btnLamlai.Click += new System.EventHandler(this.btnLamlai_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AutoSize = true;
            this.btnHuy.Location = new System.Drawing.Point(550, 196);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 89;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.Location = new System.Drawing.Point(420, 195);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 88;
            this.btnLuu.Text = "Lưu lại";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtbattery
            // 
            this.txtbattery.Location = new System.Drawing.Point(355, 143);
            this.txtbattery.Name = "txtbattery";
            this.txtbattery.Size = new System.Drawing.Size(187, 20);
            this.txtbattery.TabIndex = 87;
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(355, 169);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(187, 20);
            this.txtweight.TabIndex = 86;
            // 
            // txtbaohanh
            // 
            this.txtbaohanh.Location = new System.Drawing.Point(616, 12);
            this.txtbaohanh.Name = "txtbaohanh";
            this.txtbaohanh.Size = new System.Drawing.Size(187, 20);
            this.txtbaohanh.TabIndex = 82;
            // 
            // txtRAM
            // 
            this.txtRAM.Location = new System.Drawing.Point(355, 38);
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.Size = new System.Drawing.Size(187, 20);
            this.txtRAM.TabIndex = 81;
            // 
            // txtHDD
            // 
            this.txtHDD.Location = new System.Drawing.Point(355, 65);
            this.txtHDD.Name = "txtHDD";
            this.txtHDD.Size = new System.Drawing.Size(187, 20);
            this.txtHDD.TabIndex = 80;
            // 
            // txtwireless
            // 
            this.txtwireless.Location = new System.Drawing.Point(97, 169);
            this.txtwireless.Name = "txtwireless";
            this.txtwireless.Size = new System.Drawing.Size(187, 20);
            this.txtwireless.TabIndex = 79;
            // 
            // txtmanhinh
            // 
            this.txtmanhinh.Location = new System.Drawing.Point(355, 116);
            this.txtmanhinh.Name = "txtmanhinh";
            this.txtmanhinh.Size = new System.Drawing.Size(187, 20);
            this.txtmanhinh.TabIndex = 76;
            // 
            // txtVGA
            // 
            this.txtVGA.Location = new System.Drawing.Point(355, 91);
            this.txtVGA.Name = "txtVGA";
            this.txtVGA.Size = new System.Drawing.Size(187, 20);
            this.txtVGA.TabIndex = 75;
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(97, 38);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(187, 20);
            this.txtmasp.TabIndex = 74;
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(97, 65);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(187, 20);
            this.txttensp.TabIndex = 73;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(97, 91);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(187, 20);
            this.txtgia.TabIndex = 72;
            // 
            // txthinh
            // 
            this.txthinh.Location = new System.Drawing.Point(97, 116);
            this.txthinh.Name = "txthinh";
            this.txthinh.Size = new System.Drawing.Size(144, 20);
            this.txthinh.TabIndex = 71;
            // 
            // txtCPU
            // 
            this.txtCPU.Location = new System.Drawing.Point(355, 13);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(187, 20);
            this.txtCPU.TabIndex = 68;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(97, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(187, 20);
            this.txtID.TabIndex = 67;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(18, 13);
            this.label21.TabIndex = 66;
            this.label21.Text = "ID";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(557, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 13);
            this.label20.TabIndex = 65;
            this.label20.Text = "Bảo hành";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(290, 176);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 61;
            this.label16.Text = "Trọng lượng";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(300, 147);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 13);
            this.label15.TabIndex = 60;
            this.label15.Text = "Pin";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 59;
            this.label14.Text = "Wireless";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(300, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "Màn hình";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(300, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "VGA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(300, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "HDD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "RAM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "CPU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Loại sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Hình";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Mã sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Tên sản phẩm";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 231);
            this.panel3.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(42, 171);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(115, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa sản phẩm";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(42, 104);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(115, 23);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa sản phẩm";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(42, 41);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(115, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm sản phẩm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pbHinhAnh
            // 
            this.pbHinhAnh.Location = new System.Drawing.Point(560, 96);
            this.pbHinhAnh.Name = "pbHinhAnh";
            this.pbHinhAnh.Size = new System.Drawing.Size(243, 93);
            this.pbHinhAnh.TabIndex = 98;
            this.pbHinhAnh.TabStop = false;
            // 
            // UserControlQLSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControlQLSanPham";
            this.Size = new System.Drawing.Size(1038, 373);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Button btnLamlai;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtbattery;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.TextBox txtbaohanh;
        private System.Windows.Forms.TextBox txtRAM;
        private System.Windows.Forms.TextBox txtHDD;
        private System.Windows.Forms.TextBox txtwireless;
        private System.Windows.Forms.TextBox txtmanhinh;
        private System.Windows.Forms.TextBox txtVGA;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.TextBox txthinh;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView gvSanPham;
        private System.Windows.Forms.ComboBox cbLoaiSP;
        private System.Windows.Forms.ComboBox cbactive;
        private System.Windows.Forms.Label Active;
        private System.Windows.Forms.TextBox txtchitiet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinh;
        private System.Windows.Forms.DataGridViewComboBoxColumn maloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn VGA;
        private System.Windows.Forms.DataGridViewTextBoxColumn display;
        private System.Windows.Forms.DataGridViewTextBoxColumn wireless;
        private System.Windows.Forms.DataGridViewTextBoxColumn battery;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn chitiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn baohanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn active1;
        private System.Windows.Forms.PictureBox pbHinhAnh;
    }
}
