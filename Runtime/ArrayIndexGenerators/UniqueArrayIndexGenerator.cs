using OriGames.Extensions.CollectionExtensions;

namespace OriGames.Extensions.ArrayIndexGenerators
{
	public class UniqueArrayIndexGenerator : IArrayIndexGenerator
	{
		private readonly int _maxValue;
		private readonly bool _shuffleOnEnd;

		private int _currentObjectIndex = -1;
		private int[] _indexes;

		public UniqueArrayIndexGenerator(int maxValue, bool shuffleOnEnd)
		{
			_maxValue = maxValue;
			_shuffleOnEnd = shuffleOnEnd;

			ResetGenerator();
		}

		public int GetIndex()
		{
			_currentObjectIndex++;

			if (_currentObjectIndex >= _indexes.Length)
			{
				_currentObjectIndex = 0;

				if (_shuffleOnEnd)
					_indexes.Shuffle();
			}

			return _indexes[_currentObjectIndex];
		}

		public void ResetGenerator()
		{
			_indexes = new int[_maxValue];

			for (int i = 0; i < _maxValue; i++)
			{
				_indexes[i] = i;
			}

			_indexes.Shuffle();
		}
	}
}
