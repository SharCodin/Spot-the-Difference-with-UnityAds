using UnityEngine;

public class Hint : MonoBehaviour
{

    [SerializeField] private int differenceCount;

    private void Start()
    {
        differenceCount = transform.childCount;
    }


    // My Methods
    
    public int GetDifferenceCount()
    {
        return differenceCount;
    }

}
