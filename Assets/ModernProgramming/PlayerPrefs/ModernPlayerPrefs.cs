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

    public void SetVector3(string valueName, Vector3 value)
    {
        string result = value.x + "," + value.y + "," + value.z;
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
    
    public Vector2 GetVector3(string valueName, Vector3 defaultValue)
    {
        string defaultString = defaultValue.x + "," + defaultValue.y + "," + defaultValue.z;
        
        string value = PlayerPrefs.GetString(valueName, defaultString);
        string[] components = value.Split(',');

        return new Vector3(float.Parse(components[0]), float.Parse(components[1]), float.Parse(components[2]));
    }
}
