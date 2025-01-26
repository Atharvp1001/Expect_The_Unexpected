using UnityEngine;
using UnityEngine.UI;

public class RendText : MonoBehaviour
{
    public RawImage rawImage; // Reference to the RawImage component
    public RenderTexture[] renderTextures; // Array of RenderTextures to choose from

    // Method to dynamically assign a RenderTexture based on index
    public RenderTexture AssignRenderTexture(int index)
    {
        if (index >= 0 && index < renderTextures.Length)
        {
            rawImage.texture = renderTextures[index]; // Assign the selected RenderTexture to the RawImage
            return renderTextures[index]; // Return the assigned RenderTexture
        }
        else
        {
            Debug.LogError("Invalid RenderTexture index!");
            return null;
        }
    }
}
