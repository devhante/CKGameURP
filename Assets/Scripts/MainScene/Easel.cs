using UnityEngine;
using UnityEngine.SceneManagement;

public class Easel : MonoBehaviour
{
	public void OnClickItem()
	{
		SceneManager.LoadScene("HexPuzzleScene");
	}
}
