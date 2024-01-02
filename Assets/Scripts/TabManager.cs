using UltimateClean;
using UnityEngine;
using UnityEngine.UI;

public class TabManager : MonoBehaviour
{
    public GameObject[] tabs; // Array to hold main tabs
    public Button[] tabButtons; // Array to hold tab buttons
    
    public void OpenTab(int tabIndex)
    {
        // Close all tabs and reset their button colors
        foreach (var t in tabs)
        {
            t.SetActive(false);
        }

        // Open the selected tab and change its button color
        tabs[tabIndex].SetActive(true);
        tabButtons[tabIndex].Select();

    }

    // Start method to initialize the default tab state
    private void Start()
    {
        // Initialize the tabs (optional: open the first tab by default)
        if (tabs.Length > 0) OpenTab(0);
    }
}