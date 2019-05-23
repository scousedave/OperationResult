
namespace Lawson.OperationResult.Interfaces
{
	public interface IOperationMetaResultBase<TMeta> : IOperationResultBase
	{
		TMeta Meta { get; set; }
	}
}