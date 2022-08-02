namespace OriGames.Extensions.ArrayIndexGenerators
{
	public interface IArrayIndexGenerator
	{
		int GetIndex();

		void ResetGenerator();
	}
}
