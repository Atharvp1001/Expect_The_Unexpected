using UnityEngine;
using UnityEngine.UI; // For button reference


public class PlayAnimation : MonoBehaviour
{
    public Animator animator; // Reference to the Animator component
    public string animationName; // Name of the animation to play
    public Button yourButton; // Reference to the button

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
    }

    // This method will be called when the button is pressed
    void OnButtonPress()
    {
        if (animator != null)
        {
            animator.Play(animationName); // Play the animation
        }
        else
        {
            Debug.LogError("Animator is not assigned!");
        }
    }

}
