using System;
using System.Globalization;

namespace SoChiTieuCaNhan.Models;

public class ChiTieuViewModel
{
    private static readonly CultureInfo VnCulture = new("vi-VN");

    public int MaCt { get; set; }
    public string MaCtDisplay => MaCt.ToString("D3");
    public DateOnly NgayChi { get; set; }
    public string NgayChiDisplay => NgayChi.ToString("dd/MM/yyyy");
    public string NoiDung { get; set; } = string.Empty;
    public string LoaiChi { get; set; } = string.Empty;
    public decimal SoTien { get; set; }
    public string SoTienDisplay => SoTien.ToString("N0", VnCulture);
    public string? GhiChu { get; set; }
}
