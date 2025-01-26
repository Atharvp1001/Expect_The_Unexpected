using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerController : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Reference to the VideoPlayer component
    public VideoClip[] videoClips; // Array of video clips to choose from
    public GameObject targetObject;
    public RendText rendText; // Reference to the RendText script to access AssignRenderTexture method

    void Start()
    {
        videoPlayer.playOnAwake = false; // Ensure the VideoPlayer doesn't play on awake
    }

    public void PlayVideo(int index)    
    {
        targetObject.SetActive(true);

        // Ensure the index is valid
        if (index >= 0 && index < videoClips.Length)
        {
            // Call AssignRenderTexture from RendText script
            if (rendText != null)
            {
                // Assign RenderTexture to the VideoPlayer's targetTexture
                RenderTexture selectedTexture = rendText.AssignRenderTexture(index); // Pass the same index to assign corresponding RenderTexture
                videoPlayer.targetTexture = selectedTexture; // Set the RenderTexture to the VideoPlayer
            }
            else
            {
                Debug.LogError("RendText script not assigned!");
            }

            // Set the selected video clip and play
            videoPlayer.clip = videoClips[index];
            videoPlayer.Play();
        }
        else
        {
            Debug.LogError("Invalid video index selected!");
        }
    }

    public void PlayVideo()
    {
        if (videoPlayer != null)
        {
            videoPlayer.Play(); // Play the video
        }
        else
        {
            Debug.LogError("VideoPlayer not assigned!");
        }
    }

    public void StopVideo()
    {
        videoPlayer.Stop(); // Stop the video
    }
}
