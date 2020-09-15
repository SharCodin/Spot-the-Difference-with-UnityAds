using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadChapters : MonoBehaviour
{
    [Header("Scriptable Object to Assign")]
    [SerializeField] private SO_LoadLevelChapters currentChapter = null;

    [Header("GameObjects to Assign")]
    [SerializeField] private GameObject picture = null;
    [SerializeField] private GameObject title = null;
    [SerializeField] private GameObject room = null;

    private int startingSceneIndex;

    private void Start()
    {
        GetInformationForChapter();
    }

    private void GetInformationForChapter()
    {
        picture.GetComponent<Image>().sprite = currentChapter.GetImage();
        title.GetComponent<Text>().text = currentChapter.GetTitle();
        room.GetComponent<Text>().text = currentChapter.GetRoom();
    }

    public void NextChapter()
    {
        currentChapter = currentChapter.GetNextChapter();
        GetInformationForChapter();
    }

    public void PreviousChapter()
    {
        currentChapter = currentChapter.GetPreviousChapter();
        GetInformationForChapter();
    }

    public void LoadScene()
    {
        SceneIndex();
        Camera.main.GetComponent<Animator>().Play("Camera_GoToRooms");
    }

    public int SceneIndex()
    {
        return startingSceneIndex = currentChapter.GetScene();
    }

    public void BackToMainMenu()
    {
        Camera.main.GetComponent<Animator>().Play("BackToMainMenu");
    }

}
