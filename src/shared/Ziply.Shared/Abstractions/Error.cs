namespace Ziply.Shared.Abstractions;
public record Error(string Code)
{
    public static Error None => new Error(string.Empty);
    public static Error ShortIdAlreadyExist => new Error("Error.ShortIdAlreadyExist");
    public static Error BadRequest => new Error("Error.BadRequest");
    public static Error InvalidOriginUrl => new Error("Error.InvalidOriginUrl");
    public static Error Empty => new Error("Error.Empty");
}
