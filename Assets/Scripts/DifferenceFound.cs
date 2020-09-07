using UnityEngine;
using UnityEngine.UI;

public class DifferenceFound : MonoBehaviour
{
    private Image image;

    private void Start()
    {
        image = GetComponent<Image>();
    }


    
    // My Methods

    public void DifferenceSpotFound()
    {
        image.color = new Color(image.color.r, image.color.g, image.color.b, 1f);
        Debug.Log("Button pressed!");
    }


}
