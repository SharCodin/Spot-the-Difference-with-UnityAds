using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;

public class TotalDifferences : MonoBehaviour
{
    [Header("Differences")]
    [SerializeField] private List<Transform> myList = new List<Transform>();

    [Header("UI")]
    [SerializeField] private GameObject levelCompletedPanel = null;

    private int currentBuildIndex;

    private void Start()
    {
        currentBuildIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void AddToList(Transform t)
    {
        myList.Add(t);
    }

    public void RemoveFromList(Transform t)
    {
        myList.Remove(t);
    }

    public int CountDifferences()
    {
        return myList.Count;
    }

    public Transform GetDifferencePosition(int i)
    {
        return myList[i];
    }

    public void LevelCompleted()
    {
        StartCoroutine(LevelCompletedWait());
    }

    private IEnumerator LevelCompletedWait()
    {
        levelCompletedPanel.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        levelCompletedPanel.SetActive(false);
        SceneManager.LoadScene(currentBuildIndex + 1);
    }

}
