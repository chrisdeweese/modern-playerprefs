using System;
using UnityEngine;

namespace ModernProgramming
{
    public class PlayerPrefsExtended : MonoBehaviour
    {
        public static void Save()
        {
            PlayerPrefs.Save();
        }

        public static void DeleteAll()
        {
            PlayerPrefs.DeleteAll();
        }

        public static void DeleteKey(string key)
        {
            PlayerPrefs.DeleteKey(key);
        }
        
        public static bool HasKey(string key)
        {
            return PlayerPrefs.HasKey(key);
        }

        public static void SetBool(string valueName, bool value)
        {
            PlayerPrefs.SetInt(valueName, value ? 1 : 0);
        }
        
        public static void SetInt(string valueName, int value)
        {
            PlayerPrefs.SetInt(valueName, value);
        }

        public static void SetFloat(string valueName, float value)
        {
            PlayerPrefs.SetFloat(valueName, value);
        }

        public static void SetString(string valueName, string value)
        {
            PlayerPrefs.SetString(valueName, value);
        }

        public static void SetVector2(string valueName, Vector2 value)
        {
            string result = value.x + "," + value.y;
            PlayerPrefs.SetString(valueName, result);
        }

        public static void SetVector3(string valueName, Vector3 value)
        {
            string result = value.x + "," + value.y + "," + value.z;
            PlayerPrefs.SetString(valueName, result);
        }

        public static void SetVector4(string valueName, Vector4 value)
        {
            string result = value.w + "," + value.x + "," + value.y + "," + value.z;
            PlayerPrefs.SetString(valueName, result);
        }

        public static void SetColor(string valueName, Color color)
        {
            string result = color.r + "," + color.g + "," + color.b + "," + color.a;
            PlayerPrefs.SetString(valueName, result);
        }

        public static void SetDouble(string valueName, double value)
        {
            PlayerPrefs.SetString(valueName, value.ToString());
        }

        public static void SetDecimal(string valueName, decimal value)
        {
            PlayerPrefs.SetString(valueName, value.ToString());
        }

        public static void SetChar(string valueName, char value)
        {
            PlayerPrefs.SetString(valueName, value.ToString());
        }

        public static void SetCharArray(string valueName, char[] values)
        {
            string result = "";
            for (int i = 0; i < values.Length; i++)
            {
                result += values[i];
            }
            
            PlayerPrefs.SetString(valueName, result);
        }

        public static void SetTransform(string valueName, Transform t)
        {
            string result = t.localPosition.x + "," + 
                            t.localPosition.y + "," + 
                            t.localPosition.z + "," + 
                            t.localRotation.x + "," +
                            t.localRotation.y + "," + 
                            t.localRotation.z + "," + 
                            t.localScale.x + "," + 
                            t.localScale.y + "," + 
                            t.localScale.z;
            
            PlayerPrefs.SetString(valueName, result);
        }
        
        public static bool GetBool(string valueName)
        {
            return PlayerPrefs.GetInt(valueName, 0) > 0 ? true : false;
        }

        public static bool GetBool(string valueName, bool defaultValue)
        {
            return PlayerPrefs.GetInt(valueName, defaultValue ? 1 : 0) > 0 ? true : false;
        }
        
        public static int GetInt(string valueName, int defaultValue)
        {
            return PlayerPrefs.GetInt(valueName, defaultValue);
        }

        public static float GetFloat(string valueName, float defaultValue)
        {
            return PlayerPrefs.GetFloat(valueName, defaultValue);
        }

        public static string GetString(string valueName, string defaultValue)
        {
            return PlayerPrefs.GetString(valueName, defaultValue);
        }

        public static Vector2 GetVector2(string valueName, Vector2 defaultValue)
        {
            string defaultString = defaultValue.x + "," + defaultValue.y;
            
            string value = PlayerPrefs.GetString(valueName, defaultString);
            string[] components = value.Split(',');

            return new Vector2(float.Parse(components[0]), float.Parse(components[1]));
        }
        
        public static Vector3 GetVector3(string valueName, Vector3 defaultValue)
        {
            string defaultString = defaultValue.x + "," + defaultValue.y + "," + defaultValue.z;
            
            string value = PlayerPrefs.GetString(valueName, defaultString);
            string[] components = value.Split(',');

            return new Vector3(float.Parse(components[0]), float.Parse(components[1]), float.Parse(components[2]));
        }
        
        public static Vector4 GetVector4(string valueName, Vector4 defaultValue)
        {
            string defaultString = defaultValue.x + "," + defaultValue.y + "," + defaultValue.z + "," + defaultValue.w;
            
            string value = PlayerPrefs.GetString(valueName, defaultString);
            string[] components = value.Split(',');

            return new Vector4(float.Parse(components[0]), float.Parse(components[1]), float.Parse(components[2]), float.Parse(components[3]));
        }

        public static Color GetColor(string valueName, Color defaultValue)
        {
            string defaultString = defaultValue.r + "," + defaultValue.g + "," + defaultValue.b + "," + defaultValue.a;

            string value = PlayerPrefs.GetString(valueName, defaultString);
            string[] components = value.Split(',');
            
            return new Color(float.Parse(components[0]), float.Parse(components[1]), float.Parse(components[2]), float.Parse(components[3]));
        }

        public static double GetDouble(string valueName, double defaultValue)
        {
            string value = PlayerPrefs.GetString(valueName, defaultValue.ToString());
            double result = System.Convert.ToDouble(value);

            return result;
        }

        public static decimal GetDecimal(string valueName, decimal defaultValue)
        {
            string value = PlayerPrefs.GetString(valueName, defaultValue.ToString());
            decimal result = System.Convert.ToDecimal(value);

            return result;
        }

        public static char GetChar(string valueName, char defaultValue)
        {
            string value = PlayerPrefs.GetString(valueName, defaultValue.ToString());
            char[] result = value.ToCharArray();
            return result[0];
        }

        public static char[] GetCharArray(string valueName, char[] defaultValue)
        {
            string value = PlayerPrefs.GetString(valueName, defaultValue.ToString());
            char[] result = value.ToCharArray();
            return result;
        }

        public static Transform GetTransform(string valueName, Transform defaultValue)
        {
            string defaultString = defaultValue.localPosition.x + "," + 
                                   defaultValue.localPosition.y + "," + 
                                   defaultValue.localPosition.z + "," + 
                                   defaultValue.localRotation.x + "," +
                                   defaultValue.localRotation.y + "," + 
                                   defaultValue.localRotation.z + "," + 
                                   defaultValue.localScale.x + "," + 
                                   defaultValue.localScale.y + "," + 
                                   defaultValue.localScale.z;
            string value = PlayerPrefs.GetString(valueName, defaultString);
            string[] components = value.Split(',');

            Transform result = new GameObject().transform;
            result.localPosition = new Vector3(float.Parse(components[0]), float.Parse(components[1]), float.Parse(components[2]));
            result.eulerAngles = new Vector3(float.Parse(components[3]), float.Parse(components[4]), float.Parse(components[5]));
            result.localScale = new Vector3(float.Parse(components[6]), float.Parse(components[7]), float.Parse(components[8]));

            return result;
        }
    }   
}
