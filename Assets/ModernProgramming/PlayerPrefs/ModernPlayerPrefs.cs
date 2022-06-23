using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UIElements;

public class ModernPlayerPrefs : MonoBehaviour
{
    //int
    //float
    //double
    //string
    //bool
    //char
    //enums?
    //vector2
    //vector3
    //vector4
    //GameObject?
    //Lists
    //Dictionary?
    //Object
    //DateTime
    //Colors
    //Quaternions
    
    
    public void SetInt(string valueName, int value)
    {
        PlayerPrefs.SetInt(valueName, value);
    }

    public void SetFloat(string valueName, float value)
    {
        PlayerPrefs.SetFloat(valueName, value);
    }

    public void SetDouble(string valueName, double value)
    {
        PlayerPrefs.SetString(valueName, value.ToString(CultureInfo.InvariantCulture));
    }

    public void SetString(string valueName, string value)
    {
        PlayerPrefs.SetString(valueName, value);
    }

    public void SetBool(string valueName, bool value)
    {
        PlayerPrefs.SetInt(valueName, value ? 1 : 0);
    }

    public void SetChar(string valueName, char value)
    {
        PlayerPrefs.SetString(valueName, value.ToString());
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

    public void SetVector4(string valueName, Vector4 value)
    {
        string result = value.w + "," + value.x + "," + value.y + "," + value.z;
        PlayerPrefs.SetString(valueName, result);
    }

    public void SetList<T>(string valueName, List<T> value)
    {
        
    }

    public Vector2 GetVector2(string valueName, Vector2 defaultValue)
    {
        string defaultString = defaultValue.x + "," + defaultValue.y;
        
        string value = PlayerPrefs.GetString(valueName, defaultString);
        string[] components = value.Split(',');

        return new Vector2(float.Parse(components[0]), float.Parse(components[1]));
    }
}
