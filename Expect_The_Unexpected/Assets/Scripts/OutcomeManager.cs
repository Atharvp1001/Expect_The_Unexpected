using UnityEngine;
using UnityEngine.SceneManagement;

public class OutcomeManager : MonoBehaviour
{
      public GameObject panel; // The panel to enable

    public void EnableUIPanel()
    {
        if (panel != null)
        {
            panel.SetActive(true); // Enable the panel
        }
        else
        {
            Debug.LogError("Panel is not assigned in the Inspector!");
        }
    }

    public void retry() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void next() 
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        // Check if the next scene index is valid
        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            Debug.Log("No more scenes to load. You're at the last scene.");
        }
    }

}
