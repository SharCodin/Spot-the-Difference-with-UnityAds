using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour, IUnityAdsListener
{

    [SerializeField] private string gameId = "3808055";
    [SerializeField] private bool testMode = true;
    [SerializeField] private GameObject hintButton = null;
    [SerializeField] private GameObject toastMessage = null;

    string myPlacementId = "rewardedVideo";


    private void Start()
    {
        hintButton.SetActive(false);
        toastMessage.SetActive(false);

        Advertisement.AddListener(this);
        Advertisement.Initialize(gameId, testMode);
    }

    public void ShowRewardedVideo()
    {
        // Check if UnityAds ready before calling Show method:
        if (Advertisement.IsReady(myPlacementId))
        {
            Advertisement.Show(myPlacementId);
        }
        else
        {
            StartCoroutine(AdsNotLoaded());
        }
    }

    // Implement IUnityAdsListener interface methods:
    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished)
        {
            // Reward the user for watching the ad to completion.
        }
        else if (showResult == ShowResult.Skipped)
        {
            // Do not reward the user for skipping the ad.
        }
        else if (showResult == ShowResult.Failed)
        {
            Debug.LogWarning("The ad did not finish due to an error.");
        }
    }

    public void OnUnityAdsReady(string placementId)
    {
        // If the ready Placement is rewarded, show the ad:
        if (placementId == myPlacementId)
        {
            // Optional actions to take when the placement becomes ready(For example, enable the rewarded ads button)
            hintButton.SetActive(true);
        }
    }

    public void OnUnityAdsDidError(string message)
    {
        // Log the error.
        Debug.Log(message);
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        // Optional actions to take when the end-users triggers an ad.
    }

    // When the object that subscribes to ad events is destroyed, remove the listener:
    public void OnDestroy()
    {
        Advertisement.RemoveListener(this);
    }

    private IEnumerator AdsNotLoaded()
    {
        toastMessage.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        toastMessage.SetActive(false);
    }

}
