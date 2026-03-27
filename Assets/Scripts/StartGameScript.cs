using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour
{
    public string LevelName;
    public void LoadLevel()
    {
        SceneManager.LoadScene(LevelName);
    }
}
