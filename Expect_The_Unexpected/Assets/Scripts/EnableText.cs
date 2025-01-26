using UnityEngine;
using TMPro; // For TextMeshPro

public class EnableText : MonoBehaviour
{
    public TMP_Text textToEnable; // Reference to the TextMeshPro component
    public UnityEngine.UI.Button yourButton; // Reference to the button

    void Start()
    {
        // Ensure button is assigned and add listener for the button press
        if (yourButton != null)
        {
            yourButton.onClick.AddListener(OnButtonPress);
        }
        else
        {
            Debug.LogError("Button not assigned!");
        }

        // Initially disable the text if needed
        if (textToEnable != null)
        {
            textToEnable.gameObject.SetActive(false);
        }
        else
        {
            Debug.LogError("Text not assigned!");
        }
    }

    // This method will be called when the button is pressed
    void OnButtonPress()
    {
        if (textToEnable != null)
        {
            textToEnable.gameObject.SetActive(true); // Enable the Text GameObject
        }
        else
        {
            Debug.LogError("Text component not assigned!");
        }
    }
}
