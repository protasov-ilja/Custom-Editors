using System.Collections.Generic;
using UnityEngine;

namespace CustomInspector.CustomList
{
	public class GameManager : MonoBehaviour
	{
		[HideInInspector] public List<Item> items;
	}
}

