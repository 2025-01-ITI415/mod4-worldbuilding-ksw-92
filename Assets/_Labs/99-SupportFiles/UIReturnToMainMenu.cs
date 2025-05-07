using UnityEngine;
using UnityEngine.SceneManagement;

public class UIReturnToMainMenu : MonoBehaviour
{
    // Optional: Reference to the menu GameObject (set in Inspector or dynamically)
    private GameObject returnMenu;

    void Awake()
    {
        // Optional: preload the menu object if it exists
        returnMenu = GameObject.Find("ReturnToMenu-Equals");

        // Optionally disable it on start
        // if (returnMenu != null) returnMenu.SetActive(false);
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // Safe check before using SetActive
            if (returnMenu == null)
            {
                returnMenu = GameObject.Find("ReturnToMenu-Equals");
            }

            if (returnMenu != null)
            {
                returnMenu.SetActive(false);
            }
            else
            {
                Debug.LogWarning("UIReturnToMainMenu: Could not find 'ReturnToMenu-Equals' GameObject.");
            }
        }

        if (Input.GetKeyDown(KeyCode.Equals))
        {
            ReturnToMainMenu();
        }
    }
}
