using Ziply.Domain.Abstractions;

namespace Ziply.Domain.Links.Events;
public record LinkRemovedDomainEvent(Guid LinkId) : IDomainEvent;
