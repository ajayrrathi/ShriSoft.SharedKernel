using System;
using ShriSoft.SharedKernel.Classes;
namespace ShriSoft.SharedKernel.Entities
{
    /// <summary>
    /// Interface that should be inherited for returning operation result.
    /// </summary>
    public interface IResult
    {
        abstract bool IsSuccess { get; }
        abstract EmptyString Message { get; }
    }
}

