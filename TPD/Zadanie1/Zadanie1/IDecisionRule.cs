namespace Zadanie1
{
	public interface IDecisionRule
	{
		int[] Decide(Matrix matrix);
		string Name { get; }
	}
}