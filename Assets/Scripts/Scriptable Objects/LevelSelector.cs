using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Level", menuName = "Scriptable Objects/Level", order = 2)]
public class LevelSelector : ScriptableObject
{
    [SerializeField] private Sprite[] images =null;
    [SerializeField] private string levelName = null;
    [SerializeField] private string sceneName = null;

    public Sprite[] GetImages()
    {
        return images;
    }

    public string GetLevelName()
    {
        return levelName;
    }

    public string GetSceneName()
    {
        return sceneName;
    }
}
