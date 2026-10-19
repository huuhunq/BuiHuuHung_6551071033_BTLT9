using System;
using System.IO;
using System.Windows.Forms;
using Serilog;
using SoChiTieuCaNhan.Configuration;

namespace SoChiTieuCaNhan;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // 1. Khởi tạo thư mục Logs cạnh file exe và cấu hình Serilog ghi file theo ngày (log-yyyyMMdd.txt)
        string logDirectory = Path.Combine(AppContext.BaseDirectory, "Logs");
        if (!Directory.Exists(logDirectory))
        {
            Directory.CreateDirectory(logDirectory);
        }

        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.File(
                path: Path.Combine(logDirectory, "log-.txt"),
                rollingInterval: RollingInterval.Day,
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
            .CreateLogger();

        try
        {
            Log.Information("Ứng dụng Sổ chi tiêu cá nhân đang khởi động...");

            // 2. Nạp cấu hình từ appsettings.json
            ConfigurationHelper.LoadConfiguration();
            Log.Information("Nạp cấu hình thành công. ConnectionString: {ConnectionString}", 
                ConfigurationHelper.Current.ConnectionStrings.DefaultConnection);

            ApplicationConfiguration.Initialize();
            Application.Run(new FormChiTieu());

            Log.Information("Ứng dụng đã thoát bình thường.");
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "Ứng dụng dừng đột ngột do lỗi nghiêm trọng: {Message}", ex.Message);
            MessageBox.Show($"Lỗi nghiêm trọng: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }
}