using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadChapters : MonoBehaviour
{

    [SerializeField] private SO_LoadLevelChapters currentChapter = null;
    [SerializeField] private GameObject picture = null;
    [SerializeField] private GameObject title = null;

    private void Start()
    {
        GetInformationForChapter();
    }

    private void GetInformationForChapter()
    {
        picture.GetComponent<Image>().sprite = currentChapter.GetImage();
        title.GetComponent<Text>().text = currentChapter.GetTitle();        
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
        SceneManager.LoadScene(currentChapter.GetScene());
    }

    public void BackToMainMenu()
    {
        Camera.main.GetComponent<Animator>().Play("BackToMainMenu");
    }

}
