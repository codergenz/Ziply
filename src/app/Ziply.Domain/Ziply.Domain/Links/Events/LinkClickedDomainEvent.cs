using Ziply.Domain.Abstractions;

namespace Ziply.Domain.Links.Events;
public record LinkClickedDomainEvent(Guid LinkId) : IDomainEvent;
