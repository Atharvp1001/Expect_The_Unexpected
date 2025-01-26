using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    // Loads the current scene for retry (useful for restarting the level)
    public void RetryCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Loads the next scene in the build settings for progressing to the next level
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            Debug.LogWarning("There is no next scene in the build settings.");
        }
    }
    public void OnExitButtonClicked()
    {
        Application.Quit(); // Quit the application
        Debug.Log("Game Closed"); // This works only in a built game, not in the editor
    }
}
