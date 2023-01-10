namespace FileManager.Models;

public class RefreshToken
{
    public string Token { get; set; }
    public DateTime Created { get; set; } = DateTime.Now;
    public DateTime Expires { get; set; }
    public string RefreshedToken { get; set; } = string.Empty;
    public DateTime TokenCreated { get; set; }
    public DateTime TokenExpired { get; set; }
}