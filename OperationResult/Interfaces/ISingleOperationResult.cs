namespace Lawson.OperationResult.Interfaces
{
	public interface ISingleOperationResult<T> : IOperationResultBase
	{
		T OperationResult { get; set; }
	}
}