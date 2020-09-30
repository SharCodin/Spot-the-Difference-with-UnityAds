using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelectorScript : MonoBehaviour
{
    [Header("From Main Panel in Hierarchy")]
    [SerializeField] private LoadChapters loadChapter = null;

    [Header("Arrays")]
    [SerializeField] private Image[] images = null;
    [SerializeField] private Text[] texts = null;

    [Header("Scriptable Objects")]
    [SerializeField] private LevelSelector currentLevel = null;

    private int levelIndex = 0;

    private void Start()
    {
        levelIndex = loadChapter.SceneIndex();

        for(int i=0; i < 7; i++)
        {
            images[i].GetComponent<Image>().sprite = currentLevel.GetImages()[i];
            texts[i].GetComponent<Text>().text = "Level " + levelIndex;
            levelIndex++;
        }

        levelIndex = loadChapter.SceneIndex();
    }

    public void LoadLevelChapter(int index)
    {
        SceneManager.LoadScene(loadChapter.SceneIndex() + index);
    }
}
