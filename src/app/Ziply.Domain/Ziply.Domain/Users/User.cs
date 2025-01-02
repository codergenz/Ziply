using Ziply.Domain.Abstractions;

namespace Ziply.Domain.Users;
public sealed class User : Entity
{
    private User(Guid id) : base(id)
    {
    }

    public FirstName FirstName { get; private set; }
    public LastName LastName { get; private set; }
    public Email Email { get; private set; }
    public PasswordHash PasswordHash { get; private set; }
    public IsEmailConfirmed IsEmailConfirmed { get; set; }

    public static User Create(FirstName firstName, LastName lastName, Email email, PasswordHash passwordHash)
    {
        User user = new(Guid.NewGuid())
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            PasswordHash = passwordHash
        };

        return user;
    }
}
