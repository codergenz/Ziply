namespace Ziply.Domain.Links;
public interface ILinkRepository
{
    Task<Link?> GetByIdAsync(Guid id);
    Task<IEnumerable<Link>> GetListAsync(Guid userId);
    void Add(Link link);
}
