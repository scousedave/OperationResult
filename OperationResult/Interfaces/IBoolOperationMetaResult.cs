namespace Lawson.OperationResult.Interfaces
{
	public interface IBoolOperationMetaResult<TMeta> : IOperationMetaResultBase<TMeta>
	{
		bool OperationResult { get; }
	}
}