using Lawson.OperationResult.Interfaces;

namespace Lawson.OperationResult.OperationResults
{
	public struct RecordRange : IRecordRange
	{
		public int RangeNumber { get; set; }

		public int StartIndex { get; set; }

		public int RecordCount { get; set; }

		public RecordRange(int startIndex, int recordCount, int rangeNumber)
		{
			StartIndex = startIndex;
			RecordCount = recordCount;
			RangeNumber = rangeNumber;
		}
	}
}
