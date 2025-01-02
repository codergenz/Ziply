using Ziply.Domain.Abstractions;

namespace Ziply.Domain.Links.Events;
public record LinkScanedDomainEvent(Guid LinkId) : IDomainEvent;
