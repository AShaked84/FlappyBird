using UnityEngine;
using UnityEngine.SceneManagement; // Needed for scene management events if you want to handle specific scenes

public class MusicManager : MonoBehaviour
{
    private static MusicManager instance = null;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            // If an instance already exists, destroy this new one
            Destroy(this.gameObject);
            return;
        }
        else
        {
            // Otherwise, set this as the instance
            instance = this;
        }

        // Keep the GameObject alive across scene changes
        DontDestroyOnLoad(this.gameObject);
    }

    // You can add methods here to Play(), Stop(), or adjust volume from other scripts
    // public void PlayMusic() { ... }
    // public void StopMusic() { ... }
}
