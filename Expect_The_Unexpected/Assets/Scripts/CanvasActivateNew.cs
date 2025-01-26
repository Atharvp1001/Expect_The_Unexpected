using UnityEngine;
using UnityEngine.Video;  // Needed for VideoPlayer

public class CanvasActivatorNew : MonoBehaviour
{
    // Reference to the Canvas that you want to activate
    public Canvas canvasToActivate;

    // Reference to the VideoPlayer component that is playing the video
    public VideoPlayer videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        // Ensure VideoPlayer is not null and subscribe to the loopPointReached event
        if (videoPlayer != null)
        {
            videoPlayer.loopPointReached += OnVideoEnd;  // Subscribe to video end event
        }
        else
        {
            Debug.LogWarning("VideoPlayer reference is missing.");
        }
    }

    // Called when the video finishes playing
    private void OnVideoEnd(VideoPlayer vp)
    {
        // Activate the canvas when the video ends
        if (canvasToActivate != null)
        {
            canvasToActivate.gameObject.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Canvas reference is missing.");
        }
    }
}
