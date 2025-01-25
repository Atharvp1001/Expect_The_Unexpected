using UnityEngine;

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
}
