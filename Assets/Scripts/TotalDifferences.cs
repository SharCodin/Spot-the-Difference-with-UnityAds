using UnityEngine;
using System.Collections.Generic;

public class TotalDifferences : MonoBehaviour
{
    [Header("Differences")]
    [SerializeField] private List<Transform> myList = new List<Transform>();

    //[SerializeField] private Transform totalNumberOfDifferences;

    private void Start()
    {
        
    }

    public void AddToList(Transform t)
    {
        myList.Add(t);
    }

    public void RemoveFromList(Transform t)
    {
        myList.Remove(t);
    }

    public int RemainingDifference()
    {
        return myList.Count;
    }

}
