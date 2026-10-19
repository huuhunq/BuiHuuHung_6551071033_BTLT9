namespace SoChiTieuCaNhan.Configuration;

public class ConnectionStringsConfig
{
    public string DefaultConnection { get; set; } = string.Empty;
}

public class AppSettings
{
    public ConnectionStringsConfig ConnectionStrings { get; set; } = new();
}
