using UnityEngine;

public class CameraControls : MonoBehaviour
{
    Vector3 touchPoint;
    [SerializeField] private float zoomOutMin = 2.0f;
    [SerializeField] private float zoomOutMax = 5.0f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            touchPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevMagnitude = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float currentMagnitude = (touchZero.position - touchOne.position).magnitude;

            float difference = currentMagnitude - prevMagnitude;

            Zoom(difference * 0.01f);
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 distanceDifference = touchPoint - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log(distanceDifference);
            Camera.main.transform.position += distanceDifference;
        }
    }

    private void Zoom(float increment)
        {
            Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize - increment, zoomOutMin, zoomOutMax);
        }

}
