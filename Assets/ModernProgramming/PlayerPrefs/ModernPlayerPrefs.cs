using UnityEngine;

public class PlayerPrefsExtended : MonoBehaviour
{
    public void SetInt(string valueName, int value)
    {
        PlayerPrefs.SetInt(valueName, value);
    }

    public void SetVector2(string valueName, Vector2 value)
    {
        string result = value.x + "," + value.y;
        PlayerPrefs.SetString(valueName, result);
    }
    
    public int GetInt(string valueName, int defaultValue)
    {
        return PlayerPrefs.GetInt(valueName, defaultValue);
    }

    public Vector2 GetVector2(string valueName, Vector2 defaultValue)
    {
        string defaultString = defaultValue.x + "," + defaultValue.y;
        
        string value = PlayerPrefs.GetString(valueName, defaultString);
        string[] components = value.Split(',');

        return new Vector2(float.Parse(components[0]), float.Parse(components[1]));
    }
}
