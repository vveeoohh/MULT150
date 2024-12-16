using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	public string sceneToLoad = "jjamotillo_Final";


	public void LoadGame ()
	{
		SceneManager.LoadScene(sceneToLoad);
	}
}
