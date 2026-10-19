using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Serilog;
using SoChiTieuCaNhan.Models;

namespace SoChiTieuCaNhan;

public partial class FormChiTieu : Form
{
    private static readonly CultureInfo VnCulture = new("vi-VN");
    private int? _selectedMaCt = null;
    private List<ChiTieu> _currentList = new();

    public FormChiTieu()
    {
        InitializeComponent();
    }

    private void FormChiTieu_Load(object sender, EventArgs e)
    {
        try
        {
            // Thiết lập giá trị mặc định cho nhập liệu
            dtpNgayChi.Value = DateTime.Today;
            cboLoaiChi.SelectedIndex = 0;
            nudSoTien.Value = 0;
            txtNoiDung.Clear();
            txtGhiChu.Clear();

            // Thiết lập giá trị mặc định cho tìm kiếm / lọc
            txtTimNoiDung.Clear();
            cboTimLoaiChi.SelectedIndex = 0; // "Tất cả"
            
            // Mặc định từ ngày 1 của tháng hiện tại đến ngày hôm nay
            dtpTuNgay.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpDenNgay.Value = DateTime.Today;

            // Nạp dữ liệu lần đầu
            LoadAllData();
        }
        catch (Exception ex)
        {
            HandleDatabaseError("khởi tạo dữ liệu form", ex);
        }
    }

    /// <summary>
    /// Nạp toàn bộ dữ liệu từ CSDL lên DataGridView
    /// </summary>
    private void LoadAllData()
    {
        try
        {
            using var db = new QL_ChiTieuContext();
            _currentList = db.ChiTieus
                .OrderBy(x => x.MaCt)
                .ToList();

            DisplayData(_currentList);
        }
        catch (Exception ex)
        {
            HandleDatabaseError("đọc dữ liệu từ cơ sở dữ liệu", ex);
        }
    }

    /// <summary>
    /// Hiển thị danh sách lên lưới và cập nhật tổng chi
    /// </summary>
    private void DisplayData(List<ChiTieu> list)
    {
        var viewModels = list.Select(x => new ChiTieuViewModel
        {
            MaCt = x.MaCt,
            NgayChi = x.NgayChi,
            NoiDung = x.NoiDung,
            LoaiChi = x.LoaiChi,
            SoTien = x.SoTien,
            GhiChu = x.GhiChu
        }).ToList();

        dgvChiTieu.DataSource = viewModels;

        // Tính tổng tiền đang hiển thị trên lưới
        decimal tongTien = list.Sum(x => x.SoTien);
        lblTongChi.Text = $"Tổng chi: {tongTien.ToString("N0", VnCulture)} đ";

        ResetInputControls();
    }

    /// <summary>
    /// Reset các trường thông tin nhập liệu
    /// </summary>
    private void ResetInputControls()
    {
        _selectedMaCt = null;
        dtpNgayChi.Value = DateTime.Today;
        txtNoiDung.Clear();
        cboLoaiChi.SelectedIndex = 0;
        nudSoTien.Value = 0;
        txtGhiChu.Clear();
        dgvChiTieu.ClearSelection();
    }

    /// <summary>
    /// Kiểm tra tính hợp lệ của dữ liệu nhập vào theo yêu cầu Task 3
    /// </summary>
    private bool ValidateInputs()
    {
        // 1. Kiểm tra nội dung không rỗng
        if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
        {
            MessageBox.Show("Vui lòng nhập nội dung chi tiêu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNoiDung.Focus();
            return false;
        }

        // 2. Kiểm tra loại chi được chọn
        if (cboLoaiChi.SelectedIndex < 0)
        {
            MessageBox.Show("Vui lòng chọn loại chi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cboLoaiChi.Focus();
            return false;
        }

        // 3. Kiểm tra số tiền > 0
        if (nudSoTien.Value <= 0)
        {
            MessageBox.Show("Số tiền chi tiêu phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            nudSoTien.Focus();
            return false;
        }

        // 4. Kiểm tra ngày chi không lớn hơn hôm nay
        if (dtpNgayChi.Value.Date > DateTime.Today)
        {
            MessageBox.Show("Ngày chi không được lớn hơn ngày hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dtpNgayChi.Focus();
            return false;
        }

        return true;
    }

    /// <summary>
    /// Bấm vào một dòng trong DataGridView thì dữ liệu hiện lên các control để sửa
    /// </summary>
    private void dgvChiTieu_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= dgvChiTieu.Rows.Count)
        {
            return;
        }

        if (dgvChiTieu.Rows[e.RowIndex].DataBoundItem is ChiTieuViewModel item)
        {
            _selectedMaCt = item.MaCt;
            dtpNgayChi.Value = item.NgayChi.ToDateTime(TimeOnly.MinValue);
            txtNoiDung.Text = item.NoiDung;

            int loaiChiIndex = cboLoaiChi.FindStringExact(item.LoaiChi);
            if (loaiChiIndex >= 0)
            {
                cboLoaiChi.SelectedIndex = loaiChiIndex;
            }
            else
            {
                cboLoaiChi.Text = item.LoaiChi;
            }

            nudSoTien.Value = item.SoTien;
            txtGhiChu.Text = item.GhiChu ?? string.Empty;
        }
    }

    /// <summary>
    /// Thêm khoản chi mới
    /// </summary>
    private void btnThem_Click(object sender, EventArgs e)
    {
        if (!ValidateInputs())
        {
            return;
        }

        try
        {
            var chiTieu = new ChiTieu
            {
                NgayChi = DateOnly.FromDateTime(dtpNgayChi.Value.Date),
                NoiDung = txtNoiDung.Text.Trim(),
                LoaiChi = cboLoaiChi.SelectedItem?.ToString() ?? "Khác",
                SoTien = nudSoTien.Value,
                GhiChu = string.IsNullOrWhiteSpace(txtGhiChu.Text) ? null : txtGhiChu.Text.Trim()
            };

            using var db = new QL_ChiTieuContext();
            db.ChiTieus.Add(chiTieu);
            db.SaveChanges();

            // Ghi log mức Information kèm MaCT
            Log.Information("Thêm thành công khoản chi mới: MaCT = {MaCT}, NoiDung = {NoiDung}, SoTien = {SoTien}, LoaiChi = {LoaiChi}",
                chiTieu.MaCt, chiTieu.NoiDung, chiTieu.SoTien, chiTieu.LoaiChi);

            MessageBox.Show("Thêm khoản chi mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAllData();
        }
        catch (Exception ex)
        {
            HandleDatabaseError("thêm khoản chi mới", ex);
        }
    }

    /// <summary>
    /// Sửa khoản chi đang chọn
    /// </summary>
    private void btnSua_Click(object sender, EventArgs e)
    {
        if (_selectedMaCt == null)
        {
            MessageBox.Show("Vui lòng chọn một dòng khoản chi trên danh sách để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!ValidateInputs())
        {
            return;
        }

        try
        {
            using var db = new QL_ChiTieuContext();
            var chiTieu = db.ChiTieus.FirstOrDefault(x => x.MaCt == _selectedMaCt.Value);

            if (chiTieu == null)
            {
                MessageBox.Show("Không tìm thấy khoản chi cần sửa trong cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            chiTieu.NgayChi = DateOnly.FromDateTime(dtpNgayChi.Value.Date);
            chiTieu.NoiDung = txtNoiDung.Text.Trim();
            chiTieu.LoaiChi = cboLoaiChi.SelectedItem?.ToString() ?? "Khác";
            chiTieu.SoTien = nudSoTien.Value;
            chiTieu.GhiChu = string.IsNullOrWhiteSpace(txtGhiChu.Text) ? null : txtGhiChu.Text.Trim();

            db.SaveChanges();

            // Ghi log mức Information kèm MaCT
            Log.Information("Cập nhật thành công khoản chi: MaCT = {MaCT}, NoiDung = {NoiDung}, SoTien = {SoTien}, LoaiChi = {LoaiChi}",
                chiTieu.MaCt, chiTieu.NoiDung, chiTieu.SoTien, chiTieu.LoaiChi);

            MessageBox.Show("Cập nhật khoản chi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAllData();
        }
        catch (Exception ex)
        {
            HandleDatabaseError($"cập nhật khoản chi MaCT = {_selectedMaCt}", ex);
        }
    }

    /// <summary>
    /// Xóa khoản chi đang chọn (hỏi xác nhận trước khi xóa)
    /// </summary>
    private void btnXoa_Click(object sender, EventArgs e)
    {
        if (_selectedMaCt == null)
        {
            MessageBox.Show("Vui lòng chọn một dòng khoản chi trên danh sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var confirmResult = MessageBox.Show(
            $"Bạn có chắc chắn muốn xóa khoản chi mã {_selectedMaCt.Value:D3} (\"{txtNoiDung.Text}\") không?",
            "Xác nhận xóa",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirmResult != DialogResult.Yes)
        {
            return;
        }

        try
        {
            using var db = new QL_ChiTieuContext();
            var chiTieu = db.ChiTieus.FirstOrDefault(x => x.MaCt == _selectedMaCt.Value);

            if (chiTieu != null)
            {
                int deletedMaCt = chiTieu.MaCt;
                db.ChiTieus.Remove(chiTieu);
                db.SaveChanges();

                // Ghi log mức Information kèm MaCT
                Log.Information("Xóa thành công khoản chi: MaCT = {MaCT}", deletedMaCt);

                MessageBox.Show("Đã xóa khoản chi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Khoản chi cần xóa không tồn tại hoặc đã bị xóa trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            LoadAllData();
        }
        catch (Exception ex)
        {
            HandleDatabaseError($"xóa khoản chi MaCT = {_selectedMaCt}", ex);
        }
    }

    /// <summary>
    /// Làm mới toàn bộ form nhập liệu, reset tìm kiếm và nạp lại danh sách
    /// </summary>
    private void btnLamMoi_Click(object sender, EventArgs e)
    {
        // Reset ô tìm kiếm
        txtTimNoiDung.Clear();
        cboTimLoaiChi.SelectedIndex = 0;
        dtpTuNgay.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
        dtpDenNgay.Value = DateTime.Today;

        // Reset nhập liệu và nạp lại dữ liệu
        LoadAllData();
    }

    /// <summary>
    /// Tìm kiếm và lọc danh sách chi tiêu theo nội dung, loại chi, từ ngày - đến ngày
    /// </summary>
    private void btnTim_Click(object sender, EventArgs e)
    {
        if (dtpTuNgay.Value.Date > dtpDenNgay.Value.Date)
        {
            MessageBox.Show("Ngày bắt đầu (Từ ngày) không được lớn hơn ngày kết thúc (Đến ngày)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dtpTuNgay.Focus();
            return;
        }

        try
        {
            using var db = new QL_ChiTieuContext();
            var query = db.ChiTieus.AsQueryable();

            // 1. Lọc theo khoảng thời gian
            var fromDate = DateOnly.FromDateTime(dtpTuNgay.Value.Date);
            var toDate = DateOnly.FromDateTime(dtpDenNgay.Value.Date);
            query = query.Where(x => x.NgayChi >= fromDate && x.NgayChi <= toDate);

            // 2. Lọc theo loại chi
            string? selectedLoaiChi = cboTimLoaiChi.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedLoaiChi) && selectedLoaiChi != "Tất cả")
            {
                query = query.Where(x => x.LoaiChi == selectedLoaiChi);
            }

            // 3. Lọc theo nội dung
            string keyword = txtTimNoiDung.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.NoiDung.Contains(keyword));
            }

            var filteredList = query.OrderBy(x => x.MaCt).ToList();
            DisplayData(filteredList);

            Log.Information("Thực hiện tìm kiếm: Từ ngày = {FromDate}, Đến ngày = {ToDate}, Loại chi = {LoaiChi}, Từ khóa = {Keyword}, Kết quả: {Count} dòng",
                fromDate, toDate, selectedLoaiChi, keyword, filteredList.Count);
        }
        catch (Exception ex)
        {
            HandleDatabaseError("tìm kiếm / lọc dữ liệu", ex);
        }
    }

    /// <summary>
    /// Xử lý lỗi CSDL: Ghi log Error và hiển thị thông báo thân thiện cho người dùng
    /// </summary>
    private void HandleDatabaseError(string actionDescription, Exception ex)
    {
        Log.Error(ex, "Lỗi xảy ra khi thực hiện thao tác CSDL ({Action}): {ErrorMessage}", actionDescription, ex.Message);

        MessageBox.Show(
            "Đã có lỗi xảy ra khi truy cập cơ sở dữ liệu!\n" +
            "Vui lòng kiểm tra lại cấu hình kết nối trong appsettings.json hoặc đảm bảo SQL Server đang hoạt động.\n\n" +
            $"Chi tiết lỗi: {ex.Message}",
            "Lỗi cơ sở dữ liệu",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
    }
}
