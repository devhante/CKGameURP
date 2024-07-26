using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseInputProvider : MonoBehaviour
{
	public Vector2 WorldPosition { get; private set; }
	public event Action Clicked;

	private void OnLook(InputValue value)
	{
		WorldPosition = Camera.main.ScreenToWorldPoint(value.Get<Vector2>());
	}

	private void OnAction(InputValue value)
	{
		Clicked?.Invoke();
	}
}