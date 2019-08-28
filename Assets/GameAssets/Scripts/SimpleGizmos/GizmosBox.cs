using UnityEngine;

namespace CustomInspector.SimpleGizmos
{
	[RequireComponent(typeof(BoxCollider))]
	public class GizmosBox : MonoBehaviour
	{
		[SerializeField] private Color _gizmosColliderColor;
		[SerializeField] private Color _gizmosBordersColor;

		private BoxCollider _boxCollider;

		public BoxCollider BoxCollider
		{
			get
			{
				if (_boxCollider == null)
				{
					_boxCollider = GetComponent<BoxCollider>();
				}

				return _boxCollider;
			}
		}

		/// <summary>
		/// Called by Unity when the Editors SceneView is rendered
		/// </summary>
		private void OnDrawGizmos()
		{
			Gizmos.color = _gizmosBordersColor;
			Gizmos.DrawWireCube(transform.position + BoxCollider.center, BoxCollider.size);

			Gizmos.color = _gizmosColliderColor;
			Gizmos.DrawCube(transform.position + BoxCollider.center, BoxCollider.size);
		}

		/// <summary>
		/// Used instead of OnDrawGizmos() if the GAmeObject this script belongs to is selected
		/// </summary>
		private void OnDrawGizmosSelected()
		{
			Gizmos.color = _gizmosBordersColor;
			Gizmos.DrawWireCube(transform.position + BoxCollider.center, BoxCollider.size);

			Gizmos.color = _gizmosColliderColor;
			Gizmos.DrawCube(transform.position + BoxCollider.center, BoxCollider.size);
		}
	}
}

