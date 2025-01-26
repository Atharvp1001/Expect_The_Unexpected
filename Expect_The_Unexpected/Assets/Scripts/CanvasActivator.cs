using UnityEngine;
using System.Collections;  // Add this to use IEnumerator

public class CanvasActivator : MonoBehaviour
{
    // Reference to the Canvas that you want to activate
    public Canvas canvasToActivate;

    // Start is called before the first frame update
    void Start()
    {
        // Start the coroutine to activate the canvas after 30 seconds
        StartCoroutine(ActivateCanvasAfterDelay(10f));
    }

    // Coroutine that activates the canvas after a delay
    private IEnumerator ActivateCanvasAfterDelay(float delay)
    {
        // Wait for the specified delay time
        yield return new WaitForSeconds(delay);

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
