using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string sceneName = "SceneName";
    public void SceneChangeTo()
    {
        SceneManager.LoadScene(sceneName);
    }
}
