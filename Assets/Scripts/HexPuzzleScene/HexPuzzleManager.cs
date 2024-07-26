using UnityEngine;

public class HexPuzzleManager : MonoBehaviour
{
	[SerializeField] private GameObject[] hexTiles;
	[SerializeField] private GameObject key;
	
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
}
