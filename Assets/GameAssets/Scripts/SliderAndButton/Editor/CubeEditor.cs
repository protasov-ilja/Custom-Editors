using UnityEditor;
using UnityEngine;

namespace CustomInspector.Breakeys.Inspector
{
	/// <summary>
	/// Custom buttons for cube
	/// </summary>
	[CustomEditor(typeof(Cube))]
	public class CubeEditor : Editor
	{
		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();

			var cube = (Cube)target;

			GUILayout.BeginHorizontal();

			if (GUILayout.Button("Generate Color"))
			{
				Debug.Log("We pressed generate color");
				cube.GenerateColor();
			}

			if (GUILayout.Button("Reset"))
			{
				cube.Reset();
			}

			GUILayout.EndHorizontal();
		}
	}
}

