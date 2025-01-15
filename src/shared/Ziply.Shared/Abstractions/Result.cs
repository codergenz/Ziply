using Microsoft.AspNetCore.Http;

namespace Ziply.Shared.Abstractions;
public class Result
{
    protected internal Result(int statusCode, bool isSuccess, string error, IEnumerable<ValidationInfo>? validationInfos = null)
    {
        StatusCode = statusCode;
        IsSuccess = isSuccess;
        ErrorMessage = error;
        ValidationInfos = validationInfos;
    }

    public bool IsSuccess { get; }
    public string ErrorMessage { get; }
    public int StatusCode { get; set; }
    public IEnumerable<ValidationInfo>? ValidationInfos { get; set; }

    public static Result Success(int statusCode = StatusCodes.Status200OK) => new Result(statusCode, true, string.Empty);
    public static Result Failure(string error, int statusCode = StatusCodes.Status500InternalServerError, IEnumerable<ValidationInfo>? validationInfos = null) => new Result(statusCode, false, error, validationInfos);

    public static Result<TValue> Success<TValue>(TValue value, int statusCode = StatusCodes.Status200OK) => new Result<TValue>(statusCode,value, true, string.Empty);
    public static Result<TValue> Failure<TValue>(string error, int statusCode = StatusCodes.Status400BadRequest, IEnumerable<ValidationInfo>? validationInfos = null) => new Result<TValue>(statusCode, default, false, error, validationInfos);

    public static Result<TValue> Create<TValue>(TValue? value) =>
        value is not null ? Success(value) : Failure<TValue>("UnExpected Error");
}

public class Result<TValue> : Result
{

    private readonly TValue? _value;
    protected internal Result(int statusCode, TValue? value, bool isSuccess, string error, IEnumerable<ValidationInfo>? validationInfos = null) : base(statusCode, isSuccess, error, validationInfos)
    {
        _value = value;
    }

    public TValue? Data => IsSuccess ? _value : default;

    public static implicit operator Result<TValue>(TValue value) => Create(value);
}
