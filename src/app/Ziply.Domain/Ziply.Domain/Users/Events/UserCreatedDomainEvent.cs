using Ziply.Domain.Abstractions;

namespace Ziply.Domain.Users.Events;
public record UserCreatedDomainEvent(Guid UserId) : IDomainEvent;
