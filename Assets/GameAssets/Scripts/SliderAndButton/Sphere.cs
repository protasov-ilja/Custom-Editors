﻿using UnityEngine;

namespace CustomInspector.Breakeys
{
	public sealed class Sphere : MonoBehaviour
	{
		[HideInInspector] public float baseSize = 1f;

		private void Update()
		{
			float animation = baseSize + Mathf.Sin(Time.time * 8f) * baseSize / 7f;
			transform.localScale = Vector3.one * animation;
		}
	}
}
