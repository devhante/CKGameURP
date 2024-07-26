using UnityEngine;
using UnityEngine.SceneManagement;

public class Easel : MonoBehaviour
{
	public void OnClickItem()
	{
		Debug.Log("OnClickItem");
		SceneManager.LoadScene("HexPuzzleScene");
	}
}
