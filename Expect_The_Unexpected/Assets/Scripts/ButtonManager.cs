using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ButtonManager : MonoBehaviour
{
    public GameObject[] buttons;  // Array of the 6 buttons
    public GameObject[] options; // Array of the 3 options
   
    private int currentOptionIndex = 0; // Tracks which option to show next

    void Start()
    {
        // Assign click events to all buttons
        foreach (GameObject button in buttons)
        {
            button.GetComponent<Button>().onClick.AddListener(() => OnButtonClicked(button));
        }

        // Ensure all options are initially disabled
        foreach (GameObject option in options)
        {
            option.SetActive(false);
        }
    }

    void OnButtonClicked(GameObject button)
    {
        // Hide the clicked button

        button.SetActive(false);

        // Show the next option if available
        if (currentOptionIndex < options.Length)
        {
            options[currentOptionIndex].SetActive(true);
            currentOptionIndex++;
        }

        // If all options are revealed, destroy all buttons
        if (currentOptionIndex >= options.Length)
        {
            DestroyAllButtons();
        }
    }

  

       
    

    void DestroyAllButtons()
    {
        foreach (GameObject button in buttons)
        {
            Destroy(button); // Destroy each button
        }
    }
}
