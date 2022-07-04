using UnityEngine;

public class PlayerPrefsExtended : MonoBehaviour
{
    public void SetInt(string valueName, int value)
    {
        PlayerPrefs.SetInt(valueName, value);
    }
    
    public int GetInt(string valueName, int defaultValue)
    {
        return PlayerPrefs.GetInt(valueName, defaultValue);
    }
}
