using System;
using UnityEngine;
using UnityEngine.UI;

public class LoadChapters : MonoBehaviour
{
    [Header("Scriptable Object to Assign")]
    [SerializeField] private SO_LoadLevelChapters currentChapter = null;

    [Header("GameObjects to Assign")]
    [SerializeField] private GameObject picture = null;
    [SerializeField] private GameObject title = null;
    [SerializeField] private GameObject room = null;
    [SerializeField] private LevelSelectorScript levelSelectorScript = null;

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
        levelSelectorScript.LevelSelectorIndex = levelSelectorScript.LevelSelectorIndex + 1;
        currentChapter = currentChapter.GetNextChapter();
        GetInformationForChapter();
        levelSelectorScript.LoadDetails();
    }

    public void PreviousChapter()
    {
        currentChapter = currentChapter.GetPreviousChapter();
        GetInformationForChapter();
        try
        {
            levelSelectorScript.LevelSelectorIndex = levelSelectorScript.LevelSelectorIndex - 1;
        }
        catch(ArgumentOutOfRangeException e)
        {
            Debug.Log(e, this);
            levelSelectorScript.LevelSelectorIndex = levelSelectorScript.LevelSelectorIndex + 1;
            Debug.Log(levelSelectorScript.LevelSelectorIndex, this);
            return;
        }
        levelSelectorScript.LoadDetails();
    }

    public void LoadScene()
    {
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

    public void BackToChapterSelect()
    {
        Camera.main.GetComponent<Animator>().Play("Camera_GoToChapter");
    }

}
