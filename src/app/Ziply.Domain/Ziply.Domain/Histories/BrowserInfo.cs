namespace Ziply.Domain.Histories;
public record BrowserInfo(string? OS, string? Browser, string? IpAddress)
{
    public string City { get; set; }
    public string ContinentCode { get; set; }
    public string Region { get; set; }
    public string CountryCode { get; set; }
    public string CountryFlagUrl { get; set; }
}
