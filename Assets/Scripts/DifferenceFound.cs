using UnityEngine;

public class DifferenceFound : MonoBehaviour
{

    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Difference found.");
        }

    }

}
