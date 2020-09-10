using UnityEngine;
using UnityEngine.UI;

public class DifferenceFound : MonoBehaviour
{
    private Image image;
    private TotalDifferences td;

    private void Start()
    {
        image = GetComponent<Image>();
        td = FindObjectOfType<TotalDifferences>();
        td.AddToList(transform);
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
            Debug.Log("Game Ended.");
        }
    }

    private void DisplayDifferenceSprite()
    {
        image.color = new Color(image.color.r, image.color.g, image.color.b, 1f);
    }
}
