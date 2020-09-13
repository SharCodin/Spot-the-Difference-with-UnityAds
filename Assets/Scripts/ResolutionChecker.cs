using UnityEngine;

public class ResolutionChecker : MonoBehaviour
{

    [SerializeField] private Transform mainMenuButton = null;
    [SerializeField] private Transform previousButton = null;
    [SerializeField] private Transform nextButton = null;

    private void Start()
    {

        Debug.Log(mainMenuButton.name, mainMenuButton);

        Rect myRect = Screen.safeArea;
        if (myRect.width < 700.0f)
        {
            mainMenuButton.position = new Vector3(-5.0f, 4.4f, 90.0f);
            previousButton.position = new Vector3(-5.0f, previousButton.position.y, 90.0f);
            nextButton.position = new Vector3(5.0f, nextButton.position.y, 90.0f);
        }
    }

}
