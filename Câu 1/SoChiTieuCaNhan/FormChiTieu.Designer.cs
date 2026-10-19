namespace SoChiTieuCaNhan;

partial class FormChiTieu
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        this.grpThongTin = new System.Windows.Forms.GroupBox();
        this.btnLamMoi = new System.Windows.Forms.Button();
        this.btnXoa = new System.Windows.Forms.Button();
        this.btnSua = new System.Windows.Forms.Button();
        this.btnThem = new System.Windows.Forms.Button();
        this.txtGhiChu = new System.Windows.Forms.TextBox();
        this.lblGhiChu = new System.Windows.Forms.Label();
        this.nudSoTien = new System.Windows.Forms.NumericUpDown();
        this.lblSoTien = new System.Windows.Forms.Label();
        this.cboLoaiChi = new System.Windows.Forms.ComboBox();
        this.lblLoaiChi = new System.Windows.Forms.Label();
        this.txtNoiDung = new System.Windows.Forms.TextBox();
        this.lblNoiDung = new System.Windows.Forms.Label();
        this.dtpNgayChi = new System.Windows.Forms.DateTimePicker();
        this.lblNgayChi = new System.Windows.Forms.Label();
        this.grpTimKiem = new System.Windows.Forms.GroupBox();
        this.btnTim = new System.Windows.Forms.Button();
        this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
        this.lblDenNgay = new System.Windows.Forms.Label();
        this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
        this.lblTuNgay = new System.Windows.Forms.Label();
        this.cboTimLoaiChi = new System.Windows.Forms.ComboBox();
        this.lblTimLoaiChi = new System.Windows.Forms.Label();
        this.txtTimNoiDung = new System.Windows.Forms.TextBox();
        this.lblTimNoiDung = new System.Windows.Forms.Label();
        this.dgvChiTieu = new System.Windows.Forms.DataGridView();
        this.colMaCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colNgayChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colNoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colLoaiChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.lblTongChi = new System.Windows.Forms.Label();
        this.grpThongTin.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.nudSoTien)).BeginInit();
        this.grpTimKiem.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvChiTieu)).BeginInit();
        this.SuspendLayout();
        // 
        // grpThongTin
        // 
        this.grpThongTin.Controls.Add(this.btnLamMoi);
        this.grpThongTin.Controls.Add(this.btnXoa);
        this.grpThongTin.Controls.Add(this.btnSua);
        this.grpThongTin.Controls.Add(this.btnThem);
        this.grpThongTin.Controls.Add(this.txtGhiChu);
        this.grpThongTin.Controls.Add(this.lblGhiChu);
        this.grpThongTin.Controls.Add(this.nudSoTien);
        this.grpThongTin.Controls.Add(this.lblSoTien);
        this.grpThongTin.Controls.Add(this.cboLoaiChi);
        this.grpThongTin.Controls.Add(this.lblLoaiChi);
        this.grpThongTin.Controls.Add(this.txtNoiDung);
        this.grpThongTin.Controls.Add(this.lblNoiDung);
        this.grpThongTin.Controls.Add(this.dtpNgayChi);
        this.grpThongTin.Controls.Add(this.lblNgayChi);
        this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.grpThongTin.Location = new System.Drawing.Point(12, 12);
        this.grpThongTin.Name = "grpThongTin";
        this.grpThongTin.Size = new System.Drawing.Size(515, 205);
        this.grpThongTin.TabIndex = 0;
        this.grpThongTin.TabStop = false;
        this.grpThongTin.Text = "Thông tin khoản chi";
        // 
        // btnLamMoi
        // 
        this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnLamMoi.Location = new System.Drawing.Point(400, 160);
        this.btnLamMoi.Name = "btnLamMoi";
        this.btnLamMoi.Size = new System.Drawing.Size(95, 32);
        this.btnLamMoi.TabIndex = 13;
        this.btnLamMoi.Text = "Làm mới";
        this.btnLamMoi.UseVisualStyleBackColor = true;
        this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
        // 
        // btnXoa
        // 
        this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnXoa.Location = new System.Drawing.Point(295, 160);
        this.btnXoa.Name = "btnXoa";
        this.btnXoa.Size = new System.Drawing.Size(95, 32);
        this.btnXoa.TabIndex = 12;
        this.btnXoa.Text = "Xóa";
        this.btnXoa.UseVisualStyleBackColor = true;
        this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
        // 
        // btnSua
        // 
        this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnSua.Location = new System.Drawing.Point(190, 160);
        this.btnSua.Name = "btnSua";
        this.btnSua.Size = new System.Drawing.Size(95, 32);
        this.btnSua.TabIndex = 11;
        this.btnSua.Text = "Sửa";
        this.btnSua.UseVisualStyleBackColor = true;
        this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
        // 
        // btnThem
        // 
        this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnThem.Location = new System.Drawing.Point(85, 160);
        this.btnThem.Name = "btnThem";
        this.btnThem.Size = new System.Drawing.Size(95, 32);
        this.btnThem.TabIndex = 10;
        this.btnThem.Text = "Thêm";
        this.btnThem.UseVisualStyleBackColor = true;
        this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
        // 
        // txtGhiChu
        // 
        this.txtGhiChu.Location = new System.Drawing.Point(85, 93);
        this.txtGhiChu.MaxLength = 200;
        this.txtGhiChu.Multiline = true;
        this.txtGhiChu.Name = "txtGhiChu";
        this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtGhiChu.Size = new System.Drawing.Size(410, 53);
        this.txtGhiChu.TabIndex = 9;
        // 
        // lblGhiChu
        // 
        this.lblGhiChu.AutoSize = true;
        this.lblGhiChu.Location = new System.Drawing.Point(15, 96);
        this.lblGhiChu.Name = "lblGhiChu";
        this.lblGhiChu.Size = new System.Drawing.Size(51, 15);
        this.lblGhiChu.TabIndex = 8;
        this.lblGhiChu.Text = "Ghi chú:";
        // 
        // nudSoTien
        // 
        this.nudSoTien.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
        this.nudSoTien.Location = new System.Drawing.Point(325, 59);
        this.nudSoTien.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
        this.nudSoTien.Name = "nudSoTien";
        this.nudSoTien.Size = new System.Drawing.Size(170, 23);
        this.nudSoTien.TabIndex = 7;
        this.nudSoTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.nudSoTien.ThousandsSeparator = true;
        // 
        // lblSoTien
        // 
        this.lblSoTien.AutoSize = true;
        this.lblSoTien.Location = new System.Drawing.Point(260, 62);
        this.lblSoTien.Name = "lblSoTien";
        this.lblSoTien.Size = new System.Drawing.Size(46, 15);
        this.lblSoTien.TabIndex = 6;
        this.lblSoTien.Text = "Số tiền:";
        // 
        // cboLoaiChi
        // 
        this.cboLoaiChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboLoaiChi.FormattingEnabled = true;
        this.cboLoaiChi.Items.AddRange(new object[] {
            "Ăn uống",
            "Đi lại",
            "Học tập",
            "Giải trí",
            "Khác"});
        this.cboLoaiChi.Location = new System.Drawing.Point(325, 24);
        this.cboLoaiChi.Name = "cboLoaiChi";
        this.cboLoaiChi.Size = new System.Drawing.Size(170, 23);
        this.cboLoaiChi.TabIndex = 3;
        // 
        // lblLoaiChi
        // 
        this.lblLoaiChi.AutoSize = true;
        this.lblLoaiChi.Location = new System.Drawing.Point(260, 27);
        this.lblLoaiChi.Name = "lblLoaiChi";
        this.lblLoaiChi.Size = new System.Drawing.Size(51, 15);
        this.lblLoaiChi.TabIndex = 2;
        this.lblLoaiChi.Text = "Loại chi:";
        // 
        // txtNoiDung
        // 
        this.txtNoiDung.Location = new System.Drawing.Point(85, 59);
        this.txtNoiDung.MaxLength = 100;
        this.txtNoiDung.Name = "txtNoiDung";
        this.txtNoiDung.Size = new System.Drawing.Size(160, 23);
        this.txtNoiDung.TabIndex = 5;
        // 
        // lblNoiDung
        // 
        this.lblNoiDung.AutoSize = true;
        this.lblNoiDung.Location = new System.Drawing.Point(15, 62);
        this.lblNoiDung.Name = "lblNoiDung";
        this.lblNoiDung.Size = new System.Drawing.Size(60, 15);
        this.lblNoiDung.TabIndex = 4;
        this.lblNoiDung.Text = "Nội dung:";
        // 
        // dtpNgayChi
        // 
        this.dtpNgayChi.CustomFormat = "dd/MM/yyyy";
        this.dtpNgayChi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        this.dtpNgayChi.Location = new System.Drawing.Point(85, 24);
        this.dtpNgayChi.Name = "dtpNgayChi";
        this.dtpNgayChi.Size = new System.Drawing.Size(160, 23);
        this.dtpNgayChi.TabIndex = 1;
        // 
        // lblNgayChi
        // 
        this.lblNgayChi.AutoSize = true;
        this.lblNgayChi.Location = new System.Drawing.Point(15, 27);
        this.lblNgayChi.Name = "lblNgayChi";
        this.lblNgayChi.Size = new System.Drawing.Size(57, 15);
        this.lblNgayChi.TabIndex = 0;
        this.lblNgayChi.Text = "Ngày chi:";
        // 
        // grpTimKiem
        // 
        this.grpTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        this.grpTimKiem.Controls.Add(this.btnTim);
        this.grpTimKiem.Controls.Add(this.dtpDenNgay);
        this.grpTimKiem.Controls.Add(this.lblDenNgay);
        this.grpTimKiem.Controls.Add(this.dtpTuNgay);
        this.grpTimKiem.Controls.Add(this.lblTuNgay);
        this.grpTimKiem.Controls.Add(this.cboTimLoaiChi);
        this.grpTimKiem.Controls.Add(this.lblTimLoaiChi);
        this.grpTimKiem.Controls.Add(this.txtTimNoiDung);
        this.grpTimKiem.Controls.Add(this.lblTimNoiDung);
        this.grpTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.grpTimKiem.Location = new System.Drawing.Point(540, 12);
        this.grpTimKiem.Name = "grpTimKiem";
        this.grpTimKiem.Size = new System.Drawing.Size(422, 205);
        this.grpTimKiem.TabIndex = 1;
        this.grpTimKiem.TabStop = false;
        this.grpTimKiem.Text = "Tìm kiếm";
        // 
        // btnTim
        // 
        this.btnTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnTim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnTim.Location = new System.Drawing.Point(292, 160);
        this.btnTim.Name = "btnTim";
        this.btnTim.Size = new System.Drawing.Size(110, 32);
        this.btnTim.TabIndex = 8;
        this.btnTim.Text = "Tìm";
        this.btnTim.UseVisualStyleBackColor = true;
        this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
        // 
        // dtpDenNgay
        // 
        this.dtpDenNgay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
        this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        this.dtpDenNgay.Location = new System.Drawing.Point(92, 126);
        this.dtpDenNgay.Name = "dtpDenNgay";
        this.dtpDenNgay.Size = new System.Drawing.Size(310, 23);
        this.dtpDenNgay.TabIndex = 7;
        // 
        // lblDenNgay
        // 
        this.lblDenNgay.AutoSize = true;
        this.lblDenNgay.Location = new System.Drawing.Point(15, 129);
        this.lblDenNgay.Name = "lblDenNgay";
        this.lblDenNgay.Size = new System.Drawing.Size(60, 15);
        this.lblDenNgay.TabIndex = 6;
        this.lblDenNgay.Text = "Đến ngày:";
        // 
        // dtpTuNgay
        // 
        this.dtpTuNgay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
        this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        this.dtpTuNgay.Location = new System.Drawing.Point(92, 92);
        this.dtpTuNgay.Name = "dtpTuNgay";
        this.dtpTuNgay.Size = new System.Drawing.Size(310, 23);
        this.dtpTuNgay.TabIndex = 5;
        // 
        // lblTuNgay
        // 
        this.lblTuNgay.AutoSize = true;
        this.lblTuNgay.Location = new System.Drawing.Point(15, 95);
        this.lblTuNgay.Name = "lblTuNgay";
        this.lblTuNgay.Size = new System.Drawing.Size(52, 15);
        this.lblTuNgay.TabIndex = 4;
        this.lblTuNgay.Text = "Từ ngày:";
        // 
        // cboTimLoaiChi
        // 
        this.cboTimLoaiChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        this.cboTimLoaiChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboTimLoaiChi.FormattingEnabled = true;
        this.cboTimLoaiChi.Items.AddRange(new object[] {
            "Tất cả",
            "Ăn uống",
            "Đi lại",
            "Học tập",
            "Giải trí",
            "Khác"});
        this.cboTimLoaiChi.Location = new System.Drawing.Point(92, 58);
        this.cboTimLoaiChi.Name = "cboTimLoaiChi";
        this.cboTimLoaiChi.Size = new System.Drawing.Size(310, 23);
        this.cboTimLoaiChi.TabIndex = 3;
        // 
        // lblTimLoaiChi
        // 
        this.lblTimLoaiChi.AutoSize = true;
        this.lblTimLoaiChi.Location = new System.Drawing.Point(15, 62);
        this.lblTimLoaiChi.Name = "lblTimLoaiChi";
        this.lblTimLoaiChi.Size = new System.Drawing.Size(51, 15);
        this.lblTimLoaiChi.TabIndex = 2;
        this.lblTimLoaiChi.Text = "Loại chi:";
        // 
        // txtTimNoiDung
        // 
        this.txtTimNoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        this.txtTimNoiDung.Location = new System.Drawing.Point(92, 24);
        this.txtTimNoiDung.Name = "txtTimNoiDung";
        this.txtTimNoiDung.PlaceholderText = "Nhập nội dung...";
        this.txtTimNoiDung.Size = new System.Drawing.Size(310, 23);
        this.txtTimNoiDung.TabIndex = 1;
        // 
        // lblTimNoiDung
        // 
        this.lblTimNoiDung.AutoSize = true;
        this.lblTimNoiDung.Location = new System.Drawing.Point(15, 27);
        this.lblTimNoiDung.Name = "lblTimNoiDung";
        this.lblTimNoiDung.Size = new System.Drawing.Size(50, 15);
        this.lblTimNoiDung.TabIndex = 0;
        this.lblTimNoiDung.Text = "TextBox:";
        // 
        // dgvChiTieu
        // 
        this.dgvChiTieu.AllowUserToAddRows = false;
        this.dgvChiTieu.AllowUserToDeleteRows = false;
        this.dgvChiTieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        this.dgvChiTieu.BackgroundColor = System.Drawing.Color.White;
        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
        dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        this.dgvChiTieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        this.dgvChiTieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvChiTieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaCT,
            this.colNgayChi,
            this.colNoiDung,
            this.colLoaiChi,
            this.colSoTien,
            this.colGhiChu});
        this.dgvChiTieu.Location = new System.Drawing.Point(12, 228);
        this.dgvChiTieu.MultiSelect = false;
        this.dgvChiTieu.Name = "dgvChiTieu";
        this.dgvChiTieu.ReadOnly = true;
        this.dgvChiTieu.RowHeadersWidth = 35;
        this.dgvChiTieu.RowTemplate.Height = 26;
        this.dgvChiTieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvChiTieu.Size = new System.Drawing.Size(950, 310);
        this.dgvChiTieu.TabIndex = 2;
        this.dgvChiTieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTieu_CellClick);
        // 
        // colMaCT
        // 
        this.colMaCT.DataPropertyName = "MaCtDisplay";
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        this.colMaCT.DefaultCellStyle = dataGridViewCellStyle2;
        this.colMaCT.HeaderText = "Mã";
        this.colMaCT.Name = "colMaCT";
        this.colMaCT.ReadOnly = true;
        this.colMaCT.Width = 70;
        // 
        // colNgayChi
        // 
        this.colNgayChi.DataPropertyName = "NgayChiDisplay";
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        this.colNgayChi.DefaultCellStyle = dataGridViewCellStyle3;
        this.colNgayChi.HeaderText = "Ngày chi";
        this.colNgayChi.Name = "colNgayChi";
        this.colNgayChi.ReadOnly = true;
        this.colNgayChi.Width = 110;
        // 
        // colNoiDung
        // 
        this.colNoiDung.DataPropertyName = "NoiDung";
        this.colNoiDung.HeaderText = "Nội dung";
        this.colNoiDung.Name = "colNoiDung";
        this.colNoiDung.ReadOnly = true;
        this.colNoiDung.Width = 200;
        // 
        // colLoaiChi
        // 
        this.colLoaiChi.DataPropertyName = "LoaiChi";
        this.colLoaiChi.HeaderText = "Loại chi";
        this.colLoaiChi.Name = "colLoaiChi";
        this.colLoaiChi.ReadOnly = true;
        this.colLoaiChi.Width = 120;
        // 
        // colSoTien
        // 
        this.colSoTien.DataPropertyName = "SoTienDisplay";
        this.colSoTien.HeaderText = "Số tiền";
        this.colSoTien.Name = "colSoTien";
        this.colSoTien.ReadOnly = true;
        this.colSoTien.Width = 120;
        // 
        // colGhiChu
        // 
        this.colGhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        this.colGhiChu.DataPropertyName = "GhiChu";
        this.colGhiChu.HeaderText = "Ghi chú";
        this.colGhiChu.Name = "colGhiChu";
        this.colGhiChu.ReadOnly = true;
        // 
        // lblTongChi
        // 
        this.lblTongChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.lblTongChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTongChi.ForeColor = System.Drawing.Color.DarkRed;
        this.lblTongChi.Location = new System.Drawing.Point(540, 545);
        this.lblTongChi.Name = "lblTongChi";
        this.lblTongChi.Size = new System.Drawing.Size(422, 28);
        this.lblTongChi.TabIndex = 3;
        this.lblTongChi.Text = "Tổng chi: 0 đ";
        this.lblTongChi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // FormChiTieu
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(974, 581);
        this.Controls.Add(this.lblTongChi);
        this.Controls.Add(this.dgvChiTieu);
        this.Controls.Add(this.grpTimKiem);
        this.Controls.Add(this.grpThongTin);
        this.MinimumSize = new System.Drawing.Size(990, 620);
        this.Name = "FormChiTieu";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Sổ chi tiêu cá nhân";
        this.Load += new System.EventHandler(this.FormChiTieu_Load);
        this.grpThongTin.ResumeLayout(false);
        this.grpThongTin.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.nudSoTien)).EndInit();
        this.grpTimKiem.ResumeLayout(false);
        this.grpTimKiem.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvChiTieu)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox grpThongTin;
    private System.Windows.Forms.Label lblNgayChi;
    private System.Windows.Forms.DateTimePicker dtpNgayChi;
    private System.Windows.Forms.Label lblNoiDung;
    private System.Windows.Forms.TextBox txtNoiDung;
    private System.Windows.Forms.Label lblLoaiChi;
    private System.Windows.Forms.ComboBox cboLoaiChi;
    private System.Windows.Forms.Label lblSoTien;
    private System.Windows.Forms.NumericUpDown nudSoTien;
    private System.Windows.Forms.Label lblGhiChu;
    private System.Windows.Forms.TextBox txtGhiChu;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.GroupBox grpTimKiem;
    private System.Windows.Forms.Label lblTimNoiDung;
    private System.Windows.Forms.TextBox txtTimNoiDung;
    private System.Windows.Forms.Label lblTimLoaiChi;
    private System.Windows.Forms.ComboBox cboTimLoaiChi;
    private System.Windows.Forms.Label lblTuNgay;
    private System.Windows.Forms.DateTimePicker dtpTuNgay;
    private System.Windows.Forms.Label lblDenNgay;
    private System.Windows.Forms.DateTimePicker dtpDenNgay;
    private System.Windows.Forms.Button btnTim;
    private System.Windows.Forms.DataGridView dgvChiTieu;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMaCT;
    private System.Windows.Forms.DataGridViewTextBoxColumn colNgayChi;
    private System.Windows.Forms.DataGridViewTextBoxColumn colNoiDung;
    private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiChi;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSoTien;
    private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
    private System.Windows.Forms.Label lblTongChi;
}
