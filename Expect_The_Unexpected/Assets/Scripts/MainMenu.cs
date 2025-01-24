using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject confirmationPanel; // Panel for the first prompt
    public GameObject secondConfirmationPanel; // Panel for the second prompt

    void Start()
    {
        // Make sure the confirmation panels are hidden at the start
        confirmationPanel.SetActive(false);
        secondConfirmationPanel.SetActive(false);
    }

    public void OnPlayButtonClicked()
    {
        // Show the first confirmation prompt
        confirmationPanel.SetActive(true);
    }

    public void OnFirstConfirmation(bool isConfirmed)
    {
        if (isConfirmed)
        {
            // If "Yes" is clicked, show the second confirmation prompt
            confirmationPanel.SetActive(false);
            secondConfirmationPanel.SetActive(true);
        }
        else
        {
            // If "No" is clicked, close the panel
            confirmationPanel.SetActive(false);
        }
    }

    public void OnSecondConfirmation(bool isConfirmed)
    {
        if (isConfirmed)
        {
            // If "Yes" is clicked, start the game
            SceneManager.LoadScene("GameScene"); // Replace "GameScene" with your actual scene name
            Debug.Log("game started");
        }
        else
        {
            // If "No" is clicked, close the second panel
            secondConfirmationPanel.SetActive(false);
        }
    }

    public void OnExitButtonClicked()
    {
        Application.Quit(); // Quit the application
        Debug.Log("Game Closed"); // This works only in a built game, not in the editor
    }
}
