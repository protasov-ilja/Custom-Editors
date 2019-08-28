using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEditorInternal;

namespace CustomInspector.CustomList
{
	[CustomEditor(typeof(GameManager))]
	public class GameManagerEditor : Editor
	{
		private ReorderableList _list;
		private GameManager _gameManager;

		public void OnEnable()
		{
			_gameManager = target as GameManager;
		}

		public override void OnInspectorGUI()
		{
			DrawDefaultInspector();

			if (_gameManager.items.Count > 0)
			{
				foreach (var item in _gameManager.items)
				{
					EditorGUILayout.BeginVertical("Box");

					item.id = EditorGUILayout.IntField("Id", item.id);
					item.name = EditorGUILayout.TextField("Name of item", item.name);
					item.image = (Sprite)EditorGUILayout.ObjectField("Sprite", item.image, typeof(Sprite), false);

					EditorGUILayout.BeginHorizontal();
					if (GUILayout.Button("Delete", GUILayout.Width(50), GUILayout.Height(15)))
					{
						_gameManager.items.Remove(item);
						break;
					}
					EditorGUILayout.EndHorizontal();

					EditorGUILayout.EndVertical();
				}
			}
			else
			{
				EditorGUILayout.LabelField("List is Empty");
			}

			if (GUILayout.Button("Add item", GUILayout.Height(20)))
			{
				_gameManager.items.Add(new Item());
			}

			if (GUI.changed) SetObjectDirty(_gameManager.gameObject);
		}

		private void CreatedReodarableList()
		{
			_list = new ReorderableList(serializedObject, serializedObject.FindProperty("Pattern"), true, true, true, true);
		}

		public static void SetObjectDirty(GameObject obj)
		{
			EditorUtility.SetDirty(obj);
			EditorSceneManager.MarkSceneDirty(obj.scene);
		}
	}
}

