using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene(int sceneBuildIndex)
    {
        SceneManager.LoadScene(sceneBuildIndex);
    }
    
    public void ReLoadActiveScene()
    {
        LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
