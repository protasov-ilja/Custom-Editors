using UnityEditor;
using UnityEngine;

namespace CustomInspector.CustomWindow
{
	public class ExampleWindow : EditorWindow
	{
		private string _myString = "Hello, World!";
		private Color _color;

		[MenuItem("Window/Colorizer")]
		public static void ShowWindow()
		{
			GetWindow<ExampleWindow>("Colorizer");
		}

		private void OnGUI()
		{
			GUILayout.Label("Color the selected objects!", EditorStyles.boldLabel);

			_myString = EditorGUILayout.TextField("Name", _myString);
			_color = EditorGUILayout.ColorField("Color", _color);

			if (GUILayout.Button("Colorize!"))
			{
				Colorize();
			}
		}

		private void Colorize()
		{
			var selectedObjects = Selection.gameObjects;

			foreach (var obj in selectedObjects)
			{
				var renderer = obj.GetComponent<Renderer>();
				if (renderer != null)
				{
					renderer.sharedMaterial.color = _color;
				}
			}
		}
	}
}

