using System;
using UnityEngine;
using UnityEngine.UI;

public class HexagonPiece : MonoBehaviour
{
	private Button button;
	
	private void Start()
	{
		button = GetComponent<Button>();
		button.onClick.AddListener(OnClickButton);
	}

	private void OnClickButton()
	{
		transform.Rotate(new Vector3(0f, 0f, -60f));
	}
}
