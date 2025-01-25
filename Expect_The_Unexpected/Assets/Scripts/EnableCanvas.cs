using UnityEngine;

public class EnableCanvas : MonoBehaviour
{
    public Canvas targetCanvas; // The Canvas to enable

    // Method to enable the Canvas
    public void EnableTargetCanvas()
    {
        if (targetCanvas != null)
        {
            targetCanvas.gameObject.SetActive(true); // Enable the Canvas GameObject
        }
        else
        {
            Debug.LogError("Target Canvas is not assigned in the Inspector!");
        }
    }
}
