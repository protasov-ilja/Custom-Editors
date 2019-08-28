using UnityEngine;

namespace CustomInspector.Breakeys
{
	[RequireComponent(typeof(Renderer))]
	public class Cube : MonoBehaviour
	{
		#region Unity Methods
		private void Start()
		{
			GenerateColor();
		}
		#endregion

		#region Public Methods
		public void GenerateColor()
		{
			GetComponent<Renderer>().sharedMaterial.color = Random.ColorHSV();
		}

		public void Reset()
		{
			GetComponent<Renderer>().sharedMaterial.color = Color.white;
		}
		#endregion
	}
}

