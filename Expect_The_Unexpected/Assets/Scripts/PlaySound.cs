using UnityEngine;

public class PlaySound : MonoBehaviour
{

    public AudioClip[] audioClips; // Array of audio clips for different sounds
    public float soundVolume = 1.0f; // Volume of the sound (0.0 to 1.0)

    // Method to play a sound by index
    public void PlaySoundClip(int clipIndex)
    {
        if (clipIndex >= 0 && clipIndex < audioClips.Length)
        {
            AudioSource.PlayClipAtPoint(audioClips[clipIndex], transform.position, soundVolume);
        }
        else
        {
            Debug.LogError("Invalid audio clip index!");
        }
    }
}
