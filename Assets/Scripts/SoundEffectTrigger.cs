using UnityEngine;

public class SoundEffectTrigger : MonoBehaviour
{
    public AudioClip soundEffectClip; // Field to assign the audio clip in the Inspector
    private AudioSource audioSource; // Reference to the Audio Source component

    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogError("AudioSource component not found on this GameObject!");
        }
    }

    // This function is called when another collider enters the trigger collider attached to this GameObject
    private void OnTriggerEnter2D(Collider2D other) // Use OnTriggerEnter2D for 2D projects
    {
        // Optional: Check for a specific tag (e.g., "Player") if only certain objects should trigger the sound
        // if (other.CompareTag("Player"))
        // {
            if (soundEffectClip != null && audioSource != null)
            {
                // Play the assigned sound effect once
                audioSource.PlayOneShot(soundEffectClip);
            }
        // }
    }
}
