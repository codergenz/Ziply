using Ziply.Domain.Abstractions;
using Ziply.Domain.Links.Events;

namespace Ziply.Domain.Links;
public sealed class Link : Entity
{
    private Link(Guid id) : base(id)
    {
    }
    /// <summary>
    /// Url thực tế
    /// </summary>
    public OriginalUrl OriginalUrl { get; set; }
    /// <summary>
    /// Url rút gọn
    /// </summary>
    public ShortId ShortId { get; set; }
    /// <summary>
    /// Tiêu đề của link, dùng để hiển thị và tìm kiếm
    /// </summary>
    public Title? Title { get; set; }
    /// <summary>
    /// Các meta data dùng cho việc hiển thị link trên các trang mạng xã hội
    /// </summary>
    public LinkMetaData? LinkMetaData { get; set; }
    /// <summary>
    /// Số lượt click vào link
    /// </summary>
    public ClickCount ClickCount { get; set; }
    /// <summary>
    /// Id Người tạo link
    /// </summary>
    public Guid UserId { get; set; }
    /// <summary>
    /// Thời gian chỉnh sửa
    /// </summary>
    public DateTime LastUpdate { get; set; } = DateTime.Now;

    public static Link Create(Guid userId, OriginalUrl originalUrl, ShortId shortId, Title? title)
    {
        var link = new Link(Guid.NewGuid())
        {
            OriginalUrl = originalUrl,
            ShortId = shortId,
            Title = title,
            UserId = userId,
        };
        link.RaiseDomainEvent(new LinkCreatedDomainEvent(link.Id));
        return link;
    }

    public Link Update(OriginalUrl originalUrl, ShortId shortId, Title? title)
    {
        if(OriginalUrl != originalUrl)
        {
            RaiseDomainEvent(new LinkOriginUrlChangedDomainEvent(Id));
        }
        OriginalUrl = originalUrl;
        Title = title;
        ShortId = shortId;
        LastUpdate = DateTime.Now;
        return this;
    }

    public void Remove()
    {
        RaiseDomainEvent(new LinkRemovedDomainEvent(Id));
    }
}
