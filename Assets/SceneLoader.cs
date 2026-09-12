using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void GoToSecondaryScene()
    {
        SceneManager.LoadScene("SecondaryScene");
    }

    public void GoToPrincipalScene()
    {
        SceneManager.LoadScene("PrincipalScene");
    }
}
