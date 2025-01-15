using Ziply.Shared.Abstractions;

namespace Ziply.Shared.Exceptions;
public sealed class ValidationException(IEnumerable<ValidationInfo> validationInfos) : Exception
{
    public IEnumerable<ValidationInfo> ValidationInfos => validationInfos;
}