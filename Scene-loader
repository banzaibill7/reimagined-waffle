//Use esse script para carregar cenas consecutivas na Unity, porém é necessário
//incluir as cenas no Build Settings, pois ele usa o Index delas para carregar.

using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadFirstScene()
    {
        SceneManager.LoadScene(0);
    }
}
