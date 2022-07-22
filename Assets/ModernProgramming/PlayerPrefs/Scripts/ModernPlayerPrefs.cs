using UnityEngine;

namespace ModernProgramming
{
    public class PlayerPrefsExtended : MonoBehaviour
    {
        public void SetBool(string valueName, bool value)
        {
            PlayerPrefs.SetInt(valueName, value ? 1 : 0);
        }
        
        public void SetInt(string valueName, int value)
        {
            PlayerPrefs.SetInt(valueName, value);
        }

        public void SetFloat(string valueName, float value)
        {
            PlayerPrefs.SetFloat(valueName, value);
        }

        public void SetString(string valueName, string value)
        {
            PlayerPrefs.SetString(valueName, value);
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

        public void SetColor(string valueName, Color color)
        {
            string result = color.r + "," + color.g + "," + color.b + "," + color.a;
            PlayerPrefs.SetString(valueName, result);
        }

        public void SetDouble(string valueName, double value)
        {
            PlayerPrefs.SetString(valueName, value.ToString());
        }

        public bool GetBool(string valueName, bool defaultValue)
        {
            return PlayerPrefs.GetInt(valueName, defaultValue ? 1 : 0) > 0 ? true : false;
        }
        
        public int GetInt(string valueName, int defaultValue)
        {
            return PlayerPrefs.GetInt(valueName, defaultValue);
        }

        public float GetFloat(string valueName, float defaultValue)
        {
            return PlayerPrefs.GetFloat(valueName, defaultValue);
        }

        public string GetString(string valueName, string defaultValue)
        {
            return PlayerPrefs.GetString(valueName, defaultValue);
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
        
        public Vector2 GetVector4(string valueName, Vector4 defaultValue)
        {
            string defaultString = defaultValue.x + "," + defaultValue.y + "," + defaultValue.z + "," + defaultValue.w;
            
            string value = PlayerPrefs.GetString(valueName, defaultString);
            string[] components = value.Split(',');

            return new Vector4(float.Parse(components[0]), float.Parse(components[1]), float.Parse(components[2]), float.Parse(components[3]));
        }

        public Color GetColor(string valueName, Color defaultValue)
        {
            string defaultString = defaultValue.r + "," + defaultValue.g + "," + defaultValue.b + "," + defaultValue.a;

            string value = PlayerPrefs.GetString(valueName, defaultString);
            string[] components = value.Split(',');
            
            return new Color(float.Parse(components[0]), float.Parse(components[1]), float.Parse(components[2]), float.Parse(components[3]));
        }

        public double GetDouble(string valueName, double defaultValue)
        {
            string value = PlayerPrefs.GetString(valueName, defaultValue.ToString());
            double result = System.Convert.ToDouble(value);

            return result;
        }
    }   
}
