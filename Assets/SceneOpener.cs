using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneOpener : MonoBehaviour
{
    public string sceneToOpen;
    public void OpenScene()
    {
        SceneManager.LoadScene(2);
        Debug.Log("a");
    }
    public void OpenScene(int i)
    {
        SceneManager.LoadScene(i);
        Debug.Log("a");
    }
}



