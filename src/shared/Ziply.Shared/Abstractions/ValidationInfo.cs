namespace Ziply.Shared.Abstractions;
public class ValidationInfo
{
    public string FieldName { get; }
    public Error Error { get; }
    public ValidationInfo(string fieldName, Error error)
    {
        FieldName = fieldName;
        Error = error;
    }
}
