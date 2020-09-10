using UnityEngine;

public class CameraControls : MonoBehaviour
{
    Vector3 touchPoint;
    [SerializeField] private int zoomLevel = 0;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            touchPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 distanceDifference = touchPoint - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Camera.main.transform.position += distanceDifference;
        }
    }


    // Press reset button to reset zoom to 5.
    public void ResetZoom()
    {
        Camera.main.orthographicSize = 5.0f;
        Camera.main.transform.position = new Vector3(0.0f, 0.0f, -10.0f);
        zoomLevel = 0;
    }
    
    // Press the zoom in button to zoom camera.
    public void ZoomIn()
    {
        if (zoomLevel == 0)
        {
            ZoomMe(4.0f);
        }
        else if (zoomLevel == 1)
        {
            ZoomMe(3.0f);
        }
        else if (zoomLevel == 2)
        {
            ZoomMe(2.0f);
        }
    }

    // zoom method - changing size.
    private void ZoomMe(float f)
    {
        Camera.main.orthographicSize = f;
        zoomLevel++;
    }
}
