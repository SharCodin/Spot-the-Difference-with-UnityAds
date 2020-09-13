using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void Tutorial()
    {
        // Tutorial button pressed.
        Debug.Log("Tutorial button pressed.");
    }

    public void Play()
    {
        SceneManager.LoadScene("Room001");
    }

    public void LoadLevel()
    {
        // Level selector
        Debug.Log("Level selector");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Application Quit.");
    }

}
