using UnityEngine;

namespace CustomInspector.SimpleGizmos
{
	public class CameraSafeArea : MonoBehaviour
	{
		[Header("Safe Frame")]
		[SerializeField, Range(0, 1)]
		private float _safeFrameTop;

		[SerializeField, Range(0, 1)]
		private float _safeFrameBottom;

		[SerializeField] private Color _gizmosColor;

		private Camera _camera;
		public Camera Camera
		{
			get
			{
				if (_camera == null)
				{
					_camera = Camera.main;
				}

				return _camera;
			}
		}

		private void OnDrawGizmos()
		{
			DrawSafeFrameGizmos();
		}

		private void DrawSafeFrameGizmos()
		{
			var corner1 = Camera.ViewportToWorldPoint(new Vector3(0f, _safeFrameTop, 1f));
			var corner2 = Camera.ViewportToWorldPoint(new Vector3(1f, _safeFrameTop, 1f));
			var corner3 = Camera.ViewportToWorldPoint(new Vector3(0f, _safeFrameBottom, 1f));
			var corner4 = Camera.ViewportToWorldPoint(new Vector3(1f, _safeFrameBottom, 1f));

			Gizmos.color = _gizmosColor;
			Gizmos.DrawLine(corner1, corner2);
			Gizmos.DrawLine(corner3, corner4);
		}
	}
}
