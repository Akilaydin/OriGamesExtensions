using UnityEngine;

namespace OriGames.Utilities
{
	public class TargetFrameRateSetter : MonoBehaviour
	{
		[SerializeField]
		private int _targetFrameRate;

		[SerializeField]
		private bool _useDeviceRefreshRateAsTarget;
	
		private void Awake()
		{
			if (_useDeviceRefreshRateAsTarget)
			{
				Application.targetFrameRate = Screen.currentResolution.refreshRate;
			}
			else
			{
				Application.targetFrameRate = _targetFrameRate;
			}
		}
	}
}