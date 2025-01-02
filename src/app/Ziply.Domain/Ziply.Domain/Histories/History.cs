using Ziply.Domain.Abstractions;

namespace Ziply.Domain.Histories;
public sealed class History : Entity
{
    private History(Guid id) : base(id)
    {
    }

    public Guid UrlId { get; set; }
    public DateTime CreatedDate { get; private set; }
    public BrowserInfo? BrowserInfo { get; set; }

    public static History Create(Guid urlId, BrowserInfo? browserInfo)
    {
        return new History(Guid.NewGuid())
        {
            UrlId = urlId,
            CreatedDate = DateTime.Now
        };
    }
}
