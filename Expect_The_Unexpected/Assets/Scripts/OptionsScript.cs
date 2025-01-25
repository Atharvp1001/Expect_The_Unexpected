using UnityEngine;

public class OptionsScript : MonoBehaviour
{

    public GameObject options;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        options.SetActive(false);
    }

    public void OnOptionsButtonClicked()
    {
        options.SetActive(true);
    }

    public void OnCloseButtonClicked()
    {
        options.SetActive(false);
    }
}
