# ỨNG DỤNG "SỔ CHI TIÊU CÁ NHÂN" (WinForms - EF Core Database First)
**Bài tập Chương 11 - Lập trình trực quan**

---

## 1. Cấu trúc thư mục dự án
```text
Câu 1/
│── init_db.sql                    <- Script SQL tạo CSDL QL_ChiTieu và 12 dòng dữ liệu mẫu
│── .gitignore                     <- Loại trừ bin, obj, Logs và file cấu hình nhạy cảm chứa pass
│── SoChiTieuCaNhan.sln            <- Solution mở bằng Visual Studio 2022
│── SoChiTieuCaNhan/
│   │── Configuration/
│   │   │── AppSettings.cs         <- Lớp cấu hình strongly-typed (Task 5)
│   │   └── ConfigurationHelper.cs <- Đọc appsettings.json qua ConfigurationBuilder
│   │── Models/
│   │   │── ChiTieu.cs             <- Entity Model sinh từ EF Core Database First (Task 1)
│   │   │── QL_ChiTieuContext.cs   <- DbContext EF Core (kết nối động theo appsettings)
│   │   └── ChiTieuViewModel.cs    <- Model định dạng hiển thị cho DataGridView (D3, N0 đ)
│   │── FormChiTieu.cs             <- Code xử lý CRUD, validation, lọc/tìm kiếm, tính tổng tiền, Serilog
│   │── FormChiTieu.Designer.cs    <- Giao diện chuẩn theo đúng thiết kế mẫu (Task 2)
│   │── Program.cs                 <- Khởi tạo Serilog ghi log theo ngày, chạy ứng dụng
│   │── appsettings.json           <- File cấu hình mặc định (Copy if newer)
│   │── appsettings.Development.json <- Cấu hình môi trường dev
│   │── appsettings.example.json   <- File mẫu hướng dẫn kết nối trên máy khác (Task 5)
│   │── SoChiTieuCaNhan.csproj     <- Cấu hình .NET 8, gói nuget và thuộc tính copy
│   └── publish/                   <- Thư mục đóng gói Framework-Dependent win-x64 (Task 7)
│       │── SoChiTieuCaNhan.exe    <- File thực thi
│       │── appsettings.json       <- Chỉnh sửa chuỗi kết nối tại đây mà không cần build lại
│       │── init_db.sql            <- Chạy trên máy mới để tạo CSDL
│       └── Logs/                  <- Thư mục chứa log dạng log-yyyyMMdd.txt (Task 6)
```

---

## 2. Đáp ứng chi tiết các yêu cầu của đề bài

### Task 1: Tạo CSDL và Scaffold
- Database: `QL_ChiTieu`, bảng `ChiTieu` với các trường `MaCT` (Identity, PK), `NgayChi` (date), `NoiDung` (nvarchar 100), `LoaiChi` (nvarchar 30), `SoTien` (decimal 18,0), `GhiChu` (nvarchar 200).
- Nhập sẵn **12 dòng dữ liệu mẫu** đa dạng (Ăn uống, Đi lại, Học tập, Giải trí, Khác).
- Sinh code tự động bằng EF Core Database First:
  ```bash
  dotnet ef dbcontext scaffold "Server=localhost;Database=QL_ChiTieu;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models --context QL_ChiTieuContext
  ```

### Task 2 & 3: Thiết kế FormChiTieu và CRUD 1 bảng
- Giao diện thiết kế trực quan, chuẩn từng vị trí theo ảnh mẫu.
- **Thêm/Sửa**:
  - Tự động kiểm tra hợp lệ:
    - Nội dung không rỗng / không chỉ chứa khoảng trắng.
    - Số tiền phải > 0 (bước nhảy 1.000).
    - Ngày chi không được lớn hơn ngày hiện tại (`DateTime.Today`).
    - Phải chọn loại chi.
- **Xóa**:
  - Hiện hộp thoại `MessageBox` hỏi xác nhận trước khi xóa (Yes/No).
- **Click vào dòng trong lưới**: Tự động đổ dữ liệu lên các control để chỉnh sửa.
- **Làm mới**: Xóa trắng dữ liệu nhập, reset các bộ lọc tìm kiếm và tải lại toàn bộ danh sách.

### Task 4: Tìm kiếm / Lọc và Tổng tiền
- Tìm kiếm theo nội dung (chứa từ khóa, không phân biệt hoa thường).
- Lọc theo loại chi ("Tất cả", "Ăn uống", "Đi lại", "Học tập", "Giải trí", "Khác").
- Lọc theo khoảng thời gian ("Từ ngày" - "Đến ngày").
- Label **"Tổng chi: ... đ"** tự động tính tổng tiền của danh sách đang hiển thị và format dấu chấm hàng nghìn chuẩn tiếng Việt (ví dụ: `1.250.000 đ`).

### Task 5: Cấu hình linh hoạt (appsettings.json)
- Sử dụng thư viện `Microsoft.Extensions.Configuration` và `ConfigurationBuilder`.
- Tạo lớp strongly-typed `AppSettings` và `ConnectionStringsConfig`.
- Cấu hình thuộc tính `<CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>` cho `appsettings*.json`.
- Tạo file `.gitignore` để tránh commit mật khẩu nhạy cảm.
- Cung cấp file mẫu `appsettings.example.json`.

### Task 6: Ghi log bằng Serilog (Logs/log-yyyyMMdd.txt)
- Sử dụng Serilog với RollingInterval theo ngày: file được tạo tự động dạng `Logs/log-yyyyMMdd.txt` nằm ngay cạnh file `.exe`.
- Ghi mức `Information` khi Thêm/Sửa/Xóa (kèm mã `MaCT`).
- Ghi mức `Error` khi truy cập CSDL thất bại (bọc try/catch, ghi log chi tiết lỗi và hiển thị `MessageBox` thân thiện).

### Task 7: Đóng gói chuyển sang máy khác
- Đóng gói dạng Framework-Dependent, win-x64:
  ```bash
  dotnet publish -c Release -r win-x64 --no-self-contained -o ./publish
  ```
- **Cách chạy trên máy khác:**
  1. Đảm bảo máy đích đã cài [.NET Desktop Runtime 8.0](https://dotnet.microsoft.com/download/dotnet/8.0).
  2. Mở file `init_db.sql` trong SQL Server Management Studio (SSMS) trên máy đích và nhấn **Execute** để tạo CSDL `QL_ChiTieu`.
  3. Mở file `publish/appsettings.json`, sửa lại tên Server / tài khoản cho đúng với SQL Server của máy đích (ví dụ: `Server=.\\SQLEXPRESS;...` hoặc tên máy). **Không cần build lại code!**
  4. Chạy trực tiếp `SoChiTieuCaNhan.exe`.
