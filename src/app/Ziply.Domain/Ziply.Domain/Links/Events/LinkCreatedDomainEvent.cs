using Ziply.Domain.Abstractions;

namespace Ziply.Domain.Links.Events;
public record LinkCreatedDomainEvent(Guid LinkId) : IDomainEvent;
