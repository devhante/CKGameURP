using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HexPuzzleManager : MonoBehaviour
{
	[SerializeField] private GameObject[] hexTiles;
	[SerializeField] private GameObject key;
	[SerializeField] private Button exitButton;

	private void Awake()
	{
		exitButton.onClick.AddListener(OnClickExitButton);
	}

	private void Update()
	{
		bool solved = true;

		foreach (var tile in hexTiles)
		{
			if (tile.transform.rotation.eulerAngles.z > 0.01f)
				solved = false;
		}
		
		if (solved)
			key.SetActive(true);
	}

	private void OnClickExitButton()
	{
		SceneManager.LoadScene("MainScene");
	}
}
