using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "LoadLevelChapter", menuName = "Scriptable Objects/Chapters", order = 1)]
public class SO_LoadLevelChapters : ScriptableObject
{
    [SerializeField] private Sprite image = null;
    [SerializeField] private string title = null;
    [SerializeField] private string room = null;
    [SerializeField] private int sceneToLoad = 0;
    [SerializeField] private SO_LoadLevelChapters previousChapter = null;
    [SerializeField] private SO_LoadLevelChapters nextChapter = null;

    public Sprite GetImage()
    {
        return image;
    }

    public string GetTitle()
    {
        return title;
    }

    public string GetRoom()
    {
        return room;
    }

    public SO_LoadLevelChapters GetPreviousChapter()
    {
        return previousChapter;
    }

    public SO_LoadLevelChapters GetNextChapter()
    {
        return nextChapter;
    }

    public int GetScene()
    {
        return sceneToLoad;
    }

}
