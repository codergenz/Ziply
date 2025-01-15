namespace Ziply.Domain.Links;
public interface ILinkRepository
{
    Task<Link?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IEnumerable<Link>> GetListAsync(Guid userId, CancellationToken cancellationToken = default);
    void Add(Link link);
    void Update(Link link);
    void Remove(Link link);
    Task<bool> IsShortIdUniqueAsync(Guid? linkId, string shortId, CancellationToken cancellationToken = default);
}
