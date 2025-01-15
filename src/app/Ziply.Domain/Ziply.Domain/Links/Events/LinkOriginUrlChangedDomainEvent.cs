using Ziply.Domain.Abstractions;

namespace Ziply.Domain.Links.Events;
public record LinkOriginUrlChangedDomainEvent(Guid LinkId) : IDomainEvent;