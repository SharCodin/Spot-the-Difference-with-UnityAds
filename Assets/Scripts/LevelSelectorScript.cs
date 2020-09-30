using System;
using System.Collections.Generic;
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
    [SerializeField] private List<LevelSelector> currentLevel = null;

    private int levelIndex = 0;

    private int levelSelectorIndex = 0;

    public int LevelSelectorIndex
    {
        get => levelSelectorIndex;
        set 
        { 
            levelSelectorIndex = value;
            if (levelSelectorIndex <= 0)
                levelSelectorIndex = 0;
            else if (levelSelectorIndex >= currentLevel.Count)
                levelSelectorIndex = currentLevel.Count - 1;
            Debug.Log("Set:" + levelSelectorIndex);
        }
    }

    private void Start()
    {
        LoadDetails();
    }

    public void LoadDetails()
    {
        levelIndex = loadChapter.SceneIndex();

        for (int i = 0; i < 10; i++)
        {
            try
            {
                images[i].GetComponent<Image>().sprite = currentLevel[levelSelectorIndex].GetImages()[i];
            }
            catch(IndexOutOfRangeException e)
            {
                return;
            }
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
