using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DifferenceFound : MonoBehaviour
{
    private Image image;
    private TotalDifferences td;
    private int currentBuildIndex;

    private void Start()
    {
        image = GetComponent<Image>();
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0.0f);
        td = FindObjectOfType<TotalDifferences>();
        td.AddToList(transform);
        currentBuildIndex = SceneManager.GetActiveScene().buildIndex;
    }


    // My Methods

    public void DifferenceSpotFound()
    {
        DisplayDifferenceSprite();

        td.RemoveFromList(transform);

        CheckGameWin();
    }

    private void CheckGameWin()
    {
        if (td.CountDifferences() <= 0)
        {
            PlayerPrefs.SetInt("Room Completed", currentBuildIndex);
            td.LevelCompleted();
        }
    }

    private void DisplayDifferenceSprite()
    {
        image.color = new Color(image.color.r, image.color.g, image.color.b, 1.0f);
    }
}
