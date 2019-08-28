using UnityEditor;
using UnityEngine;

namespace CustomInspector.Breakeys.Inspector
{
	/// <summary>
	/// Custom slider for sphere
	/// </summary>
	[CustomEditor(typeof(Sphere))]
	public class SphereEditor : Editor
	{
		public override void OnInspectorGUI()
		{
			var sphere = (Sphere)target;

			GUILayout.Label("Oscillates around a base size.");

			sphere.baseSize = EditorGUILayout.Slider("Size", sphere.baseSize, 0.1f, 2.0f);

			sphere.transform.localScale = Vector3.one * sphere.baseSize;
		}
	}
}
