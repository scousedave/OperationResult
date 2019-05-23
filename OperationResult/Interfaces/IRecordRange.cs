namespace Lawson.OperationResult.Interfaces
{
	public interface IRecordRange
	{
		int RangeNumber { get; set; }
		int StartIndex { get; set; }
		int RecordCount { get; set; }
	}
}