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
        Camera.main.GetComponent<Animator>().Play("MainMenuCameraMovement");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Application Quit.");
    }

}
