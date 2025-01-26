using UnityEngine;

public class AnimationEventHandler : MonoBehaviour
{
    // Reference to the Canvas that you want to activate
    public Canvas canvasToActivate;

    // This method is called when the animation event is triggered
    public void ActivateCanvas()
    {
        // Activate the canvas
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
