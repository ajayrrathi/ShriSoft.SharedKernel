
using ShriSoft.SharedKernel.Classes;
namespace ShriSoft.SharedKernel.Entities
{
    /// <summary>
    /// Can be used for returning the results of the operation.
    /// </summary>
    public class Result : IResult
    {
        public virtual bool IsSuccess { get; } 
        public virtual EmptyString Message { get; }

        public Result(string message, bool isSuccess)
        {
            Message = message;
            IsSuccess = isSuccess;
        }
    }
}
