using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Slider VolumeSlider;

    public void SetVolume()
    {
        // Calculate the inverted volume value and normalize it between 0 and 1
        float normalizedVolume = (100f - VolumeSlider.value) / 100f;

        // Clamp the value to ensure it stays within the valid range (0 to 1)
        AudioListener.volume = Mathf.Clamp(normalizedVolume, 0f, 1f);

        // Debug log to verify the calculated volume
        Debug.Log("Volume: " + AudioListener.volume);
    }
}